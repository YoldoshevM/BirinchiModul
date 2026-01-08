namespace Dars9;

internal class Program
{

    static List<string> Ids = new List<string>();
  

    static void Main(string[] args)
    {


    }


    static void AddId (string id)
    {
        Ids.Add(id);
    }

    static void DeleteID ( string id)
    {
        Ids.Remove(id);
    }

    static void DisplayIDs()
    {
        foreach ( var id in Ids )
        {
            Console.WriteLine(id);
        }
        Console.WriteLine();
    }

    static void UpdateId (string oldId , string newId)
    {

        var index = Ids.IndexOf(oldId);

        if ( index != -1 )
        {
            Ids[index] = newId;      
        }

    }
    



}
