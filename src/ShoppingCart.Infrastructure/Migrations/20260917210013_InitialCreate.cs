using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ShoppingCart.Infrastructure.Migrations
{
  /// <inheritdoc />
  public partial class InitialCreate : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "product",
        columns: table => new
        {
          Id = table.Column<long>(type: "bigint", nullable: false)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
          Name = table.Column<string>(type: "text", nullable: false),
          Description = table.Column<string>(type: "text", nullable: true),
          Price = table.Column<long>(type: "bigint", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_product", x => x.Id);
        }
      );

      // Seed data inicial
      migrationBuilder.InsertData(
        table: "product",
        columns: new[] { "Name", "Description", "Price" },
        values: new object[,]
        {
            { "PLAY 5",          "Sony video game console",      500L },
            { "XBOX SERIES X",   "Microsoft video game console", 700L },
            { "NINTENDO SWITCH", "Nintendo video game console",  400L }
        }
      );
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "product");
    }
  }
}
