using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class NewDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistConcert_Person_ArtistsId",
                table: "ArtistConcert");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistGenre_Person_ArtistsId",
                table: "ArtistGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Person_PersonId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "People");

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PersonComment",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonComment", x => new { x.PersonId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_PersonComment_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonComment_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonComment_CommentId",
                table: "PersonComment",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistConcert_People_ArtistsId",
                table: "ArtistConcert",
                column: "ArtistsId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistGenre_People_ArtistsId",
                table: "ArtistGenre",
                column: "ArtistsId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistConcert_People_ArtistsId",
                table: "ArtistConcert");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistGenre_People_ArtistsId",
                table: "ArtistGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_People_PersonId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "PersonComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.RenameTable(
                name: "People",
                newName: "Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => new { x.PersonId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_Like_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Like_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Like_CommentId",
                table: "Like",
                column: "CommentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistConcert_Person_ArtistsId",
                table: "ArtistConcert",
                column: "ArtistsId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistGenre_Person_ArtistsId",
                table: "ArtistGenre",
                column: "ArtistsId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Person_PersonId",
                table: "Comments",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
