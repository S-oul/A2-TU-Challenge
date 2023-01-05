using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool IsMajeur(int age)
        {
            if (age < 18)
            {
                if (age <= -1) { throw new ArgumentException(); }
                return false;
            }
            else
            {
                if (age >= 141) { throw new ArgumentException(); }
                return true;
            }
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static bool IsDivisible(int a,int b)
        {
            if(a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrimary(int a)
        {
            if (a == 2 || a == 3) return true;
            if (a <= 1 || a % 2 == 0 || a % 3 == 0) return false;

            for (int i = 5; i * i <= a; i += 6)
            {
                if (a % i == 0 || a % (i + 2) == 0) return false;
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> list = new List<int>();
            for(int i = 0; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            if (b == 0) { return 1; }
            int c = a;
            for(int i = 1; i < b; i++)
            {
                c *= a;
            }
            return c;
        }

        public static int IsInOrder(int a, int b)
        {
            if(a == b) { return 0; }
            else if (a < b) { return 1; }
            else {return -1; }
        }

        public static bool IsListInOrder(List<int> list)
        {
            for(int i = 0; i < list.Count-1; i++)
            {
                if(IsInOrder(list[i], list[i + 1]) == -1 )
                {
                    return false;
                }
            }
            return true;
        }

        public static object Sort(List<int> toSort)
        {
            for (int i = 0; i < toSort.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < toSort.Count; j++)
                {
                    if (toSort[j] < toSort[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = toSort[i];
                toSort[i] = toSort[minIndex];
                toSort[minIndex] = temp;
            }
            return toSort;
        }

        public static object GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }
    }
}
