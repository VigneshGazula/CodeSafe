using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShareItems_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AlterFilePathColumnNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Make FilePath column nullable to support Cloudinary storage
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "NoteFiles",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert FilePath column to NOT NULL
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "NoteFiles",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
