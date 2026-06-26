abstract class Vehicle
{
    public abstract string FuelType();
    public abstract int MaxSpeed();
    public string Describe()
    {
        return $"This {StringFormatter.ToLowerSentence(this.ToString())} runs on {FuelType()} and reaches up to {MaxSpeed()} km/h.";
    }
}