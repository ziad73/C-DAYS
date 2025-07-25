﻿namespace app
{
    public class DArray<T>
    {
        T[] array;
        int maxSize;
        int count;
        private void resize(int newSize)
        {
            T[] temp = new T[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            array = temp;
        }

        public bool isEmpty() => count == 0;
        public bool isFull() => count == maxSize;
        public int Count() => count;
        public DArray(int mSize = 10)
        {
            maxSize = mSize;
            count = 0;
            array = new T[mSize];
        }

        public void insertBack(T value)
        {
            if (isFull())
            {
                Console.WriteLine($"Array is full, Resizing...Now size: {maxSize * 2}");
                resize(maxSize * 2);
            }
            array[count] = value;
            count++;
        }

        public void removeBack()
        {
            if (isEmpty())
            {
                Console.WriteLine("Array is Empty");
                return;
            }
            count--;
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public double average()
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += (dynamic) array[i];
            }
            return (double) sum / (double) count;
        }
    }

}
