﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;


/// <summary>
/// <para>** NOTE: ADDED in CFX 1.3 **</para>
/// An enumeration indicating the type of sensor that is located in a resource / sub-resource / endpoint
/// </summary>
namespace CFX.Structures.Maintenance
{
    /// <summary>
    /// The type of the sensor (distance, temperature, time etc.). It shall be used together with the SensorUnitOfMeasure
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SensorType
    {
            /// <summary>
            /// Unknown sensor
            /// </summary>
            Unkwnown,
            /// <summary>
            /// General sensor
            /// </summary>    
            General,
            /// <summary>
            /// Temperature sensor
            /// </summary>
            Temperature,
            /// <summary>
            /// Electric sensor (e.g. voltage)
            /// </summary>
            Electric,
            /// <summary>
            /// Distance sensor
            /// </summary>
            Distance,
            /// <summary>
            /// Time sensor
            /// </summary>
            Time,
            /// <summary>
            /// Humidity sensor
            /// </summary>
            Humidity,
            /// <summary>
            /// Pressure sensor
            /// </summary>
            Pressure,
            /// <summary>
            /// Torque sensor
            /// </summary>
            Torque,
            /// <summary>
            /// Power sensor
            /// </summary>
            Power,
            /// <summary>
            /// Frequency sensor
            /// </summary>
            Frequency

    }

    /// <summary>
    /// The unit of measure of the sensor (meter, degree, hour etc. according to derived SI where applicable).
    /// It shall be used together with the SensorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SensorUnitOfMeasure
    {
        /// <summary>
        /// Unknown sensor
        /// </summary>
        Unkwnown,
        /// <summary>
        /// Temperature type
        /// </summary>
        DegreeCelsius,
        /// <summary>
        /// Voltage
        /// </summary>
        V,
        /// <summary>
        /// Ampere
        /// </summary>
        A,
        /// <summary>
        /// Resistance
        /// </summary>
        Ohm,
        /// <summary>
        /// Distance type
        /// </summary>
        m,
        /// <summary>
        /// Time type - not SI but accepted by SI
        /// </summary>
        h,
        /// <summary>
        /// Umidity unit - in SI as grams per cubic meter
        /// </summary>
        HumidityPercentage,
        /// <summary>
        /// Pressure type
        /// </summary>
        Pa,
        /// <summary>
        /// Torque unit
        /// </summary>
        Nm,
        /// <summary>
        /// Power unit
        /// </summary>
        W,
        /// Frequency unit
        /// </summary>
        Hz
    }

}