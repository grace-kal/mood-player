# 🎵 Mood Player

A .NET MAUI mobile app that matches your mood to a playlist. Select how you're feeling and instantly get a curated list of tracks — with a smooth animated background that changes color for each mood.

Built as a live coding demo for a .NET MAUI masterclass.

---

## Features

- 5 moods — Happy, Sad, Chill, Angry, Focus
- Animated accent background per mood
- Bounce animation on mood selection
- Playlist with title, artist, genre and duration
- DateTime timestamp on every selection
- Fully hardcoded seed data — no API required
- Dark theme throughout

---

## Tech Stack

| | |
|---|---|
| Framework | .NET MAUI (.NET 10) |
| Language | C# 13 |
| UI | XAML + Code-Behind |
| Architecture | Code-Behind (no MVVM) |
| IDE | Visual Studio 2026 |

---

## Project Structure

```
MoodPlayer/
├── Constants/
│   └── AppConstants.cs        # Colors, dimensions, animation durations, strings
├── Models/
│   ├── Mood.cs                # Mood model — Name, Emoji, AccentColor, Playlist
│   └── Track.cs               # Track model — Title, Artist, Duration, Genre
├── Data/
│   └── MoodData.cs            # Static seed data — 5 moods × 5 tracks
├── Pages/
│   ├── MainPage.xaml          # UI layout — mood buttons, banner, playlist
│   └── MainPage.xaml.cs       # Code-behind — animations, tap handlers, DateTime
└── Resources/
    └── Styles/
        ├── Colors.xaml        # All color tokens
        └── Styles.xaml        # Global styles
```

---

## Prerequisites

- [Visual Studio 2026](https://visualstudio.microsoft.com/) with the **.NET Multi-platform App UI** workload
- .NET 10 SDK
- For Android: Android SDK API 35+ (via Tools → Android → Android SDK Manager)
- For iOS/macOS: a Mac with Xcode installed

---

## How to Run

### Windows (quickest)

1. Clone the repository
   ```bash
   git clone https://github.com/grace-kal/mood-player.git
   ```
2. Open `MoodPlayer.sln` in Visual Studio 2026
3. Select **Windows Machine** from the target dropdown
4. Press **F5** or click the green arrow

### Android

1. Open Tools → Android → Android Device Manager
2. Create or start an emulator (API 35+)
3. Select the emulator from the target dropdown
4. Press **F5**

### iOS / macOS

Requires a paired Mac. Select the target device from the dropdown and press **F5**.

---

## Key Concepts Demonstrated

This project was built to demonstrate the following C# and .NET MAUI concepts:

| Concept | Where |
|---|---|
| `init`-only properties | `Mood.cs`, `Track.cs` |
| `static readonly` | `MoodData.All` |
| `async` / `await` | `OnMoodSelectedAsync()` |
| `Task.WhenAll` | Parallel fade animations |
| `DateTime` formatting | `UpdatePlaylist()` — `HH:mm · dd MMM yyyy` |
| Dynamic UI generation | `BuildMoodButtons()` |
| `Color.FromArgb` | `HighlightSelectedButton()` |
| `.FadeToAsync` / `.ScaleToAsync` | .NET 10 animation API |
| Code-Behind vs MVVM | Entire app — intentionally no ViewModel |

---

## Extending the App

A few ideas for taking it further:

- **Add a 6th mood** — just add a new `Mood` object to `MoodData.All`. The button appears automatically.
- **Connect to Spotify API** — replace `MoodData` with an `HttpClient` call to Spotify's recommendations endpoint
- **Migrate to MVVM** — extract `BuildMoodButtons` and animation logic into a `MoodViewModel` using `CommunityToolkit.Mvvm`
- **Add SQLite history** — log every mood selection with its timestamp to a local database
