using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TxArt.GoldenNews.Data.Migrations
{
    /// <inheritdoc />
    public partial class addaprovadotocomentarioTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Aprovado",
                table: "Comentario",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aprovado",
                table: "Comentario");
        }
    }
}
