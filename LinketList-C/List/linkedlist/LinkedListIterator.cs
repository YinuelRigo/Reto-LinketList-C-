using System;
using System.Collections.Generic;
using System.Text;

namespace LinketList_C.List.linkedList
{
    public class LinkedListIterator<T> : Iterator<T> {

    private Node<T> currentNode;

    public LinkedListIterator(Node<T> head)
    {
        currentNode = head;
    }

    public T next()
    {
        T data = currentNode.data;

        currentNode = currentNode.next;

        return data;
    }

    public bool hasNext()
    {
        return currentNode != null;
    }
}
}
