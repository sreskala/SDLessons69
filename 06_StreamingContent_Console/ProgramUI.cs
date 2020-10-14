using StreamingContent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console
{
    public class ProgramUI
    {

        private StreamingContentRepo _repo = new StreamingContentRepo();

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            //continues to run program
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Update existing streaming content\n" +
                    "5. Remove streaming content\n" +
                    "6. Exit menu\n");

                //user response
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        //Show all content
                        ShowAllContent();
                        break;
                    case "2":
                        //Get content by title
                        GetContentByTitle();
                        break;
                    case "3":
                        //Add new content
                        CreateNewContent();
                        break;
                    case "4":
                        //Update streaming content
                        break;
                    case "5":
                        //Delete content
                        DeleteContent();
                        break;
                    case "6":
                        //Exit menu
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        Console.ReadKey();
                        //Not valid input
                        break;
                }
            }
        }

        private void ShowAllContent()
        {
            Console.Clear();

            List<StreamingContentBase> listOfContent = _repo.GetContents();

            foreach (StreamingContentBase content in listOfContent)
            {
                DisplayContent(content);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void CreateNewContent()
        {
            Console.Clear();

            //instantiate empty StreamingContentBase object
            StreamingContentBase newContent = new StreamingContentBase();

            //get user input
            Console.WriteLine("Enter a title:");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("Enter a description:");
            newContent.Description = Console.ReadLine();

            Console.WriteLine("Enter a rating (1.0 - 10.0):");
            string ratingAsString = Console.ReadLine();
            double ratingAsDouble = double.Parse(ratingAsString);
            newContent.StarRating = ratingAsDouble;

            Console.WriteLine("Select a genre:");
            Console.WriteLine(" 1.Horror\n 2.RomCom\n 3.SciFi\n 4.Action\n 5.Documentary\n 6.Musical\n" +
                " 7.Drama\n 8.Mystery\n");
            string genreInput = Console.ReadLine();
            int genreInt = Int32.Parse(genreInput);
            //cast the genre
            newContent.Genre = (Genre)(genreInt - 1);

            Console.WriteLine("Select a Maturity Rating:");
            Console.WriteLine("1.G\n 2.PG\n 3.PG_13\n 4.R\n 5.NC_17\n");

            string maturityRating = Console.ReadLine();

            switch (maturityRating)
            {
                case "1":
                    newContent.MaturityRating = MaturityRating.G;
                        break;
                case "2":
                    newContent.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    newContent.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    newContent.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    newContent.MaturityRating = MaturityRating.NC_17;
                    break;
                default:
                    throw new InvalidEnumArgumentException("Invalid selection from category");
            }

            bool wasAdded = _repo.AddContentToDirectory(newContent);
            if(wasAdded)
            {
                Console.WriteLine("Content successfully added");
            } else
            {
                Console.WriteLine("Oops! Something went wrong, not added.");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private void GetContentByTitle()
        {
            Console.Clear();

            Console.WriteLine("Enter the title of the content you'd like to see: ");
            string title = Console.ReadLine();

            StreamingContentBase content = _repo.GetContentByTitle(title);

            if(content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("That title doesn't exist.");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private void DisplayContent(StreamingContentBase content)
        {
            //Display Content
            int multiplier = 20;
            string division = String.Concat(Enumerable.Repeat("*", multiplier));
            Console.WriteLine(division);
            Console.WriteLine($"Title: {content.Title}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Star-rating: {content.StarRating}");
            Console.WriteLine($"Genre: {content.Genre}");
            Console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            Console.WriteLine($"Is family friendly?: {content.IsFamilyFriendly}");
            Console.WriteLine(division);
        }

        private void DeleteContent()
        {
            Console.Clear();
            Console.WriteLine("Please type in title to delete: ");

            //iterate titles
            List<StreamingContentBase> listOfContents = _repo.GetContents();
            foreach(StreamingContentBase contentTitle in listOfContents)
            {
                Console.WriteLine($"- {contentTitle.Title}");
            }

            string title = Console.ReadLine();
            StreamingContentBase content = _repo.GetContentByTitle(title);

            bool contentDidDelete = _repo.DeleteExisitingContent(content);

            if(contentDidDelete != false)
            {
                Console.WriteLine("Content successfully deleted");
            } else
            {
                Console.WriteLine("Something went wrong. Was not able to delete content");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
