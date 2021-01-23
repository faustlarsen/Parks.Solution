using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<NationalPark> NationalParks { get; set; }
    public DbSet<StatePark> StateParks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<NationalPark>()
        .HasData(
            new NationalPark { NationalParkId = 1, Name = "Saguaro", State = "Arizona", Type = "National Park", Description = "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities." },
            new NationalPark { NationalParkId = 2, Name = "Grand Canyon", State = "Arizona", Type = "National Park", Description = "The Grand Canyon, carved by the mighty Colorado River. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls." },
            new NationalPark { NationalParkId = 3, Name = "Glacier Bay", State = "Alaska", Type = "National Park", Description = "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles." },
            new NationalPark { NationalParkId = 4, Name = "Acadia", State = "Maine", Type = "National Park", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes." },
            new NationalPark { NationalParkId = 5, Name = "Biscayne", State = "Florida", Type = "National Park", Description = "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs." } 
      );
      builder.Entity<StatePark>()
        .HasData(
            new StatePark { StateParkId = 1, Name = "Catalina State Park", State = "Arizona", Type = "State Park", Description = "Preserves a diverse desert landscape at the foot of the Santa Catalina Mountains." },
            new StatePark { StateParkId = 2, Name = "Coral Pink Sand Dunes", State = "Utah", Type = "State Park", Description = "Preserves the only dune field on the Colorado Plateau, with a unique color caused by iron oxides and minerals in the Navajo sandstone." },
            new StatePark { StateParkId = 3, Name = "Angel Island State Park", State = "California", Type = "State Park", Description = "Interprets an island in San Francisco Bay whose history encompasses Coast Miwok prehistory, ranching, the 1910–1940 Angel Island Immigration Station, and long military use." },
            new StatePark { StateParkId = 4, Name = "Catharine Valley Trail", State = "New York", Type = "State Park", Description = "Encompasses a planned 12-mile (19 km) recreation trail that follows abandoned railroad grades and canal towpaths between Watkins Glen and Horseheads." },
            new StatePark { StateParkId = 5, Name = "Baxter State Park", State = "Maine", Type = "State Park", Description = "Not only is this sprawling 200,000-acre park home to Northern Maine's beloved Mount Katahdin, it's also the domain of a killer variety of wildlife, from hawks to black bears who make their home amid the park's peaceful lakes and waterfalls." }
      );
    }
  }
}