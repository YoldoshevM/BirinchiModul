namespace Dras8;

internal class Program
{

    static List<int> Ages = new List<int>();
    
  
    static void Main(string[] args)
    {

        while ( true )
        {

            Console.Write(" 1. Create : ");
            Console.Write(" 2. Delete : ");
            Console.Write(" 3. Update : ");
            Console.Write(" 4. Read : ");


            Console.Write( " Tanlang : ");

            int.TryParse(Console.ReadLine(), out int c);

            if ( c == 1 )
            {

                Console.Write( " Ism kiriting : ");
                int.TryParse(Console.ReadLine(), out int ism);
                

            }
            



        }





    }



}
