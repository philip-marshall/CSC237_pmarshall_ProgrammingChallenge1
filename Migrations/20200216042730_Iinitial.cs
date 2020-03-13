using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_pmarshall_ProgrammingChallenge1.Migrations
{
    public partial class Iinitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 27, 29, 440, DateTimeKind.Local).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 27, 29, 444, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 27, 29, 444, DateTimeKind.Local).AddTicks(4535));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 24, 5, 666, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 24, 5, 671, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 2, 15, 21, 24, 5, 671, DateTimeKind.Local).AddTicks(9447));
        }
    }
}
