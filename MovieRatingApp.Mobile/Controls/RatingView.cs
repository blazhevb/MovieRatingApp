﻿

namespace MovieRatingApp.Mobile.Controls
{
    public partial class RatingView : HorizontalStackLayout
    {
        private const int MAX_VALUE_ALLOWED = 10;

        public static readonly BindableProperty ValueProperty = 
            BindableProperty.Create(
                nameof(Value), 
                typeof(int), 
                typeof(RatingView),
                defaultValue: default(int));

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
                defaultValue: Colors.Transparent);

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }    

        public static readonly BindableProperty MaxRatingProperty =
            BindableProperty.Create(
                nameof(Size),
                typeof(int),
                typeof(RatingView),
                defaultValue: 5);

        public int MaxRating
        {
            get => (int)GetValue(MaxRatingProperty);
            set
            {
                if(value < 1)
                    SetValue(MaxRatingProperty, 1);
                else if(value > MAX_VALUE_ALLOWED)
                    SetValue(MaxRatingProperty, MAX_VALUE_ALLOWED);
                else
                    SetValue(MaxRatingProperty, value);
            }
        }
    }
}