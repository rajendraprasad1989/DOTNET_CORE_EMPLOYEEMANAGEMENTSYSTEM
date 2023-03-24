using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebNetCoreAPIClass9.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_NETCORE_EMPLOYEE",
                columns: table => new
                {
                    Employee_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email_Id = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NETCORE_EMPLOYEE", x => x.Employee_Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_NETCORE_EMPLOYEE_LEAVES",
                columns: table => new
                {
                    Leave_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Employee_Id = table.Column<int>(nullable: false),
                    Total_Leaves = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_NETCORE_EMPLOYEE_LEAVES", x => x.Leave_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_NETCORE_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "TBL_NETCORE_EMPLOYEE_LEAVES");
        }
    }
}
