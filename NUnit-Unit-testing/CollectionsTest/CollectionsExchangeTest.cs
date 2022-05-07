using System;
using Collections;
using NUnit.Framework;

namespace CollectionsExchangeTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_ExchangeFirstLast()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3 });

            // Act
            collection.Exchange(0, 2);

            // Assert
            Assert.That(collection.Count == 3);
            Assert.That(collection.Capacity == 16);
            Assert.That(collection[0] == 3);
            Assert.That(collection[2] == 1);
        }

        [Test]
        public void Test_Collections_ExchangeMiddle()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3, 4 });

            // Act
            collection.Exchange(1, 2);

            // Assert
            Assert.That(collection.Count == 4);
            Assert.That(collection.Capacity == 16);
            Assert.That(collection[1] == 3);
            Assert.That(collection[2] == 2);
        }

        [Test]
        public void Test_Collections_ExchangeInvalidIndexes()
        {
            // Arrange
            Collection<int> collection = new Collection<int>(new int[] { 1, 2, 3, 4 });

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => collection.Exchange(8, 2));
        }
    }
}