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
    public class StateParksController : ControllerBase
    {
        private ParksLookupContext _db;
        public StateParksController(ParksLookupContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<StatePark>> Get(string name, string state, string type, bool random)
        {
            var query = _db.StateParks.AsQueryable();
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
                List<StatePark> returnedId = _db.StateParks.ToList();

                int randomPark = rndm.Next(1,5);
                query = query.Where(entry => entry.StateParkId == randomPark);
                
            }
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<StatePark> Get(int id)
        {
            return _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
        }

        [HttpPost]
        public void Post([FromBody] StatePark park)
        {
            _db.StateParks.Add(park);
            _db.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] StatePark park)
        {
            park.StateParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            StatePark parkToDelete = _db.StateParks.FirstOrDefault(entry => entry.StateParkId == id);
            _db.StateParks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}
