using Collections;
using NUnit.Framework;

namespace CollectionsConstructorTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_ConstructorMultipleItems()
        {
            // Act
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });

            // Assert
            Assert.That(collection.Count == 3);
            Assert.That(collection.Capacity == 16);
        }

        [Test]
        public void Test_Collections_ConstructorSingleItem()
        {
            // Act
            Collection<int> collection = new Collection<int>(new int[] { 1 });

            // Assert
            Assert.That(collection.Count == 1);
            Assert.That(collection.Capacity == 16);
        }

        [Test]
        public void Test_Collections_EmptyConstructor()
        {
            // Act
            Collection<int> collection = new Collection<int>();

            // Assert
            Assert.That(collection.Count == 0);
            Assert.That(collection.Capacity == 16);
        }

        [Test]
        public void Test_Collections_MultipleItemsWithIncreasedDefaultCapacity()
        {
            // Act
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            // Assert
            Assert.That(collection.Count == 9);
            Assert.That(collection.Capacity == 18);
        }
    }
}