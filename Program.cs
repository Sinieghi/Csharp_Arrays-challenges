class Program
{
    static void Main(string[] args)
    {

        Array array = new() { Arr = new int[20], Length = 20, Size = 20 };
        for (int i = 0; i < array.Length; i++)
        {
            array.Arr[i] = i;
        }
        // array.Set(2, 15);
        // array.Set(11, 15);
        array.FindKeyPairsHash();
        System.Console.WriteLine("sorted");
        array.FindKeyPairsSorted();
        // array.Set(11, 35);
        System.Console.WriteLine(array.FindMinMax());

    }
}