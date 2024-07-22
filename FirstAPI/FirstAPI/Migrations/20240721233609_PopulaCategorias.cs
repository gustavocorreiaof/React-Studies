using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Category(Name, ImageUrl) values('Bebidas', 'https://bebidas.logo.jpg')");
            mb.Sql("insert into Category(Name, ImageUrl) values('Lanches', 'https://lanches.logo.jpg')");
            mb.Sql("insert into Category(Name, ImageUrl) values('Sobremesas', 'https://sobremesas.logo.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Categoy");
        }
    }
}
