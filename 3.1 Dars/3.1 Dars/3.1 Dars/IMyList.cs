using System;
using System.Collections.Generic;
using System.Text;

namespace _3._1_Dars;

public interface IMyList
{

    public bool Add(int num);
    public bool RemoveAll(int num);
    public bool Remove(int num);
    public bool Contains(int num);
    public int IndexOf(int num);
    public bool RemoveAt(int num);
    public int GetById(int num);
    public void DisplayElements();        
        




}
