using MovieRatingApp.Mobile.Platforms.Android.Controls.RatingView;
using Microsoft.Maui.Handlers;
using MovieRatingApp.Mobile.Controls;


namespace MovieRatingApp.Mobile.Handlers
{
    public partial class RatingViewHandler : ViewHandler<RatingView, NativeRatingView>
    {
        protected override NativeRatingView CreatePlatformView()
        {
            throw new NotImplementedException();
        }

        protected override void ConnectHandler(NativeRatingView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(NativeRatingView platformView)
        {
            base.DisconnectHandler(platformView);
        }

        private static void MapValue(RatingViewHandler handler, Mobile.Controls.RatingView view)
        {
            
            throw new NotImplementedException();
        }

        private static void MapColor(RatingViewHandler handler, Mobile.Controls.RatingView view)
        {
            throw new NotImplementedException();
        }
    }
}