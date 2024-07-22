using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstAPI.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Bananinha', 'Cachaça doce', 'https://littlebanana.logo.jpg', '" + DateTime.Now.ToString() +"', 79, 1, 2)");
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Amarula', 'Cachaça de chocolate', 'https://amarula.logo.jpg', '" + DateTime.Now.ToString() + "', 121, 1, 2)");
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Pastelão', 'Big pastel from ChinaBrasil', 'https://pasta.logo.jpg', '" + DateTime.Now.ToString() + "', 5, 2, 2)");
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Torta', 'A piece of torta from ChinaBrasil', 'https://torta.logo.jpg', '" + DateTime.Now.ToString() + "', 6, 2, 2)");
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Fondue', 'MINHA NOSSA SENHORA COMO EU AMO FUDE', 'https://xxx.logo.jpg', '" + DateTime.Now.ToString() + "', 666, 3, 2)");
            mb.Sql("insert into Product(Name, Description, ImageUrl, CreationDate, Value, CategoryId, Stock) values ('Carrot Cake', 'EH O BOLO DE CENOURA DO MURINHA NE MEO', 'https://carrot.logo.jpg', '" + DateTime.Now.ToString() + "', 1000, 3, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete From Products");
        }
    }
}
