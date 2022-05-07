using Collections;
using NUnit.Framework;

namespace CollectionsAddTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_AddToExisting()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 3 });
            
            // Act
            collection.Add(5);

            // Assert
            Assert.That(collection.Count == 3);
        }

        [Test]
        public void Test_Collections_AddToEmpty()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { });
            
            // Act
            collection.Add(5);

            // Assert
            Assert.That(collection.Count == 1);
            Assert.That(collection[0] == 5);
        }

        [Test]
        public void Test_Collections_AddUsingArrayIndexing()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1 });
            
            // Act
            collection[0] = 5;

            // Assert
            Assert.That(collection.Count == 1);
            Assert.That(collection[0] == 5);
        }

        [Test]
        public void Test_Collections_AddRangeToExisting()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 3 });
            
            // Act
            collection.AddRange(new int[] { 5, 7 });

            // Assert
            Assert.That(collection.Count == 4);
        }


        [Test]
        public void Test_Collections_AddRangeToEmpty()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { });
            
            // Act
            collection.AddRange(new int[] { 1, 2 });

            // Assert
            Assert.That(collection.Count == 2);
            Assert.Positive(collection.Count);
        }

        [Test]
        public void Test_Collections_AddRangeOverCapacity()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1 });
            
            // Act
            collection.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });

            // Assert
            Assert.That(collection.Count == 17);
            Assert.That(collection.Capacity == 32);
        }
    }
}