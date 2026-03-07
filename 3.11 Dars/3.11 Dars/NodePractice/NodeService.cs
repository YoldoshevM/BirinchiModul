using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _3._11_Dars.NodePractice;

public class NodeService
{
    public static Node CreateNode(int length)
    {

        
        
        


    }


    public static void Print(Node head)
    {

        Node temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Next;
        }


    }


}



