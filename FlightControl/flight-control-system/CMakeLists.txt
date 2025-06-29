cmake_minimum_required(VERSION 3.10)

# Set the project name
project(FlightControlSystem)

# Specify the C++ standard
set(CMAKE_CXX_STANDARD 11)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# Include directories
include_directories(include)
include_directories(src)

# Source files
set(SOURCES
    src/Main.cpp
    src/Controller.cpp
    src/FlightData.cpp
)

# Add executable
add_executable(FlightControlSystem ${SOURCES})

# Enable testing
enable_testing()

# Add tests
add_subdirectory(tests)