using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BitArray64Task
{
    public class BitArray : IEnumerable<int>
    {
        public ulong BitArray64 { get; set; }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                return (BitArray64 & ((ulong)1 << index)) != 0 ? 1 : 0;
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException();
                }


                if (value == 1)
                {
                    this.BitArray64 = this.BitArray64 | ((ulong)1 << index);
                }
                else
                {
                    this.BitArray64 = this.BitArray64 & (~((ulong)1 << index));
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BitArray64Enumerator(BitArray64);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            BitArray arr = obj as BitArray;
            if ((object)arr == null)
            {
                return false;
            }

            return this.BitArray64 == arr.BitArray64;
        }

        public override int GetHashCode()
        {
            return this.BitArray64.GetHashCode();
        }

        public static bool operator ==(BitArray first, BitArray second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return !(first == second);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                sb.AppendFormat("[{0}] = {1} \n", i, this[i]);
            }
            return sb.ToString();
        }

        private class BitArray64Enumerator : IEnumerator
        {
            private int index = -1;
            private ulong bits;

            public BitArray64Enumerator(ulong bits)
            {
                this.bits = bits;
            }

            public object Current
            {
                get
                {
                    return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
                }
            }

            public bool MoveNext()
            {
                index++;
                return (index < 64);
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}