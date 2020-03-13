using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_pmarshall_ProgrammingChallenge1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Organization = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[] { 1, new DateTime(2020, 2, 15, 21, 24, 5, 666, DateTimeKind.Local).AddTicks(3539), "james_marshall48@aol.com", "James", "Marshall", "Student", "720-965-1963" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[] { 2, new DateTime(2020, 2, 15, 21, 24, 5, 671, DateTimeKind.Local).AddTicks(9347), "philip.marshall123456789@gmail.com", "Philip", "Marshall", "Student", "720-965-5459" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "DateAdded", "Email", "FirstName", "LastName", "Organization", "Phone" },
                values: new object[] { 3, new DateTime(2020, 2, 15, 21, 24, 5, 671, DateTimeKind.Local).AddTicks(9447), "keith.howard@whatever.com", "Keith", "Howard", "Teacher", "777-777-7777" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
