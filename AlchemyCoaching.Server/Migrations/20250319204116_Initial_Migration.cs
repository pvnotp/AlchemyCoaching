using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DemoSite.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PersonalSite");

            migrationBuilder.CreateTable(
                name: "Appointment",
                schema: "PersonalSite",
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
                schema: "PersonalSite",
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
                schema: "PersonalSite",
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
                schema: "PersonalSite",
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
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "PersonalSite",
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
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "PersonalSite",
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
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "PersonalSite",
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
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "PersonalSite",
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
                        principalSchema: "PersonalSite",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "PersonalSite",
                table: "Appointment",
                columns: new[] { "Id", "ClientId", "Location", "Note", "Time" },
                values: new object[,]
                {
                    { 1, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "Dolor voluptate quia dolores delectus doloremque omnis voluptatem officia fuga.\nEos dolore a.\nDicta tempora corrupti omnis rerum est.\nSed vero magnam sequi eligendi est sapiente molestiae unde tempora.\nEt suscipit et aut.", new DateTime(2025, 1, 4, 3, 34, 9, 334, DateTimeKind.Unspecified).AddTicks(4410) },
                    { 2, "21d2afc1-49fb-4e30-8ab1-8427709c9f2b", 0, "Corrupti molestias explicabo quia et.\nQuasi sed ipsum deleniti ipsa quibusdam vel ratione tempora.", new DateTime(2025, 6, 10, 23, 14, 25, 64, DateTimeKind.Unspecified).AddTicks(8616) },
                    { 3, "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "Consequatur amet aut incidunt molestias vero laboriosam ipsa reiciendis omnis. Delectus asperiores iste iusto. Similique ut alias odit repudiandae enim consequatur ut enim. Beatae dolores neque ut consequuntur nemo.", new DateTime(2025, 4, 26, 10, 32, 45, 453, DateTimeKind.Unspecified).AddTicks(9675) },
                    { 4, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "Ut et exercitationem aut et vero suscipit ut.", new DateTime(2025, 3, 18, 5, 11, 53, 268, DateTimeKind.Unspecified).AddTicks(5895) },
                    { 5, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "Omnis quam neque perspiciatis corrupti in vel.\nMinima quis molestiae voluptas et voluptas delectus fuga ab suscipit.", new DateTime(2025, 2, 9, 12, 34, 56, 137, DateTimeKind.Unspecified).AddTicks(4208) },
                    { 6, "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "Rerum consequuntur quae voluptatem optio quidem voluptatem voluptas unde eaque.\nVoluptatibus aut qui.\nProvident laboriosam perspiciatis necessitatibus et sit maiores quis incidunt.", new DateTime(2025, 4, 20, 0, 35, 44, 532, DateTimeKind.Unspecified).AddTicks(3021) },
                    { 7, "df986608-2a74-4168-84a7-043934b89456", 0, "eaque", new DateTime(2025, 3, 13, 22, 26, 26, 402, DateTimeKind.Unspecified).AddTicks(3235) },
                    { 8, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "nemo", new DateTime(2025, 4, 25, 13, 30, 44, 647, DateTimeKind.Unspecified).AddTicks(6686) },
                    { 9, "e5fba865-f5c4-47b5-aed2-5a46a186cb83", 0, "Hic facere enim et optio dolores est iure. Commodi quaerat perspiciatis voluptas possimus cum quia libero esse ipsum. Ipsum nemo veritatis sint. Dolores odit nostrum quo qui ducimus qui.", new DateTime(2025, 4, 3, 6, 49, 9, 280, DateTimeKind.Unspecified).AddTicks(7843) },
                    { 10, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "Vero odit sit praesentium corporis voluptates et quas a. Hic et sapiente qui qui. Quae veniam consequuntur aut iste corrupti quae eum optio. Aspernatur libero blanditiis.", new DateTime(2025, 5, 12, 4, 37, 1, 145, DateTimeKind.Unspecified).AddTicks(5760) },
                    { 11, "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "Animi ut dolorum id nemo dolorem aut.\nEst velit a velit consequatur distinctio sunt.\nMinus sunt repellendus labore eum delectus sed consequuntur.\nEligendi id consectetur non velit quo reprehenderit nisi dolore.\nMolestias rerum deleniti aliquid porro.", new DateTime(2025, 4, 6, 21, 29, 57, 130, DateTimeKind.Unspecified).AddTicks(7300) },
                    { 12, "9e942e34-9563-447a-a12b-e6cb31f25f3a", 0, "Tempora modi illum.\nAut sit suscipit quasi deserunt recusandae aliquid nihil deserunt perferendis.\nInventore eveniet voluptas eveniet voluptatem et consequatur veniam et.\nQuia rerum modi atque rerum quos.", new DateTime(2025, 1, 21, 14, 22, 8, 996, DateTimeKind.Unspecified).AddTicks(5723) },
                    { 13, "79ab798a-f0da-45de-958c-4f88a3c1d3aa", 0, "Sapiente dolorem quia eum libero.\nAut nostrum hic.\nAb odio et voluptatem commodi libero voluptate omnis.", new DateTime(2025, 6, 11, 17, 20, 58, 697, DateTimeKind.Unspecified).AddTicks(6214) },
                    { 14, "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "Eos odio iste nulla facilis consequatur rerum id.\nConsequuntur corrupti nobis porro.", new DateTime(2025, 3, 17, 23, 38, 5, 720, DateTimeKind.Unspecified).AddTicks(6672) },
                    { 15, "df986608-2a74-4168-84a7-043934b89456", 0, "Non quia ad exercitationem laboriosam saepe.", new DateTime(2025, 4, 18, 1, 11, 17, 458, DateTimeKind.Unspecified).AddTicks(7441) },
                    { 16, "21d2afc1-49fb-4e30-8ab1-8427709c9f2b", 0, "possimus", new DateTime(2025, 5, 12, 5, 19, 45, 718, DateTimeKind.Unspecified).AddTicks(2907) },
                    { 17, "e5fba865-f5c4-47b5-aed2-5a46a186cb83", 0, "Distinctio id cupiditate qui nemo quos animi voluptatibus.\nEsse minus vitae cupiditate voluptatem iusto tempore officia eum.\nQuod animi aut error pariatur.\nArchitecto iure est.\nReprehenderit nobis hic aut iste dolores dicta magni.\nEveniet laborum rerum aperiam vel eum excepturi voluptate.", new DateTime(2025, 2, 5, 21, 17, 20, 601, DateTimeKind.Unspecified).AddTicks(6665) },
                    { 18, "df986608-2a74-4168-84a7-043934b89456", 0, "Quas dicta consectetur.", new DateTime(2025, 6, 20, 12, 19, 44, 318, DateTimeKind.Unspecified).AddTicks(352) },
                    { 19, "79ab798a-f0da-45de-958c-4f88a3c1d3aa", 0, "Et expedita animi. Sed facere et quis et consequuntur rerum voluptate quisquam omnis. Eum rem veritatis a velit fugiat eos hic eos nulla. Dolor ut non. Assumenda voluptatem dolore numquam.", new DateTime(2025, 3, 22, 18, 53, 56, 762, DateTimeKind.Unspecified).AddTicks(9754) },
                    { 20, "9e942e34-9563-447a-a12b-e6cb31f25f3a", 0, "Sunt consequatur vel.\nDoloribus praesentium nam et laudantium iusto accusamus reiciendis eligendi.\nExplicabo soluta aut.", new DateTime(2025, 5, 4, 5, 23, 47, 577, DateTimeKind.Unspecified).AddTicks(7392) },
                    { 21, "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "Porro quo nisi maiores qui.\nEt debitis quisquam quo maxime.", new DateTime(2025, 6, 26, 22, 14, 31, 666, DateTimeKind.Unspecified).AddTicks(8076) },
                    { 22, "79ab798a-f0da-45de-958c-4f88a3c1d3aa", 0, "Assumenda sed adipisci cumque tempore omnis nemo accusantium cupiditate harum.", new DateTime(2025, 6, 7, 22, 37, 39, 42, DateTimeKind.Unspecified).AddTicks(3434) },
                    { 23, "9e942e34-9563-447a-a12b-e6cb31f25f3a", 0, "consequuntur", new DateTime(2025, 2, 25, 12, 19, 53, 7, DateTimeKind.Unspecified).AddTicks(5413) },
                    { 24, "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "Quidem ea qui ullam voluptas amet libero autem.\nQuisquam dolorem commodi aut accusamus quis nostrum sunt.\nPlaceat rerum repellendus excepturi repudiandae dolorum.\nVel ab at est eos rerum qui voluptatum.\nNihil omnis dolorem rerum sed modi.", new DateTime(2025, 6, 19, 12, 11, 28, 775, DateTimeKind.Unspecified).AddTicks(5007) },
                    { 25, "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "quidem", new DateTime(2025, 3, 18, 18, 22, 48, 80, DateTimeKind.Unspecified).AddTicks(7075) },
                    { 26, "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "In occaecati neque.", new DateTime(2025, 3, 16, 9, 8, 32, 179, DateTimeKind.Unspecified).AddTicks(8275) },
                    { 27, "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "consequatur", new DateTime(2025, 1, 29, 20, 36, 20, 285, DateTimeKind.Unspecified).AddTicks(7447) },
                    { 28, "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "et", new DateTime(2025, 4, 15, 17, 23, 1, 691, DateTimeKind.Unspecified).AddTicks(1381) },
                    { 29, "21d2afc1-49fb-4e30-8ab1-8427709c9f2b", 0, "Officiis ea enim rem delectus dolores laboriosam debitis. Est asperiores dicta voluptatibus adipisci sapiente officiis illo quasi quia. Velit doloremque dolore eos dolorem aut laudantium dolore. Expedita quidem voluptatem eos optio molestiae quis voluptatem id.", new DateTime(2025, 1, 11, 19, 50, 40, 243, DateTimeKind.Unspecified).AddTicks(1052) },
                    { 30, "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "cupiditate", new DateTime(2025, 2, 23, 1, 26, 2, 74, DateTimeKind.Unspecified).AddTicks(3620) }
                });

            migrationBuilder.InsertData(
                schema: "PersonalSite",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a2a713f-bdc9-45c5-969f-6411da61f098", null, "Admin", "ADMIN" },
                    { "89e922f9-758b-493d-9ec0-8b9af6b18b61", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "PersonalSite",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "21d2afc1-49fb-4e30-8ab1-8427709c9f2b", 0, "97eb897b-6899-491d-ac6c-aa6748e01b07", "Irving_Gibson82@email.com", false, "Irving", "Gibson", false, null, "irving_gibson82@email.com", "irving_gibson82@email.com", "AQAAAAIAAYagAAAAEA0W9B8ooRSLmJb3ZOgGYk2VTH9vrHP8AGEARVdV7ZRFYqghKH/SIhyyHdCcBX6nEw==", null, false, "dcc55f8b-b10e-4837-be78-00b1bf90a453", false, "irving_gibson82@email.com" },
                    { "30095dca-b53e-4f33-90b8-a213ebf2883f", 0, "00070f97-a591-4731-be03-91da72b8bcbf", "Gordon.Gislason@email.com", false, "Gordon", "Gislason", false, null, "gordon.gislason@email.com", "gordon.gislason@email.com", "AQAAAAIAAYagAAAAEARgrMZFxsEsrwPGe+R8NgcK+naHwVxJ4sNJeJNElzqxEPGmJBB12LoAlT7LaXPM7g==", null, false, "ee98ffe4-a90a-4bf0-9725-db7556232cf5", false, "gordon.gislason@email.com" },
                    { "3a02dbc3-09cf-4511-9d8f-c40cc78c6285", 0, "bea17a0c-b9af-4773-87f6-55ca5cdc24a0", "Darryl_Monahan15@email.com", false, "Darryl", "Monahan", false, null, "darryl_monahan15@email.com", "darryl_monahan15@email.com", "AQAAAAIAAYagAAAAEBGv8jxUE2y912/+rOVv0hD4Rvg9QBQjyW8RT8F2ZZ4jnWWchc/cTAJxHKeVJ+fhHA==", null, false, "399f07c1-0945-427c-ab31-9594d3434f37", false, "darryl_monahan15@email.com" },
                    { "79ab798a-f0da-45de-958c-4f88a3c1d3aa", 0, "07e11f47-42ac-4b52-b43d-8a0e2d34efdd", "Jeanne58@email.com", false, "Jeanne", "Howell", false, null, "jeanne58@email.com", "jeanne58@email.com", "AQAAAAIAAYagAAAAEPEOOZ7nT4WpDA5XLq7HfWyhliSnjTm+DMmvETQRsrkCqwg1eHdKCXECcWtjhfXgHQ==", null, false, "d2b20940-d362-4b88-a230-71b9e2453fc9", false, "jeanne58@email.com" },
                    { "9e942e34-9563-447a-a12b-e6cb31f25f3a", 0, "a1850053-779f-46fc-93d2-39598ac7f460", "Sonja.Connelly58@email.com", false, "Sonja", "Connelly", false, null, "sonja.connelly58@email.com", "sonja.connelly58@email.com", "AQAAAAIAAYagAAAAEB6VxfiqdKOQaZyYUYdbpEZGhbnkuMC6P4i+qHPVP6WL0/BzNq2BTD5iUA5ZYIdHSw==", null, false, "d9eba852-3e93-41c0-ab8c-5452b5e74c2f", false, "sonja.connelly58@email.com" },
                    { "c21ae03e-c588-4605-94f0-0f8019c56299", 0, "edfe3238-6030-4526-8289-b11ccf7d09e4", "Cornelius46@email.com", false, "Cornelius", "Beatty", false, null, "cornelius46@email.com", "cornelius46@email.com", "AQAAAAIAAYagAAAAEKeq4HBuvm9g+v6cnbxtLn/dIbGa2uRHMk2Zo6cawIHdsQyzYGAXiGWrQL/uB9hUfQ==", null, false, "6c6b6916-8cf6-4996-9b32-68da85a4bb54", false, "cornelius46@email.com" },
                    { "cdd16811-d61a-44f1-8267-f1d4e8d82686", 0, "3f844363-2243-4ee6-9d4f-9eda3f4ee7fb", "Melinda_Hermiston3@email.com", false, "Melinda", "Hermiston", false, null, "melinda_hermiston3@email.com", "melinda_hermiston3@email.com", "AQAAAAIAAYagAAAAEMdn/HzL1khHAL449424cX4Pnd4iamvA5lNDcfsYyTZG3nnEGcCe5K8gez7t4zN93A==", null, false, "8f520d69-ac61-4413-a4b7-70ce26667560", false, "melinda_hermiston3@email.com" },
                    { "df986608-2a74-4168-84a7-043934b89456", 0, "2dd4bba3-6873-4fb4-bd1b-b089cacc8994", "Erica_Hyatt83@email.com", false, "Erica", "Hyatt", false, null, "erica_hyatt83@email.com", "erica_hyatt83@email.com", "AQAAAAIAAYagAAAAEPA7vnkwuEAzRjoQRqKo0gokDdmmvjzVRER76STjbVApoTAhXyw2V15rVV21zvqY6Q==", null, false, "80c37e26-d7a1-4c6d-bcba-688342a15d33", false, "erica_hyatt83@email.com" },
                    { "e5fba865-f5c4-47b5-aed2-5a46a186cb83", 0, "325484db-e01f-48f7-97cc-054711870902", "Vernon_Christiansen@email.com", false, "Vernon", "Christiansen", false, null, "vernon_christiansen@email.com", "vernon_christiansen@email.com", "AQAAAAIAAYagAAAAENQJm4e4sfranMeqBLN4W/5M/SWW8ei/gtPoiGFJeq5R+edqCWK6xg3Kx1xRGywM9Q==", null, false, "e7f2581d-342a-4ce2-803a-a60dd450b8d8", false, "vernon_christiansen@email.com" },
                    { "f2b75dde-ff5c-4c8f-8a44-5a7af46fc6d1", 0, "fb96de82-966e-4fdf-9335-bb040872c8c2", "Elena_Feest@email.com", false, "Elena", "Feest", false, null, "elena_feest@email.com", "elena_feest@email.com", "AQAAAAIAAYagAAAAEEU2cMe0BvlM8KcJsm/Jy99fDh9eVV7R6w6hrVcohw5bvDuPt2fzIpCKd/4/Mg+ENw==", null, false, "4f2a891a-0bed-49b3-aa33-2c3b972966d3", false, "elena_feest@email.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "PersonalSite",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "PersonalSite",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "PersonalSite",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "PersonalSite",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "PersonalSite",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "PersonalSite",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "PersonalSite",
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
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "PersonalSite");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "PersonalSite");
        }
    }
}
