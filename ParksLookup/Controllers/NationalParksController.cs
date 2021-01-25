using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookup.Models;

namespace ParksLookup.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalParksController : ControllerBase
    {
        private ParksLookupContext _db;
        public NationalParksController(ParksLookupContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<NationalPark>> Get(string name, string state, string type, bool random)
        {
            var query = _db.NationalParks.AsQueryable();
            if (name != null)
            {
                query = query.Where(entry => entry.Name == name);
            }
            if (state != null)
            {
                query = query.Where(entry => entry.State == state);
            }
            if (type != null)
            {
                query = query.Where(entry => entry.Type == type);
            }
            if (random != false)
            {
                Random rndm = new Random();
                List<NationalPark> returnedId = _db.NationalParks.ToList();

                int randomPark = rndm.Next(1,_db.NationalParks.Count());
                query = query.Where(entry => entry.NationalParkId == randomPark);
                
            }
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<NationalPark> Get(int id)
        {
            return _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
        }

        [HttpPost]
        public void Post([FromBody] NationalPark park)
        {
            _db.NationalParks.Add(park);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] NationalPark park)
        {
            park.NationalParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            NationalPark parkToDelete = _db.NationalParks.FirstOrDefault(entry => entry.NationalParkId == id);
            _db.NationalParks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
