namespace app
{
    public class DArray
    {
        int[] array;
        int maxSize;
        int count;
        private void resize(int newSize)
        {
            int[] temp = new int[newSize];
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
            array = new int[mSize];
        }

        public void insertBack(int num)
        {
            if (isFull())
            {
                Console.WriteLine($"Array is full, Resizing...Now size: {maxSize * 2}");
                resize(maxSize * 2);
            }
            array[count] = num;
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
                sum += array[i];
            }
            return (double) sum / (double) count;
        }
    }

}
