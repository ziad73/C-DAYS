namespace app
{
    public class Program
    {
        static void Main(string[] args)
        {

            Stack<int> s = new Stack<int>(4);
            s.push(1);
            s.push(2);
            s.push(3);
            s.push(4);
            s.pop();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(s.pop());
            }

            //DArray<int> arr = new DArray<int>(4);
            //arr.insertBack(1);
            //arr.insertBack(2);
            //arr.insertBack(3);
            //arr.insertBack(4);
            //arr.insertBack(5);
            //arr.removeBack();
            //arr.print();
            //Console.WriteLine($"\nAverage: {arr.average()}, Count: {arr.Count()}");


        }
    }

}
