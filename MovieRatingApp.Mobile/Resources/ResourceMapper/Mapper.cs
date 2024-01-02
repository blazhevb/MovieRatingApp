using MovieRatingApp.Mobile.Common.Enums;

namespace MovieRatingApp.Mobile.Resources.ResourceMapper;


public class Mapper
{
    public static Dictionary<EnumIndicatorImage, string> RatingIconName = new Dictionary<EnumIndicatorImage, string>()
    {
        { EnumIndicatorImage.Empty, "popcorn_empty.png" },
        { EnumIndicatorImage.Full, "popcorn_full.png" }
    };
}
