using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapiService swapi = new SwapiService();

            Console.WriteLine("Select which character you'd like to see.");
            Console.WriteLine("1. Luke Skywalker");
            Console.WriteLine("2. C3PO");
            Console.WriteLine("3. R2-D2");
            Console.WriteLine("4. Darth Vader");
            Console.WriteLine("5. Leia Organa");

            string choice = Console.ReadLine();

            int response = Int32.Parse(choice);

            Person person = swapi.GetPerson(response).Result;

            GetAllProperties(person);
            Console.ReadKey();
        }

        public static void GetAllProperties(Person person)//helper method
        {
            SwapiService swapi = new SwapiService();

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Hair color: {person.Hair_Color}");
            Console.WriteLine($"Height: {person.Height}");
            Console.WriteLine($"Mass: {person.Mass}");
            Console.WriteLine(person.Homeworld);
            Console.WriteLine($"Birth year: {person.Birth_Year}");
            Console.WriteLine($"Gender: {person.Gender}");
            Console.WriteLine($"Eye color: {person.Eye_Color}");
            Console.WriteLine($"Skin color: {person.Skin_Color}");
            //species
            Console.WriteLine("----Species-----");
            foreach (string sp in person.Species)
            {
                Species species = swapi.GetSpecies(sp).Result;
                Console.WriteLine(species.name);
                Console.WriteLine(species.language);
            }
            //vehicles
            Console.WriteLine("-------Vehicles----");
            foreach (string v in person.Vehicles)
            {
                Vehicle vehicle = swapi.GetVehicle(v).Result;
                Console.WriteLine(vehicle.name);
                Console.WriteLine(vehicle.model);
            }
            //films
            Console.WriteLine("----Films-----");
            foreach (string film in person.Films)
            {
                Films films = swapi.GetFilm(film).Result;
                Console.WriteLine(films.Title);
                /*Console.WriteLine(films.Opening_Crawl)*/;
            }
            Console.WriteLine("------------");
            Console.WriteLine("-----Starships-----");
            foreach (string starship in person.Starships)
            {
                Starship ship = swapi.GetStarship(starship).Result;
                Console.WriteLine(ship.Name);
            }
            Console.WriteLine("-------");
            Console.WriteLine(person.Created);
            Console.WriteLine(person.Edited);
            Console.WriteLine(person.Url);
        }

    }
}
