using System;
using System.Collections.Generic;
using System.Text;
using LinketList_C.List.arraylist;

namespace LinketList_C.List.ArrayList
{
    public class ArrayList<H> : List<H>{
    private Object[] array;
    private int size;

    public ArrayList()
    {
        array = new Object[2];
    }

    public void add(H data)
    {

        if (size >= array.Length)
        {
            increaseArrayCapacity();
        }

        this.array[size] = data;
        size++;
    }

    public void insert(H data, int index)
    {
        if (index < 0 || index > size)
        {
            return;
        }

        if (size >= array.Length)
        {
            increaseArrayCapacity();
        }

        if (size - index >= 0)
            Array.Copy(array, index, array, index + 1, size - index);

        array[index] = data;
        size++;
    }

    public void delete(int index)
    {
        if (index < 0 || index >= size)
        {
            return;
        }
        if (size - 1 - index >= 0)
        {
            Array.Copy(array, index + 1, array, index, size - 1 - index);
        }
        size--;
    }

    public int getSize()
    {
        return size;
    }

    public H getAt(int index)
    {
        if (index < 0 || index >= size)
        {
            return default(H);
        }
        return (H)this.array[index];
    }

    public void print()
    {
        for (int i = 0; i < size; i++)
        {
                System.Console.WriteLine(array[i]);
        }
    }

    public Iterator<H> getIterator()
    {
        return new ArrayListIterator<H>(this);
    }

    private void increaseArrayCapacity()
    {
        Object[] newArray = new Object[array.Length * 2];

        Array.Copy(array, 0, newArray, 0, array.Length);

        array = newArray;
    }
}
}
