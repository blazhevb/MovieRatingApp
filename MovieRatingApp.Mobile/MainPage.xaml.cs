using MovieRatingApp.Mobile.ViewModels;

namespace MovieRatingApp.Mobile;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        var viewModel = this.BindingContext as MoviesViewModel;
        if(viewModel != null)
        {
            await viewModel.InitializeAsync();
        }

        base.OnAppearing();
    }
}

