using System;

class Unitconvertor
{
    public double Convert(double value, string fromUnit, string toUnit)
    {
        if(fromUnit=="meters" && toUnit == "kilometers")
        {
            return value*0.001;
        }else if(fromUnit=="kilometers" && toUnit == "meters")
        {
            return value*1000;
        }else if(fromUnit=="miles" && toUnit == "feet")
        {
            return value*5280;
        }else if(fromUnit=="feet" && toUnit == "miles")
        {
            return value/5280;
        }else if(fromUnit=="grams" && toUnit == "kilograms")
        {
            return value*001;
        }else if(fromUnit=="kilograms" && toUnit == "grams")
        {
            return value*1000;
        }else if(fromUnit=="pounds" && toUnit == "ounces")
        {
            return value*16;
        }else if(fromUnit=="ounces" && toUnit == "pounds")
        {
            return value/16;
        }else if(fromUnit=="celsius" && toUnit == "Fahrenheit")
        {
            return (value*9/5)+32;
        }else if(fromUnit=="Fahrenheit" && toUnit == "celsius")
        {
            return (value-32)* 5/9;
        }else if(fromUnit=="celsius" && toUnit == "kelvin")
        {
            return value+273.15;
        }else if(fromUnit=="kelvin" && toUnit == "celsius")
        {
            return value-273.15;
        }
        else
        {
            return 0.0;
        }
        
    }

    public double Convert(double value, string fromUnit)
    {
        if(fromUnit=="meters" || fromUnit=="kilometers" ||fromUnit=="miles" || fromUnit == "feet")
        {
            if (fromUnit == "meters")
            {
                return value;
            }
            else
            {
                return Convert(value,fromUnit,toUnit);
            }
        }else if(fromUnit=="grams" || fromUnit=="kilograms" ||fromUnit=="pounds" || fromUnit == "ounces")
        {
            if (fromUnit == "grams")
            {
                return value;
            }
            else
            {
                return Convert(value,fromUnit,toUnit);
            }
        }
    }
}