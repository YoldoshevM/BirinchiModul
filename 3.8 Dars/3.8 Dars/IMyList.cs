using System;
using System.Collections.Generic;
using System.Text;

namespace _3._8_Dars;

public interface IMyList<T>
{
    public bool Add(T item);
    public bool RemoveAll(T item);
    public bool Remove(T item);
    public bool Contains(T item);
    public int IndexOf(T item);
    public bool RemoveAt(int index);
    public T GetById(int index);
    public void DisplayElements();
}
