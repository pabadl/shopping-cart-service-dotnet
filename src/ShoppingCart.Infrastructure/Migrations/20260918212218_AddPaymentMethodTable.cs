using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ShoppingCart.Infrastructure.Migrations
{
  /// <inheritdoc />
  public partial class AddPaymentMethodTable : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder) {
      migrationBuilder.CreateTable(
        name: "payment_method",
        columns: table => new
        {
          Id = table.Column<long>(type: "bigint", nullable: false)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
          Name = table.Column<string>(type: "text", nullable: false),
          Charge = table.Column<decimal>(type: "numeric(5,2)", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_payment_method", x => x.Id);
        }
      );

      // Seed data inicial
      migrationBuilder.InsertData(
          table: "payment_method",
          columns: new[] { "Name", "Charge" },
          values: new object[,]
          {
              { "CREDIT_CARD", 3.50m },
              { "DEBIT_CARD",  1.50m },
              { "CASH",        0.0m  }
          }
      ); 
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "payment_method");
    }
  }
}
