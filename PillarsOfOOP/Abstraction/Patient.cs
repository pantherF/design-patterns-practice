class Patient
{
    public required string Name { get; set; }
    public required uint Age { get; set; }
    public required string SocialSecurityNumber { get; set; }
    public required string Address { get; set; }
    public string? EmergencyContactPhone { get; set; }
    public uint FitnessLevel { get; set; }
    public float BloodPressure { get; set; }
    public List<string>? Medications { get; set; }
    public List<string>? Prescriptions { get; set; }
    public List<string>? MedicalConditions { get; set; }
    public List<string>? Surgeries { get; set; }

    public void PrintSummary()
    {
        Console.WriteLine("=== Hospital Patient Summary ===");
        Console.WriteLine($"Name:              {Name}");
        Console.WriteLine($"Age:               {Age}");
        Console.WriteLine($"SSN:               {SocialSecurityNumber}");
        Console.WriteLine($"Address:           {Address}");
        Console.WriteLine($"Emergency Contact: {EmergencyContactPhone ?? "N/A"}");
        Console.WriteLine($"Fitness Level:     {FitnessLevel}");
        Console.WriteLine($"Blood Pressure:    {BloodPressure}");
        Console.WriteLine($"Medications:       {FormatList(Medications)}");
        Console.WriteLine($"Prescriptions:     {FormatList(Prescriptions)}");
        Console.WriteLine($"Conditions:        {FormatList(MedicalConditions)}");
        Console.WriteLine($"Surgeries:         {FormatList(Surgeries)}");
    }

    private static string FormatList(List<string>? list) =>
        (list is { Count: > 0 }) ? string.Join(", ", list) : "None";
}
