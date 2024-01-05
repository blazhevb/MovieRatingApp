# MovieRatingApp

Overview
The Movie Rating App is an application designed for movie enthusiasts. It utilizes the TMDb API to fetch and display a curated list of popular movies, offering users a simple and convenient way to rate movies.

Features
Movie Listings: Retrieves and showcases a list of popular movies from TMDb, including key details like Title, Overview, and Posters.

Custom Rating Control: Integrates a native control for movie ratings, featuring icons. The control's distinct features include:
Value: Implements two-way binding to reflect and update the movie's rating.
MaxRating: Configurable to set the maximum number of rating slots.
Color: Adjustable via XAML, this property modifies the background color of the rating indicator, enhancing the UI's visual appeal.

Platform Support
The application is currently developed for and supports the Android platform.

Integration
TMDb API: The app leverages this API for real-time, dynamic movie data, ensuring a constantly updated catalog.

User Interaction
Users can interactively rate each movie, with their input directly influencing the displayed rating, thanks to the two-way binding mechanism.
