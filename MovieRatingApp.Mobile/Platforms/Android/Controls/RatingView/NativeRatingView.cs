using Android.Content;
using Android.Widget;
using MovieRatingApp.Mobile.Common.Enums;

namespace MovieRatingApp.Mobile.Platforms.Android.Controls.RatingView;

public class NativeRatingView : LinearLayout
{
    private readonly ImageSource _imgEmpty;
    private readonly ImageSource _imgFull;

    public NativeRatingView(Context? context) : base(context)
    {
        _imgEmpty = ImageSource.FromFile(Mobile.Resources.ResourceMapper.Mapper.RatingIconName[EnumIndicatorImage.Empty]);
        _imgFull = ImageSource.FromFile(Mobile.Resources.ResourceMapper.Mapper.RatingIconName[EnumIndicatorImage.Full]);
    }

}
