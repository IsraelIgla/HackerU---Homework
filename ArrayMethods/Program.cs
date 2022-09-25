using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Append");
            Print(Append(new int[] { 1, 2 }, 3));
            Print(Append(null, 3));
            Console.WriteLine("GetIndexes");
            Print(GetIndexes(new int[] {1,4,1,5,9,2},1));
            Print(GetIndexes(new int[] {1,4,1,5,9,2},3));
            Console.WriteLine("GetItemsAbove");
            Print(GetItemsAbove(new int[] {1,4,1,5,9,2},4));
            Print(GetItemsAbove(new int[] {1,4,1,5,9,2},31));
            Console.WriteLine("GetItemsExcept");
            Print(GetItemsExcept(new int[] {1,4,1,5,9,2},1));
            Console.WriteLine("GetAllContains");
            Print(GetAllContains(new int[] {11,4,15,5,1,29,2},1));
            Console.WriteLine("GetSorted");
            Print(GetSorted(new int[] {3,2,1}));
            Console.WriteLine("AreItemsSame");
            Console.WriteLine(AreItemsSame(new int[] {1,4,1}).ToString());
            Console.WriteLine(AreItemsSame(new int[] {4,4,4}).ToString());
         }

        static void Print(int[] arr)
        {
            if(arr == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[" + String.Join(",", arr) + "]");
        }

        static int[] Append(int[] arr, int i)
        {
            if(arr == null) return new int[] { i };
            int[] result = new int[arr.Length + 1];
            for(int j = 0; j < arr.Length; j++)
                result[j] = arr[j];
            result[arr.Length] = i;
            return result;
        }

        static int[] GetIndexes(int[] arr, int i)
        {
            if(arr == null) return null;

            int count = 0;
            int[] temp = new int[arr.Length];
            for(int j = 0; j < arr.Length; j++)
            {
                if(arr[j] == i)
                {
                    temp[count] = j;
                    count++;
                }
            }

            if(count == 0) return null;

            int[] result = new int[count];
            for(int j = 0; j < count; j++)
                result[j] = temp[j];

            return result;
        }

        static int[] GetItemsAbove(int[] arr, int i)
        {
            if(arr == null) return null;

            int count = 0;
            int[] temp = new int[arr.Length];
            for(int j = 0; j < arr.Length; j++)
            {
                if(arr[j] > i)
                {
                    temp[count] = arr[j];
                    count++;
                }
            }

            if(count == 0) return null;

            int[] result = new int[count];
            for(int j = 0; j < count; j++)
                result[j] = temp[j];

            return result;
        }

        static int[] GetItemsExcept(int[] arr, int i)
        {
            if(arr == null) return null;

            int count = 0;
            int[] temp = new int[arr.Length];
            for(int j=0; j<arr.Length; j++)
            {
                if(arr[j]==i)
                    continue;
                temp[count] = arr[j];
                count++;
            }

            int[] result = new int[count];
            for(int j = 0; j < count; j++)
                result[j] = temp[j];

            return result;
        }

        static int[] GetAllContains(int[] arr, int i)
        {
            if(arr == null) return null;

            int count = 0;
            int[] temp = new int[arr.Length];
            for(int j=0; j<arr.Length; j++)
            {
                if(arr[j].ToString().IndexOf(i.ToString()) == -1)
                    continue;
                temp[count] = arr[j];
                count++;
            }

            int[] result = new int[count];
            for(int j = 0; j < count; j++)
                result[j] = temp[j];

            return result;
        }

        static int[] GetSorted(int[] arr)
        {
            if(arr == null) return null;

            int[] result = new int[arr.Length];
            for(int i=0; i<arr.Length; i++)
                result[i] = arr[i];

            int temp;
            for(int i=1; i<result.Length; i++)
            {
                for(int j=i; j>0; j--)
                {
                    if(result[j] < result[j-1])
                    {
                        temp = result[j];
                        result[j] = result[j-1];
                        result[j-1] = temp;
                    }
                }
            }

            return result;
        }

        static bool AreItemsSame(int[] arr)
        {
            if(arr == null || arr.Length == 0) return true;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[0] != arr[i]) return false;
            }
            return true;
        }
    }
}
