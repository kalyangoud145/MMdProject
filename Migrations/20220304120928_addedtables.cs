using Microsoft.EntityFrameworkCore.Migrations;

namespace MMMMedia.Migrations
{
    public partial class addedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesignationMaster",
                columns: table => new
                {
                    DesignationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignationName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignationMaster", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMaster",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMaster", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_EmployeeMaster_DesignationMaster_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "DesignationMaster",
                        principalColumn: "DesignationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_DesignationId",
                table: "EmployeeMaster",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_Email",
                table: "EmployeeMaster",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_EmployeeNo",
                table: "EmployeeMaster",
                column: "EmployeeNo",
                unique: true,
                filter: "[EmployeeNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeMaster_Mobile",
                table: "EmployeeMaster",
                column: "Mobile",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeMaster");

            migrationBuilder.DropTable(
                name: "DesignationMaster");
        }
    }
}
