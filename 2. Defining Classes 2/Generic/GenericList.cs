using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class GenericList<T>
        where T : new()
    {
        private T[] elements;
        private int size;
        private int endInd = 0;
        private int elementCount = 0;

        public GenericList(int size)
        {
            this.elements = new T[size];
            this.size = size;
        }

        public void AddElement(T element)
        {
            if (this.endInd < this.elements.Length - 1)
            {
                this.elements[this.endInd] = element;
                this.endInd++;
                this.elementCount++;
            }
            else
            {
                T[] newElements = new T[2 * this.elements.Length];
                for (int i = 0; i < this.elements.Length; i++)
                {
                    newElements[i] = this.elements[i];
                }
                newElements[this.endInd] = element;
                this.elements = newElements;
                this.endInd++;
                this.elementCount++;
                this.size = this.elements.Length;
            }
        }

        public T ElementAt(int index)
        {
            if (index >= 0 && index < this.elements.Length)
            {
                return this.elements[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < this.elements.Length)
            {
                T[] newElements = new T[this.elements.Length];
                this.elementCount = 0;
                for (int i = 0; i < this.elements.Length; i++)
                {
                    if (i != index && !newElements[i].Equals(this.elements[i]))
                    {
                        newElements[i] = this.elements[i];
                        elementCount++;
                    }
                }
                this.elements = newElements;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void InsertAt(T element, int index)
        {
            if (index >= 0 && index < this.elements.Length)
            {
                T[] newElements;

                if (this.elements[this.elements.Length - 1].Equals(new T()))
                {
                    newElements = new T[this.elements.Length];
                }
                else
                {
                    newElements = new T[2 * this.elements.Length];
                    this.size = newElements.Length;
                }

                for (int i = 0; i < newElements.Length; i++)
                {
                    if (!newElements[i].Equals(this.elements[i]) && i < this.elements.Length)
                    {
                        if (i < index)
                        {
                            newElements[i] = this.elements[i];
                        }
                        else if (i == index)
                        {
                            newElements[i] = element;
                        }
                        else
                        {
                            newElements[i] = this.elements[i - 1];
                        }
                    }
                }
                
                this.endInd++;
                this.elements = newElements;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Clear()
        {
            this.elements = new T[this.elements.Length];
        }

        public int Find(T value)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public T Min<T>() where T: IComparable
        {
            dynamic min = this.elements[0];

            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i] < min)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max<T>() where T : IComparable
        {
            dynamic max = this.elements[0];

            for (int i = 1; i < this.elements.Length; i++)
            {
                if (this.elements[i] > max)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.elements.Length; i++)
            {
                result.Append(this.elements[i]);
                if (i != this.elements.Length - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }
    }
}
