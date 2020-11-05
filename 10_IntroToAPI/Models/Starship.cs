using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI.Models
{
	/*
     * {
	"name": "X-wing",
	"model": "T-65 X-wing",
	"manufacturer": "Incom Corporation",
	"cost_in_credits": "149999",
	"length": "12.5",
	"max_atmosphering_speed": "1050",
	"crew": "1",
	"passengers": "0",
	"cargo_capacity": "110",
	"consumables": "1 week",
	"hyperdrive_rating": "1.0",
	"MGLT": "100",
	"starship_class": "Starfighter",
	"pilots": [
		"http://swapi.dev/api/people/1/",
		"http://swapi.dev/api/people/9/",
		"http://swapi.dev/api/people/18/",
		"http://swapi.dev/api/people/19/"
	],
	"films": [
		"http://swapi.dev/api/films/1/",
		"http://swapi.dev/api/films/2/",
		"http://swapi.dev/api/films/3/"
	],
	"created": "2014-12-12T11:19:05.340000Z",
	"edited": "2014-12-20T21:23:49.886000Z",
	"url": "http://swapi.dev/api/starships/12/"
}
     */
	public class Starship
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Cost_In_Credits { get; set; }
        public string Length { get; set; }
        public string Max_Atmosphering_Speed { get; set; }
        public string Crew { get; set; }
        public string Passengers { get; set; }
        public string Cargo_Capacity { get; set; }
        public string Consumables { get; set; }
        public string Hyperdrive_Rating { get; set; }
        public string MGLT { get; set; }
        public string Starship_Class { get; set; }
        public List<string> Pilots { get; set; }
        public List<string> Films { get; set; }
        public string Created { get; set; }
        public string Edited { get; set; }
        public string Url { get; set; }
    }
}
