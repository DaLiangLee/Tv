using Microsoft.EntityFrameworkCore.Migrations;

namespace Tv.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO TvNetworks (Name) VALUES ('Netflix')");
            migrationBuilder.Sql("INSERT INTO TvNetworks (Name) VALUES ('HBO')");
            migrationBuilder.Sql("INSERT INTO TvNetworks (Name) VALUES ('CBS')");
            migrationBuilder.Sql("INSERT INTO TvNetworks (Name) VALUES ('NBC')");

            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('House of Cards', (SELECT Id FROM TvNetworks WHERE Name='Netflix'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Altered Carbon', (SELECT Id FROM TvNetworks WHERE Name='Netflix'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Marvel''s Daredevil', (SELECT Id FROM TvNetworks WHERE Name='Netflix'))");

            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Game of Thrones', (SELECT Id FROM TvNetworks WHERE Name='HBO'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Silicon Valley', (SELECT Id FROM TvNetworks WHERE Name='HBO'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Veep', (SELECT Id FROM TvNetworks WHERE Name='HBO'))");

            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('NCIS', (SELECT Id FROM TvNetworks WHERE Name='CBS'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('The Big Bang Theory', (SELECT Id FROM TvNetworks WHERE Name='CBS'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Criminal Minds', (SELECT Id FROM TvNetworks WHERE Name='CBS'))");

            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Friends', (SELECT Id FROM TvNetworks WHERE Name='NBC'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Chicago Fire', (SELECT Id FROM TvNetworks WHERE Name='NBC'))");
            migrationBuilder.Sql("INSERT INTO TvShows (Name, TvNetworkId) VALUES ('Will & Grace', (SELECT Id FROM TvNetworks WHERE Name='NBC'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TvNetworks WHERE Name IN ('Netflix', 'HBO', 'CBS', 'NBC')");
        }
    }
}
