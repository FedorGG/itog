class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] originalArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку: ");
            originalArray[i] = Console.ReadLine();
        }
         string[] newArray = FilterArray(originalArray);

        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
        
    }

   