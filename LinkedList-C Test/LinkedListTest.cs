using LinketList_C.List;
using LinketList_C.List.linkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace LinkedListTest
{
    [TestClass()]
    public class LinkedListTest
    {
        [TestMethod()]

        public void whenListIsCretaed_thenSizeIsZero()
        {
            //given
            LinkedList<int> list = new LinkedList<int>();
            //when
            int size = list.getSize();
            //then
            Assert.AreEqual(0, size);
        }

        [TestMethod()]
        public void givenAnewList_whenAdd_thenSizeIsOne()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            //when
            list.add("Mario");
            //then
            Assert.AreEqual(1, list.getSize());
        }

        [TestMethod()]
        public void givenAListWithOneElement_whenAdd_thenSizeIstwo()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            //when
            list.add("Rosa");
            list.add("Mario");
            //then
            Assert.AreEqual(2, list.getSize());
        }

        [TestMethod()]
        public void givenAListWithThreeElement_whenGetAt_thenElementsAreReturnedSuccesfuly()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
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
            LinkedList<String> list = new LinkedList<String>();
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
            LinkedList<Double> list = new LinkedList<Double>();
            //when
            list.insert(2.5, 0);
            //then
            Assert.AreEqual(1, list.getSize());
            Assert.AreEqual(2.5, list.getAt(0));

        }

        [TestMethod()]
        public void given_whenInsertForIndexLessThanZero_TheElementIsNotInsert()
        {
            //given
            LinkedList<Double> list = new LinkedList<Double>();
            //when
            list.insert(3.5, -1);
            //then
            Assert.AreEqual(0, list.getSize());
        }

        [TestMethod()]
        public void whenInsertForIndexGraterThanSize_TheElementIsNotInsert()
        {
            //given
            LinkedList<Double> list = new LinkedList<Double>();
            //when
            list.insert(3.5, 1);
            //then
            Assert.AreEqual(0, list.getSize());
        }

        [TestMethod()]
        public void givenAListWith2Elements_whenInsertForIndexGrater1_TheElementIsNotInsert()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
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
        public void givenAListWith2Elements_whenInsertForIndexZero_TheElementIsInsert()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            list.add("Segundo");
            list.add("Tercero");
            //when
            list.insert("Primero", 0);
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
            LinkedList<String> list = new LinkedList<String>();
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
        public void givenAListWith2Elements_whenDeleteForIndex2_TheElementIsDelete()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
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
            LinkedList<String> list = new LinkedList<String>();
            list.add("Primero");
            list.add("Segundo");
            //when
            list.delete(-1);
            //then
            Assert.AreEqual(2, list.getSize());
            Assert.AreEqual("Primero", list.getAt(0));
            Assert.AreEqual("Segundo", list.getAt(1));

        }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndexForIndex3_TheElementIsNotDelete()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            list.add("Primero");
            list.add("Segundo");
            //when
            list.delete(3);
            //then
            Assert.AreEqual(2, list.getSize());
            Assert.AreEqual("Primero", list.getAt(0));
            Assert.AreEqual("Segundo", list.getAt(1));

        }

        [TestMethod()]
        public void givenAListWith2Elements_whenDeleteForIndex1_TheElementIsDelete()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            list.add("Primero");
            list.add("Segundo");
            //when
            list.delete(1);
            //then
            Assert.AreEqual(1, list.getSize());
            Assert.AreEqual("Primero", list.getAt(0));
        }

        [TestMethod()]
        public void givenAListWith3Elements_whenDeleteForIndex1_TheElementIsDelete()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            list.add("Primero");
            list.add("Segundo");
            list.add("Tercero");
            //when
            list.delete(1);
            //then
            Assert.AreEqual(2, list.getSize());
            Assert.AreEqual("Primero", list.getAt(0));
            Assert.AreEqual("Tercero", list.getAt(1));
        }

        [TestMethod()]
        public void givenAListWith3Elements_whenIterator_ThenIterationWorksFine()
        {
            //given
            LinkedList<String> list = new LinkedList<String>();
            list.add("Primero");
            list.add("Segundo");
            list.add("Tercero");
            //when
            Iterator<String> it = list.getIterator();

            //then
            Assert.IsTrue(it is LinkedListIterator<String>);
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
