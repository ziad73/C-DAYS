namespace app
{
    public class Stack
    {
        int[] stack;
        int maxSize;
        int top;

        public Stack(int MSize = 4)
        {
            maxSize = MSize;
            stack = new int[maxSize];
            top = 0;
        }
        public bool isEmpty() => top == 0;
        public bool isFull() => top == maxSize;
        public void insertBack(int num)
        {
            if (isFull()) { Console.WriteLine("Stck is Full"); return; }
            stack[top] = num;
            top++;
        }
        public void pop()
        {
            if (isEmpty()) { Console.WriteLine("Stack is Empty"); return; }
            top--;
        }
        public int peek()
        {
            if (isEmpty()) { throw new Exception("Stack is Empty"); }

            return stack[top - 1];
        }
    }

}
