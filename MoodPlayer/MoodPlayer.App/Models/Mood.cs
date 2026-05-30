namespace MoodPlayer.App.Models;

public class Mood
{
    public string Name { get; init; } = string.Empty;
    public string Emoji { get; init; } = string.Empty;
    public string AccentColor { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public List<Track> Playlist { get; init; } = new();
}
