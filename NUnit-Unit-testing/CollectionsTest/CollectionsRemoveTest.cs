using System;
using Collections;
using NUnit.Framework;

namespace CollectionsRemoveTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_RemoveAtStart()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 3 });
            
            // Act
            collection.RemoveAt(0);

            // Assert
            Assert.That(collection.Count == 1);
            Assert.That(collection[0] == 3);
        }

        [Test]
        public void Test_Collections_RemoveAtEnd()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 3 });
            
            // Act
            collection.RemoveAt(1);

            // Assert
            Assert.That(collection.Count == 1);
            Assert.That(collection[0] == 1);
        }

        [Test]
        public void Test_Collections_RemoveAtMiddle()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 3, 5 });
            
            // Act
            collection.RemoveAt(1);

            // Assert
            Assert.That(collection.Count == 2);
            Assert.That(collection[0] == 1);
            Assert.That(collection[1] == 5);
        }

        [Test]
        public void Test_Collections_RemoveAll()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1 });
            
            // Act
            collection.RemoveAt(0);

            // Assert
            Assert.That(collection.Count == 0);
        }

        [Test]
        public void Test_Collections_RemoveAtInvalidIndex()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1 });

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => collection.RemoveAt(2));
        }

                [Test]
        public void Test_Collections_Clear()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });
            
            // Act
            collection.Clear();

            // Assert
            Assert.That(collection.Count == 0);
        }
    }
}