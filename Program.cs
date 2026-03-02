namespace Week7Assignment7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers you want to sort: ");
            string userinput = (Console.ReadLine());
            List<int> nums = new List<int>();
            foreach( string num in userinput.Split(' '))
            {
                nums.Add(int.Parse(num));
               
            }
            int[] unsorted = nums.ToArray();
            Divide(unsorted,0,unsorted.Length-1);
            Console.WriteLine(string.Join(" ", unsorted));
        }

       
        public static void Divide(int[]arr, int l, int r)
        {
            if (l<r)
            {
                int m = (l+r) / 2;
                Divide(arr, l, m);
                Divide(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
            
        }
        public static void Merge(int[] arr, int l, int m, int r)
        {
            int i = l;
            int j = m + 1;
            int[] temp = new int[r+1];

            int k = l; //index for merged array
            while ( i<=m && j<=r)
            {
                if(arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }
            while(i<=m)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }
            while(j<=r)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }
            for (int x = l; x <= r; x++)
            {
                arr[x] = temp[x];
            }


        }
    }
}
