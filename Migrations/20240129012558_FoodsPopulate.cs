using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanche.Migrations
{
    /// <inheritdoc />
    public partial class FoodsPopulate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(1, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',0, 0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(1, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',0,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(2, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',1,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(1, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',1,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(3, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',1,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(4, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',1,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(1, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',0,0)");
            migrationBuilder.Sql("INSERT INTO Foods(CategoryId, Name, Description, Price, Image, IsAvailable, Favorite)" + "VALUES(2, 'Lanche muito comum', 'Lanche muito comum mesmo', '10.5', 'lanchecomum',1,1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Foods");

        }
    }
}
