namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {

            FindMax findMax = new FindMax();

            //maximum integer
            int result = findMax.FindMaxInteger(150, 100, 5);
            Console.WriteLine("Greatest number among three numbers is : " + result);

            //maximum float
            float result1 = findMax.FindMaxFloat(322.3f, 433.7f, 683.2f);
            Console.WriteLine("\nGreatest number among three Float Numbers is : " + result1);

            //find maximum string
            string result3 = findMax.FindMaxString("Apple", "Peach", "Banana");
            Console.WriteLine("\nGreatest string among three is : " + result3);
        }
    }
}