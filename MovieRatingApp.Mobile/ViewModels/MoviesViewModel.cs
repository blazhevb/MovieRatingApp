using Microsoft.Extensions.Logging;
using MovieRatingApp.Mobile.Configuration;
using MovieRatingApp.Mobile.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovieRatingApp.Mobile.ViewModels
{
    public class MoviesViewModel : BaseViewModel
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly MovieApiConfig _movieApiConfig;

        public ObservableCollection<Movie> Movies { get; set; }

        public MoviesViewModel()
        {
            Movies = new ObservableCollection<Movie>();

            var configService = new ConfigurationService();
            _movieApiConfig = ConfigurationService.GetConfiguration<AppConfig>("appsettings.json").MovieApi;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task InitializeAsync()
        {
            await LoadMoviesAsync();
        }

        private async Task LoadMoviesAsync()
        {
            IsLoading = true;
            try
            {
                string apiKey = _movieApiConfig.ApiKey;
                string rqUrl = _movieApiConfig.RequestUrl;
                string url = rqUrl.Replace("{apiKey}", apiKey);

                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                 
                var movieData = JsonConvert.DeserializeObject<MovieApiResponse>(responseBody);
                foreach(var movie in movieData?.Results)
                {
                    Movies.Add(new Movie
                    {
                        Title = movie.Title,
                        Description = movie.Overview,
                        ImageUrl = String.Format("{0}{1}", _movieApiConfig.ImageUrlBase, movie.PosterPath)
                    });
                }
            }
            catch(HttpRequestException e)
            {
                AppLogger.LogError(e, "Unable to load movies.");
            }
            finally
            {
                IsLoading = false;
            }
        }
    }
}
