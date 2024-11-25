# game403


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
