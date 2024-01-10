using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_adois.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrecoDest",
                table: "Destinos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 1,
                column: "PrecoDest",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 2,
                column: "PrecoDest",
                value: 300);

            migrationBuilder.InsertData(
                table: "Destinos",
                columns: new[] { "IdDes", "ImagemDoDestino", "NomeDoDestino", "PrecoDest" },
                values: new object[,]
                {
                    { 3, "https://wordpress-network.prod.aws.skyscnr.com/wp-content/uploads/2018/05/GettyImages-488388458.jpg", "Foz do Iguaçu", 350 },
                    { 4, "https://www.falandodeviagem.com.br/imagens22/Guaruja.jpg", "Guarujá", 100 },
                    { 5, "https://media.tacdn.com/media/attractions-splice-spp-674x446/09/93/6a/89.jpg", "Londres", 1000 },
                    { 6, "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/06/morar-em-nova-york-1170x777.jpg.webp", "Nova York", 2300 },
                    { 7, "https://www.kayak.com.br/rimg/himg/4f/2d/0e/leonardo-2672017-DPSHA_4636182078_O-333430.jpg?width=1366&height=768&crop=true", "Bali", 2000 },
                    { 8, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRq5O8R9NyYOH6bOyYwCCMj4cu7ymj6PMLd1M1ySCdUfesRAZs6_ZyM-6GVV003r8JwZO0&usqp=CAU", "Dubai", 3300 },
                    { 9, "https://blog.123milhas.com/wp-content/uploads/2023/08/brasileiros-na%CC%83o-precisam-mais-de-visto-para-turismo-no-japa%CC%83o-monte-fuji-conexa%CC%83o123.jpg", "Japão", 1500 },
                    { 10, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSo1wwNTG-MmPHGs2qVivurSlcz1LFNeYyg4BwhVwNcm2-wRWqrLwzkr5SVmEufdSQEuIg&usqp=CAU", "Veneza", 2000 },
                    { 11, "https://www.passagenspromo.com.br/blog/wp-content/uploads/2019/04/viagem-para-paris.jpg", "Paris", 1500 },
                    { 12, "https://blog.abreutur.com.br/wp-content/uploads/2022/01/CAPA_Egito.jpg", "Egito", 900 },
                    { 13, "https://www.adventureclub.com.br/wp-content/uploads/2022/06/Bali-Indonesia-topo.jpg", "Indonésia", 1500 },
                    { 14, "https://dynl.mktgcdn.com/p/PdKIFm42x4ilTlmQqIo-hn9SeaU0eEOojHALpH1XPwc/540x450.jpg", "Maldivas", 3300 },
                    { 15, "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/03/abrir-uma-empresa-na-Australia-1-2-1200x675.jpg", "Austrália", 2300 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Destinos",
                keyColumn: "IdDes",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "PrecoDest",
                table: "Destinos");
        }
    }
}
