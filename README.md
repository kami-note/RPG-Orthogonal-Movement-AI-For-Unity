# RPG Orthogonal Movement AI For Unity

## Description

RPG Orthogonal Movement AI For Unity is an AI library for Unity, specifically designed for RPG games with orthogonal movements. The library provides an efficient and easy-to-use implementation for controlling the player character's movement in a grid environment, allowing precise orthogonal movements. Ideal for turn-based RPG games or any game requiring right-angle movements.

## Installation

To install this library, follow these steps:

1. Clone this repository to your local machine.
2. Copy the `IAMoviment.cs` file into the `Assets` directory of your Unity project.

## Usage

To use this library in your Unity project, follow these steps:

1. Add the `IAMoviment` script to the player object in your scene.
2. In the inspector, set the target and speed according to your game's needs.
3. The position where the player will move should be defined in the `target` variable.
4. Call the `IAHandle()` function in the `Update()` method of the class that is using this library.

## License

This project is licensed under the Apache License - see the LICENSE file for details.

## Author

kami-note
