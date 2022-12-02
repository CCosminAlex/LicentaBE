using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class tabelamanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "Voluntarys",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "User_Voluntarys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VolunteerId = table.Column<string>(type: "text", nullable: true),
                    VoluntaryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Voluntarys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Voluntarys_AspNetUsers_VolunteerId",
                        column: x => x.VolunteerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Voluntarys_Voluntarys_VoluntaryId",
                        column: x => x.VoluntaryId,
                        principalTable: "Voluntarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voluntarys_CompanyId",
                table: "Voluntarys",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Voluntarys_VoluntaryId",
                table: "User_Voluntarys",
                column: "VoluntaryId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Voluntarys_VolunteerId",
                table: "User_Voluntarys",
                column: "VolunteerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntarys_AspNetUsers_CompanyId",
                table: "Voluntarys",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voluntarys_AspNetUsers_CompanyId",
                table: "Voluntarys");

            migrationBuilder.DropTable(
                name: "User_Voluntarys");

            migrationBuilder.DropIndex(
                name: "IX_Voluntarys_CompanyId",
                table: "Voluntarys");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Voluntarys");
        }
    }
}
