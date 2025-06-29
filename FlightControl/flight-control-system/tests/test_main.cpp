#include <gtest/gtest.h>
#include "../src/Controller.h"
#include "../src/FlightData.h"

TEST(ControllerTest, Initialization) {
    Controller controller;
    EXPECT_NO_THROW(controller.initialize());
}

TEST(ControllerTest, Update) {
    Controller controller;
    controller.initialize();
    EXPECT_NO_THROW(controller.update());
}

TEST(ControllerTest, ControlFlight) {
    Controller controller;
    controller.initialize();
    EXPECT_NO_THROW(controller.controlFlight());
}

TEST(FlightDataTest, GetAltitude) {
    FlightData flightData;
    flightData.setAltitude(1000);
    EXPECT_EQ(flightData.getAltitude(), 1000);
}

TEST(FlightDataTest, GetSpeed) {
    FlightData flightData;
    flightData.setSpeed(250);
    EXPECT_EQ(flightData.getSpeed(), 250);
}

TEST(FlightDataTest, GetHeading) {
    FlightData flightData;
    flightData.setHeading(90);
    EXPECT_EQ(flightData.getHeading(), 90);
}

int main(int argc, char **argv) {
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}