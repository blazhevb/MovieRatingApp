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
            Movies = new ObservableCollection<Movie>();    
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
