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
    public class ParksController : ControllerBase
    {
        private ParksLookupContext _db;
        public ParksController(ParksLookupContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string name, string state, string type, bool random)
        {
            var query = _db.Parks.AsQueryable();
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
                List<Park> returnedId = _db.Parks.ToList();

                int randomPark = rndm.Next(1,10);
                query = query.Where(entry => entry.ParkId == randomPark);
                
            }
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Park parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
