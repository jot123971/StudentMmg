using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;

namespace StudentMmg.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrol_Course_CourseID",
                table: "Enrol");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrol_Student_Student_ObjStudentID",
                table: "Enrol");

            migrationBuilder.DropIndex(
                name: "IX_Enrol_Student_ObjStudentID",
                table: "Enrol");

            migrationBuilder.DropColumn(
                name: "Course_ID",
                table: "Enrol");

            migrationBuilder.DropColumn(
                name: "Student_ID",
                table: "Enrol");

            migrationBuilder.DropColumn(
                name: "Student_ObjStudentID",
                table: "Enrol");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrol",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Enrol",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrol_StudentID",
                table: "Enrol",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrol_Course_CourseID",
                table: "Enrol",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrol_Student_StudentID",
                table: "Enrol",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
            var sqlFile = Path.Combine(".\\Database", @"script.sql");

            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrol_Course_CourseID",
                table: "Enrol");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrol_Student_StudentID",
                table: "Enrol");

            migrationBuilder.DropIndex(
                name: "IX_Enrol_StudentID",
                table: "Enrol");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Enrol");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "Enrol",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Course_ID",
                table: "Enrol",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Student_ID",
                table: "Enrol",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Student_ObjStudentID",
                table: "Enrol",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrol_Student_ObjStudentID",
                table: "Enrol",
                column: "Student_ObjStudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrol_Course_CourseID",
                table: "Enrol",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrol_Student_Student_ObjStudentID",
                table: "Enrol",
                column: "Student_ObjStudentID",
                principalTable: "Student",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
