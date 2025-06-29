#include <iostream>
#include "Controller.h"
#include "FlightData.h"

int main() {
    // Initialize the flight control system
    Controller flightController;
    FlightData flightData;

    flightController.initialize();

    // Main loop
    while (true) {
        flightData.update();
        flightController.controlFlight(flightData);
        
        // Add a delay or condition to break the loop as needed
    }

    return 0;
}