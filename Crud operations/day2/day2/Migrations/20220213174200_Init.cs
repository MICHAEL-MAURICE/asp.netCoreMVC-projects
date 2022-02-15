using Microsoft.EntityFrameworkCore.Migrations;

namespace day2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    min_Degree = table.Column<int>(type: "int", nullable: false),
                    dept_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_courses_departments_dept_Id",
                        column: x => x.dept_Id,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "trainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainee_departments_dept_Id",
                        column: x => x.dept_Id,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "instuctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    dept_Id = table.Column<int>(type: "int", nullable: false),
                    crs_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instuctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_instuctors_courses_crs_Id",
                        column: x => x.crs_Id,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_instuctors_departments_dept_Id",
                        column: x => x.dept_Id,
                        principalTable: "departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "crsResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(type: "int", nullable: false),
                    crs_ID = table.Column<int>(type: "int", nullable: false),
                    trainee_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crsResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_crsResults_courses_crs_ID",
                        column: x => x.crs_ID,
                        principalTable: "courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_crsResults_trainee_trainee_ID",
                        column: x => x.trainee_ID,
                        principalTable: "trainee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_courses_dept_Id",
                table: "courses",
                column: "dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_crsResults_crs_ID",
                table: "crsResults",
                column: "crs_ID");

            migrationBuilder.CreateIndex(
                name: "IX_crsResults_trainee_ID",
                table: "crsResults",
                column: "trainee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_instuctors_crs_Id",
                table: "instuctors",
                column: "crs_Id");

            migrationBuilder.CreateIndex(
                name: "IX_instuctors_dept_Id",
                table: "instuctors",
                column: "dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_trainee_dept_Id",
                table: "trainee",
                column: "dept_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "crsResults");

            migrationBuilder.DropTable(
                name: "instuctors");

            migrationBuilder.DropTable(
                name: "trainee");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
