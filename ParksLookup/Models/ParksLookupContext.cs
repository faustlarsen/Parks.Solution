using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
            new Park { ParkId = 1, Name = "Saguaro", State = "Arizona", Type = "National Park", Description = "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities." },

            new Park { ParkId = 2, Name = "Grand Canyon", State = "Arizona", Type = "National Park", Description = "The Grand Canyon, carved by the mighty Colorado River. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls." },

            new Park { ParkId = 3, Name = "Petrified Forest", State = "Arizona", Type = "National Park", Description = "This portion of the Chinle Formation has a large concentration of 225-million-year-old petrified wood. Dinosaur fossils and over 350 Native American sites are protected in this park" },

            new Park { ParkId = 4, Name = "Glacier Bay", State = "Alaska", Type = "National Park", Description = "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles." },

            new Park { ParkId = 5, Name = "Catalina State Park", State = "Arizona", Type = "State Park", Description = "Preserves a diverse desert landscape at the foot of the Santa Catalina Mountains." },

            new Park { ParkId = 6, Name = "Coral Pink Sand Dunes", State = "Utah", Type = "State Park", Description = "Preserves the only dune field on the Colorado Plateau, with a unique color caused by iron oxides and minerals in the Navajo sandstone." },

            new Park { ParkId = 7, Name = "Angel Island State Park", State = "California", Type = "State Park", Description = "Interprets an island in San Francisco Bay whose history encompasses Coast Miwok prehistory, ranching, the 1910–1940 Angel Island Immigration Station, and long military use." },

            new Park { ParkId = 8, Name = "Catharine Valley Trail", State = "New York", Type = "State Park", Description = "Encompasses a planned 12-mile (19 km) recreation trail that follows abandoned railroad grades and canal towpaths between Watkins Glen and Horseheads." },

            new Park { ParkId = 9, Name = "Acadia", State = "Maine", Type = "National Park", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes." },

            new Park { ParkId = 10, Name = "Biscayne", State = "Florida", Type = "National Park", Description = "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs." }
        );
    }
  }
}