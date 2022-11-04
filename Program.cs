namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {

            //maximum integer
            FindMax<int> obj = new FindMax<int>(22, 54, 62);
            int result = obj.FindMaxShow();
            Console.WriteLine("Greatest number among three numbers is :  " + result);

            //maximum float
            FindMax<float> objf = new FindMax<float>(22.6f, 22.8f, 22.6f);
            float resultf = objf.FindMaxShow();
            Console.WriteLine("Greatest number among three float number is :  " + resultf);

            //find maximum string
            FindMax<string> objs = new FindMax<string>("Apple", "Peach", "Banana");
            string results = objs.FindMaxShow();
            Console.WriteLine("Greatest string among three string is :  " + results);

        }
    }
}