using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_pmarshall_ProgrammingChallenge1.Migrations
{
    public partial class CategoryDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 31, 44, 285, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 31, 44, 288, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 31, 44, 288, DateTimeKind.Local).AddTicks(5441));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 27, 56, 95, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 27, 56, 97, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 2, 16, 14, 27, 56, 97, DateTimeKind.Local).AddTicks(7901));
        }
    }
}
