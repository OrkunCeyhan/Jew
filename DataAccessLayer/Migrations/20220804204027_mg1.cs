using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "paymentMethodID",
                table: "PreOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PreOrders_paymentMethodID",
                table: "PreOrders",
                column: "paymentMethodID");

            migrationBuilder.AddForeignKey(
                name: "FK_PreOrders_PaymentMethods_paymentMethodID",
                table: "PreOrders",
                column: "paymentMethodID",
                principalTable: "PaymentMethods",
                principalColumn: "paymentMethodID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PreOrders_PaymentMethods_paymentMethodID",
                table: "PreOrders");

            migrationBuilder.DropIndex(
                name: "IX_PreOrders_paymentMethodID",
                table: "PreOrders");

            migrationBuilder.DropColumn(
                name: "paymentMethodID",
                table: "PreOrders");
        }
    }
}
