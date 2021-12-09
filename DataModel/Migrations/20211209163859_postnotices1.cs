using Microsoft.EntityFrameworkCore.Migrations;

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataModel.Migrations
{
    public partial class postnotices1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PubDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    Type = table.Column<string>(type: "varchar(50)", nullable: false),
                    EventDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    PubDesc = table.Column<string>(type: "varchar(400)", nullable: false),
                    Category = table.Column<string>(type: "varchar(20)", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Password = table.Column<string>(type: "varchar(100)", nullable: false),
                    PasswordCheck = table.Column<string>(type: "varchar(100)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(100)", nullable: false),
                    Brithday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 12, 9, 13, 38, 59, 429, DateTimeKind.Local).AddTicks(8406)),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ChatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserIdReceive = table.Column<int>(type: "int", nullable: false),
                    UserIdSend = table.Column<int>(type: "int", nullable: false),
                    CommentDate = table.Column<string>(type: "varchar(600)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ChatId);
                    table.ForeignKey(
                        name: "FK_Chat_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    Dislikes = table.Column<int>(type: "int", nullable: false),
                    Commentaries = table.Column<string>(type: "varchar(200)", nullable: false),
                    Description = table.Column<string>(type: "varchar(300)", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Post_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commentary",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentDesc = table.Column<string>(type: "varchar(400)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CommentDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentary", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Commentary_Post_PostId",
                        column: x => x.PostId,
                        principalTable: "Post",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commentary_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dislike",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostagemId = table.Column<int>(type: "int", nullable: false),
                    DislikeDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    PostUserId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dislike", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Dislike_Post_PostUserId",
                        column: x => x.PostUserId,
                        principalTable: "Post",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dislike_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostagemId = table.Column<int>(type: "int", nullable: false),
                    LikeDate = table.Column<string>(type: "varchar(10)", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    PostUserId = table.Column<int>(type: "int", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Like_Post_PostUserId",
                        column: x => x.PostUserId,
                        principalTable: "Post",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Like_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_UserId",
                table: "Chat",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentary_PostId",
                table: "Commentary",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Commentary_UserId1",
                table: "Commentary",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Dislike_PostUserId",
                table: "Dislike",
                column: "PostUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Dislike_UserId1",
                table: "Dislike",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Like_PostUserId",
                table: "Like",
                column: "PostUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UserId1",
                table: "Like",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserId1",
                table: "Post",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Commentary");

            migrationBuilder.DropTable(
                name: "Dislike");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Notices");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
