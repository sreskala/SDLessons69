using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StreamingContent;

namespace StreamingContentTests
{
    [TestClass]
    public class StreamingContentRepoTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            StreamingContentBase content = new StreamingContentBase();
            StreamingContentRepo repository = new StreamingContentRepo();

            bool addResult = repository.AddContentToDirectory(content);

            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            StreamingContentBase content = new StreamingContentBase();
            StreamingContentRepo repo = new StreamingContentRepo();

            repo.AddContentToDirectory(content);

            List<StreamingContentBase> contents = repo.GetContents();

            bool directoryHasContent = contents.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            StreamingContentRepo repo = new StreamingContentRepo();
            StreamingContentBase newContent = new StreamingContentBase("Jumanji", "Cool", 10, Genre.Action, MaturityRating.PG_13);
            repo.AddContentToDirectory(newContent);
            string title = "Jumanji";

            //Act
            StreamingContentBase searchResult = repo.GetContentByTitle(title);

            //Assert
            Assert.AreEqual(searchResult.Title, title);
        }

        [TestMethod]
        public void UpdateContent_ShouldUpdateContentCorrectly()
        {
            //Arrange
            StreamingContentRepo repo = new StreamingContentRepo();
            StreamingContentBase oldContent = new StreamingContentBase("Jumanji", "Cool", 10, Genre.Action, MaturityRating.PG_13);
            repo.AddContentToDirectory(oldContent);

            StreamingContentBase newContent = new StreamingContentBase("Jumanji", "It sucks", 7, Genre.Horror, MaturityRating.PG_13);

            //Act
            bool didUpdateContent = repo.UpdateExistingContent("Jumanji", newContent);
            
            //Assert
            Assert.IsTrue(didUpdateContent);
        }

        [TestMethod]
        public void DeleteContent_ShouldDeleteContentCorrectly()
        {
            //Arrange
            StreamingContentRepo repo = new StreamingContentRepo();
            StreamingContentBase existingContent = new StreamingContentBase("Jumanji", "Cool", 10, Genre.Action, MaturityRating.PG_13);
            repo.AddContentToDirectory(existingContent);

            //Act
            StreamingContentBase content = repo.GetContentByTitle("Jumanji");
            bool didDelete = repo.DeleteExisitingContent(content);

            //Assert
            Assert.IsTrue(didDelete);
        }
    }
}
