namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {     
            //maximum integer
            FindMax<int> obj = new FindMax<int>(22, 54, 62, 87, 32);
            obj.PrintMaxValue();

            //maximum float
            FindMax<float> objf = new FindMax<float>(22.6f, 122.8f, 22.6f, 65.6f, 65.9f);
            objf.PrintMaxValue();

            //find maximum string
            FindMax<string> objs = new FindMax<string>("zApple", "Peach", "Banana", "Mango", "Stewberry");
            objs.PrintMaxValue();

        }
    }
}