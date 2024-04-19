# Space Shooter Game

## Overview
This repository contains the Unity scripts for a Space Shooter game. Players control a spaceship, navigating through space, dodging asteroids, and fighting enemies. The game features several interactive components such as asteroids, enemies, and power-ups, all managed by comprehensive game and spawn management systems.

## Features
- **Player Control**: Maneuver a spaceship with the ability to shoot lasers.
- **Asteroids**: Asteroids move through space and can be destroyed with lasers.
- **Enemies**: Various enemy ships challenge the player with different attack patterns.
- **Power-ups**: Enhance the spaceship's abilities temporarily.
- **Explosions**: Visual effects for when objects are destroyed.
- **Game Management**: Handles game state, including scores and player life.
- **UI Management**: Dynamic user interface that updates based on game state.

## Scripts
- `Player.cs`: Controls player movements and shooting mechanics.
- `Enemy.cs`: Defines enemy behaviors and effects upon destruction.
- `Asteroid.cs`: Manages the behavior of asteroids in the game.
- `Laser.cs`: Governs the properties and behavior of lasers shot by the player.
- `Explosion.cs`: Manages the explosion effects when game objects are destroyed.
- `Powerup.cs`: Defines various power-ups that the player can collect.
- `GameManager.cs`: Manages the overall game state, including the start and end of the game.
- `SpawnManager.cs`: Controls the spawning of enemies and asteroids.
- `UIManager.cs`: Manages all user interface elements.

## Getting Started
To run this project, you will need Unity Editor. After cloning the repository, open the project in Unity, load the main scene, and hit the play button to start the game.

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

