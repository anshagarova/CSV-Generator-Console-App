using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "mock_data.csv";

        int numRows = 7000;

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Write header row
            writer.WriteLine("Email, Name, Surname, Department, Role, Authorization");

            // Generate and write data for each row
            Random random = new Random();
            for (int i = 0; i < numRows; i++)
            {
                string email = $"user{i}@example.com";
                string name = "Name" + i;
                string surname = "Surname" + i;
                string department = "Dep1";
                string role = "Clinical Nurse (direct care)";
                string auth = "none";

                // Write the data to the file
                writer.WriteLine($"{email}, {name}, {surname}, {department}, {role}, {auth}");
            }
        }

        Console.WriteLine("CSV file generated successfully.");
    }
}

