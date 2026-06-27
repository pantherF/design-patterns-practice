class ReportGenerator
{
    public string Generate(DataFormatter formatter)
    {
        return formatter.Format("generated data");
    }
}