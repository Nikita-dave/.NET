using System;

class UnitConvertor
{
    // Method 1: Convert from one unit to another
    public double Convert(double value, string fromUnit, string toUnit)
    {
        if (fromUnit == toUnit)
            return value;

        // Length
        if (fromUnit == "meters" && toUnit == "kilometers")
            return value * 0.001;

        if (fromUnit == "kilometers" && toUnit == "meters")
            return value * 1000;

        if (fromUnit == "miles" && toUnit == "feet")
            return value * 5280;

        if (fromUnit == "feet" && toUnit == "miles")
            return value / 5280;

        // Weight
        if (fromUnit == "grams" && toUnit == "kilograms")
            return value * 0.001;

        if (fromUnit == "kilograms" && toUnit == "grams")
            return value * 1000;

        if (fromUnit == "pounds" && toUnit == "ounces")
            return value * 16;

        if (fromUnit == "ounces" && toUnit == "pounds")
            return value / 16;

        // Temperature
        if (fromUnit == "celsius" && toUnit == "fahrenheit")
            return (value * 9 / 5) + 32;

        if (fromUnit == "fahrenheit" && toUnit == "celsius")
            return (value - 32) * 5 / 9;

        if (fromUnit == "celsius" && toUnit == "kelvin")
            return value + 273.15;

        if (fromUnit == "kelvin" && toUnit == "celsius")
            return value - 273.15;

        throw new ArgumentException("Invalid unit conversion");
    }

    // Method 2 (Overloaded): Convert to base unit
    public double Convert(double value, string fromUnit)
    {
        // Length → meters
        if (fromUnit == "kilometers")
            return Convert(value, "kilometers", "meters");

        if (fromUnit == "miles")
            return Convert(value, "miles", "feet") * 0.3048;

        if (fromUnit == "feet")
            return value * 0.3048;

        if (fromUnit == "meters")
            return value;

        // Weight → grams
        if (fromUnit == "kilograms")
            return Convert(value, "kilograms", "grams");

        if (fromUnit == "pounds")
            return Convert(value, "pounds", "ounces") * 28.3495;

        if (fromUnit == "ounces")
            return value * 28.3495;

        if (fromUnit == "grams")
            return value;

        // Temperature → celsius
        if (fromUnit == "fahrenheit")
            return Convert(value, "fahrenheit", "celsius");

        if (fromUnit == "kelvin")
            return Convert(value, "kelvin", "celsius");

        if (fromUnit == "celsius")
            return value;

        throw new ArgumentException("Unsupported unit");
    }
}
