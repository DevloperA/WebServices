﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWeatherService" in both code and config file together.
[ServiceContract]
public interface IWeatherService
{
    [OperationContract]
    WeatherReports getWeatherData(string city_name, string state_name);

    [OperationContract]
    double AreaSquare(double sides);

    [OperationContract]
    double AreaRectangle(double length, double breadth);

    [OperationContract]
    double GetSpeed(double distance, double time);

    [OperationContract]
    double GetDistance(double speed, double time);
}
