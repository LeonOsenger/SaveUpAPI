using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaveUpAPI.Migrations
{
    /// <inheritdoc />
    public partial class GeneratedValueId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__Products__3214EC27CC8CE770",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Products__3214EC27CC8CE770",
                table: "Products",
                column: "ID");
        }
    }
}
