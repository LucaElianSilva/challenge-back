using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace challengeback.Migrations
{
    /// <inheritdoc />
    public partial class addPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Personas",
                columns: new[] { "Id", "Apellido", "Documento", "Edad", "Nombre", "Sexo" },
                values: new object[,]
                {
                    { 1, "Silva", "42901989", 22, "Luca", (byte)0 },
                    { 2, "Watson", "4564546", 27, "Emma", (byte)1 },
                    { 3, "Silva", "42901989", 19, "Ciro", (byte)0 },
                    { 4, "Anastacia", "4564233", 18, "Micaela", (byte)1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
