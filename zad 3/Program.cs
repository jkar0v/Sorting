using static System.Reflection.Metadata.BlobBuilder;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new Worker("Jan", 2000),
                new Worker("Krzysztof", 3500),
                new Worker("Anna", 1999),
                new Worker("Zbigniew", 2500),
                new Worker("Marek", 4000)
            };
            MergeSort(workers, 0, workers.Length - 1);
            foreach (var book in workers)
            {
                Console.WriteLine(book);
            }
        }
        static void MergeSort(Worker[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(Worker[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            Worker[] leftArray = new Worker[n1];
            Worker[] rightArray = new Worker[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int i1 = 0, i2 = 0, k = left;
            while (i1 < n1 && i2 < n2)
            {
                if (leftArray[i1].Salary <= rightArray[i2].Salary)
                    arr[k++] = leftArray[i1++];
                else
                    arr[k++] = rightArray[i2++];
            }
            while (i1 < n1) arr[k++] = leftArray[i1++];
            while (i2 < n2) arr[k++] = rightArray[i2++];
        }
    }
}
