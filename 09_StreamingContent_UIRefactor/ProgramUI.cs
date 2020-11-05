using _09_StreamingContent_UIRefactor.UI;
using StreamingContent;
using StreamingContent.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor
{
    class ProgramUI
    {
        private IConsole _console;
        //Dependency Injection
        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void SayHello()
        {
            _console.WriteLine("What is your name?");
            string name = _console.ReadLine();
            _console.WriteLine($"Hey, {name} how are you doing?");
            string reply = _console.ReadLine();
            _console.WriteLine(reply);
            _console.ReadKey();
        }

        private StreamingContentRepo _repo = new StreamingContentRepo();

        public void Run()
        {
            SeedContent();
            Menu();
        }

        private void SeedContent()
        {
            Movie futureWar = new Movie(
                "Future War",
                "A war in the future",
                10.0,
                Genre.SciFi,
                MaturityRating.G,
                90.0
                );

            _repo.AddContentToDirectory(futureWar);

            Movie theRoom = new Movie(
                "The Room",
                "Everyone betrays Johnny",
                10.0,
                Genre.Documentary,
                MaturityRating.G,
                99.0
                );

            _repo.AddContentToDirectory(theRoom);

            //episodes
            Episode episode1 = new Episode("Morty's Mind Blowers", 23.5, 4);
            Episode episode2 = new Episode("The Ricklantis Mixup", 24.0, 3);

            //show
            Show rickMorty = new Show("Rick and Morty", "Goofy ass show", 10.0, Genre.Action, MaturityRating.R, 24.5);
            rickMorty.Episodes = new List<Episode>();
            rickMorty.Episodes.Add(episode1);
            rickMorty.Episodes.Add(episode2);

            _repo.AddContentToDirectory(rickMorty);
        }

        private void Menu()
        {
            //continues to run program
            bool continueToRun = true;

            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Update existing streaming content\n" +
                    "5. Remove streaming content\n" +
                    "6. Exit menu\n");

                //user response
                string userChoice = _console.ReadLine();

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
                        //UpdateExistingContent();
                        break;
                    case "5":
                        //Delete content
                        //DeleteContent();
                        break;
                    case "6":
                        //Exit menu
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please choose a valid option");
                        _console.ReadKey();
                        //Not valid input
                        break;
                }
            }
        }

        public void ShowAllContent()
        {
            _console.Clear();

            List<StreamingContentBase> listOfContent = _repo.GetContents();

            foreach (StreamingContentBase content in listOfContent)
            {
                DisplayContent(content);
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        public void DisplayContent(StreamingContentBase content)
        {
            if (content.GetType().Name == "Movie")
            {
                _console.WriteLine("======Movie======");
                _console.WriteLine(((Movie)content).RunTime);
            }

            if(content.GetType().Name == "Show")
            {
                _console.WriteLine("======Show======");
                Show show = (Show)content;
                _console.WriteLine($"Episodes: {show.EpisodeCount}");
                List<Episode> episodes = show.Episodes;
                foreach(Episode episode in episodes)
                {
                    _console.WriteLine(episode.Title);
                }
            }
            //Display Content
            int multiplier = 20;
            string division = String.Concat(Enumerable.Repeat("*", multiplier));
            _console.WriteLine(division);
            _console.WriteLine($"Title: {content.Title}");
            _console.WriteLine($"Description: {content.Description}");
            _console.WriteLine($"Star-rating: {content.StarRating}");
            _console.WriteLine($"Genre: {content.Genre}");
            _console.WriteLine($"Maturity Rating: {content.MaturityRating}");
            _console.WriteLine($"Is family friendly?: {content.IsFamilyFriendly}");
            _console.WriteLine(division);
        }

        public void GetContentByTitle()
        {
            _console.Clear();

            _console.WriteLine("Enter the title of the content you'd like to see: ");
            string title = _console.ReadLine();

            StreamingContentBase content = _repo.GetContentByTitle(title);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                _console.WriteLine("That title doesn't exist.");
            }

            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        public void CreateNewContent()
        {
            _console.Clear();

            //instantiate empty StreamingContentBase object
            StreamingContentBase newContent = new StreamingContentBase();

            //get user input
            _console.WriteLine("Enter a title:");
            newContent.Title = _console.ReadLine();

            _console.WriteLine("Enter a description:");
            newContent.Description = _console.ReadLine();

            _console.WriteLine("Enter a rating (1.0 - 10.0):");
            string ratingAsString = _console.ReadLine();
            double ratingAsDouble = double.Parse(ratingAsString);
            newContent.StarRating = ratingAsDouble;

            _console.WriteLine("Select a genre:");
            _console.WriteLine(" 1.Horror\n 2.RomCom\n 3.SciFi\n 4.Action\n 5.Documentary\n 6.Musical\n" +
                " 7.Drama\n 8.Mystery\n");
            string genreInput = _console.ReadLine();
            int genreInt = Int32.Parse(genreInput);
            //cast the genre
            newContent.Genre = (Genre)(genreInt - 1);

            _console.WriteLine("Select a Maturity Rating:");
            _console.WriteLine("1.G\n 2.PG\n 3.PG_13\n 4.R\n 5.NC_17\n");

            string maturityRating = _console.ReadLine();

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
            if (wasAdded)
            {
                _console.WriteLine("Content successfully added");
            }
            else
            {
                _console.WriteLine("Oops! Something went wrong, not added.");
            }

            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }
    }
}
