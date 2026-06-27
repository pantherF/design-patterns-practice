class CsvFormatter : DataFormatter
{
    public override string Format(string data)
    {
        return $"JSON: {data}";
    }
}