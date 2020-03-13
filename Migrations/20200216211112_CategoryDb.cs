using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSC237_pmarshall_ProgrammingChallenge1.Migrations
{
    public partial class CategoryDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Work" },
                    { 2, "Friend" },
                    { 3, "Family" },
                    { 4, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 1,
                columns: new[] { "CategoryId", "DateAdded" },
                values: new object[] { 3, new DateTime(2020, 2, 16, 14, 11, 12, 260, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 2,
                columns: new[] { "CategoryId", "DateAdded" },
                values: new object[] { 3, new DateTime(2020, 2, 16, 14, 11, 12, 263, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "ContactId",
                keyValue: 3,
                columns: new[] { "CategoryId", "DateAdded" },
                values: new object[] { 1, new DateTime(2020, 2, 16, 14, 11, 12, 263, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_CategoryId",
                table: "Contact",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Category_CategoryId",
                table: "Contact");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_CategoryId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "ContactId");

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
    }
}
