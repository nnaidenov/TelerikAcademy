using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        //Fields
        private T[] array;
        private int capacity = 30;
        private int index = 0;
        //End Fields

        //Indexer
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < capacity)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Out Of Range!");
                }
            }

            set
            {
                if (index >= 0 && index < this.capacity)
                {
                    this.array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index Out Of Range!");
                }
            }
        }
        //End Indexer

        //Constuctor
        public GenericList(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity];
        }

        //Methods
        public void AddElement(T element)
        {
            if (index >= capacity)
            {
                autoGrow(capacity);
            }
            this.array[index] = element;
            index++;
        }

        public void removeElement(int possition)
        {
            if (index <= 0 && index > this.capacity)
            {
                throw new IndexOutOfRangeException("Index Out Of Range!");
            }
            else
            {
                T[] tempArr = new T[capacity - 1];
                index = 0;
                for (int i = 0; i < possition; i++)
                {
                    tempArr[i] = array[i];
                    index++;
                }
                for (int i = possition; i < array.Length - 1; i++)
                {
                    tempArr[i] = array[i + 1];
                    index++;
                }
                clearElements();
                for (int i = 0; i < tempArr.Length; i++)
                {
                    array[i] = tempArr[i];
                }
            }
        }

        public T accessElement(int possition)
        {
            if (index <= 0 && index > this.capacity)
            {
                throw new IndexOutOfRangeException("Index Out Of Range!");
            }
            else
            {
                return array[possition];
            }

        }

        public void clearElements()
        {
            Array.Clear(array, 0, capacity);
        }

        public void insertElement(T element, int position)
        {
            if (index <= 0 && index > this.capacity)
            {
                throw new IndexOutOfRangeException("Index Out Of Range!");
            }
            else
            {
                index = 0;
                if (position >= capacity)
                {
                    autoGrow(capacity);
                }
                T[] tempArr = new T[capacity];

                for (int i = 0; i < position; i++)
                {
                    tempArr[i] = array[i];
                    index++;
                }
                tempArr[index] = element;
                index++;

                for (int i = index; i < array.Length; i++)
                {
                    tempArr[i] = array[i - 1];

                }

                for (int i = 0; i < tempArr.Length; i++)
                {
                    array[i] = tempArr[i];
                }
            }
        }

        public int findElement(T element)
        {
            int index = Array.IndexOf(array, element);
            return index;
        }

        public void autoGrow(int capacity)
        {
            capacity *= 2;
            T[] tempArray = new T[this.capacity];
            Array.Copy(this.array, tempArray, this.index);
            this.array = tempArray;
        }

        public T Max<T>()
        {
            dynamic maxValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (maxValue <= array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        public T Min<T>()
        {
            dynamic minValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (minValue >= array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }

        //Override ToString()
        public override string ToString()
        {
            return String.Format("index({0}) -> {1}", index, array[index]);
        }
    }
}