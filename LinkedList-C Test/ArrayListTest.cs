using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using LinketList_C.List.ArrayList;
using LinketList_C.List.arraylist;
using LinketList_C.List;

namespace ArrayListTest
{
    [TestClass()]
    public class ArrayListTest
    {
        [TestMethod()]
        public void whenListIsCretaed_thenSizeIsZero()
        {
            //given
            ArrayList<int> list = new ArrayList<int>();
            //when
            int size = list.getSize();
            //then
            Assert.AreEqual(0, size);
        }

        [TestMethod()]

        public void givenAnewList_whenAdd_thenSizeIsOne()
        {
            //given
            ArrayList<String> list = new ArrayList<String>();
            //when
            list.add("Mario");
            //then
            Assert.AreEqual(1, list.getSize());
        }

        [TestMethod()]
        public void givenAList_whenAdd_thenSizeIsTwo()
        {
            //given
            ArrayList<String> list = new ArrayList<String>();
            //when
            list.add("Mario");
            list.add("Maria");
            //then
            Assert.AreEqual(2, list.getSize());

        }

        [TestMethod()]
        public void givenAList_whenAdd_thenSizeIsMoreThan5IncreaseArray()
        {
            ArrayList<String> list = new ArrayList<String>();
            //when

            list.add("Mario");
            list.add("Maria");
            list.add("Rosa");
            list.add("Mario");
            list.add("Maria");
            list.add("Rosa");

            //then
            Assert.AreEqual(6, list.getSize());
        }

        [TestMethod()]
        public void giveAList_whenAdd_increase()
        {
            ArrayList<String> list = new ArrayList<String>();

           //while
            list.add("Mario");
            list.add("Rosa");


            //then
            Assert.AreEqual(2, list.getSize());

            list.add("Pedro");
            Assert.AreEqual(3, list.getSize());
        }

        [TestMethod()]
        public void givenAListWithThreeElement_whenGetAt_thenElementsAreReturnedSuccesfuly()
        {
            //given
            ArrayList<String> list=new ArrayList<String>();
        //when
        list.add("Luis");
        list.add("Maria");
        list.add("Pancho");
        //then
        Assert.AreEqual("Luis", list.getAt(0));
        Assert.AreEqual("Maria", list.getAt(1));
        Assert.AreEqual("Pancho", list.getAt(2));
        }

        [TestMethod()]
        public void givenAListWithThreeElement_whenGetAtIndex4_thenNullIsReturn()
        {
        //given
        ArrayList<String> list=new ArrayList<String>();
        //when
        list.add("Luis");
        list.add("Maria");
        list.add("Pancho");
         //then
         Assert.IsNull(null, list.getAt(4));


        }

        [TestMethod()]
        public void givenAEmptyList_whenInsert_TheElementInsertedSucesfully() 
        {
              //given
             ArrayList<String> list=new ArrayList<String>();
             //when
            list.insert("Maria", 0);
            //then
            Assert.AreEqual(1, list.getSize());
           Assert.AreEqual("Maria", list.getAt(0));

       }

        [TestMethod()]
        public void given_whenInsertForIndex_TheElementIsNotInsert()
        {
           //given
          ArrayList<Double> list = new ArrayList<Double>();
          //when
          list.insert(3.5, 1);
          //then
          Assert.AreEqual(0, list.getSize());
        }

        [TestMethod()]
        public void given_whenInsertForIndexLessThanZero_TheElementIsNotInsert()
        { 
            //given
            ArrayList<Double> list = new ArrayList<Double>();
           //when
           list.insert(3.5, -1);
           //then
          Assert.AreEqual(0, list.getSize());
        }

        [TestMethod()]
        public void whenInsertForIndexGraterThanSize_TheElementIsNotInsert()
        {
        //given
        ArrayList<Double> list = new ArrayList<Double>();
        //when
        list.insert(3.5, 1);
        //then
        Assert.AreEqual(0, list.getSize());
        }

        [TestMethod()]
        public void givenAListWith2Elements_whenInsertForIndexGrater1_TheElementIsNotInsert()
     { 
         //given
        ArrayList<String> list=new ArrayList<String>();
        list.add("Primero");
        list.add("Tercero");
        //when
       list.insert("Segundo", 1);
       //then
       Assert.AreEqual(3, list.getSize());
       Assert.AreEqual("Primero", list.getAt(0));
       Assert.AreEqual("Segundo", list.getAt(1));
       Assert.AreEqual("Tercero", list.getAt(2));
    }

        [TestMethod()]
        public void givenAListWith2Elements_whenInsertForIndex2_TheElementIsInsert()
     {
          //given
         ArrayList<String> list=new ArrayList<String>();
         list.add("Primero");
         list.add("Segundo");
         //when
         list.insert("Tercero", 2);
         //then
         Assert.AreEqual(3, list.getSize());
         Assert.AreEqual("Primero", list.getAt(0));
         Assert.AreEqual("Segundo", list.getAt(1));
         Assert.AreEqual("Tercero", list.getAt(2));
    }

        [TestMethod()]
        public void givenAList_whenInsert_thenSizeIsMoreThan5IncreaseArray()
    {
          ArrayList<String> list = new ArrayList<String>();
         //when

         list.insert("Mario", 0);
         list.insert("Maria", 1);
         list.insert("Rosa", 2);
         list.insert("Alan", 3);
         list.insert("Alfonso", 4);
         list.insert("Roberto", 5);

         //then
         Assert.AreEqual(6, list.getSize());
    }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndex2_TheElementIsDelete() 
    {
         //given
         ArrayList<String> list=new ArrayList<String>();
        list.add("Primero");
        list.add("Segundo");
        //when
        list.delete(0);
        //then
        Assert.AreEqual(1, list.getSize());
        Assert.AreEqual("Segundo", list.getAt(0));

    }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndexMinus1_TheElementIsNotDelete()
    { 
         //given
         ArrayList<String> list=new ArrayList<String>();
         list.add("Primero");
         list.add("Segundo");
         //when
         list.delete( -1);
            //then

         Assert.AreEqual(2, list.getSize());
         Assert.AreEqual("Primero", list.getAt(0));
         Assert.AreEqual("Segundo", list.getAt(1));

        }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndexForIndex3_TheElementIsNotDelete() 
    {
         //given
          ArrayList<String> list=new ArrayList<String>();
          list.add("Primero");
          list.add("Segundo");

         //when
         list.delete( 3);
            //then

            Assert.AreEqual(2, list.getSize());
            Assert.AreEqual("Primero", list.getAt(0));
            Assert.AreEqual("Segundo", list.getAt(1));
    }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndex1_TheElementIsDelete()
    {
        //given
        ArrayList<String> list=new ArrayList<String>();
        list.add("Primero");
        list.add("Segundo");
        //when
        list.delete(1);
        //then
        Assert.AreEqual(1, list.getSize());
        Assert.AreEqual("Primero", list.getAt(0));
    }

        [TestMethod()]
        public void givenAListWith3Elements_whenIterator_ThenIterationWorksFine() 
    {
         //given
         ArrayList<String> list=new ArrayList<String>();
         list.add("Primero");
         list.add("Segundo");
         list.add("Tercero");
         //when
        Iterator<String> it = list.getIterator();

        //then
       Assert.IsTrue(it is ArrayListIterator<String>);
       Assert.IsTrue(it.hasNext());
       Assert.AreEqual("Primero", it.next());
       Assert.IsTrue(it.hasNext());
       Assert.AreEqual("Segundo", it.next());
       Assert.IsTrue(it.hasNext());
       Assert.AreEqual("Tercero", it.next());
       Assert.IsFalse(it.hasNext());
    }
    }
}