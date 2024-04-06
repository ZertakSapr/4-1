using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _4_1
{
    class OneDim<T>
        where T : IComparable<T>
    {
        private T[] array;

        private int capacity;

        private int size;

        public OneDim(int cap=7)
        {
            capacity = cap;

            array = new T[capacity];
            size = 0;
        }

        public void Print()
        {
            Console.WriteLine("Вывод массива");
            string answ = null;
            for (int i=0; i<size; i++)
            {
                answ += array[i] + " ";
            }
            Console.WriteLine(answ);

        }

        public void Add(T it)
        {
            if (size >= capacity)
            {
                capacity = capacity * 2 + 1;
                Array.Resize(ref array, capacity);
            }
            array[size] = it;
            size++;
        }

        public void Remove(T el)
        {
            size--;
            int ind = FindInd(el);
            if (ind != -1)
            {
                Array.Copy(array, ind + 1, array, ind, size - 1);
            }

        }

        public int FindInd(T el)
        {
            int ans = -1;
            for (int i = 0; i < size; i++)
            {
                if (array[i].Equals(el))
                {
                    ans = i;
                }
            }
            return ans;
        }

        public int AmountCond(Func<T,bool> cond)
        {
            if (cond == null)
            {
                throw new Exception("Нет условия");
            }
            int amount = 0;
            for (int i=0; i < size; i++)
            {
                if (cond(array[i]))
                {
                    amount++;
                }
            }
            return amount;
        }

        public bool CheckEl(Func<T, bool> cond)
        {
            if (cond == null)
            {
                throw new Exception("Нет условия");
            }
            bool ans = false;
            for (int i = 0; i < size; i++)
            {
                if (cond(array[i]))
                {
                    ans = true;
                }
            }
            return ans;
        }
        
        public int Size()
        {
            return size;
        }

        public bool Check(Func<T, bool> cond)
        {
            if (cond == null)
            {
                throw new Exception("Нет условия");
            }
            bool ans = true;
            for (int i = 0; i < size; i++)
            {
                if (!cond(array[i]))
                {
                    ans = false;
                }
            }
            return ans;
        }

        public T FindEl(Func<T, bool> cond)
        {
            if (cond == null)
            {
                throw new Exception("Нет условия");
            }
            for (int i = 0; i < size; i++)
            {
                if (cond(array[i]))
                {
                    return array[i];
                }
            }
            throw new Exception("Нет элементов под такое условие");
        }

        public void ActToAll(Action<T> act)
        {
            if (act == null)
            {
                throw new Exception("Нет условия");
            }
            for (int i = 0; i < size; i++)
            {
                act(array[i]);
            }
        }

        public T[] FindArrayEl(Func<T, bool> cond)
        {
            T[] result = new T[size];
            int cou = 0;
            if (cond == null)
            {
                throw new Exception("Нет условия");
            }
            for (int i = 0; i < size; i++)
            {
                if (cond(array[i]))
                {
                    result[cou] = array[i];
                    cou++;
                }
            }
            if (result[0] == null)
            {
                throw new Exception("Нет элементов под такое условие");
            }
            return result;
        }
        
        public void Reverse()
        {
            T[] result = new T[size];
            int cou = 0;
            for (int i = size-1; i>=0; i--)
            {
                result[cou] = array[i];
                cou++;
            }

            array = result;
        }
         
        public T[] GetFromInd(int index, int amount)
        {
            if (index>size||amount>(size-index))
            {
                throw new Exception("За пределы массива");
            }
            T[] result = new T[size];
            int cou = 0;
            for(int i=index; i < index + amount; i++)
            {
                result[cou] = result[i];
                cou++;
            }
            return result;
        }

        public T Max()
        {

            T max = array[0];

            for (int i = 1; i < size; i++)
            {
                if (max.CompareTo(array[i]) < 0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public T Min()
        {

            T min = array[0];

            for (int i = 1; i < size; i++)
            {
                if (min.CompareTo(array[i]) > 0)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public void Sort()
        {
            T[] result = array[0..size];
            Array.Sort(result);
            array = result;
        }
    }
}
