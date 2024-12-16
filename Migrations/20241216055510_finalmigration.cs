using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingBlog.Migrations
{
    /// <inheritdoc />
    public partial class finalmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Hash", "LastName", "Salt" },
                values: new object[] { "linkwithpurna@gmail.com", "Purna", "yeaghakshencdsskkokwwrnds/=", "Lungeli", "uthedggdggsgs" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "Hash", "LastName", "Salt" },
                values: new object[] { "abhayprince@outlook.com", "Abhay", "dfhkhsdskdfffgfjgfjgkdfhjgkdf/=", "Prince", "dshfksdhfk" });
        }
    }
}
