#if ANDROID

#endif

namespace MovieRatingApp.Mobile.Handlers
{

    public partial class RatingViewHandler
    {
        public static IPropertyMapper<Mobile.Controls.RatingView, RatingViewHandler> PropertyMapper =
            new PropertyMapper<Mobile.Controls.RatingView, RatingViewHandler>()
            {
                [nameof(Mobile.Controls.RatingView.Value)] = MapValue,
                [nameof(Mobile.Controls.RatingView.Color)] = MapColor,
            };


        public RatingViewHandler() : base(PropertyMapper)
        {
            
        }
    }
}