using Collections;
using NUnit.Framework;

namespace CollectionsInsertAtTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_InsertAtEnd()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });
            
            // Act
            collection.InsertAt(3, 4);

            // Assert
            Assert.That(collection.Count == 4);
            Assert.That(collection[3] == 4);
        }

        [Test]
        public void Test_Collections_InsertAtMiddle()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });
            
            // Act
            collection.InsertAt(1, 8);

            // Assert
            Assert.That(collection.Count == 4);
            Assert.That(collection[1] == 8);
        }

        [Test]
        public void Test_Collections_InsertAtStart()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });
            
            // Act
            collection.InsertAt(0, 8);

            // Assert
            Assert.That(collection.Count == 4);
            Assert.That(collection[0] == 8);
        }

        [Test]
        public void Test_Collections_InsertAtWithGrow()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(
                new int[] { }
            );
            collection.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16});
            
            // Act
            collection.InsertAt(16, 17);

            // Assert
            Assert.That(collection.Count == 17);
            Assert.That(collection[16] == 17);
            Assert.That(collection.Capacity == 32);
        }
    }
}