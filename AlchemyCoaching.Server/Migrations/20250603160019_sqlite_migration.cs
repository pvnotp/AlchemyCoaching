using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlchemyCoaching.Server.Migrations
{
    /// <inheritdoc />
    public partial class sqlite_migration : Migration
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<int>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                    { 1, "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "Iure fugit veniam et.\nA molestiae fugit velit hic natus quaerat fugit facere.\nEst soluta ut quia dolores aperiam in quia.\nQui magni atque voluptate consectetur molestiae.", new DateTime(2025, 6, 29, 13, 45, 29, 842, DateTimeKind.Unspecified).AddTicks(413) },
                    { 2, "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "et", new DateTime(2025, 6, 30, 17, 55, 29, 911, DateTimeKind.Unspecified).AddTicks(5372) },
                    { 3, "4648bd27-14a0-41a5-93ed-c082e35751db", 0, "Nisi tenetur est qui consectetur sequi expedita. Libero expedita harum quisquam ut aut aut velit vero. Dolores minima aut ducimus id odit.", new DateTime(2025, 2, 25, 11, 48, 24, 196, DateTimeKind.Unspecified).AddTicks(5120) },
                    { 4, "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "exercitationem", new DateTime(2025, 3, 16, 2, 40, 34, 236, DateTimeKind.Unspecified).AddTicks(3156) },
                    { 5, "a98f4a90-23d2-477d-be11-b13842692679", 0, "perspiciatis", new DateTime(2025, 2, 24, 12, 28, 31, 381, DateTimeKind.Unspecified).AddTicks(9139) },
                    { 6, "57650b32-15eb-45bc-86de-9aa3c9453309", 0, "sit", new DateTime(2025, 3, 9, 20, 19, 12, 933, DateTimeKind.Unspecified).AddTicks(7989) },
                    { 7, "4648bd27-14a0-41a5-93ed-c082e35751db", 0, "et", new DateTime(2025, 5, 15, 2, 7, 11, 86, DateTimeKind.Unspecified).AddTicks(1284) },
                    { 8, "36b7ee83-5861-4123-9f3a-bcde88cb7495", 0, "Tempora asperiores rerum aut.", new DateTime(2025, 1, 31, 6, 38, 51, 699, DateTimeKind.Unspecified).AddTicks(1013) },
                    { 9, "345e82e9-ffb8-4c2a-8fae-99577ac8e2fd", 0, "Quam deleniti et quo nostrum. Assumenda at totam possimus qui nisi magni voluptatum. Error alias velit nemo quidem qui dicta natus ducimus rem.", new DateTime(2025, 3, 13, 2, 6, 34, 211, DateTimeKind.Unspecified).AddTicks(856) },
                    { 10, "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "quae", new DateTime(2025, 3, 6, 21, 15, 33, 83, DateTimeKind.Unspecified).AddTicks(2459) },
                    { 11, "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "dolores", new DateTime(2025, 2, 2, 8, 5, 36, 618, DateTimeKind.Unspecified).AddTicks(253) },
                    { 12, "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "Consequuntur suscipit blanditiis. Ut delectus nulla et dolor ea. Laudantium fuga totam amet quaerat.", new DateTime(2025, 2, 23, 17, 58, 59, 329, DateTimeKind.Unspecified).AddTicks(888) },
                    { 13, "a98f4a90-23d2-477d-be11-b13842692679", 0, "Sed voluptates magnam odio cumque qui ex voluptates totam.", new DateTime(2025, 5, 21, 18, 56, 11, 850, DateTimeKind.Unspecified).AddTicks(9438) },
                    { 14, "36b7ee83-5861-4123-9f3a-bcde88cb7495", 0, "Doloremque qui aut quia voluptatem enim.\nDelectus quasi et doloribus nihil.\nConsectetur minima consequuntur repudiandae excepturi accusamus.\nEst est sit iure beatae explicabo.", new DateTime(2025, 3, 11, 13, 32, 30, 493, DateTimeKind.Unspecified).AddTicks(6596) },
                    { 15, "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "Commodi praesentium animi rem quod sit sint.", new DateTime(2025, 6, 13, 3, 50, 34, 823, DateTimeKind.Unspecified).AddTicks(9055) },
                    { 16, "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "Ipsam repellendus id doloribus ad sit sit. Omnis ut cupiditate. Aut quae id voluptatibus illo nam. Quia nulla quia pariatur minus ea et expedita quia. Expedita doloribus laborum et sapiente accusamus eos.", new DateTime(2025, 1, 31, 15, 32, 46, 836, DateTimeKind.Unspecified).AddTicks(4523) },
                    { 17, "57650b32-15eb-45bc-86de-9aa3c9453309", 0, "Et possimus neque et ullam odit deserunt.\nTotam repudiandae sapiente quod ex sed ab voluptatem dolorem.\nEnim aliquam explicabo enim expedita officia.\nUt deleniti debitis veniam ut qui neque nesciunt.", new DateTime(2025, 5, 27, 20, 3, 13, 155, DateTimeKind.Unspecified).AddTicks(849) },
                    { 18, "a98f4a90-23d2-477d-be11-b13842692679", 0, "Illum necessitatibus unde ea voluptas. Sit est soluta quia. Cum nihil sint officiis. Commodi ut dolores pariatur sed qui voluptatem autem eaque.", new DateTime(2025, 6, 14, 23, 22, 49, 874, DateTimeKind.Unspecified).AddTicks(7329) },
                    { 19, "4648bd27-14a0-41a5-93ed-c082e35751db", 0, "recusandae", new DateTime(2025, 4, 28, 16, 30, 19, 653, DateTimeKind.Unspecified).AddTicks(4722) },
                    { 20, "a98f4a90-23d2-477d-be11-b13842692679", 0, "Eos blanditiis porro perferendis hic molestiae non adipisci quasi iusto. Excepturi minima voluptas vero est quo cupiditate occaecati doloribus sunt. Facere placeat qui expedita laborum iure.", new DateTime(2025, 5, 22, 6, 31, 25, 647, DateTimeKind.Unspecified).AddTicks(534) },
                    { 21, "36b7ee83-5861-4123-9f3a-bcde88cb7495", 0, "Perspiciatis eum modi temporibus maiores itaque animi.", new DateTime(2025, 5, 12, 15, 0, 58, 805, DateTimeKind.Unspecified).AddTicks(9675) },
                    { 22, "345e82e9-ffb8-4c2a-8fae-99577ac8e2fd", 0, "Rerum excepturi iure provident reiciendis.\nCulpa similique quia earum quis temporibus.", new DateTime(2025, 3, 11, 7, 58, 25, 650, DateTimeKind.Unspecified).AddTicks(5237) },
                    { 23, "17d37933-ff23-4949-83b2-261b817d4005", 0, "Voluptas quis incidunt eveniet earum.\nQuidem temporibus aut aut odio iste at ut hic omnis.\nAliquid repellendus nemo quos aut quam reprehenderit sed facilis.\nAnimi a mollitia esse sint sed molestiae.", new DateTime(2025, 2, 20, 12, 44, 49, 931, DateTimeKind.Unspecified).AddTicks(7914) },
                    { 24, "c107dc83-afe5-48f5-996f-1a20ae8beb62", 0, "et", new DateTime(2025, 5, 26, 0, 51, 10, 705, DateTimeKind.Unspecified).AddTicks(9410) },
                    { 25, "345e82e9-ffb8-4c2a-8fae-99577ac8e2fd", 0, "Impedit est eum eveniet nesciunt blanditiis. Sapiente ratione recusandae ut. In et rerum praesentium et rem autem. Fugiat provident sed.", new DateTime(2025, 4, 15, 16, 35, 6, 727, DateTimeKind.Unspecified).AddTicks(7007) },
                    { 26, "a98f4a90-23d2-477d-be11-b13842692679", 0, "quo", new DateTime(2025, 2, 24, 13, 23, 41, 520, DateTimeKind.Unspecified).AddTicks(4584) },
                    { 27, "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "Unde ut et aut dolor dolorum qui veritatis.\nId sunt dolorum aliquam quod officia eos repudiandae.\nQui laborum officia qui voluptas consequatur enim ad et.\nRepellat tempora consequatur occaecati repellendus sint harum veritatis velit soluta.", new DateTime(2025, 1, 13, 5, 9, 28, 775, DateTimeKind.Unspecified).AddTicks(2141) },
                    { 28, "4648bd27-14a0-41a5-93ed-c082e35751db", 0, "amet", new DateTime(2025, 4, 9, 11, 33, 12, 432, DateTimeKind.Unspecified).AddTicks(3050) },
                    { 29, "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "Ducimus saepe ducimus nam reiciendis. Pariatur placeat consequatur enim dolores est aut. Dolorem nulla excepturi est itaque ipsa. Error dolor et excepturi accusantium. Fugit velit enim iure vel.", new DateTime(2025, 2, 22, 9, 50, 40, 630, DateTimeKind.Unspecified).AddTicks(4987) },
                    { 30, "57650b32-15eb-45bc-86de-9aa3c9453309", 0, "Libero numquam sunt et est expedita ad qui magni. Est optio et. Sed esse vitae sit. Accusantium voluptas deserunt delectus quibusdam. Numquam possimus et officia rerum. Quae est nihil doloribus animi.", new DateTime(2025, 6, 27, 22, 15, 42, 408, DateTimeKind.Unspecified).AddTicks(9103) }
                });

            migrationBuilder.InsertData(
                schema: "PersonalSite",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17a8fb86-db18-41fb-a97a-26595a5f074b", null, "Admin", "ADMIN" },
                    { "bbb3e921-380e-4da8-a07d-0ab57afa7fa4", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "PersonalSite",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "17d37933-ff23-4949-83b2-261b817d4005", 0, "90ffd8ed-07a5-4bdd-bd51-e6f396083608", "Eileen.Bernhard@email.com", false, "Eileen", "Bernhard", false, null, "eileen.bernhard@email.com", "eileen.bernhard@email.com", "AQAAAAIAAYagAAAAEKC1hTE8m0L+T8xTDvPsUd5IUvvZWEmOf3ga1Qb4aaMiOBIiuSk9jT1brwIteJr1IQ==", null, false, "0701302b-b842-4760-8dac-d28c82fb9f9e", false, "eileen.bernhard@email.com" },
                    { "1e8b7700-2695-4834-adfc-ca918047bca4", 0, "81c62f27-ba0b-46ed-b8ee-88473941737a", "Perry34@email.com", false, "Perry", "Spinka", false, null, "perry34@email.com", "perry34@email.com", "AQAAAAIAAYagAAAAEDMQFm3CArX0yBHIe+z8RbO8z9U3ZwD56t2EMe9NjoJhBADfdFy1L0yUjTLn9zheHw==", null, false, "f02e784d-5934-4c84-ade3-6fde434364a2", false, "perry34@email.com" },
                    { "345e82e9-ffb8-4c2a-8fae-99577ac8e2fd", 0, "9c46061a-4af6-4733-b8b1-78a184367187", "Francis_Anderson@email.com", false, "Francis", "Anderson", false, null, "francis_anderson@email.com", "francis_anderson@email.com", "AQAAAAIAAYagAAAAECUSoWMSvDeHdWxX0PS29T/q9iXz1tNp0/IqT/6PsmqniWlKkzaP2pSA5RuTRqqFAA==", null, false, "d7dc4d43-7262-4d70-b04c-fca7d0f986c5", false, "francis_anderson@email.com" },
                    { "36b7ee83-5861-4123-9f3a-bcde88cb7495", 0, "286daf99-153c-4306-8f6b-b566e11512a1", "Cary.Renner@email.com", false, "Cary", "Renner", false, null, "cary.renner@email.com", "cary.renner@email.com", "AQAAAAIAAYagAAAAEDRhH14FRGhLN6tJ6EUhynVPHd8Kg/j3jUH3+MA5g3DnRxkCm/NzXhCVVxArUVHN+w==", null, false, "5b8e137c-840a-49e0-9627-dd030d6481f9", false, "cary.renner@email.com" },
                    { "37c95c63-3a36-4430-8546-c6cd95fb8d04", 0, "86244e36-1658-42a4-9386-489cdef10da0", "Theodore79@email.com", false, "Theodore", "O'Kon", false, null, "theodore79@email.com", "theodore79@email.com", "AQAAAAIAAYagAAAAEH6ZYdngmRBepCgNhvQd1niy+DJ+g0JwYxjvfeNZ6M2yrERgDsBYRgNes3S1APsb4w==", null, false, "a4b45689-6aab-4edb-b2d1-062d876cf6fb", false, "theodore79@email.com" },
                    { "4648bd27-14a0-41a5-93ed-c082e35751db", 0, "832288c3-d6a2-473b-b6a1-6efc9f566662", "Latoya93@email.com", false, "Latoya", "Bosco", false, null, "latoya93@email.com", "latoya93@email.com", "AQAAAAIAAYagAAAAEGXsiztChWVx4RUjZE/YQT0plLX2sZr4rh/nHaYCJt20xEl/COZnB26zEE3xNBucUw==", null, false, "ae53fd5c-4eec-46a3-a9af-f72cf735c84e", false, "latoya93@email.com" },
                    { "57650b32-15eb-45bc-86de-9aa3c9453309", 0, "20211e25-a758-42cf-adea-463ca5faf2ce", "Levi_Trantow83@email.com", false, "Levi", "Trantow", false, null, "levi_trantow83@email.com", "levi_trantow83@email.com", "AQAAAAIAAYagAAAAEPAiy1mU7IFWt0xyIFCIAvHccPzd1+FUT0pw2On7wYhhYV/Fl9qcXbSLfjQAFKxCGw==", null, false, "2d560358-96cb-4ef1-b684-b2c5664ef2ef", false, "levi_trantow83@email.com" },
                    { "a98f4a90-23d2-477d-be11-b13842692679", 0, "26a2359a-7e21-43db-8cb5-6c0f147818d9", "Fred56@email.com", false, "Fred", "Heller", false, null, "fred56@email.com", "fred56@email.com", "AQAAAAIAAYagAAAAEBEQXtGscyrt7SGoeAi3Ek3x20EFLosGz2nrg1xntwVyL50s5gzjNY+8xnE5POyKPA==", null, false, "ecf81f85-99b0-4186-9b4f-edd80bd9ae19", false, "fred56@email.com" },
                    { "ba8f572e-0193-40a8-8f2b-97e6e36979cb", 0, "7b7b655b-360e-49ae-b7e9-29af6e2bde97", "Clay96@email.com", false, "Clay", "Robel", false, null, "clay96@email.com", "clay96@email.com", "AQAAAAIAAYagAAAAEJGkjhhdhEJB4XQt3un6bHcBxz9mIUlLiQyXvcdGF/bVAyad+83URneylUugP5pm9g==", null, false, "0d54c293-49be-4896-b405-66efb796a2df", false, "clay96@email.com" },
                    { "c107dc83-afe5-48f5-996f-1a20ae8beb62", 0, "0125e370-e754-44e3-b783-d978ae866bb5", "Rickey48@email.com", false, "Rickey", "Bashirian", false, null, "rickey48@email.com", "rickey48@email.com", "AQAAAAIAAYagAAAAEM9I8YVZBBiNoY2qAyf+txWk3G/15eh3NnGToIiDJOtTXTBFq+SnbhAbZoMcKT8qUQ==", null, false, "4b457127-612d-4023-8608-95a4b30a9280", false, "rickey48@email.com" }
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
                unique: true);

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
                unique: true);
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
