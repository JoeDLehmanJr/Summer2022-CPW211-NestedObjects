using NestedObjects;

Advisor compSciAdvisor = new()
{
    FullName = "Annemarie Smith",
    Email = "Annemarie@cptc.edu",
    OfficeLocation = "B17 Rm 150",
};

Student stu1 = new()
{
    FirstName = "Homer",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "2535899999",
    SchoolEmail = "Homer.Simpson@students,cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");