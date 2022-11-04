namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
                        
            //maximum integer
            FindMax<int> obj = new FindMax<int>(22, 54, 62, 87, 32);
            int result = obj.Maxmethod();
            Console.WriteLine("Greatest number among three numbers is :  " + result);

            //maximum float
            FindMax<float> objf = new FindMax<float>(22.6f, 22.8f, 22.6f, 65.6f, 65.9f);
            float resultf = objf.Maxmethod();
            Console.WriteLine("Greatest number among three float number is :  " + resultf);

            //find maximum string
            FindMax<string> objs = new FindMax<string>("Apple", "Peach", "Banana", "Mango", "Stewberry");
            string results = objs.Maxmethod();
            Console.WriteLine("Greatest string among three string is :  " + results);

        }
    }
}