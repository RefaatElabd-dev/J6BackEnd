using Microsoft.EntityFrameworkCore.Migrations;

namespace J6BackEnd.Migrations
{
    public partial class inii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "prod_order");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "prod_order",
                type: "int",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "productId",
                table: "prod_order",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "prod_order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
