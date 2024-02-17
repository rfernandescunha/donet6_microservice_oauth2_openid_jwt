using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.Api.Migrations
{
    public partial class AddSeedDataProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "img_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Brinquedo", "Capacete do Dather Vader", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg", "Capacete Darth Vader", 350.99m },
                    { 4L, "Brinquedo", "Boneco Storm Tropper", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg", "Boneco Storm Tropper", 150m },
                    { 5L, "Camiseta", "Camiseta 100% Gamer", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg", "Camiseta 100% Gamer", 45.99m },
                    { 6L, "Camiseta", "Camiseta SpaceX", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg", "Camiseta SpaceX", 40m },
                    { 7L, "Camiseta", "Camiseta Coffee", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg", "Camiseta Coffee", 35.99m },
                    { 8L, "Blusa", "Blusa Cobra Kai", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg", "Blusa Cobra Kai", 150m },
                    { 9L, "Livro", "Livro Star Talk", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg", "Livro Star Talk", 30m },
                    { 10L, "Brinquedo", "Milennium Falcon", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg", "Milennium Falcon", 250.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}
