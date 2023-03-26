using Assignment1;
using System.Security.Cryptography.X509Certificates;

namespace BagUnitTests
{
    [TestClass]
    public class BagTests
    {

        //!TEST FOR INSERT()
        #region Test1
        [TestMethod]
        public void TestInsertMethod_BagEmpty()
        {
            //TEST WHEN THE BAG IS EMPTY AND WE INSERT AN ELEMENT

            //ARRANGE
            Methods method = new Methods();
            int initialLength = method.bag.Count;//0

            //ACT AND ASSERT
            //on inserting an element to an empty bag,the length should increase by 1

            method.insert(10);
            Assert.AreEqual(initialLength + 1, method.bag.Count);





        }
        #endregion

        #region Test2
        [TestMethod]
        public void TestInsert_BagNotEmptyElementInBag()
        {
            //TEST WHEN THE BAG IS NOT EMPTY AND WE INSERT AN ELEMENT THAT IS IN THE BAG - frequency of the element should increase by 1

            //arrange
            Methods method = new Methods();
            int index = 0;
            int insertElement = 10;

            //act and assert
            method.insert(insertElement);
            int initialFreq = 1; // Frequency of element 10 in the bag
            method.insert(insertElement);
            for (int i = 0; i < method.bag.Count; i++)
            {
                if (method.bag[i][0] == 10)
                {
                    index = i; break;
                }

            }
            Assert.AreEqual(initialFreq + 1, method.bag[index][1]);

        }
        #endregion

        #region Test3

        [TestMethod]
        public void TestInsert_BagNotEmpty_ElementNotInBag()
        {
            //TEST WHEN WE INSERT AN ELEMENT INTO THE BAG AND IT'S INITIALL NOT IN - Count should increase
            //Arrange
            Methods method = new Methods();
            //Act
            method.insert(21);
            method.insert(200);
            method.insert(200);
            int initialLength = method.bag.Count;

            //inserting a new element into a non empty bag. Length should increase
            int insertElelem = 100;
            method.insert(insertElelem);
            Assert.AreEqual(initialLength + 1, method.bag.Count);

        }
        #endregion


        //!TESTS FOR REMOVE()
        #region Test4

        [TestMethod]
        public void TestRemove_BagEmpty()
        {
            //arrange
            int removeElement = 100;
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();

            //Act and Assert
            Assert.ThrowsException<BagEmptyException>(() => method.remove(removeElement));
        }
        #endregion

        #region Test5
        [TestMethod]
        public void TestRemove_ElementInBag_FrequencyOne()
        {
            //When we remove an element from the bag that is present in the bag and the frequency is 1 - length of bag should reduce by 1


            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();
            method.insert(100);
            method.insert(200);
            method.insert(200);
            int initialLength = method.bag.Count;

            //Act and assert
            method.remove(100);
            Assert.AreEqual(initialLength - 1, method.bag.Count);



        }


        #endregion

        #region Test6
        [TestMethod]
        public void TestRemove_ElemenetInBagAndFrequencyMoreThanOne()
        {
            //The frequency is expected to reduce by 1

            //Arrange
            Methods method = new Methods();
            method.insert(100);
            method.insert(100);
            method.insert(100);
            int removeElem = 100;
            int initialFrequency = 3;
            method.remove(removeElem);
            int actual = 0;
            //Act and Assert

            for (int i = 0; i < method.bag.Count; i++)
            {
                if (method.bag[i][0] == removeElem)
                {
                    actual = method.bag[i][1];
                    break;
                }
            }

            Assert.AreEqual(initialFrequency - 1, actual);


        }

        #endregion

        //!TESTS FOR RETURN_FREQUENCY()
        #region Test7


        [TestMethod]
        public void TestReturnFrequency_BagEmpty()
        {
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();
            int testNumber = 200;

            //Act and assert
            Assert.ThrowsException<BagEmptyException>(() => method.return_Frequency(testNumber));

        }
        #endregion

        #region Test8

        [TestMethod]
        public void TestReturnFrequency_BagNonEmpty_ElementNotInBag()
        {
            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();
            method.insert(1000);
            method.insert(1230);
            method.insert(1300);

            //Act and Assert
            Assert.ThrowsException<ElementNotInBagException>(() => method.return_Frequency(200));

        }
        #endregion

        #region Test9
        [TestMethod]
        public void TestReturnFrequency_BagNonEmpty_ElementInBag()
        {
            //Arrange
            Methods method = new Methods();
            int testNumber = 232;
            method.insert(232);
            method.insert(232);
            method.insert(2032);
            method.insert(1000);

            //Act and Assert

            Assert.AreEqual(2, method.return_Frequency(testNumber));

        }

        #endregion

        //!TESTS FOR MOST_FREQUENT()
        #region Test10

        [TestMethod]
        public void TestmostFrequent_BagEmpty()
        {
            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();

            //Act and Assert
            Assert.ThrowsException<BagEmptyException>(() => method.most_frequent());
        }

        #endregion

        #region Test11

        [TestMethod]
        public void Testmost_frequent_OnlyOneElement()
        {
            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();
            method.insert(100);

            //Act and Assert
            Assert.AreEqual(100, method.most_frequent());

        }
        #endregion

        #region Test12
        [TestMethod]
        public void Testmost_frequent_morethanOneFrequent()
        {
            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();

            //We have 2 most frequent elements, 12 and 17. We should get the first most frequent element
            method.insert(12);
            method.insert(12);
            method.insert(17);
            method.insert(17);
            method.insert(412);
            method.insert(43);


            //Act and Assert
            Assert.AreEqual(12, method.most_frequent());
        }

        #endregion

        //!TESTS FOR PRINT_BAG
        #region Test13
        [TestMethod]

        public void Testprint_the_bag_BagEmpty()
        {
            //Arrange
            Methods method = new Methods();
            List<List<int>> bag = new List<List<int>>();

            //Act and Assert
            Assert.ThrowsException<BagEmptyException>(() => method.print_the_bag());
        }

        #endregion


    }
}