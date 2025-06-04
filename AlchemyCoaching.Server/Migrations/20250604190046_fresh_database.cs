using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlchemyCoaching.Server.Migrations
{
    /// <inheritdoc />
    public partial class fresh_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AlchemyCoaching");

            migrationBuilder.CreateTable(
                name: "Appointment",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "AlchemyCoaching",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "AlchemyCoaching",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                columns: new[] { "Id", "ClientId", "Location", "Note", "Time" },
                values: new object[,]
                {
                    { 1, "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", 0, "Suscipit ipsum ea aliquid aut ut omnis et quo. Natus nisi est vero consequuntur qui. Quibusdam nihil sit. Itaque repellat excepturi accusamus sed. Enim praesentium voluptas optio tenetur et et similique magni.", new DateTime(2025, 2, 23, 19, 59, 53, 108, DateTimeKind.Unspecified).AddTicks(3833) },
                    { 2, "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "Eius facilis id quis architecto.\nNon voluptas iusto sint sit et autem consequatur.\nEst et voluptatem magni illo delectus est.\nVelit tempora libero omnis et sit autem laborum.\nVoluptatem similique consectetur reprehenderit modi est quia et corrupti.", new DateTime(2025, 3, 11, 23, 13, 56, 761, DateTimeKind.Unspecified).AddTicks(3110) },
                    { 3, "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", 0, "Aliquam ut et dicta velit quibusdam ut numquam voluptatum.\nDolores eius at debitis sint.", new DateTime(2025, 1, 25, 23, 37, 28, 112, DateTimeKind.Unspecified).AddTicks(7457) },
                    { 4, "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", 0, "Consectetur aliquam sunt et corrupti molestiae aut accusamus aperiam. Excepturi suscipit aliquam autem sunt vitae quia. Reiciendis tempora autem qui dolore.", new DateTime(2025, 3, 29, 7, 2, 13, 33, DateTimeKind.Unspecified).AddTicks(7589) },
                    { 5, "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "Consectetur libero pariatur aut sed. Explicabo porro ut qui quis qui recusandae. Tenetur hic in qui quis. Asperiores sunt ducimus quo. Ducimus quae est tempora sed.", new DateTime(2025, 6, 13, 14, 10, 46, 477, DateTimeKind.Unspecified).AddTicks(4921) },
                    { 6, "a2d15849-5376-4e4b-af5d-accb1ffa3935", 0, "Occaecati minus voluptatum non velit qui earum.", new DateTime(2025, 4, 24, 0, 2, 9, 39, DateTimeKind.Unspecified).AddTicks(4056) },
                    { 7, "d61ac6e5-72e0-4e5a-9946-10c694abeef6", 0, "eos", new DateTime(2025, 1, 6, 23, 47, 20, 969, DateTimeKind.Unspecified).AddTicks(6472) },
                    { 8, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "Veniam ut facilis consequatur soluta.", new DateTime(2025, 2, 22, 14, 5, 43, 187, DateTimeKind.Unspecified).AddTicks(9180) },
                    { 9, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "Expedita repellendus odit.\nQuas unde est quo cumque.\nUt odit dolores rem omnis illo.", new DateTime(2025, 6, 3, 19, 18, 18, 215, DateTimeKind.Unspecified).AddTicks(5637) },
                    { 10, "f8294be2-341c-4a94-97c6-6e9f2a189070", 0, "Ullam earum minus. Mollitia doloremque ea maiores. Expedita qui aliquid illum eum fugit.", new DateTime(2025, 3, 3, 20, 11, 38, 254, DateTimeKind.Unspecified).AddTicks(6213) },
                    { 11, "f8294be2-341c-4a94-97c6-6e9f2a189070", 0, "Quia consequatur rerum dolores eligendi voluptas temporibus est officiis.", new DateTime(2025, 1, 12, 7, 12, 51, 681, DateTimeKind.Unspecified).AddTicks(421) },
                    { 12, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "Ducimus perspiciatis dolores.\nQuo ut odio cumque amet vel.\nVoluptas repudiandae eveniet quis odio dignissimos facilis dolorem fugiat.\nNostrum earum vitae.\nBlanditiis cum expedita maiores ducimus eos nam libero.", new DateTime(2025, 4, 3, 1, 6, 59, 344, DateTimeKind.Unspecified).AddTicks(4658) },
                    { 13, "a2d15849-5376-4e4b-af5d-accb1ffa3935", 0, "At animi id officiis nesciunt rerum non soluta.", new DateTime(2025, 6, 4, 2, 2, 30, 798, DateTimeKind.Unspecified).AddTicks(918) },
                    { 14, "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "Sed et labore maxime.", new DateTime(2025, 1, 27, 2, 42, 39, 692, DateTimeKind.Unspecified).AddTicks(8840) },
                    { 15, "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "Cupiditate explicabo nesciunt sint quam nostrum laboriosam autem suscipit repellendus. Rerum quia rerum. Libero animi aliquid quibusdam. Animi dolorem error eius adipisci molestiae dolorem deleniti. Molestias eaque corrupti et recusandae earum voluptas deserunt minima.", new DateTime(2025, 4, 6, 15, 58, 38, 318, DateTimeKind.Unspecified).AddTicks(4020) },
                    { 16, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "omnis", new DateTime(2025, 3, 20, 18, 41, 11, 605, DateTimeKind.Unspecified).AddTicks(2365) },
                    { 17, "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "Maiores vero qui.\nQui consequatur eos qui qui cupiditate quia alias.\nVoluptas est est molestiae alias ut asperiores.\nRepellat tenetur explicabo provident aliquid ea quia.", new DateTime(2025, 3, 28, 22, 47, 17, 551, DateTimeKind.Unspecified).AddTicks(1237) },
                    { 18, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "Magnam placeat est repudiandae quaerat id ut minima omnis occaecati. Et non consequatur qui ipsa perferendis. Enim commodi repudiandae quisquam ab. Est sint autem est dicta.", new DateTime(2025, 4, 21, 18, 44, 45, 87, DateTimeKind.Unspecified).AddTicks(6746) },
                    { 19, "f8294be2-341c-4a94-97c6-6e9f2a189070", 0, "Ut sint consequatur unde ut.\nQuasi facere eligendi et id saepe.\nQuae repudiandae animi et eos numquam dolorem voluptas.\nAliquam qui harum qui aliquid placeat eligendi expedita.", new DateTime(2025, 5, 21, 23, 44, 47, 614, DateTimeKind.Unspecified).AddTicks(6450) },
                    { 20, "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", 0, "Commodi quaerat enim repellat et quaerat.\nSequi hic neque.\nIpsa ad rem porro explicabo pariatur adipisci consequatur.", new DateTime(2025, 1, 2, 13, 44, 19, 315, DateTimeKind.Unspecified).AddTicks(3556) },
                    { 21, "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "Non sed ad odio deserunt voluptatum ut.\nEum aut veniam nemo non ipsam delectus fugiat cupiditate unde.", new DateTime(2025, 3, 4, 20, 14, 6, 883, DateTimeKind.Unspecified).AddTicks(4956) },
                    { 22, "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "aut", new DateTime(2025, 2, 25, 8, 28, 49, 583, DateTimeKind.Unspecified).AddTicks(8992) },
                    { 23, "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "Labore repellendus eius sit et cupiditate.", new DateTime(2025, 2, 16, 2, 11, 53, 451, DateTimeKind.Unspecified).AddTicks(6484) },
                    { 24, "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", 0, "Error sunt id iure. Autem aut est. A nihil eos voluptatem quibusdam voluptatem ea fugit quis dolorem. Ratione quibusdam rerum.", new DateTime(2025, 3, 30, 11, 36, 59, 627, DateTimeKind.Unspecified).AddTicks(8774) },
                    { 25, "d61ac6e5-72e0-4e5a-9946-10c694abeef6", 0, "Nihil cum sit rerum.", new DateTime(2025, 3, 8, 23, 42, 16, 784, DateTimeKind.Unspecified).AddTicks(7634) },
                    { 26, "1e0ff4af-05e6-4dc4-ad25-edec7652ff45", 0, "Unde qui nemo autem provident atque. Aut voluptate ab omnis quaerat exercitationem dicta. Ad commodi maiores eius est in nostrum autem maiores et. Impedit repellendus autem.", new DateTime(2025, 4, 19, 17, 8, 1, 513, DateTimeKind.Unspecified).AddTicks(271) },
                    { 27, "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "explicabo", new DateTime(2025, 4, 27, 18, 54, 57, 919, DateTimeKind.Unspecified).AddTicks(2434) },
                    { 28, "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "Praesentium molestias aut praesentium consequatur quibusdam natus ullam odio.\nAsperiores quia labore quae eius.", new DateTime(2025, 6, 2, 19, 29, 35, 637, DateTimeKind.Unspecified).AddTicks(2515) },
                    { 29, "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "Dicta incidunt aliquid ratione sit saepe ut. Assumenda nihil minus soluta natus amet sit. Aut laboriosam occaecati qui. Nobis eius ut dicta debitis laborum non illo.", new DateTime(2025, 5, 14, 5, 24, 13, 621, DateTimeKind.Unspecified).AddTicks(9668) },
                    { 30, "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", 0, "Fuga vel perferendis. Voluptatem quo quos perspiciatis. Natus eos recusandae. Neque et qui voluptatem earum quisquam suscipit voluptates. Doloribus et est ipsum aut quia ut. Quisquam velit architecto voluptas nam modi quod commodi nulla.", new DateTime(2025, 2, 5, 7, 55, 26, 861, DateTimeKind.Unspecified).AddTicks(1445) }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "53c128ff-e28d-4f22-908c-12abed534cc5", null, "Admin", "ADMIN" },
                    { "761481ad-b971-49b9-9389-1f0599751dd6", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e0ff4af-05e6-4dc4-ad25-edec7652ff45", 0, "29c2fa94-2db2-45fb-805e-18192cc21d22", "Lula.Orn57@email.com", false, "Lula", "Orn", false, null, "lula.orn57@email.com", "lula.orn57@email.com", "AQAAAAIAAYagAAAAEN5yfCNehYd6NrrE2nyCJZSyal7qxJS4897qUvs8D8HWi/2mAZ/DZrfMyYuLclU6lw==", null, false, "670675a8-4060-4981-bc19-3918258e3b7f", false, "lula.orn57@email.com" },
                    { "2618f4d1-f4a8-4584-901c-57b233900da2", 0, "acb2feb5-9758-4451-88ee-3c3929d4017c", "Katie_Terry@email.com", false, "Katie", "Terry", false, null, "katie_terry@email.com", "katie_terry@email.com", "AQAAAAIAAYagAAAAEIZJG2ErxEyoVFxGwxXQ3/BwUbA3Owak0E6Q8xL75Ty147jy/gskKNmFnsZD4tMhVA==", null, false, "6c9ab80f-db3f-4d21-a952-c4cdb0e47907", false, "katie_terry@email.com" },
                    { "41ef70d3-b947-4099-b772-b77df022cc23", 0, "31bf2d74-5667-480b-89d6-ddda4d390455", "Jacquelyn.Cormier18@email.com", false, "Jacquelyn", "Cormier", false, null, "jacquelyn.cormier18@email.com", "jacquelyn.cormier18@email.com", "AQAAAAIAAYagAAAAEDN4LQVIBLgPAu22eoblaR8OvgIy5eJOw+ucT6MowgTrgIc6YzCAPfIvFAFWQq0qdw==", null, false, "050706dc-8efe-4b44-b7b6-8401efb0d3ad", false, "jacquelyn.cormier18@email.com" },
                    { "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", 0, "759a5282-1d52-44ac-bad1-a30bdf3839c7", "Herbert_Luettgen9@email.com", false, "Herbert", "Luettgen", false, null, "herbert_luettgen9@email.com", "herbert_luettgen9@email.com", "AQAAAAIAAYagAAAAENUqiP38AGTJVrzLh+GXAgQ5mXQnJfK7enPavBlNFpkq5fjd93sUtnU2JaePAviiAQ==", null, false, "33852f04-0f51-4bf8-9b94-42cabbce8c60", false, "herbert_luettgen9@email.com" },
                    { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", 0, "755f8ed0-0de5-4edf-a184-64ded9cfdfe8", "Eloise35@email.com", false, "Eloise", "Olson", false, null, "eloise35@email.com", "eloise35@email.com", "AQAAAAIAAYagAAAAEOe+J423dW7wCeSpVCy7vnFnrPLeqLsYYEIyqYv6/cu7HEJxfgVmT1nkgWO9NyDNsQ==", null, false, "56df5e7b-2ff0-441f-8039-0b4298813ee9", false, "eloise35@email.com" },
                    { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", 0, "b9dcfc1a-d447-4048-ad0b-d130d013b9a5", "Agnes_Wolf@email.com", false, "Agnes", "Wolf", false, null, "agnes_wolf@email.com", "agnes_wolf@email.com", "AQAAAAIAAYagAAAAEA1xhosSSEA9dPj2zziNqmoFHWCzwK17mOysS4vOEW3bP+E4E/1MPJ/oLjZbUr5KGg==", null, false, "64e2c042-f0c0-42eb-9f57-2a4a7bdc0343", false, "agnes_wolf@email.com" },
                    { "a2d15849-5376-4e4b-af5d-accb1ffa3935", 0, "7e7c26c2-c51c-42d8-ac40-b8f616b6080e", "Hector.Jenkins8@email.com", false, "Hector", "Jenkins", false, null, "hector.jenkins8@email.com", "hector.jenkins8@email.com", "AQAAAAIAAYagAAAAEHgL/njMypSb2Jsa6ihRNosrDw2wP4IeCeHVNyE0UyoOvwqO8j2cVMgMHy2bZ5AOVA==", null, false, "d472ab5d-f198-45d8-98ea-c6ebf168c797", false, "hector.jenkins8@email.com" },
                    { "d61ac6e5-72e0-4e5a-9946-10c694abeef6", 0, "1a07b1bc-9bb5-4eaf-9b90-06e61ed740f7", "Paulette.Heaney@email.com", false, "Paulette", "Heaney", false, null, "paulette.heaney@email.com", "paulette.heaney@email.com", "AQAAAAIAAYagAAAAEPENMUUfZatwDPzB+ecInS9Dcv2cqHhiraOoh9YhDe6oK5L41dWj6daJGtEC5Wfs1g==", null, false, "735f10d4-5d2d-4ed5-a2ed-5366bc0dc217", false, "paulette.heaney@email.com" },
                    { "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", 0, "c4f60b9d-1295-4cd4-90e4-c64591946504", "Gregg69@email.com", false, "Gregg", "Larson", false, null, "gregg69@email.com", "gregg69@email.com", "AQAAAAIAAYagAAAAELWZywuRjh5KRlyJq9ShgzkBrsg/U0M0bM4Obr/NhJtZhIZEZCaDGWD0LGs34xrLXg==", null, false, "fe0f98df-895e-4a2e-8b97-1abfb1ea2ca3", false, "gregg69@email.com" },
                    { "f8294be2-341c-4a94-97c6-6e9f2a189070", 0, "804e72ec-bfd2-4f7c-93b6-c0e75a4208cf", "Kelli.Schumm67@email.com", false, "Kelli", "Schumm", false, null, "kelli.schumm67@email.com", "kelli.schumm67@email.com", "AQAAAAIAAYagAAAAEDdYtKRXPjhuIKKPrYGLDU7CU0X8R0nCRfwbTkrqG1bYEAvGf0figSNVpSLbgiS2CQ==", null, false, "bbf7425d-c9b9-45c5-a242-90af889b6645", false, "kelli.schumm67@email.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "AlchemyCoaching",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "AlchemyCoaching",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "AlchemyCoaching",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "AlchemyCoaching",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "AlchemyCoaching");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "AlchemyCoaching");
        }
    }
}
