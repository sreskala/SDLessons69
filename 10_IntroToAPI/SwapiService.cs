using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    public class SwapiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _baseUrl = "https://swapi.dev/api/";

        public async Task<Person> GetPerson(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(_baseUrl + "people/" + id );

            if(response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            return null;
        }

        public async Task<Starship> GetStarship(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                Starship starship = await response.Content.ReadAsAsync<Starship>();
                return starship;
            }

            return null;
        }

        public async Task<Films> GetFilm(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                Films film = await response.Content.ReadAsAsync<Films>();
                return film;
            }

            return null;
        }

        public async Task<Vehicle> GetVehicle(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Vehicle vehicle = await response.Content.ReadAsAsync<Vehicle>();
                return vehicle;
            }

            return null;
        }

        public async Task<Species> GetSpecies(string url)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                Species species = await response.Content.ReadAsAsync<Species>();
                return species;
            }

            return null;
        }
    }
}
