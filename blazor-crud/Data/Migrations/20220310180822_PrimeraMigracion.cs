using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazor_crud.Data.Migrations
{
    public partial class PrimeraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Chasis = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<string>(type: "TEXT", nullable: false),
                    Comentario = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 1, "Chasis 1", "Color 1", "Comentario 1", "Foto 1", "Marca 1", "Modelo 1", "Year 1" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 2, "Chasis 2", "Color 2", "Comentario 2", "Foto 2", "Marca 2", "Modelo 2", "Year 2" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 3, "Chasis 3", "Color 3", "Comentario 3", "Foto 3", "Marca 3", "Modelo 3", "Year 3" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 4, "Chasis 4", "Color 4", "Comentario 4", "Foto 4", "Marca 4", "Modelo 4", "Year 4" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 5, "Chasis 5", "Color 5", "Comentario 5", "Foto 5", "Marca 5", "Modelo 5", "Year 5" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Chasis", "Color", "Comentario", "Foto", "Marca", "Modelo", "Year" },
                values: new object[] { 6, "Chasis 6", "Color 6", "Comentario 6", "Foto 6", "Marca 6", "Modelo 6", "Year 6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
