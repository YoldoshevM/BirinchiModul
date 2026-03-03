using System.Collections;

namespace _3._9;

internal class Program
{
    static void Main(string[] args)
    {


        // 1


        //ArrayList list = new ArrayList();

        //list.Add(1);
        //list.Add(2);
        //list.Add(3);
        //list.Add(4);
        //list.Add(5);


        // 2


        //ArrayList list1 = new ArrayList();

        //list1.Add(1);
        //list1.Add(2);
        //list1.Add(3);


        //foreach(int item in list1)
        //{
        //    Console.WriteLine(item);
        //}



        // 3


        //ArrayList list = new ArrayList();

        //Console.WriteLine(list.Count);


        // 4


        //ArrayList list = new ArrayList();

        //Console.WriteLine(list[3]);



        // 5


        //ArrayList list = new ArrayList();

        //list.Add("salom");
        //list.Add("Hello");

        //foreach (var item in list)
        //{
        //    Console.WriteLine(item);
        //}



        // 6


        //ArrayList list = new ArrayList();

        //list.Add("salom");

        //Console.WriteLine(list.Contains("salom"));



        // 7


        //ArrayList list = new ArrayList();   

        //list.Add(200);

        //list.Remove(200);

        //foreach (int item in list)
        //{
        //    Console.WriteLine(item);
        //}



        // 8


        //ArrayList list = new ArrayList();


        //list.Add(1);
        //list.Add(2);
        //list.Add("adml");

        //Console.WriteLine(list.Clear);



        // 9


        ArrayList list = new ArrayList();

        //for (int i = 1; i <= 10; i++)
        //{
        //    list.Add(i);
        //}



        // 10

        list.Add(1);
        list.Add(1);
        list.Add(1);

        for ( int i = 0; i < list.Count; i++ )
        {
            Console.WriteLine(list[i]);
        }







    }
}
