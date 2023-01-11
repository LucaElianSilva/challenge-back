using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace challengeback.Migrations
{
    /// <inheritdoc />
    public partial class AddProductosSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Categoria", "FechaCarga", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, (byte)0, new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6371), "Prod 1", 5 },
                    { 2, (byte)1, new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6387), "Prod 2", 10 },
                    { 3, (byte)0, new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6388), "Prod 3", 15 },
                    { 4, (byte)1, new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6390), "Prod 4", 20 },
                    { 5, (byte)0, new DateTime(2023, 1, 11, 5, 12, 4, 177, DateTimeKind.Local).AddTicks(6391), "Prod 5", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
