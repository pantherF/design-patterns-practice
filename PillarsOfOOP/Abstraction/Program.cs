// Exercise 3 — Abstraction
// Topic: Modeling only what's relevant to context

var customer = new Customer
{
    Name = "Alice Johnson",
    PhoneNumber = "555-867-5309",
    Email = "alice@example.com",
    Newsletter = true
};

var patient = new Patient
{
    Name = "Bob Smith",
    Age = 45,
    SocialSecurityNumber = "123-45-6789",
    Address = "742 Evergreen Terrace, Springfield, IL",
    EmergencyContactPhone = "555-111-2222",
    FitnessLevel = 3,
    BloodPressure = 120.8f,
    Medications = new List<string> { "Lisinopril", "Metformin" },
    Prescriptions = new List<string> { "Amoxicillin 500mg" },
    MedicalConditions = new List<string> { "Hypertension", "Type 2 Diabetes" },
    Surgeries = null
};

customer.PrintSummary();
Console.WriteLine();
patient.PrintSummary();