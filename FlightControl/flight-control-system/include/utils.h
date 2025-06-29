#ifndef UTILS_H
#define UTILS_H

#include <cmath>

// Utility functions
namespace Utils {
    const double PI = 3.14159265358979323846;

    // Function to convert degrees to radians
    inline double degreesToRadians(double degrees) {
        return degrees * (PI / 180.0);
    }

    // Function to convert radians to degrees
    inline double radiansToDegrees(double radians) {
        return radians * (180.0 / PI);
    }

    // Function to clamp a value between a minimum and maximum
    template<typename T>
    inline T clamp(T value, T min, T max) {
        return (value < min) ? min : (value > max) ? max : value;
    }
}

#endif // UTILS_H