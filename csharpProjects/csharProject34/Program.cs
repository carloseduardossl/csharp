string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

void DisplayStudents(string[] students)
{
    foreach (string nome in students)
    {
        Console.Write($"{nome}, ");
    }
}

DisplayStudents(new string[] { "Robert", "Vanya" });
DisplayStudents(students);