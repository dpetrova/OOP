using System;
using System.Text;

namespace GenericList
{
    using System.Linq;

    [Version(1, 2)]
    public class GenericList<T> where T : IComparable<T>
    {
        public const int DefaultCapacity = 16;

        private int index;
        private T[] array;
        private int currentCapacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.index = 0;
            this.CurrentCapacity = capacity;
        }

        public int CurrentCapacity
        {
            get { return this.currentCapacity; }
            set { this.currentCapacity = value; }
        }


        //Methods:
        private void Resize()
        {
            int newCapacity = this.CurrentCapacity * 2;
            T[] extendedArr = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                extendedArr[i] = this.array[i];
            }
            this.array = extendedArr;
            this.CurrentCapacity = newCapacity;
        }


        public void Add(T element)
        {
            if (this.index >= this.CurrentCapacity)
            {
                this.Resize();
            }
            this.array[this.index] = element;
            this.index++;
        }

        
        public void RemoveAt(int index)
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (index > this.array.Length - 1)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative!");
            }
            T[] tempArr = new T[this.array.Length - 1];
            for (int i = 0, pos = 0; i < this.array.Length; i++, pos++)
            {
                if (i == index)
                {
                    pos--;
                }
                else
                {
                    tempArr[pos] = this.array[i];
                }
            }
            this.array = tempArr;
            this.index--;
        }


        public T AccessAt(int index)
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            if (index > this.array.Length - 1)
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative!");
            }
            return this.array[index];
        }


        public void InsertAt(T element, int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative!");
            }
            if (index >= this.CurrentCapacity)
            {
                Resize();
            }
            T[] tempArr = new T[this.array.Length + 1];
            for (int i = 0, pos = 0; i < tempArr.Length - 1; i++, pos++)
            {
                if (pos == index)
                {
                    tempArr[pos] = element;
                    i--;
                }
                else
                {
                    tempArr[pos] = this.array[i];
                }
            }
            this.array = tempArr;
            if (index > this.index)
            {
                this.index += index - this.index + 1;
            }
            else
            {
                this.index ++;
            }
        }


        public void Clear()
        {
            this.array = new T[DefaultCapacity];
            this.index = 0;
        }


        public int Find(T element)
        {
            return Array.IndexOf(this.array, element);
            //for (int i = 0; i < this.index; i++)
            //{
            //    if (this.array[i].Equals(element))
            //    {
            //        return i;
            //    }
            //}
            //return -1;
        }


        public bool Contain(T element)
        {
            return this.Find(element) >= 0;
            //for (int i = 0; i < this.index; i++)
            //{
            //    if (this.array[i].Equals(element))
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        
        public T Min()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T min = this.array[0];
            foreach (var element in this.array)
            {
                if (element.CompareTo(min) < 0)
                {
                    min = element;
                }
            }
            return min;
        }


        public T Max()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T max = this.array[0];
            foreach (var element in this.array)
            {
                if (element.CompareTo(max) > 0)
                {
                    max = element;
                }
            }
            return max;
        }

        public override string ToString()
        {
            T[] tempArr = this.array.Take(this.index).ToArray();
            return String.Join(", ", tempArr);
        }
    }
}
