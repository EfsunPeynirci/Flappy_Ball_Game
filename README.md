# Flappy Ball Game 🏀🎮

**Flappy Ball** is a simple and fun Unity game where you control a ball and try to pass through columns without hitting them. The game ends when the ball collides with an obstacle, and you can restart to try again.

## How to Play 🕹️

1. **Start** the game by clicking or tapping the screen. 🏁
2. **Control** the ball's movement to avoid obstacles. ⚡
3. If you hit an obstacle, the game pauses, showing the **Game Over** screen. 🛑
4. If you successfully pass all obstacles, you'll see a **Well Done** message! 🎉
5. **Restart** the game by pressing the **Restart** button.

## Features 🚀

- **Simple Controls**: Tap or click to move the ball.
- **Game Over & Success Screens**: See your result after every round.
- **Responsive Gameplay**: Smooth movement and collision detection.

## Flappy Ball Game - Live Demo 🎮

https://github.com/user-attachments/assets/2d6815d5-d35f-44e6-91e2-c349e302f2da

## Screenshots 📸

![1](https://github.com/user-attachments/assets/0cf5f542-3e05-4865-8a69-6bb6146d33d8)

![2](https://github.com/user-attachments/assets/9d2af989-4c30-451f-9f86-a5a5efc16f0c)

![3](https://github.com/user-attachments/assets/fb556d9f-68d3-4e35-8e7f-88234fd8f8a4)

![4](https://github.com/user-attachments/assets/29904d72-5221-41e4-be69-d2718e1f6c7f)

## Technologies 🛠️

- **Unity**: Game development platform used to create and build the game.
- **C#**: Programming language used for implementing game mechanics, including ball movement, collision detection, and game state management.
- **Rigidbody**: Used for controlling the physics of the ball, including its movement and collisions with obstacles.
- **Scene Management**: To load and restart the game scene when necessary using `SceneManager`.
- **UI System**: For managing and displaying game menus such as **Main Menu**, **Game Over**, and **Victory** screens.
- **Player Input**: Used to detect mouse/touch input to control the ball's movement.
- **Time.timeScale**: To pause and restart the game after a collision or when the game is won.
- **Transform**: To move and position the camera to follow the ball smoothly during the game.

## Code Overview 📂

- **BallController.cs**: Handles ball movement, collision detection, and game logic (Game Over and Success screens).
- **CamController.cs**: Follows the ball with a smooth camera movement.

## Course 🎓
Developed as part of the Udemy course: "Mobile Game Development: Unity Essentials" by Yücel Bayram.
