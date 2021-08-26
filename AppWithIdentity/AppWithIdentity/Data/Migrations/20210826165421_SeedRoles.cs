using AppWithIdentity.Data.Extensions;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppWithIdentity.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddRole("admin");
            migrationBuilder.AddRole("operator");

            migrationBuilder.AddUserWithRoles(
                "admin@accountsapp.com",
                "Admin123!",
                new[] { "admin" });

            migrationBuilder.AddUserWithRoles(
                "operator@accountsapp.com",
                "Operator123!",
                new[] { "operator" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
