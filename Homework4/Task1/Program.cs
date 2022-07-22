namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            1. 1) Считать целое число N из консоли
//2)Создать массив разменостью N
//3)Последовательно считать из консоли элементы массива
//4)Вычислить сумму элементов с нечетными номерами(индексами) и вывести эту сумму на экран
//5)Найти минимальный элемент в массиве и вывести его на экран.
//Для этой задачи используйте обычный массив
           
            Console.WriteLine("Введите целое число (длину массива)");
            int n = int.Parse(Console.ReadLine());
            
            int[] Array;
            Array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите {i} элемент массива");
                Array[i] = int.Parse(Console.ReadLine());

            }

            int Sum = 0;
            for (int i = 1; i < n; i=i+2)
            {
                Sum = Sum + Array[i];
            }

            Console.WriteLine("Сумма нечетных элементов равна");
            Console.WriteLine(Sum);

            int Min = Array[0];

            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] < Min)
                {
                    Min = Array[i];
                }

            }

             Console.WriteLine("Минимальный элемент массива");
             Console.WriteLine(Min);
             Console.ReadKey();
            


        }
    }
}