using HackerRankTasks.ProblemSolving;

namespace HackerRankTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
#nullable disable

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.GradingStudents(grades);

            Console.WriteLine(String.Join("\n", result));

#nullable enable
        }
    }
}
