using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Parks",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Split into the separate Rincon Mountain and Tucson Mountain districts, this park is evidence that the dry Sonoran Desert is still home to a great variety of life spanning six biotic communities.", "Saguaro", "Arizona", "National Park" },
                    { 2, "The Grand Canyon, carved by the mighty Colorado River. Millions of years of erosion have exposed the multicolored layers of the Colorado Plateau in mesas and canyon walls.", "Grand Canyon", "Arizona", "National Park" },
                    { 3, "This portion of the Chinle Formation has a large concentration of 225-million-year-old petrified wood. Dinosaur fossils and over 350 Native American sites are protected in this park", "Petrified Forest", "Arizona", "National Park" },
                    { 4, "Glacier Bay contains tidewater glaciers, mountains, fjords, and a temperate rainforest, and is home to large populations of grizzly bears, mountain goats, whales, seals, and eagles.", "Glacier Bay", "Alaska", "National Park" },
                    { 5, "Preserves a diverse desert landscape at the foot of the Santa Catalina Mountains.", "Catalina State Park", "Arizona", "State Park" },
                    { 6, "Preserves the only dune field on the Colorado Plateau, with a unique color caused by iron oxides and minerals in the Navajo sandstone.", "Coral Pink Sand Dunes", "Utah", "State Park" },
                    { 7, "Interprets an island in San Francisco Bay whose history encompasses Coast Miwok prehistory, ranching, the 1910–1940 Angel Island Immigration Station, and long military use.", "Angel Island State Park", "California", "State Park" },
                    { 8, "Encompasses a planned 12-mile (19 km) recreation trail that follows abandoned railroad grades and canal towpaths between Watkins Glen and Horseheads.", "Catharine Valley Trail", "New York", "State Park" },
                    { 9, "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes.", "Acadia", "Maine", "National Park" },
                    { 10, "Located in Biscayne Bay, this park at the north end of the Florida Keys has four interrelated marine ecosystems: mangrove forest, the Bay, the Keys, and coral reefs.", "Biscayne", "Florida", "National Park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Parks");
        }
    }
}
