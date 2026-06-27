// Exercise 8 — Dependency
// Topic: Weakest relation — one class uses another temporarily

var formatter = new DataFormatter();
var json = new JsonFormatter();
var csv = new CsvFormatter();

var formatters = new List<DataFormatter>
{
    formatter,
    json,
    csv
};

var report = new ReportGenerator();

foreach (var f in formatters)
{
    Console.WriteLine(report.Generate(f));
}

// I don't have to change the generate class at all, any of the passed in formatters work just fine.