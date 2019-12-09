using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class DynamicArrayHardcoreMode<T> : DynamicArray<T>, ICloneable
    {
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
                return base[Length + index];
            }
            set
            {
                if (index >= 0)
                {
                    base[index] = value;
                }
                base[Length + index] = value;
            }
        }

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
    }
}
