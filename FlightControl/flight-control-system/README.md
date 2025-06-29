# Flight Control System

## Overview
The Flight Control System is a software application designed to manage and control flight operations. It processes sensor data, manages flight parameters, and ensures safe and efficient flight operations.

## Project Structure
```
flight-control-system
├── src
│   ├── Main.cpp
│   ├── Controller.cpp
│   ├── Controller.h
│   ├── FlightData.cpp
│   └── FlightData.h
├── include
│   └── utils.h
├── tests
│   └── test_main.cpp
├── CMakeLists.txt
└── README.md
```

## Files Description
- **src/Main.cpp**: Entry point of the application. Initializes the flight control system and manages the main loop.
- **src/Controller.cpp**: Implementation of the Controller class, responsible for managing flight operations and responding to sensor data.
- **src/Controller.h**: Header file declaring the Controller class with methods such as `initialize()`, `update()`, and `controlFlight()`.
- **src/FlightData.cpp**: Implements the FlightData class, handling storage and processing of flight-related information like altitude, speed, and heading.
- **src/FlightData.h**: Header file declaring the FlightData class with methods such as `getAltitude()`, `getSpeed()`, and `getHeading()`.
- **include/utils.h**: Contains utility functions and constants for mathematical operations and data validation.
- **tests/test_main.cpp**: Contains unit tests for the main components of the flight control system, ensuring functionality of the Controller and FlightData classes.
- **CMakeLists.txt**: Configuration file for CMake, specifying project settings, source files, and build instructions.

## Setup Instructions
1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Create a build directory and navigate into it:
   ```
   mkdir build
   cd build
   ```
4. Run CMake to configure the project:
   ```
   cmake ..
   ```
5. Build the project:
   ```
   make
   ```

## Usage Guidelines
- After building the project, run the executable generated in the build directory to start the flight control system.
- Ensure that all necessary sensors and hardware interfaces are properly connected and configured before running the system.

## Features
- Real-time flight data processing.
- Control algorithms for managing flight operations.
- Modular design for easy maintenance and extension.
- Unit tests to ensure reliability and correctness of the system components.