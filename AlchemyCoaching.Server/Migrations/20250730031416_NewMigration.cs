using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlchemyCoaching.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
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
                    Coach = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "ClientId", "Coach", "Location", "Note", "Time" },
                values: new object[,]
                {
                    { 1, "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, 0, "Deleniti soluta dolore quidem et. Ipsam voluptatem hic sed rerum qui qui enim nisi earum. Cumque corporis asperiores eum.", new DateTime(2025, 3, 27, 7, 40, 24, 249, DateTimeKind.Unspecified).AddTicks(7444) },
                    { 2, "4b7f463b-2129-4ab2-adfb-c7f1ae861f5a", 0, 0, "Quaerat nihil voluptate fugiat corporis reiciendis. Consectetur iusto occaecati nemo doloribus corrupti et placeat aut ipsum. Libero reprehenderit quos non laborum cupiditate ut. Delectus explicabo tempore. Dolorum ut perspiciatis rerum. Rerum sit nihil a.", new DateTime(2025, 12, 13, 20, 16, 25, 977, DateTimeKind.Unspecified).AddTicks(2477) },
                    { 3, "4b7f463b-2129-4ab2-adfb-c7f1ae861f5a", 0, 0, "Aspernatur autem error et praesentium.\nQuia consequatur non eaque.\nTotam suscipit reprehenderit omnis.\nQui voluptates suscipit voluptas velit rerum rerum nemo magni aliquam.\nConsequatur modi est animi eum ipsa.\nBeatae doloribus dolor dolores qui dolore sunt accusantium qui sunt.", new DateTime(2025, 12, 6, 21, 24, 59, 371, DateTimeKind.Unspecified).AddTicks(8935) },
                    { 4, "35bc7f81-b492-487f-981d-767d4d1605f8", 0, 0, "Illum quis soluta.", new DateTime(2025, 10, 18, 10, 25, 49, 401, DateTimeKind.Unspecified).AddTicks(5705) },
                    { 5, "c6654d38-aa6d-48cb-9510-9c37b6cac539", 0, 0, "nihil", new DateTime(2025, 8, 29, 10, 0, 43, 780, DateTimeKind.Unspecified).AddTicks(9941) },
                    { 6, "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, 0, "voluptates", new DateTime(2025, 12, 24, 19, 38, 36, 676, DateTimeKind.Unspecified).AddTicks(6463) },
                    { 7, "2557440c-ce23-4bb7-9e56-415c896895f9", 0, 0, "In rerum blanditiis tempora dolor.\nNesciunt in reprehenderit fugiat.\nMolestiae ex quo tempore molestias iure qui nostrum.\nVoluptatem dolore aut.", new DateTime(2025, 6, 4, 1, 10, 59, 480, DateTimeKind.Unspecified).AddTicks(8457) },
                    { 8, "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, 0, "dolor", new DateTime(2025, 8, 28, 15, 58, 52, 746, DateTimeKind.Unspecified).AddTicks(8031) },
                    { 9, "9df337a9-1d0e-4986-aa74-d4aa690b3e1a", 0, 0, "Alias ipsa ullam aut temporibus qui mollitia beatae. Corporis et consequatur accusamus delectus culpa. Aliquid possimus esse sit rerum deserunt dolores aut autem. Provident rerum numquam autem expedita minus iusto consequatur aut eum. Eum excepturi suscipit fugiat odio alias. Aut consequatur quas delectus sit sunt.", new DateTime(2025, 6, 26, 17, 52, 42, 911, DateTimeKind.Unspecified).AddTicks(9106) },
                    { 10, "c6654d38-aa6d-48cb-9510-9c37b6cac539", 0, 0, "Eaque id incidunt voluptatibus. Vero minima nihil omnis molestias mollitia molestiae sit maxime. Et sequi esse voluptates ut dignissimos enim similique ut harum. Repellat aut fugiat aut consequuntur qui.", new DateTime(2025, 11, 16, 11, 0, 32, 881, DateTimeKind.Unspecified).AddTicks(6237) },
                    { 11, "d99dc1a4-6e16-492d-8151-90b6aa2d7d7f", 0, 0, "rerum", new DateTime(2025, 6, 5, 3, 38, 45, 338, DateTimeKind.Unspecified).AddTicks(8363) },
                    { 12, "2557440c-ce23-4bb7-9e56-415c896895f9", 0, 0, "Qui qui odio nemo perferendis.\nIpsa hic facere totam.\nQuaerat debitis consequatur et temporibus dolores mollitia.\nNulla vero alias repellendus vero.\nCulpa in ex qui.", new DateTime(2025, 10, 13, 14, 11, 34, 695, DateTimeKind.Unspecified).AddTicks(8085) },
                    { 13, "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, 0, "consectetur", new DateTime(2025, 7, 10, 15, 28, 18, 765, DateTimeKind.Unspecified).AddTicks(8210) },
                    { 14, "2557440c-ce23-4bb7-9e56-415c896895f9", 0, 0, "Esse id reprehenderit est reprehenderit.\nQui et eos exercitationem omnis porro accusamus.\nEaque et est beatae.\nMolestias cumque nesciunt voluptas veniam nihil quis est quod harum.\nSint natus neque id quis facilis fuga sequi reprehenderit.", new DateTime(2025, 8, 30, 20, 35, 10, 461, DateTimeKind.Unspecified).AddTicks(1473) },
                    { 15, "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, 0, "Ut minus et a.", new DateTime(2025, 12, 11, 5, 19, 46, 563, DateTimeKind.Unspecified).AddTicks(3412) },
                    { 16, "6507f074-b299-4abb-8b9c-c69d59a11504", 0, 0, "Et molestiae rerum deleniti non amet sit.\nQui dolorem sed et quisquam hic aliquid.", new DateTime(2025, 9, 5, 1, 21, 32, 262, DateTimeKind.Unspecified).AddTicks(2074) },
                    { 17, "6507f074-b299-4abb-8b9c-c69d59a11504", 0, 0, "Qui quisquam magnam sint eos aut iste quia.", new DateTime(2025, 10, 26, 21, 55, 12, 505, DateTimeKind.Unspecified).AddTicks(4650) },
                    { 18, "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, 0, "rerum", new DateTime(2025, 8, 30, 18, 45, 24, 618, DateTimeKind.Unspecified).AddTicks(4056) },
                    { 19, "d99dc1a4-6e16-492d-8151-90b6aa2d7d7f", 0, 0, "Quidem id totam magnam aut quia. Aut ipsa animi accusantium voluptas eos. Est et ut fugit sed.", new DateTime(2025, 4, 16, 2, 18, 52, 384, DateTimeKind.Unspecified).AddTicks(8799) },
                    { 20, "4b7f463b-2129-4ab2-adfb-c7f1ae861f5a", 0, 0, "Consectetur enim repellendus.", new DateTime(2025, 7, 10, 7, 0, 6, 500, DateTimeKind.Unspecified).AddTicks(907) },
                    { 21, "35bc7f81-b492-487f-981d-767d4d1605f8", 0, 0, "Facere velit error alias autem adipisci nobis et voluptatum dolorem.\nQuod in omnis corporis.\nNihil culpa voluptatem ut et laborum a.\nBlanditiis et minima illum esse.", new DateTime(2025, 4, 2, 14, 5, 40, 350, DateTimeKind.Unspecified).AddTicks(3848) },
                    { 22, "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, 0, "Earum debitis ipsa sequi et occaecati eius.", new DateTime(2025, 5, 25, 10, 8, 10, 144, DateTimeKind.Unspecified).AddTicks(4994) },
                    { 23, "6507f074-b299-4abb-8b9c-c69d59a11504", 0, 0, "Consequatur sit aut harum eos.\nVoluptatem id molestias temporibus.\nQuasi harum saepe amet.\nVeniam unde minus aut.", new DateTime(2025, 9, 16, 23, 53, 14, 339, DateTimeKind.Unspecified).AddTicks(2406) },
                    { 24, "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, 0, "Consequatur aut non dolore enim nesciunt. Voluptatem exercitationem quia sapiente sunt id rem consequatur. In dolorem mollitia soluta tempora modi odio sed. Eos veniam ab nisi ut.", new DateTime(2025, 2, 2, 16, 29, 22, 66, DateTimeKind.Unspecified).AddTicks(5581) },
                    { 25, "d99dc1a4-6e16-492d-8151-90b6aa2d7d7f", 0, 0, "Qui quam est aut.", new DateTime(2025, 5, 6, 3, 47, 4, 696, DateTimeKind.Unspecified).AddTicks(3799) },
                    { 26, "6507f074-b299-4abb-8b9c-c69d59a11504", 0, 0, "Ipsa distinctio officia illo voluptatem corporis aut.", new DateTime(2025, 1, 11, 22, 38, 12, 562, DateTimeKind.Unspecified).AddTicks(716) },
                    { 27, "c6654d38-aa6d-48cb-9510-9c37b6cac539", 0, 0, "Voluptatem et quam placeat laborum eveniet.\nDolor et quam perferendis pariatur sed voluptas vitae aut consectetur.\nEt sint aut vitae cumque ut eaque ea sit.\nEst necessitatibus laborum est.", new DateTime(2025, 5, 3, 11, 12, 24, 741, DateTimeKind.Unspecified).AddTicks(5374) },
                    { 28, "4b7f463b-2129-4ab2-adfb-c7f1ae861f5a", 0, 0, "Itaque nihil est at.\nQuo unde autem eaque aperiam et libero perspiciatis.", new DateTime(2025, 12, 8, 14, 37, 41, 732, DateTimeKind.Unspecified).AddTicks(7399) },
                    { 29, "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, 0, "Eaque officia aut.\nVoluptatem voluptate aut eaque distinctio perspiciatis.", new DateTime(2025, 2, 7, 15, 17, 34, 270, DateTimeKind.Unspecified).AddTicks(3931) },
                    { 30, "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, 0, "Eos impedit explicabo rem aut rerum suscipit.", new DateTime(2025, 6, 11, 11, 39, 20, 663, DateTimeKind.Unspecified).AddTicks(2395) }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e38844f-a3d6-4c5c-9ce5-84799105b249", null, "Client", "CLIENT" },
                    { "5fc772b7-f0b2-475f-987f-9fd5cfc43886", null, "Admin", "ADMIN" },
                    { "bd1efe44-7a72-4014-b3b1-9193bdd420bf", null, "Coach", "COACH" }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000000", 0, "78f139ad-bac0-456c-bc25-8e68d12f2784", "alisonjoyforster@gmail.com", false, false, null, "alisonjoyforster@gmail.com", "alison", "AQAAAAIAAYagAAAAEN1+YUvTQUfF4BY2XEDNILwoCLQrSqSTC40wuS0RlSYGfbKH8EhdUejAIxR9czTKdw==", null, false, "94e15e72-2136-44b8-9b00-bde0f26188ee", false, "Alison" },
                    { "2557440c-ce23-4bb7-9e56-415c896895f9", 0, "2b8c2053-fa94-4e33-a2f9-2acea425a4bf", "Charlotte79@email.com", false, false, null, "charlotte79@email.com", "charlotte_wolff86", "AQAAAAIAAYagAAAAEJuzEkoJCXBc906zQ9ONxSm69SltXaV1LmrBYyBCC5ufPTWv3KFr1X1d3oCwNfTLlw==", null, false, "ad48f279-7112-4f69-a92b-06d76cfc5299", false, "Charlotte_Wolff86" },
                    { "35bc7f81-b492-487f-981d-767d4d1605f8", 0, "90179e32-a78d-4481-95d7-beb6e3dcfd32", "Bradley.Howell86@email.com", false, false, null, "bradley.howell86@email.com", "bradley.howell", "AQAAAAIAAYagAAAAEPllpA9l0a/ighXJ8iFdAOOpZFB3efF1MAHusWJBZecWRFxUiH6YDSpCLn2ZDqC67g==", null, false, "51797b54-78d8-41c7-a875-259ff05b8864", false, "Bradley.Howell" },
                    { "46c2621d-c662-47c6-8d58-ee683fb12e6a", 0, "87dcabf7-32e1-4100-a374-02f16eceda03", "Gilbert35@email.com", false, false, null, "gilbert35@email.com", "gilbert24", "AQAAAAIAAYagAAAAEJ5k6vr+J+Tg2uA+Ws+dAhpuLUYKAzyfKKL/R2p6bIvOY2RCTByxkON4tvoMFdwS/g==", null, false, "bb310fc4-5f9a-4768-b497-bb8a6f22e8a2", false, "Gilbert24" },
                    { "4b7f463b-2129-4ab2-adfb-c7f1ae861f5a", 0, "7fb8f0c5-0e0d-4b52-9620-961e8ce96d31", "Malcolm.Gerhold75@email.com", false, false, null, "malcolm.gerhold75@email.com", "malcolm.gerhold47", "AQAAAAIAAYagAAAAEDUhQaRt/NqodAq2STg9cjZziJFvcT38gaGmHs52XZaF21BJprHzxUkmU45AZC6E0Q==", null, false, "e4c20f60-ea78-47c3-97d5-713fb10ee9bb", false, "Malcolm.Gerhold47" },
                    { "6507f074-b299-4abb-8b9c-c69d59a11504", 0, "34a44e2c-eaa1-4c92-bbb2-20d72e9719c3", "Melody_Morar@email.com", false, false, null, "melody_morar@email.com", "melody2", "AQAAAAIAAYagAAAAEBWBAR3OAJ3v3IH8yHXx7zufsx79GHsuOeDVWx0b1Te8/74HwXwhaEM3vaiDwJAwDw==", null, false, "e8e14515-805f-48c8-ba39-19f2851fdf81", false, "Melody2" },
                    { "8a5bfbc4-50ff-46fc-a2eb-9cc63ded88e3", 0, "22ff1534-10e4-4ec2-b708-9480734c9407", "Edwin_Funk@email.com", false, false, null, "edwin_funk@email.com", "edwin_funk85", "AQAAAAIAAYagAAAAEN+P9vYRyHsQysQm4TccgYHDlAxOhq0CqFzk4ZXkTEdo4PKsDmYYvkIwPkXzTa72lg==", null, false, "52cbab99-794a-420f-a1f6-9173bca478cd", false, "Edwin_Funk85" },
                    { "9df337a9-1d0e-4986-aa74-d4aa690b3e1a", 0, "dd0a8247-e368-4aac-9123-4c4d8aa54815", "Maggie.Runolfsson@email.com", false, false, null, "maggie.runolfsson@email.com", "maggie17", "AQAAAAIAAYagAAAAEFWHXiny+gadWLK9sDRHwwygHWrRCwwag2bk8P01fKZb2Bq1Z0LaBUaV6XCGV1tN6w==", null, false, "6a3ab2da-d472-460a-96ba-2596214c2426", false, "Maggie17" },
                    { "a7f0f254-4b16-45bf-9b58-223b1758279f", 0, "557cefee-436d-4028-bc77-781d1ab482e5", "Alexandra.Thiel41@email.com", false, false, null, "alexandra.thiel41@email.com", "alexandra88", "AQAAAAIAAYagAAAAEGC936xdz8IIzuZ4fzj38/6JByCxtikzWf17VJtUGxGrB04Mp4is7jdX9sjR/Qb4kQ==", null, false, "b07ee2eb-e29f-4f81-a0ac-dbe2ec61abc6", false, "Alexandra88" },
                    { "c6654d38-aa6d-48cb-9510-9c37b6cac539", 0, "0e8c6f19-f65a-4063-a99d-77df7de96a33", "Charlotte63@email.com", false, false, null, "charlotte63@email.com", "charlotte78", "AQAAAAIAAYagAAAAEMldfGyRHZalk9QHTvTRZiSx8LL2rU6sT0rjbGS9RltGxwldOBWcDA+wSmFreoiY8g==", null, false, "9ef0a72f-3162-48eb-93d9-f6c2ed340bcd", false, "Charlotte78" },
                    { "d99dc1a4-6e16-492d-8151-90b6aa2d7d7f", 0, "4f14225c-408f-4f82-a7e2-3693fe543711", "Edmund87@email.com", false, false, null, "edmund87@email.com", "edmund22", "AQAAAAIAAYagAAAAEGkSRZtnRpsBmVYCCDtEmsqvnzhuEkYEjJfGhziBzaNqZmId7JwqYDlEZ6PVEtmS5Q==", null, false, "8e57d869-76fd-4d20-b29a-04404e8a4afc", false, "Edmund22" }
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
