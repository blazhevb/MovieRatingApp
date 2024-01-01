

using MovieRatingApp.Mobile.Resources.FontsMapping;

namespace MovieRatingApp.Mobile.Controls
{
    public partial class RatingView : ContentView
    {
        public static readonly BindableProperty ValueProperty = 
            BindableProperty.Create(
                nameof(Value), 
                typeof(int), 
                typeof(RatingView),
                defaultValue: default(int), 
                propertyChanged:OnPropertyChanged);

        public int Value
        {
            get => (int)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public static readonly BindableProperty ColorProperty = 
            BindableProperty.Create(
                nameof(Color), 
                typeof(Color), 
                typeof(RatingView), 
                defaultValue: Colors.Yellow, 
                propertyChanged: OnPropertyChanged);

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public static readonly BindableProperty SizeProperty =
            BindableProperty.Create(
                nameof(Size),
                typeof(double),
                typeof(RatingView),
                defaultValue:26d,
                propertyChanged: OnPropertyChanged);

        public double Size
        {
            get => (double)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }

        public static readonly BindableProperty MaxRatingProperty =
            BindableProperty.Create(
                nameof(Size),
                typeof(int),
                typeof(RatingView),
                defaultValue: 5,
                propertyChanged: OnPropertyChanged);

        public double MaxRating
        {
            get => (int)GetValue(MaxRatingProperty);
            set => SetValue(MaxRatingProperty, value);
        }

        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if(bindable is RatingView)
            {
                UpdateReview((RatingView)bindable);
            }
        }

        private static void UpdateReview(RatingView obj)
        {
            obj.RatingPointsContainer.Children.Clear();

            for(int i = 0; i < obj.MaxRating; i++)
            {
                if(obj.Value > i)
                {
                    obj.RatingPointsContainer.Children.Add(getLabel(Icons.FullIndicator, obj.Size, obj.Color));
                }
                else
                {
                    obj.RatingPointsContainer.Children.Add(getLabel(Icons.EmptyIndicator, obj.Size, obj.Color));
                }
            }
        }

        private static Label getLabel(string text, double size, Color color)
        {
            return new Label
            {
                Text = text,
                TextColor = color,
                FontSize = size,
                FontFamily = Icons.FONT_FAMILY
            };
        }
    }
}