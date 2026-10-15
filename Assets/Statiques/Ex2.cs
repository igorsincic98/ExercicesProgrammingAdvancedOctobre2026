using System;
using UnityEngine;

namespace Statiques
{

    public class Ex2 : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(TemperatureConverter.CelsiusToFahrenheit(20) + " Fahrenheit ");
            Debug.Log(TemperatureConverter.FahrenheitToCelsius(50) + " Celsius ");
        }
    }

    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double CelsiusTemp)
        {
            return CelsiusTemp * 9 / 5 + 32;
        }

        public static double FahrenheitToCelsius(double FahrenheitTemp)
        {
            return (FahrenheitTemp - 32) * 5 / 9;
        }
    }
}