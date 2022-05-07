using Collections;
using NUnit.Framework;

namespace CollectionsToStringTest
{
    public class Tests
    {
        [Test]
        public void Test_Collections_ToStringCollectionOfCollections()
        {
            // Arrange
            Collection<string> innerCollection = new Collection<string>(new string[] { "1" });
            Collection<Collection<string>> collection = new Collection<Collection<string>>(innerCollection);

            // Act & Assert
            Assert.That(collection.ToString() == "[[1]]");
        }

        [Test]
        public void Test_Collections_ToStringEmpty()
        {
            // Arrange
            Collection<string> collection = new Collection<string>(new string[] {  });

            // Act & Assert
            Assert.That(collection.ToString() == "[]");
        }

        [Test]
        public void Test_Collections_ToStringMultiple()
        {
            // Arrange
            Collection<string> collection = new Collection<string>(new string[] { "1", "2", "3" });

            // Act & Assert
            Assert.That(collection.ToString() == "[1, 2, 3]");
        }
           
        [Test]
        public void Test_Collections_ToStringSingle()
        {
            // Arrange
            Collection<string> collection = new Collection<string>(new string[] { "1" });

            // Act & Assert
            Assert.That(collection.ToString() == "[1]");
        }
    }
}