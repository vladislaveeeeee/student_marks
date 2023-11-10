using System;

class Student
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Group { get; set; }
    public DateTime DateOfBirth { get; set; }

    
    private int[] grades = new int[3];

    
    public Student(string firstName, string lastName, string group, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        DateOfBirth = dateOfBirth;
    }

    
    public void SetGrade(int subjectIndex, int grade)
    {
        if (subjectIndex >= 0 && subjectIndex < 3)
        {
            grades[subjectIndex] = grade;
        }
    }

    
    public int GetGrade(int subjectIndex)
    {
        if (subjectIndex >= 0 && subjectIndex < 3)
        {
            return grades[subjectIndex];
        }
        return -1; 
    }

   
    public double CalculateAverageGrade()
    {
        double sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return sum / 3;
    }

  
    public void PrintStudentInfo()
    {
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Група: {Group}");
        Console.WriteLine($"Дата народження: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Оцінки з предметів:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Предмет {i + 1}: {grades[i]}");
        }
        Console.WriteLine($"Середній бал: {CalculateAverageGrade()}");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Влад", "Рошко", "Група 214", new DateTime(2007, 8, 03));
        student.SetGrade(0, 8);
        student.SetGrade(1, 11);
        student.SetGrade(2, 9);

        student.PrintStudentInfo();
    }
}