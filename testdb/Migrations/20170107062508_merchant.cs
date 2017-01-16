using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testdb.Migrations
{
    public partial class merchant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Students",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Student_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Student_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Student",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");
        }
    }
}
