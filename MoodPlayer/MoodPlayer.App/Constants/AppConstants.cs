namespace MoodPlayer.App.Constants;

public static class AppConstants
{
    public static class Colors
    {
        public static readonly Color Surface = Color.FromArgb("#1A2F4A");
        public static readonly Color Border = Color.FromArgb("#243552");
        public static readonly Color TextSecondary = Color.FromArgb("#A5C8E8");
        public static readonly Color AccentDefault = Color.FromArgb("#7C3AED");
    }

    public static class Dimensions
    {
        public const int MoodButtonWidth = 130;
        public const int MoodButtonHeight = 100;
        public const int ButtonCornerRadius = 16;
        public const double AccentOpacity = 0.12f;
        public const float SelectedAlpha = 0.15f;
        public const double StrokeSelected = 2;
        public const double StrokeDefault = 1;
    }

    public static class Animation
    {
        public const uint ScaleDownDuration = 80;
        public const uint ScaleUpDuration = 120;
        public const uint FadeOutDuration = 200;
        public const uint FadeInDuration = 300;
        public const uint BannerFadeDuration = 300;
        public const uint PlaylistFadeDuration = 400;
        public const uint FlashOutDuration = 100;
        public const uint FlashInDuration = 200;
        public const double ScaleDownValue = 0.92;
        public const double ScaleUpValue = 1.0;
        public const double FadeOutValue = 0;
        public const double FadeInValue = 0.12;
        public const double FullOpacity = 1;
        public const double HalfOpacity = 0.5;
    }

    public static class Strings
    {
        public const string AppTitle = "Mood Player";
        public const string SubtitleDefault = "How are you feeling today?";
        public const string PlaylistHeader = "🎵  Playlist";
        public const string TrackCountFormat = "{0} tracks";
        public const string MoodSelectedFormat = "Mood set to {0} ✓";
        public const string TimestampFormat = "Updated at {0:HH:mm  ·  dd MMM yyyy}";
    }
}