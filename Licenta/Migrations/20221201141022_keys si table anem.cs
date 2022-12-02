using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class keyssitableanem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partners_Levels_LevelId",
                table: "Partners");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Voluntarys_AspNetUsers_VolunteerId",
                table: "User_Voluntarys");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Voluntarys_Voluntarys_VoluntaryId",
                table: "User_Voluntarys");

            migrationBuilder.DropForeignKey(
                name: "FK_Voluntarys_AspNetUsers_CompanyId",
                table: "Voluntarys");

            migrationBuilder.DropForeignKey(
                name: "FK_Voluntarys_Locations_LocationId",
                table: "Voluntarys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User_Voluntarys",
                table: "User_Voluntarys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partners",
                table: "Partners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Voluntarys",
                table: "Voluntarys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Levels",
                table: "Levels");

            migrationBuilder.RenameTable(
                name: "User_Voluntarys",
                newName: "user_voluntarys");

            migrationBuilder.RenameTable(
                name: "Partners",
                newName: "partners");

            migrationBuilder.RenameTable(
                name: "Voluntarys",
                newName: "voluntary");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "location");

            migrationBuilder.RenameTable(
                name: "Levels",
                newName: "level");

            migrationBuilder.RenameIndex(
                name: "IX_User_Voluntarys_VolunteerId",
                table: "user_voluntarys",
                newName: "IX_user_voluntarys_VolunteerId");

            migrationBuilder.RenameIndex(
                name: "IX_User_Voluntarys_VoluntaryId",
                table: "user_voluntarys",
                newName: "IX_user_voluntarys_VoluntaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Partners_LevelId",
                table: "partners",
                newName: "IX_partners_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_Voluntarys_LocationId",
                table: "voluntary",
                newName: "IX_voluntary_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Voluntarys_CompanyId",
                table: "voluntary",
                newName: "IX_voluntary_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_voluntarys",
                table: "user_voluntarys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_partners",
                table: "partners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_voluntary",
                table: "voluntary",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_location",
                table: "location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_level",
                table: "level",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_partners_level_LevelId",
                table: "partners",
                column: "LevelId",
                principalTable: "level",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_voluntarys_AspNetUsers_VolunteerId",
                table: "user_voluntarys",
                column: "VolunteerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_voluntarys_voluntary_VoluntaryId",
                table: "user_voluntarys",
                column: "VoluntaryId",
                principalTable: "voluntary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_voluntary_AspNetUsers_CompanyId",
                table: "voluntary",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_voluntary_location_LocationId",
                table: "voluntary",
                column: "LocationId",
                principalTable: "location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_partners_level_LevelId",
                table: "partners");

            migrationBuilder.DropForeignKey(
                name: "FK_user_voluntarys_AspNetUsers_VolunteerId",
                table: "user_voluntarys");

            migrationBuilder.DropForeignKey(
                name: "FK_user_voluntarys_voluntary_VoluntaryId",
                table: "user_voluntarys");

            migrationBuilder.DropForeignKey(
                name: "FK_voluntary_AspNetUsers_CompanyId",
                table: "voluntary");

            migrationBuilder.DropForeignKey(
                name: "FK_voluntary_location_LocationId",
                table: "voluntary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_voluntarys",
                table: "user_voluntarys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_partners",
                table: "partners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_voluntary",
                table: "voluntary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_location",
                table: "location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_level",
                table: "level");

            migrationBuilder.RenameTable(
                name: "user_voluntarys",
                newName: "User_Voluntarys");

            migrationBuilder.RenameTable(
                name: "partners",
                newName: "Partners");

            migrationBuilder.RenameTable(
                name: "voluntary",
                newName: "Voluntarys");

            migrationBuilder.RenameTable(
                name: "location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "level",
                newName: "Levels");

            migrationBuilder.RenameIndex(
                name: "IX_user_voluntarys_VolunteerId",
                table: "User_Voluntarys",
                newName: "IX_User_Voluntarys_VolunteerId");

            migrationBuilder.RenameIndex(
                name: "IX_user_voluntarys_VoluntaryId",
                table: "User_Voluntarys",
                newName: "IX_User_Voluntarys_VoluntaryId");

            migrationBuilder.RenameIndex(
                name: "IX_partners_LevelId",
                table: "Partners",
                newName: "IX_Partners_LevelId");

            migrationBuilder.RenameIndex(
                name: "IX_voluntary_LocationId",
                table: "Voluntarys",
                newName: "IX_Voluntarys_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_voluntary_CompanyId",
                table: "Voluntarys",
                newName: "IX_Voluntarys_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User_Voluntarys",
                table: "User_Voluntarys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partners",
                table: "Partners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Voluntarys",
                table: "Voluntarys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Levels",
                table: "Levels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Partners_Levels_LevelId",
                table: "Partners",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Voluntarys_AspNetUsers_VolunteerId",
                table: "User_Voluntarys",
                column: "VolunteerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Voluntarys_Voluntarys_VoluntaryId",
                table: "User_Voluntarys",
                column: "VoluntaryId",
                principalTable: "Voluntarys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntarys_AspNetUsers_CompanyId",
                table: "Voluntarys",
                column: "CompanyId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Voluntarys_Locations_LocationId",
                table: "Voluntarys",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
