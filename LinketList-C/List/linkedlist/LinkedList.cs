using System;
using System.Collections.Generic;
using System.Text;

namespace LinketList_C.List.linkedList
{
    public class LinkedList<H> : List<H>{
    private Node<H> head;
    private Node<H> tail;
    private int size;

    public void add(H data)
    {
        Node<H> node = new Node<H>();

        node.data = data;

        if (head == null)
        {
            head = node;
        }

        node.previous = tail;

        if (tail != null)
        {
            tail.next = node;
        }

        tail = node;
        size++;
    }

    public void insert(H data, int index)
    {
        int counter = 0;
        Node<H> iterator = head;

        if (index < 0 || index > size)
        {
            return;
        }

        if (index == size)
        {
            add(data);
            return;
        }

        while (counter < index && iterator != null)
        {
            iterator = iterator.next;
            counter++;
        }

        Node<H> node = new Node<H>();

        node.data = data;
        node.next = iterator;
        node.previous = iterator.previous;

        if (iterator.previous == null)
        {
            head = node;
        }
        else
        {
            iterator.previous.next = node;
        }
        iterator.previous = node;

        size++;
    }

    public void delete(int index)
    {
        int counter = 0;
        Node<H> iterator = head;

        if (index < 0 || index >= size)
        {
            return;
        }

        while (counter < index && iterator != null)
        {
            iterator = iterator.next;
            counter++;
        }

        if (iterator != null)
        {
            if (iterator.previous == null)
            {
                head = iterator.next;
            }
            else
            {
                iterator.previous.next = iterator.next;
            }

            if (iterator.next == null)
            {
                tail = iterator.previous;
            }
            else
            {
                iterator.next.previous = iterator.previous;
            }
        }

        size--;
    }


    public int getSize()
    {
        return size;
    }

    public H getAt(int index)
    {
        int counter = 0;
        Node<H> it = head;

        while (counter < index && it != null)
        {
            counter++;
            it = it.next;
        }
        return it == null ? default : it.data;
    }

    public Iterator<H> getIterator()
    {
        return new LinkedListIterator<H>(head);
    }

    public void print()
    {
        Node<H> it = head;

        while (it != null)
        {
                System.Console.WriteLine(it.data);
            it = it.next;
        }
    }
}
}
