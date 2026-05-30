using MoodPlayer.App.Models;

namespace MoodPlayer.App.Data;

public static class MoodData
{
    public static readonly List<Mood> All = new()
    {
        new Mood
        {
            Name        = "Happy",
            Emoji       = "😊",
            AccentColor = "#F59E0B",
            Description = "Energetic beats to keep the good vibes going!",
            Playlist    = new()
            {
                new Track { Title = "Can't Stop the Feeling", Artist = "Justin Timberlake", Duration = "3:56", Genre = "Pop" },
                new Track { Title = "Happy",                  Artist = "Pharrell Williams",  Duration = "3:53", Genre = "Pop" },
                new Track { Title = "Uptown Funk",            Artist = "Mark Ronson",        Duration = "4:30", Genre = "Funk" },
                new Track { Title = "Walking on Sunshine",    Artist = "Katrina & The Waves",Duration = "3:58", Genre = "Pop Rock" },
                new Track { Title = "Good as Hell",           Artist = "Lizzo",              Duration = "2:39", Genre = "Pop" },
            }
        },

        new Mood
        {
            Name        = "Sad",
            Emoji       = "😢",
            AccentColor = "#6366F1",
            Description = "Let it out. Sometimes you just need to feel it.",
            Playlist    = new()
            {
                new Track { Title = "Someone Like You",  Artist = "Adele",            Duration = "4:45", Genre = "Soul" },
                new Track { Title = "Fix You",           Artist = "Coldplay",         Duration = "4:55", Genre = "Alt Rock" },
                new Track { Title = "Skinny Love",       Artist = "Bon Iver",         Duration = "3:58", Genre = "Indie Folk" },
                new Track { Title = "Let Her Go",        Artist = "Passenger",        Duration = "4:14", Genre = "Folk Pop" },
                new Track { Title = "The Night Will Always Win", Artist = "Manchester Orchestra", Duration = "4:02", Genre = "Alt Rock" },
            }
        },

        new Mood
        {
            Name        = "Chill",
            Emoji       = "😌",
            AccentColor = "#10B981",
            Description = "Slow down, breathe, float away.",
            Playlist    = new()
            {
                new Track { Title = "Sunset Lover",   Artist = "Petit Biscuit",    Duration = "3:42", Genre = "Electronic" },
                new Track { Title = "Redbone",        Artist = "Childish Gambino", Duration = "5:27", Genre = "Neo Soul" },
                new Track { Title = "Golden Hour",    Artist = "JVKE",             Duration = "3:29", Genre = "Indie Pop" },
                new Track { Title = "Coffee",         Artist = "beabadoobee",      Duration = "1:48", Genre = "Indie" },
                new Track { Title = "Weightless",     Artist = "Marconi Union",    Duration = "8:09", Genre = "Ambient" },
            }
        },

        new Mood
        {
            Name        = "Angry",
            Emoji       = "😡",
            AccentColor = "#EF4444",
            Description = "Channel it. Turn that energy into something.",
            Playlist    = new()
            {
                new Track { Title = "Break Stuff",         Artist = "Limp Bizkit", Duration = "2:46", Genre = "Nu Metal" },
                new Track { Title = "Bulls on Parade",     Artist = "RATM",        Duration = "3:50", Genre = "Metal" },
                new Track { Title = "Killing in the Name", Artist = "RATM",        Duration = "5:13", Genre = "Metal" },
                new Track { Title = "Given Up",            Artist = "Linkin Park", Duration = "3:09", Genre = "Rock" },
                new Track { Title = "Monster",             Artist = "Imagine Dragons", Duration = "3:54", Genre = "Alt Rock" },
            }
        },

        new Mood
        {
            Name        = "Focus",
            Emoji       = "🎯",
            AccentColor = "#06B6D4",
            Description = "Zone in. Deep work mode activated.",
            Playlist    = new()
            {
                new Track { Title = "Experience",  Artist = "Ludovico Einaudi", Duration = "5:14", Genre = "Classical" },
                new Track { Title = "Time",        Artist = "Hans Zimmer",      Duration = "4:35", Genre = "Soundtrack" },
                new Track { Title = "Strobe",      Artist = "deadmau5",         Duration = "10:33",Genre = "Electronic" },
                new Track { Title = "Intro",       Artist = "The xx",           Duration = "2:07", Genre = "Indie" },
                new Track { Title = "Weightless",  Artist = "Marconi Union",    Duration = "8:09", Genre = "Ambient" },
            }
        },
    };
}
