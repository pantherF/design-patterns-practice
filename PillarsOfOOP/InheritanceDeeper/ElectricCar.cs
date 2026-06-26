class ElectricCar : Vehicle
{
    public override string FuelType()
    {
        return "electricity";
    }

    public override int MaxSpeed()
    {
        return 400;
    }
}