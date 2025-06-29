#include "FlightData.h"
#include "MPU6050.h"

FlightData::FlightData() : altitude(0.0), speed(0.0), heading(0.0) {}

void FlightData::setAltitude(double alt) {
    altitude = alt;
}

void FlightData::setSpeed(double spd) {
    speed = spd;
}

void FlightData::setHeading(double hdg) {
    heading = hdg;
}

double FlightData::getAltitude() const {
    return altitude;
}

double FlightData::getSpeed() const {
    return speed;
}

double FlightData::getHeading() const {
    return heading;
}

void FlightData::update() { 
    MPU6050 mpu;
    mpu.readSensor();
    pitch = mpu.getPitch();
    roll = mpu.getRoll();
    yaw = mpu.getYaw();
}