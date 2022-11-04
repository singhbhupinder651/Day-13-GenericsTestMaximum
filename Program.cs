namespace FindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {

            FindMax findMax = new FindMax();

            //maximum integer
            int result = findMax.FindMaxAll(15, 100, 5);
            Console.WriteLine("\nGreatest number among three numbers is : " + result);

            //maximum float
            float result1 = findMax.FindMaxAll(322.3f, 433.7f, 683.2f);
            Console.WriteLine("\nGreatest number among three Float Numbers is : " + result1);

            //find maximum string
            string result3 = findMax.FindMaxAll("Apple", "Banana", "Peach");
            Console.WriteLine("\nGreatest string among three is : " + result3);
        }
    }
}