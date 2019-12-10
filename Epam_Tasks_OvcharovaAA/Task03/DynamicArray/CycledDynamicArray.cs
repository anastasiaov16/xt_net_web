using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class CycledDynamicArray<T> : DynamicArray<T>, IEnumerable<T>, IEnumerator<T>
    {
        private int pos = 0;
        #region ctor
        public CycledDynamicArray() : base() { }

        public CycledDynamicArray(int n) : base(n) { }

        public CycledDynamicArray(IEnumerable<T> mas, int length) : base(mas, length){}

        #endregion

        #region methods
        public new IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return base.GetEnumerator();
        }

        public T Current
        {
            get
            {
                try
                {
                    return Array[pos];
                }
                catch
                {
                    throw new InvalidOperationException();
                }
            }
            
        }

        object IEnumerator.Current => Current;

        public void Dispose(){}

        public bool MoveNext()
        {
            if (pos < Length - 1)
                pos++;
            else
                Reset();

            return true;
        }

        public void Reset()
        {
            pos = 0;
        }
        #endregion
    }

}
