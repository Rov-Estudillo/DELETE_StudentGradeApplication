internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Define subjects
        string[] subjects = { "English", "Math", "Science", "Filipino", "History" };
        double totalGrades = 0;
        int subjectCount = subjects.Length;

        Console.WriteLine("Grades");

        // Loop to input grades for each subject
        for (int i = 0; i < subjectCount; i++)
        {
            double grade;
            while (true)
            {
                Console.Write($" {subjects[i]}: ");
                if (double.TryParse(Console.ReadLine(), out grade))
                {
                    totalGrades += grade;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }

        // Calculate average
        double average = totalGrades / subjectCount;

        // Determine pass/fail status
        string status = average >= 75 ? "passed" : "failed";

        // Output results
        Console.WriteLine($"\nThe student {status}.");
        Console.WriteLine($"The general average of {name} is {average:F2}.");
    }
}