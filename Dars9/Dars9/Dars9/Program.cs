namespace Dars9;

internal class Program
{

    static void Main(string[] args)
    {

            List<int> nums = new List<int>();

            Console.Write("List lengthini kiriting: ");

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("List elementini kiriting: ");

                nums.Add(int.Parse(Console.ReadLine()));
            }

            var sum = 0;


            for (int i = 0; i < n; i++)
            {

                sum += nums[i];
            }

            return sum;

    }

}
