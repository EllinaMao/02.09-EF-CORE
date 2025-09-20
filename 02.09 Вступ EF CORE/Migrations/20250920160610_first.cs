using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02._09_Вступ_EF_CORE.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    orders_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    orders_create = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orders_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    orders_description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    products_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    products_cost = table.Column<double>(type: "float", nullable: false),
                    products_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    products_quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    users_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    users_lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    users_login = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    users_password = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    users_email = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
