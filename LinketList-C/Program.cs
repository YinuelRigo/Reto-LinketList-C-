using System;
using LinketList_C.List;
using LinketList_C.List.ArrayList;
using LinketList_C.List.linkedList;

namespace LinketList_C
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> books = new ArrayList<int>();
            List<int> students = new LinkedList<int>();

            books.add(11);
            books.add(22);
            books.add(33);
            books.add(44);
            //books.add(55);

            books.insert(55, 4);

            books.delete(2);

            students.add(3278);
            students.add(2245);

            System.Console.WriteLine("Libros size:" + books.getSize());
            System.Console.WriteLine("Alumnos size:" + students.getSize());

            System.Console.WriteLine("Libros en posición 0 :" + books.getAt(0));
            System.Console.WriteLine("Libros en posición 1 :" + books.getAt(1));
            System.Console.WriteLine("Libros en posición 2 :" + books.getAt(2));
            System.Console.WriteLine("Libros en posición 3 :" + books.getAt(3));

            books.print();

            for (int i = 0; i < books.getSize(); i++)
            {
                int data = books.getAt(i);

                System.Console.WriteLine(data);
            }

            System.Console.WriteLine("Datos de la iteracion Libros");

            Iterator<int> it = books.getIterator();

            while (it.hasNext())
            {
                int data = it.next();

                System.Console.WriteLine(data);
            }

            System.Console.WriteLine("Datos de la iteracion Alumnos");

            Iterator<int> it2 = students.getIterator();

            while (it2.hasNext())
            {
                int data = it2.next();

                System.Console.WriteLine(data);
            }
        }
    }
}
