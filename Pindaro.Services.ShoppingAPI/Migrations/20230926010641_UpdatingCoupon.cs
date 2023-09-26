using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pindaro.Services.ShoppingCartAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingCoupon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CouponCode",
                table: "CartHeaders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CouponCode",
                table: "CartHeaders");
        }
    }
}
