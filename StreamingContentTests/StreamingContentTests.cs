using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent;

namespace StreamingContentTests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldReturnCorrectString()
        {
            //Arrange
            StreamingContentBase var1 = new StreamingContentBase();

            //Act
            var1.Title = "Movie 2";

            //Assert
            Assert.AreEqual(var1.Title, "Movie 2");
        }

        [TestMethod]
        public void CheckIfFamilyFriendlyBasedOnMaturityRating()
        {
            StreamingContentBase isFamilyFriendly = new StreamingContentBase();
            isFamilyFriendly.MaturityRating = MaturityRating.R;
            bool check = isFamilyFriendly.IsFamilyFriendly;

            Assert.IsFalse(check);
        }
    }
}
