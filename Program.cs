
    public class StudentGrades
    {
        public string Name { get; }
        public int[] Grades { get; }

        public StudentGrades(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public double GetAverageGrade()
        {
            return Grades.Length > 0 ? Grades.Average() : 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            StudentGrades[] students = new StudentGrades[]
            {
            new StudentGrades("Анна", new int[] {85, 90, 95}),
            new StudentGrades("Денис", new int[] {75, 80, 85}),
            new StudentGrades("Влад", new int[] {90, 95, 100}),
            new StudentGrades("Настя", new int[] {70, 75, 80})
            };

            StudentGrades studentWithMaxAverageGrade = students.OrderByDescending(s => s.GetAverageGrade()).FirstOrDefault();

            if (studentWithMaxAverageGrade != null)
            {
                Console.WriteLine($"Студент з максимальною середньою оцінкою: {studentWithMaxAverageGrade.Name}");
                Console.WriteLine($"Середня оцінка: {studentWithMaxAverageGrade.GetAverageGrade()}");
            }
            else
            {
                Console.WriteLine("Не вдалося знайти студента.");
            }
        }
    }

