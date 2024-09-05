using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeGroom.Migrations.HomeGroom
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24eef174-f129-447d-aade-c3e8275edd5e", "be0976d3-ae11-41e5-98af-2f7bf02f807c", "Admin", "ADMIN" },
                    { "3454268d-163c-43ab-beac-cea1ec177eb1", "245b4a61-359c-4f04-8aa2-3b37a818ead4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3f0fd2e0-cf93-4803-954c-69d5c5965dce", 0, "5f255465-6d88-48e2-9b6b-e1a4a491fd5f", "user2@hotmail.com", false, false, null, "USER2@HOTMAIL.COM", "USER2@HOTMAIL.COM", "AQAAAAEAACcQAAAAEJGFC8T1SW3ba7AV9S5u8LZSEJ5Md9iySvNluWsqrpTYnECCJtL42/tg+33ID0GkyA==", null, false, "bcfb2730-ac95-480e-b066-713575c537d4", false, "user2@hotmail.com" },
                    { "290da9c0-36bf-4dac-9948-2df4a93b40af", 0, "896e1ee1-c35b-45f1-9a16-0b81828c0c31", "user3@hotmail.com", false, false, null, "USER3@HOTMAIL.COM", "USER3@HOTMAIL.COM", "AQAAAAEAACcQAAAAEAS5NdRySI3k0iRQiGBWYu9P2pBA80ZgSr4NwMjtcDCzMfThKFiSCTM7Ih2P7vLHBQ==", null, false, "857a1886-d1d6-4f05-a7f0-872185544612", false, "user3@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3454268d-163c-43ab-beac-cea1ec177eb1", "3f0fd2e0-cf93-4803-954c-69d5c5965dce" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "24eef174-f129-447d-aade-c3e8275edd5e", "290da9c0-36bf-4dac-9948-2df4a93b40af" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "24eef174-f129-447d-aade-c3e8275edd5e", "290da9c0-36bf-4dac-9948-2df4a93b40af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3454268d-163c-43ab-beac-cea1ec177eb1", "3f0fd2e0-cf93-4803-954c-69d5c5965dce" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24eef174-f129-447d-aade-c3e8275edd5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3454268d-163c-43ab-beac-cea1ec177eb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "290da9c0-36bf-4dac-9948-2df4a93b40af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f0fd2e0-cf93-4803-954c-69d5c5965dce");
        }
    }
}
