using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class DynamicArrayHardcoreMode<T> : DynamicArray<T>, ICloneable
    {
        #region ctor
        public DynamicArrayHardcoreMode() { }

        public DynamicArrayHardcoreMode(int n) : base(n) { }

        public DynamicArrayHardcoreMode(IEnumerable<T> mas, int length) : base(mas, length) { }

        public new T this[int index]
        {
            get
            {
                if (index >= 0)
                {
                    return base[index];
                }
                else if (index >= -Length)
                {
                    return base[Length + index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0)
                {
                    base[index] = value;
                }
                else if (index >= -Length)
                {
                    base[Length + index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        #endregion

        #region methods
        public object Clone()
        {
            var temp = new DynamicArrayHardcoreMode<T>(Capacity);
            temp.AddRange(Array, Length);
            temp.Length = Length;
            return temp;
        }

        public void NewCapacity(int capacity)
        {
            //if (capacity < 0)
            //{
            //    throw new ArgumentException("Wrong capacity");
            //}
            T[] newArray = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                newArray[i] = Array[i];
            }
            Array = newArray;
        }

        public T[] ToArray()
        {
            var res = new T[Length];
            for (int i = 0; i < Length; i++)
            {
                res [i] = Array[i];
            }
            return res;
        }
        #endregion

        #region show
        public static void ShowHM()
        {
            var mas = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 9; i++)
            {
                mas.Add(r.Next(100));
            }
            Console.WriteLine("Dynamic Array Hardcore Mode:");
            var res = new DynamicArrayHardcoreMode<int>(mas, mas.Count);

            Console.WriteLine($"Length: {res.Length}\nCapacity: {res.Capacity}");
            Console.WriteLine("New Array:");
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Last element");
            Console.WriteLine(res[-1]);

            //res.NewCapacity(12); 
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion
    }
}
