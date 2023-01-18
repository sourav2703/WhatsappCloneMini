using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Asp.NetChatingWebsite.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MsgTable1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SentOn2 = table.Column<DateTime>(nullable: false),
                    Name2 = table.Column<string>(nullable: true),
                    Message2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MsgTable1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MsgTable1");
        }
    }
}
