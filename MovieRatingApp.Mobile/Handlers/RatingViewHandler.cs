#if ANDROID
using PlatformView = MovieRatingApp.Mobile.Platforms.Android.Controls.RatingView.NativeRatingView;
#endif

using RatingView = MovieRatingApp.Mobile.Controls.RatingView;

namespace MovieRatingApp.Mobile.Handlers;

public partial class RatingViewHandler
{
    public static IPropertyMapper<Mobile.Controls.RatingView, RatingViewHandler> PropertyMapper =
        new PropertyMapper<Mobile.Controls.RatingView, RatingViewHandler>()
        {
            [nameof(RatingView.Value)] = MapValue,
            [nameof(RatingView.Color)] = MapColor,
            [nameof(RatingView.MaxRating)] = MapMaxValue
        };


    public RatingViewHandler() : base(PropertyMapper)
    {
        
    }
}