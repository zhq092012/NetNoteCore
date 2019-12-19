using Microsoft.EntityFrameworkCore.Migrations;

namespace NetNote.Migrations
{
    public partial class NotePassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_NoteTypes_TypeId",
                table: "Notes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Notes",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_NoteTypes_TypeId",
                table: "Notes",
                column: "TypeId",
                principalTable: "NoteTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_NoteTypes_TypeId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Notes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_NoteTypes_TypeId",
                table: "Notes",
                column: "TypeId",
                principalTable: "NoteTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
