#pragma once
#include "FlightData.h"

class Controller {
public:
    Controller();
    void initialize();
    void update(const FlightData& flightData);
    void controlFlight(const FlightData& data);
};