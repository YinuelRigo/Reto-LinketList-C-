using System;
using System.Collections.Generic;
using System.Text;
using LinketList_C.List.ArrayList;

namespace LinketList_C.List.arraylist
{
    public class ArrayListIterator<T> : Iterator<T> {

    private int currentIndex = 0;
    private ArrayList<T> arrayList;

    public ArrayListIterator(ArrayList<T> arrayList)
    {
        this.arrayList = arrayList;
    }

    public T next()
    {
        return arrayList.getAt(currentIndex++);
    }

    public bool hasNext()
    {
        return currentIndex < arrayList.getSize();
    }
}  
}
