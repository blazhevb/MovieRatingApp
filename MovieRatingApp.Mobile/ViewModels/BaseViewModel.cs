using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatingApp.Mobile.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
                OnPropertyChanged(nameof(IsDone));
            }
        }

        //TO DO Use IsLoading with InvertBooleanConverter from MauiCommunity.Toolkit instead
        public bool IsDone => !IsLoading;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
