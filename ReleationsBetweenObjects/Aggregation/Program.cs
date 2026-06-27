// Exercise 10 — Aggregation
// Topic: "Has-a" where parts can exist independently

var englishDepartment = new Department()
{
    Professors = new List<Professor>()
};

var mathematicsDepartment = new Department()
{
    Professors = new List<Professor>()
};

var profSmith = new Professor("Dr.", "Smith");
var profAngles = new Professor("Dr.", "Angles");
var profMcDonald = new Professor("Dr.", "McDonald");
var profDeacan = new Professor("Dr.", "Deacan");
var profJohnnson = new Professor("Dr.", "Johnnson");
var profBean = new Professor("Mr.", "Bean");

englishDepartment.Professors = [profSmith, profMcDonald, profAngles];

Console.WriteLine("English department professors:");
foreach (var professor in englishDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

// This professor does not belong to a department, but he can still exist without it
Console.WriteLine("Independent professors:");
Console.WriteLine($"{profBean.Title} {profBean.Name}");

// Same is true for Dr. Smith, she can exist without the department, so it doesn't need a department, to be usable
Console.WriteLine("English department professors can also exist independenlty:");
Console.WriteLine($"{profSmith.Title} {profSmith.Name}");

// Dr. Smith is also capable to exist within multiple departments at the same time, meaning, if we add her to the mathematics department, she can still be part of the english department:
mathematicsDepartment.Professors = [profSmith, profJohnnson, profDeacan];

Console.WriteLine("English department professors:");
foreach (var professor in englishDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

Console.WriteLine("Maths department professors:");
foreach (var professor in mathematicsDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

// If I were to take out Dr. Smith from the english department, she can still be in the maths department and exist independently too:

englishDepartment.Professors.Remove(profSmith);

Console.WriteLine("Ms. Smith can exist without being in the english department:");
Console.WriteLine($"{profSmith.Title} {profSmith.Name}");

Console.WriteLine("English department professors:");
foreach (var professor in englishDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

Console.WriteLine("Maths department professors:");
foreach (var professor in mathematicsDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

mathematicsDepartment.Professors.Remove(profSmith);

Console.WriteLine("And she still exists after being removed from both departments:");
Console.WriteLine($"{profSmith.Title} {profSmith.Name}");

Console.WriteLine("English department professors:");
foreach (var professor in englishDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

Console.WriteLine("Maths department professors:");
foreach (var professor in mathematicsDepartment.Professors)
{
    Console.WriteLine($"{professor.Title} {professor.Name}");
}

