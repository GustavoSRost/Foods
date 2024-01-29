using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanche.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesPopulate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description)" + "VALUES('Normal', 'Lanche normal')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description)" + "VALUES('Normal', 'Lanche normal')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description)" + "VALUES('Normal', 'Lanche normal')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description)" + "VALUES('Normal', 'Lanche normal')");
            migrationBuilder.Sql("INSERT INTO Categories(Name, Description)" + "VALUES('Normal', 'Lanche normal')");




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
