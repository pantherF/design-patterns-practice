class JsonFormatter : DataFormatter
{
    public override string Format(string data)
    {
        return $"CSV: {data}";
    }
}