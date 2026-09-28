# Island Escape

**Island Escape** is a PC endless-runner game developed in Unity. The player progresses through an island environment while collecting items, reacting to obstacles and interactive events, using power-ups, and trying to achieve a higher score.

This repository is presented as a **gameplay-programming portfolio**. The C# scripts included here represent the systems I was responsible for implementing during the project.

## My Contributions

My work focused on supporting the core gameplay loop and player experience through several Unity/C# systems:

- NPC follow behaviour and animation-state handling
- Randomised power-up spawning
- Quick-time-event (QTE) door interaction
- Runtime environment cleanup for endless-runner level progression
- Score display and game-over flow
- Scene navigation and restart/quit behaviour
- Background-audio timing integrated with the opening gameplay sequence

## Gameplay Systems

### NPC Follow System

The NPC system maintains an initial positional offset from the player and follows the player's movement using interpolated positioning. It also coordinates the NPC's running animation with the game's initial delay and stops the NPC when the player dies.

**Script:** `NPCController.cs`

### Power-Up Spawning

The power-up manager periodically generates a random gameplay pickup and positions it along the upcoming path. The implemented spawn pool includes:

- Heart
- Magnet
- Double-points coin
- Mystery card

Spawn positions and distances are randomised to introduce variation during a run.

**Script:** `PowerUpManager.cs`

### QTE Door Interaction

The QTE door system detects when the player remains within the interaction trigger and allows the door-opening animation to be activated with the Space key. A state flag prevents the same door from being repeatedly opened.

**Script:** `QTE_DoorController.cs`

### Endless-Runner Environment Cleanup

To support continuous forward progression, environment objects that have fallen sufficiently far behind the player are destroyed at runtime. Different distance thresholds are used for laboratory and island-ground objects, while the ground count is updated when generated ground sections are removed.

**Script:** `SceneController.cs`

### Score & Game-Over Flow

The project includes score presentation during gameplay and carries the final score into the game-over screen. The game-over interface provides restart and quit functionality.

**Scripts:** `ScoreManager.cs`, `GameOver.cs`

### Audio Timing

Background music begins after the same initial delay used by the player sequence, synchronising the audio with the start of the running section.

**Script:** `AudioManager.cs`

## Technical Focus

- Unity
- C#
- Gameplay programming
- Coroutines
- Runtime object spawning
- Randomised gameplay events
- Trigger-based interactions
- Animation control
- NPC follow behaviour
- Scene management
- Runtime object lifecycle management
- UI / score presentation

## Code Included

| Script | Responsibility |
| --- | --- |
| `NPCController.cs` | NPC follow movement and animation behaviour |
| `PowerUpManager.cs` | Randomised power-up generation and placement |
| `QTE_DoorController.cs` | Player-triggered QTE door interaction |
| `SceneController.cs` | Removes environment sections after the player passes them |
| `ScoreManager.cs` | Gameplay score handling/display |
| `GameOver.cs` | Final score, restart and quit flow |
| `AudioManager.cs` | Delayed background-music playback |

## Gameplay Trailer

[Watch the Island Escape gameplay trailer on YouTube](https://youtu.be/q0IvLKlY4CE)

## Repository Note

This repository contains selected scripts representing **my contribution to the project**, rather than the complete Unity project. Other gameplay systems referenced by these scripts may therefore not be included here.

The repository is intended to demonstrate my work in Unity gameplay programming and the implementation of supporting systems for an endless-runner game.
