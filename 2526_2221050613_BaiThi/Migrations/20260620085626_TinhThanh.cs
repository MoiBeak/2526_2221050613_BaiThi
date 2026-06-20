using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2526_2221050613_BaiThi.Migrations
{
    /// <inheritdoc />
    public partial class TinhThanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TinhThanhs",
                columns: table => new
                {
                    MaTinh = table.Column<string>(type: "TEXT", nullable: false),
                    TenTinh = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanhs", x => x.MaTinh);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TinhThanhs");
        }
    }
}
