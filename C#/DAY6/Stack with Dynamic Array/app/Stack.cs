namespace app
{
    public class Stack<T>
    {
        T[] stack;
        int maxSize;
        int top;

        public Stack(int MSize = 4)
        {
            maxSize = MSize;
            stack = new T[maxSize];
            top = 0;
        }
        public bool isEmpty() => top == 0;
        public bool isFull() => top == maxSize;
        public void push(T value)
        {
            if (isFull()) { Console.WriteLine("Stck is Full"); return; }
            stack[top] = value;
            top++;
        }
        public T pop()
        {
            if (isEmpty()) { throw new Exception("Stack is Empty"); }
            top--;
            return stack[top];
        }
        public T peek()
        {
            if (isEmpty()) { throw new Exception("Stack is Empty"); }

            return stack[top - 1];
        }
    }

}
