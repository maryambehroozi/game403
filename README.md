# game403

## endless runner
## Objective
The goal of this project is to design and develop an Endless Runner game using Unity 3D. This game will provide players with the opportunity to compete in a dynamic and challenging environment, testing their skills in navigating obstacles. By employing modern game development techniques, we aim to deliver an engaging and entertaining experience for players.

## Project Specifications
### 1. Game Mechanics
The game is designed so that the player character automatically moves forward. This feature allows players to focus on reacting to obstacles rather than controlling movement. The game path is dynamically generated, meaning that each time the game starts, new obstacles and challenges are created randomly. This aspect enhances the diversity and appeal of the gameplay.

Various obstacles will appear along the path that players must avoid by moving left or right. These obstacles include both static and moving objects, each presenting unique challenges. Additionally, a High Score system is implemented to track the best records achieved by players. This feature motivates players to strive for new high scores and improve their performance with each playthrough.

#### 2. User Interface (UI) Elements
The game’s user interface is designed to enhance the player experience by making it more intuitive and enjoyable. One of the key UI elements is the score counter, which increases as the player progresses through the game. This counter provides players with feedback on their progress and the score they have achieved.

Furthermore, a button for restarting the game after a loss (Game Over) has been added. This button allows players to easily resume the game without needing to exit, encouraging them to take on the challenge again.

### 3. Graphics and Assets
To create a visually appealing and immersive game environment, we utilize free assets available from the Unity Asset Store. These assets include player models, textures, and other graphical elements that contribute to the overall visual design of the game. Our goal is to ensure that the game environment captivates players and encourages them to continue playing.

Ultimately, this project serves not only as an entertaining game but also as a learning opportunity for developers. By using Unity 3D and implementing various game mechanics, we aim to create a unique experience for players. We hope that this game will provide hours of fun and challenge, motivating users to return and play again.

## Ploce car
In this exercise, you will create a police car driving simulator using Unity. This project helped us get familiar with lights, sound effects, and controlling a car.

## Project Development
- **Driving Controls:** Use keyboard inputs to control the movement of the car.
- **Front Lights:** Create the car's front lights and add functionality to toggle them on/off using the "G" key.
- **Police Siren Light and Sound:** Design a flashing light that is always on. When the spacebar is pressed, the siren light becomes brighter, and the siren sound is activated.

## Code Summary

The provided code defines a `CarController` class that manages the behavior of a police car in the simulator. Here's a breakdown of its components:

### Class Variables
- **Input Constants:** Defines input axes for horizontal and vertical movement.
- **State Variables:** Tracks inputs for steering, braking, light status, and siren status.
- **Serialized Fields:** Exposes variables in the Unity Inspector for motor force, brake force, steering angle, and wheel colliders/transforms for the car.

### Key Methods
1. **Update():** Called once per frame to handle input, update lights, motor, steering, and wheel positions.
2. **GetInput():** Captures user input for steering, acceleration, braking, and toggling lights and siren.
3. **HandleMotor():** Applies motor torque to the front wheels based on user input and manages braking.
4. **HandleLight():** Toggles the front lights on or off based on user input.
5. **TopHandleLight():** Manages the flashing effect of the siren lights using a time-based cycle.
6. **ApplyBreaking():** Applies brake torque to the front wheels when braking is active.
