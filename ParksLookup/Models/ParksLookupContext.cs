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
            new Park { ParkId = 1, Name = "Saguaro", State = "Arizona", Description = "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities." },
            new Park { ParkId = 2, Name = "Grand Canyon", State = "Arizona", Description = "The Grand Canyon, carved by the mighty Colorado River. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls." },
            new Park { ParkId = 3, Name = "Petrified Forest", State = "Arizona", Description = "This portion of the Chinle Formation has a large concentration of 225-million-year-old petrified wood. Dinosaur fossils and over 350 Native American sites are protected in this park" },
            new Park { ParkId = 4, Name = "Glacier Bay", State = "Alaska", Description = "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles." },
            new Park { ParkId = 5, Name = "White Sands", State = "New Mexico", Description = "Located in the mountain-ringed Tularosa Basin, White Sands consists of the southern part of a 275-square-mile (710 km2) field of white sand dunes composed of gypsum crystals—the world's largest gypsum dunefield. " },
            new Park { ParkId = 6, Name = "Wind Cave", State = "South Dakota", Description = "Wind Cave is distinctive for its calcite fin formations called boxwork, a unique formation rarely found elsewhere, and needle-like growths called frostwork. The cave is one of the longest and most complex caves in the world." },
            new Park { ParkId = 7, Name = "Shenandoah", State = "Virginia", Description = "Shenandoah's Blue Ridge Mountains are covered by hardwood forests that teem with a wide variety of wildlife. The Skyline Drive and Appalachian Trail run the entire length of this narrow park, passing scenic overlooks and cataracts of the Shenandoah River." },
            new Park { ParkId = 8, Name = "Zion", State = "Utah", Description = "Located at the junction of the Colorado Plateau, Great Basin, and Mojave Desert, this park contains sandstone features such as mesas, rock towers, and canyons, including the Virgin River Narrows." },
            new Park { ParkId = 9, Name = "Acadia", State = "Maine", Description = "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes." },
            new Park { ParkId = 10, Name = "Biscayne", State = "Florida", Description = "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs." }
        );
    }
  }
}