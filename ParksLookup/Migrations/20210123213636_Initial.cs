using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    State = table.Column<string>(maxLength: 20, nullable: false),
                    Type = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "StateParks",
                columns: table => new
                {
                    StateParkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    State = table.Column<string>(maxLength: 20, nullable: false),
                    Type = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 100000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateParks", x => x.StateParkId);
                });

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities.", "Saguaro", "Arizona", "National Park" },
                    { 2, "The Grand Canyon, carved by the mighty Colorado River. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls.", "Grand Canyon", "Arizona", "National Park" },
                    { 3, "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles.", "Glacier Bay", "Alaska", "National Park" },
                    { 4, "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes.", "Acadia", "Maine", "National Park" },
                    { 5, "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs.", "Biscayne", "Florida", "National Park" }
                });

            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Preserves a diverse desert landscape at the foot of the Santa Catalina Mountains.", "Catalina State Park", "Arizona", "State Park" },
                    { 2, "Preserves the only dune field on the Colorado Plateau, with a unique color caused by iron oxides and minerals in the Navajo sandstone.", "Coral Pink Sand Dunes", "Utah", "State Park" },
                    { 3, "Interprets an island in San Francisco Bay whose history encompasses Coast Miwok prehistory, ranching, the 1910–1940 Angel Island Immigration Station, and long military use.", "Angel Island State Park", "California", "State Park" },
                    { 4, "Encompasses a planned 12-mile (19 km) recreation trail that follows abandoned railroad grades and canal towpaths between Watkins Glen and Horseheads.", "Catharine Valley Trail", "New York", "State Park" },
                    { 5, "Not only is this sprawling 200,000-acre park home to Northern Maine's beloved Mount Katahdin, it's also the domain of a killer variety of wildlife, from hawks to black bears who make their home amid the park's peaceful lakes and waterfalls.", "Baxter State Park", "Maine", "State Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalParks");

            migrationBuilder.DropTable(
                name: "StateParks");
        }
    }
}
