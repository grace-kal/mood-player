using MoodPlayer.App.Constants;
using MoodPlayer.App.Data;
using MoodPlayer.App.Models;

namespace MoodPlayer.App;

public partial class MainPage : ContentPage
{
    // state
    private Mood? _currentMood;
    private bool _isAnimating;

    public MainPage()
    {
        InitializeComponent();
        BuildMoodButtons();
    }

    // generating mood buttons dynamically
    private void BuildMoodButtons()
    {
        foreach (var mood in MoodData.All)
        {
            var button = new Border
            {
                BackgroundColor = AppConstants.Colors.Surface,
                Stroke = AppConstants.Colors.Border,
                StrokeThickness = AppConstants.Dimensions.StrokeDefault,
                StrokeShape = new Microsoft.Maui.Controls.Shapes.RoundRectangle
                {
                    CornerRadius = AppConstants.Dimensions.ButtonCornerRadius
                },
                Margin = new Thickness(8),
                WidthRequest = AppConstants.Dimensions.MoodButtonWidth,
                HeightRequest = AppConstants.Dimensions.MoodButtonHeight,
            };

            var inner = new VerticalStackLayout
            {
                Spacing = 4,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };

            inner.Add(new Label
            {
                Text = mood.Emoji,
                FontSize = 32,
                HorizontalOptions = LayoutOptions.Center,
            });

            inner.Add(new Label
            {
                Text = mood.Name,
                FontSize = 13,
                FontAttributes = FontAttributes.Bold,
                TextColor = AppConstants.Colors.TextSecondary,
                HorizontalOptions = LayoutOptions.Center,
            });

            button.Content = inner;

            // button click handler
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) => await OnMoodSelectedAsync(mood, button);
            button.GestureRecognizers.Add(tap);

            MoodButtonsLayout.Add(button);
        }
    }

    // mood selection flow
    private async Task OnMoodSelectedAsync(Mood mood, Border tappedButton)
    {
        if (_isAnimating) return;
        _isAnimating = true;

        _currentMood = mood;

        // bounce animation on the tapped button
        await tappedButton.ScaleToAsync(
            AppConstants.Animation.ScaleDownValue,
            AppConstants.Animation.ScaleDownDuration,
            Easing.CubicIn);

        await tappedButton.ScaleToAsync(
            AppConstants.Animation.ScaleUpValue,
            AppConstants.Animation.ScaleUpDuration,
            Easing.CubicOut);

        // highlight the selected button
        HighlightSelectedButton(tappedButton, mood.AccentColor);

        // animate background color change
        await AnimateBackgroundAsync(mood.AccentColor);

        // update the mood banner with new info
        UpdateMoodBanner(mood);

        // update the playlist with tracks for the selected mood
        UpdatePlaylist(mood);

        // show the banner and playlist with a fade-in or flash effect
        await ShowContentAsync();

        _isAnimating = false;
    }

    private void HighlightSelectedButton(Border selected, string accentHex)
    {
        var accent = Color.FromArgb(accentHex);

        foreach (var child in MoodButtonsLayout.Children)
        {
            if (child is Border b)
            {
                bool isSelected = b == selected;
                b.Stroke = isSelected ? accent : AppConstants.Colors.Border;
                b.StrokeThickness = isSelected
                    ? AppConstants.Dimensions.StrokeSelected
                    : AppConstants.Dimensions.StrokeDefault;
                b.BackgroundColor = isSelected
                    ? accent.WithAlpha(AppConstants.Dimensions.SelectedAlpha)
                    : AppConstants.Colors.Surface;
            }
        }
    }

    private async Task AnimateBackgroundAsync(string accentHex)
    {
        AccentBackground.Color = Color.FromArgb(accentHex);

        await AccentBackground.FadeToAsync(
            AppConstants.Animation.FadeOutValue,
            AppConstants.Animation.FadeOutDuration,
            Easing.CubicIn);

        await AccentBackground.FadeToAsync(
            AppConstants.Animation.FadeInValue,
            AppConstants.Animation.FadeInDuration,
            Easing.CubicOut);
    }

    private void UpdateMoodBanner(Mood mood)
    {
        MoodEmojiLabel.Text = mood.Emoji;
        MoodNameLabel.Text = mood.Name;
        MoodNameLabel.TextColor = Color.FromArgb(mood.AccentColor);
        MoodDescLabel.Text = mood.Description;
        SubtitleLabel.Text = string.Format(
            AppConstants.Strings.MoodSelectedFormat, mood.Name);
        SubtitleLabel.TextColor = Color.FromArgb(mood.AccentColor);
    }

    private void UpdatePlaylist(Mood mood)
    {
        TrackList.ItemsSource = mood.Playlist;
        TrackCountLabel.Text = string.Format(
            AppConstants.Strings.TrackCountFormat, mood.Playlist.Count);

        TimestampLabel.Text = string.Format(
            AppConstants.Strings.TimestampFormat, DateTime.Now);
    }

    private async Task ShowContentAsync()
    {
        if (!MoodBanner.IsVisible)
        {
            MoodBanner.Opacity = 0;
            PlaylistContainer.Opacity = 0;
            MoodBanner.IsVisible = true;
            PlaylistContainer.IsVisible = true;

            await Task.WhenAll(
                MoodBanner.FadeToAsync(
                    AppConstants.Animation.FullOpacity,
                    AppConstants.Animation.BannerFadeDuration,
                    Easing.CubicOut),
                PlaylistContainer.FadeToAsync(
                    AppConstants.Animation.FullOpacity,
                    AppConstants.Animation.PlaylistFadeDuration,
                    Easing.CubicOut)
            );
        }
        else
        {
            await Task.WhenAll(
                MoodBanner.FadeToAsync(
                    AppConstants.Animation.HalfOpacity,
                    AppConstants.Animation.FlashOutDuration),
                PlaylistContainer.FadeToAsync(
                    AppConstants.Animation.HalfOpacity,
                    AppConstants.Animation.FlashOutDuration)
            );
            await Task.WhenAll(
                MoodBanner.FadeToAsync(
                    AppConstants.Animation.FullOpacity,
                    AppConstants.Animation.FlashInDuration),
                PlaylistContainer.FadeToAsync(
                    AppConstants.Animation.FullOpacity,
                    AppConstants.Animation.FlashInDuration)
            );
        }
    }
}