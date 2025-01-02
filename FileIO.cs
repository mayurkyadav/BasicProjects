using System;

public class FileIO
{/// <summary>
/// this class is responisble for the file io operations
/// </summary>
	public FileIO()
	{
	}
    public static void AddNoteToFile(string username, string password, string problems, DateTime date, string noteContent, ListBox listBoxName)
    {

        
        string filePath = "appointments.txt";

            // Get vitals from the list box
            string vitals = string.Join(";", listBoxName.Items.Cast<string>());

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Write the appointment details to the file
                writer.WriteLine($"{username}|{password}|{problems}|{date.ToString("yyyy-MM-dd")}|{vitals}|{noteContent}");
                // Write an empty line to separate entries
                writer.WriteLine();
            }

            // Add the appointment to the list box
            listBoxName.Items.Add($"{username}");
        
    }

    private static bool IsAlphabetic(string input)
    {
        return input.All(char.IsLetter);
    }
}

