using MovieRatingApp.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Mobile.ViewModels
{
    public class MoviesViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; set; }

        public MoviesViewModel() 
        {
            Movies = new ObservableCollection<Movie>
        {
            // Add some sample movies here
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 1 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 5 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 3 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 5 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 2 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 5 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 0 },
            new Movie { Title = "Inception", Description = "A movie about dreams within dreams.", ImageUrl = "dotnet_bot.png", Rating = 5 },
            // Add more movies
        };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
