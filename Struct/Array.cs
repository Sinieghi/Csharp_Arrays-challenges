struct Array
{
    public int[] Arr { get; set; }
    public int Length { get; set; }
    public int Size { get; set; }

    public void FindMissingElements()
    {
        //Max()
        //Min()
        int max = 0;
        int min = 0;
        int i;
        for (i = 0; i < Length; i++)
        {
            if (max < Arr[i]) max = Arr[i];
            if (min > Arr[i]) min = Arr[i];
        }
        int[] hash = new int[max + 1];
        for (i = min; i < max; i++)
        {
            hash[Arr[i]]++;
        }
        for (i = min; i < max; i++)
        {
            if (hash[i] == 0) System.Console.WriteLine(i);
        }
    }

    public void FindDuplicatedUsingHash()
    {
        //work on this one as well, not finished.
        int i;
        int max = Max() + 1;
        int[] H = new int[max];
        for (i = 0; i < max; i++)
        {
            H[Arr[i]]++;
        }
        for (i = 0; i < max; i++)
        {
            // System.Console.Write("repeated ");
            // System.Console.Write(H[i]);
            // System.Console.WriteLine();
            if (H[i] > 0)
            {
                System.Console.Write(" position ");
                System.Console.Write(i);
                System.Console.Write(" element repeated ");
                System.Console.Write(H[i]);
                System.Console.WriteLine();
            }
        }

    }

    public void FindDuplicated()
    {
        int lastDuplicate = 0;
        int n = Length;
        int j;
        for (int i = 0; i < n - 1; i++)
        {
            if (Arr[i] == Arr[i + 1] && Arr[i] != lastDuplicate)
            {
                lastDuplicate = Arr[i];
                //lets count the num of repeated elements
                j = i + 1;
                // @@@@@@@@@@@@@@ have to fix @@@@@@@@@@@
                while (Arr[j] == Arr[i]) j++;
                i = j - 1;
                System.Console.WriteLine(j - i);
                //lets delete duplicates... 
                // DELETE(ref array, lastDuplicate);
                //for some reason the last index repeated was not deleted, have to check later...
            }
        }
    }
    public void FindDuplicatedUnsorted()
    {
        int n = Length;
        for (int i = 0; i < n - 1; i++)
        {
            int count = 1;
            if (Arr[i] != -1)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        count++;
                        Arr[j] = -1;
                    }
                }
                if (count > 1)
                {
                    System.Console.Write(" position ");
                    System.Console.Write(i);
                    System.Console.Write(" element repeated ");
                    System.Console.Write(Arr[i]);
                    System.Console.WriteLine();
                }
            }
        }
    }
    public void FindDuplicatedUnsortedHash()
    {
        int n = Length;
        int max = Max() + 1;
        int[] H = new int[max];

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (Arr[i] == Arr[j])
                    H[Arr[i]]++;

            }
        }
        for (int i = 0; i < max; i++)
        {
            // System.Console.Write(H[i]);

            if (H[i] > 0)
            {
                System.Console.Write(" element repeated ");
                System.Console.Write(i);
                System.Console.WriteLine();
            }
        }

    }

    public void FindKeyPairs()
    {
        int n = Length;
        int k = 12;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (Arr[i] + Arr[j] == k)
                {
                    System.Console.Write(Arr[i]);
                    System.Console.Write(" ");
                    System.Console.Write(Arr[j]);
                    System.Console.Write(" = ");
                    System.Console.WriteLine(k);
                }
            }
        }
    }
    public void FindKeyPairsHash()
    {
        int n = Length;
        int k = 12;
        int max = Max() + 1;
        int[] H = new int[max];
        for (int i = 0; i < n; i++)
        {
            if (k - Arr[i] >= 0 && H[k - Arr[i]] > 0)
            {
                System.Console.Write(k - Arr[i]);
                System.Console.Write(" + ");
                System.Console.Write(Arr[i]);
                System.Console.Write(" = ");
                System.Console.WriteLine(k);
            }
            H[Arr[i]]++;
        }
    }

    public void FindKeyPairsSorted()
    {
        int n = Length - 1;
        int i = 0, j = n, k = 12;
        while (i < j)
        {
            if (Arr[i] + Arr[j] == k)
            {
                System.Console.Write(k - Arr[i]);
                System.Console.Write(" + ");
                System.Console.Write(Arr[i]);
                System.Console.Write(" = ");
                System.Console.WriteLine(k);
                i++;
                j--;
            }
            else if (Arr[i] + Arr[j] < k)
                i++;
            else j--;
        }
    }


    public int Max()
    {
        int max = Arr[0];
        int i;
        for (i = 0; i < Length; i++)
        {
            if (max < Arr[i]) max = Arr[i];
        }
        return max;
    }

    public Tuple<int, int> FindMinMax()
    {
        //use A[0] normally because descendent list's witch is the best case comparison n - 1
        //ascended and unsorted comparison 2(n - 1)
        //but in the end is just O(n)
        int min = Arr[0], max = Arr[0];

        for (int i = 0; i < Length; i++)
        {
            if (Arr[i] < min) min = Arr[i];
            else if (Arr[i] > max) max = Arr[i];
        }

        return Tuple.Create(min, max);
    }

    public void Set(int index, int x)
    {
        if (index < 0 || index > Length) return;
        Arr[index] = x;
    }

}