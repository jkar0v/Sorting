namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {   new Student("Angel", 17),
                new Student("Yoana", 18),
                new Student("Sofia", 16),
                new Student("Jivko", 18),
            };
            BubbleSort(students);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        static void BubbleSort(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = 0; j < students.Length - i - 1; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                }
            }
        }
    }
}
