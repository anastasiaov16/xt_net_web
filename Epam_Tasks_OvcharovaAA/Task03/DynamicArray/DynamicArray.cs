using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private const int startCapacity = 8;

        public static T[] Array { get; set; }

        public int Capacity { get; set; }

        public  int Length { get; set; }

        public DynamicArray()
        {
            Array = new T[startCapacity];
            Length = 0;
            Capacity = startCapacity;
        }

        public DynamicArray(int capacity)
        {
            Array = new T[capacity];
            Length = 0;
            Capacity = capacity;
        }

        public DynamicArray(IEnumerable<T> mas, int len)
        {
            Capacity = 2 * len;
            Length = 0;
            Array = new T[this.Capacity];
            foreach (var item in mas)
            {
                Add(item);
            }
        }

        public void Add(T item)
        {
            if (Capacity == Length)
            {
                ChangeCapacity();
            }
            else
            {
                Array[Length] = item;
                Length++;
            }
        }

        public void ChangeCapacity()
        {
            var tmp = Array;
            Capacity *= 2;
            Length = 0;
            Array = new T[Capacity];
            foreach (var it in tmp)
            {
                Array[Length] = it;
                Length++;
            }
        }

        public void ChangeCapacity(int len)
        {
            var tmp = Array;
            Capacity = len;
            Length = 0;
            Array = new T[Capacity];
            foreach (var it in tmp)
            {
                Array[Length] = it;
                Length++;
            }
        }

        public void AddRange(IEnumerable<T> mas, int len)
        {
            int newLength = len + Length;
            if (newLength > Capacity)
            {
                ChangeCapacity(newLength);
            }
            foreach (var item in mas)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            int searchIndex = -1;
            for (int i = 0; i < Length; i++)
            {
                if (Array[i].Equals(item))
                {
                    searchIndex = i;
                    break;
                }
            }
            if (searchIndex == -1)
            {
                return false;
            }

            else
            {
                for (int i = searchIndex; i < Length; i++)
                {
                    Array[i] = Array[i + 1];
                }
                Length--;
            }
            return true;
        }

        public bool Insert(int index, T item)
        {
            if (!CheckIdx(index))
            {
                throw new ArgumentOutOfRangeException("Wrong index!");
            }

            int fullLenght = Length + 1;

            if (fullLenght > Capacity)
            {
                ChangeCapacity();
            }

            for (var i = Length - 1; i >= index; i--)
            {
                Array[i + 1] = Array[i];
            }

            Array[index] = item;
            Length++;
            return true;
        }

        public bool CheckIdx(int index)
        {
            if (index >= Length || index < 0)
            {
                return false;
            }
            return true;
        }

        public T this[int index]
        {
            get
            {
                if (!CheckIdx(index))
                {
                    throw new ArgumentOutOfRangeException("Wrong index!");
                }  
                else
                return Array[index];
            }
            set
            {
                if (!CheckIdx(index))
                {
                    throw new ArgumentOutOfRangeException("Wrong index!");
                }
                else
                Array[index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Length; i++)
            {
                yield return Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public static void Show()
        {
            var mas = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                mas.Add(i);
            }

            var res = new DynamicArray<int>(mas, mas.Count);

            Console.WriteLine($"Length: {res.Length}\nCapacity: {res.Capacity}");
            Console.WriteLine("New Array:");
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            Console.WriteLine("Insert 3 in position 5");
            res.Insert(5, 3);
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("Remove element in position 0");
            res.Remove(0);
            foreach (var item in res)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
