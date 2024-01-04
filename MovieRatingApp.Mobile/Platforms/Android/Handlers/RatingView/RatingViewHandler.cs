using MovieRatingApp.Mobile.Platforms.Android.Controls.RatingView;
using Microsoft.Maui.Handlers;
using MovieRatingApp.Mobile.Controls;


namespace MovieRatingApp.Mobile.Handlers;

public partial class RatingViewHandler : ViewHandler<RatingView, NativeRatingView>
{
    protected override NativeRatingView CreatePlatformView()
    {
        return new NativeRatingView(Context);
    }

    protected override void ConnectHandler(NativeRatingView platformView)
    {
        base.ConnectHandler(platformView);
        platformView.RatingChanged += OnRatingChanged;
    }

    protected override void DisconnectHandler(NativeRatingView platformView)
    {
        platformView.RatingChanged -= OnRatingChanged;
        platformView.Dispose();
        base.DisconnectHandler(platformView);
    }

    private void OnRatingChanged(object sender, int newRating)
    {
        if(VirtualView != null)
            VirtualView.Value = newRating;
    }

    private static void MapValue(RatingViewHandler handler, Mobile.Controls.RatingView view)
    {          
        handler.PlatformView?.UpdateValue(view.Value);
    }
    private static void MapMaxValue(RatingViewHandler handler, Mobile.Controls.RatingView view)
    {
        handler.PlatformView?.UpdateMaxValue(view.MaxRating);
    }
   
    private static void MapColor(RatingViewHandler handler, Mobile.Controls.RatingView view)
    {
        handler.PlatformView?.UpdateColor(view.Color);
    }
}