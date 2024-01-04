using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace MovieRatingApp.Mobile.Platforms.Android.Controls.RatingView;

public class NativeRatingView : LinearLayout
{
    private int _value;
    private int _maxValue;

    public NativeRatingView(Context? context) : base(context) 
    {
        Orientation = Orientation.Horizontal;
    }

    public void UpdateValue(int value)
    {
        _value = value;
        this.RemoveAllViews();

        for(int i = 0; i < _maxValue; i++)
        {
            var imageView = new ImageView(Context);
            Icon icon = Icon.CreateWithResource(Context, i < _value ? _Microsoft.Android.Resource.Designer.ResourceConstant.Drawable.popcorn_full_icon : Resource.Drawable.popcorn_empty_icon);
            imageView.SetImageIcon(icon);
            int ratingValue = i + 1;
            imageView.Click += (sender, e) => UpdateRating(ratingValue);
            this.AddView(imageView);
        }
    }

    public void UpdateMaxValue(int maxValue)
    {
        _maxValue = maxValue;
        UpdateValue(_value);
    }

    private void UpdateRating(int newRating)
    {
        UpdateValue(newRating);
        RatingChanged?.Invoke(this, newRating);
    }

    public void UpdateColor(Color color)
    {
        this.SetBackgroundColor(color.ToAndroid());
    }

    public delegate void RatingChangedEventHandler(object sender, int newValue);
    public event RatingChangedEventHandler RatingChanged;
}
