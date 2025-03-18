using Microsoft.AspNetCore.Mvc;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace GoshehArtWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;
        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public List<City> GetCities()wwwwwwwwwwwwwwwwww
        //{
        //    List<City> cities = new List<City>();
        //    cities = _context.Cities.ToList();
        //    return cities;
        //}

        //[HttpGet("create")]
        //public SelectList GetImages(int id)
        //{
        //    var cityList = new SelectList(_context.Cities, "Id", "Name");
        //    return cityList;
        //}

        //[HttpGet]
        //public List<Person> Getppl()
        //{
        //    List<Person> people = new List<Person>();
        //    people = _context.People.Include(c => c.City).ToList();
        //    return people;
        //}

        //[HttpGet("personcity")]
        //public List<Person> GetCityPeople(int id)
        //{
        //    var people = new List<Person>();

        //    people = _context.People.Include(c => c.City).ToList();
        //    return people;
        //}

        //[Authorize]
        [HttpGet("asset")]
        public List<Asset> GetAssets()
        {
            List<Asset> assets = new List<Asset>();
            assets = _context.Assets.Include(c => c.Categories).ToList();
            return assets;
        }

        [HttpGet("page")]
        public List<Page> GetPages()
        {
            List<Page> pages = new List<Page>();
            pages = _context.Pages.ToList();
            return pages;
        }
        //[HttpGet("persondetails")]
        //public IActionResult GetPeople(int id)
        //{
        //    var person = _context.People.Find(id);
        //    return person as IActionResult;
        //}

        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var person = _context.People.Find(id);
        //    if (person != null)
        //    {
        //        _context.People.Remove(person);
        //        _context.SaveChanges();
        //        return StatusCode(200);
        //    }
        //    return StatusCode(404);
        //}

        //[HttpPost("create")]
        //public IActionResult Create(JsonObject person)
        //{
        //    string jsonPerson = person.ToString();
        //    Person personToCreate = JsonConvert.DeserializeObject<Person>(jsonPerson);

        //    if (personToCreate != null)
        //    {
        //        _context.People.Add(personToCreate);
        //        _context.SaveChanges();

        //        return StatusCode(200);
        //    }
        //    return StatusCode(404);
        //}

    }
}