#pragma once

class FlightData {
public:
    FlightData();

    double getAltitude() const;
    double getSpeed() const;
    double getHeading() const;

    void setAltitude(double altitude);
    void setSpeed(double speed);
    void setHeading(double heading);

    float pitch, roll, yaw;
    float getPitch() const { return pitch; }
    float getRoll() const { return roll; }
    float getYaw() const { return yaw; }
    void update();

private:
    double altitude;
    double speed;
    double heading;
};