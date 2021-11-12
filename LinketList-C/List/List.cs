using System;
using System.Collections.Generic;
using System.Text;

namespace LinketList_C.List
{
    public interface List<T>
    {

        void add(T data);

        int getSize();

        T getAt(int index);

        void delete(int index);

        void insert(T data, int index);

        void print();

        Iterator<T> getIterator();
    }
}
