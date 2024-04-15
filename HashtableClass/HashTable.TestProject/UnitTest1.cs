using HashtableClass;
namespace HashTable.TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // AAA 
            // Arrange : Instantiate class

            Solution solution = new Solution();

            // Act

            solution.Put(1,1);
            solution.Put(2,2);

            int value1 = solution.Get(1);
            int value2 = solution.Get(3);

            solution.Put(2,1);
            int value3 = solution.Get(2);

            solution.Remove(2);

            int valueAfterRemoval = solution.Get(2);

            //Assert
            Assert.AreEqual(1, value1);
            Assert.AreEqual(-1, value2); 
            Assert.AreEqual(1, value3);
            Assert.AreEqual(-1, valueAfterRemoval);  

        }
    }
}