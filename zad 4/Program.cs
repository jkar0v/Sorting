namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student ("Ана", 5.50),
                new Student ("Борис", 4.80),
                new Student ("Васил", 6.00),
                new Student ("Ивана", 5.50),
                new Student ("Галя", 5.00)
            };
            InsertionSort(students);
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} - {student.AverageMark:f2}");
            }
        }
        static void InsertionSort(Student[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                Student key = array[i];
                int j = i - 1;
                while (j >= 0 &&
                      (array[j].AverageMark > key.AverageMark ||
                      (array[j].AverageMark == key.AverageMark && array[j].Name.CompareTo(key.Name) > 0)))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }
    }
}
