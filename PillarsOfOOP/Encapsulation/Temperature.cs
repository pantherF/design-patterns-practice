class Temperature
{
    double _celsius;
    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < -273.15)
            {
                throw new ArgumentException("Value cannot be lower than -273.15");
            }

            _celsius = value;
        }
    }

    public double Fahrenheit
    {
        get => _celsius * (9.0 / 5) + 32;
    }

    public double Kelvin
    {
        get => _celsius + 273.15;
    }

    public static Temperature FromFahrenheit(double f)
    {
        var c = (f - 32) * (5.0 / 9);
        var k = (f - 459.67) * (5.0 / 9);

        return new Temperature { Celsius = c };
    }
}