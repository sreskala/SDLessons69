using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent
{
    public class StreamingContentRepo
    {
        private List<StreamingContentBase> _contentDirectory = new List<StreamingContentBase>();

        public bool AddContentToDirectory(StreamingContentBase content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;

            return wasAdded;
        }

        public List<StreamingContentBase> GetContents()
        {
            return _contentDirectory;
        }

        public StreamingContentBase GetContentByTitle(string title)
        {
            foreach(StreamingContentBase content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }

        public bool UpdateExistingContent(string originalTitle, StreamingContentBase newContent)
        {
            StreamingContentBase oldContent = GetContentByTitle(originalTitle); //Calling this method inside same class

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.Genre = newContent.Genre;
                return true;
            } else
            {
                return false;
            }
        }

        public bool DeleteExisitingContent(StreamingContentBase existingContent)
        {
            bool isDeleted = _contentDirectory.Remove(existingContent);
            return isDeleted;
        }
    }
}
