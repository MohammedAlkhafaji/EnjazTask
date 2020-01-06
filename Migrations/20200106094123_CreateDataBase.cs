using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Enjaz_StackOverFlow.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Question_Id = table.Column<int>(nullable: false),
                    Comment_Date = table.Column<DateTime>(nullable: false),
                    Evaluation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Question_Date = table.Column<DateTime>(nullable: false),
                    Tag_UserName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    User_Id = table.Column<int>(nullable: false),
                    Comment_Id = table.Column<int>(nullable: false),
                    Question_Date = table.Column<DateTime>(nullable: false),
                    Evaluation = table.Column<int>(nullable: false),
                    Question_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Person_Name = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Profile_Picture = table.Column<byte[]>(nullable: true),
                    Creation_Date = table.Column<DateTime>(nullable: false),
                    Point = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question_Histories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qustion_Id = table.Column<int>(nullable: false),
                    Before_Edit = table.Column<string>(nullable: true),
                    After_Edit = table.Column<string>(nullable: true),
                    Edit_DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Histories_Questions_Qustion_Id",
                        column: x => x.Qustion_Id,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Question_Histories_Qustion_Id",
                table: "Question_Histories",
                column: "Qustion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_User_Name",
                table: "Users",
                column: "User_Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Question_Histories");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
