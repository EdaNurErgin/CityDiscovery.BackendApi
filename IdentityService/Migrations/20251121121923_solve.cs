using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityService.Migrations
{
    /// <inheritdoc />
    public partial class solve : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_RefreshTokens_ExpiresAfterCreate",
                table: "RefreshTokens",
                sql: "[ExpiresAt] > [CreatedAt]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_RefreshTokens_ExpiresAfterCreate",
                table: "RefreshTokens");
        }
    }
}
