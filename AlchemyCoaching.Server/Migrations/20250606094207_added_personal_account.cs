using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlchemyCoaching.Server.Migrations
{
    /// <inheritdoc />
    public partial class added_personal_account : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832227a6-1a9d-479d-b276-1df539980696");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d20c16e7-48c7-438f-97c4-c5587216c884");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "026107dd-c265-48dd-9118-ce8399e47315");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "051ec062-149f-4280-9968-451ed0f27017");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c073eab-8027-4b88-931f-80033082b0d9");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40aedae8-36a2-4977-9867-860d5bcbbd0f");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "470cdc87-5a39-41f5-a7fe-574f11d32c27");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56644ae5-0f9b-4e28-be4e-3b06cb60457b");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bedddae-6d72-4538-aaab-0461e2ff2c75");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8a8a600-ec2e-4c52-aa1d-70e1b0de6cb8");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bff1a9ce-5b3e-4762-9f87-679898fab278");

            migrationBuilder.DropColumn(
                name: "FirstName",
                schema: "AlchemyCoaching",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "0f3d69cb-418e-4810-b56b-152226572cf3", "Ut tempora sit rerum corporis.\nVoluptatem dolores quia quos officia voluptate temporibus.\nAsperiores nemo fugiat facilis reprehenderit ab.", new DateTime(2025, 11, 7, 0, 44, 2, 220, DateTimeKind.Unspecified).AddTicks(1834) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "Et animi voluptate nihil aut impedit nobis.\nSimilique voluptatem tempore et molestiae error.\nDolore sunt suscipit in.\nQuasi dolor aperiam modi similique tempore qui est.", new DateTime(2025, 8, 19, 1, 33, 5, 990, DateTimeKind.Unspecified).AddTicks(9214) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "24d787eb-988d-48fa-997a-d051ceb30443", "Nam ex tenetur eos dolor exercitationem non molestias tempore. Tenetur aut distinctio consequatur asperiores. Illo aut provident sunt saepe sequi. Labore ad nostrum qui maxime aliquam. Aspernatur repellendus qui. Illo corporis occaecati odit repellat voluptatum recusandae eum.", new DateTime(2025, 10, 2, 16, 50, 18, 792, DateTimeKind.Unspecified).AddTicks(8219) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "Iure tempora qui fuga magni hic facilis fugiat et quo.\nDicta doloremque qui autem amet molestiae.\nUt suscipit quaerat inventore eum incidunt natus rerum quaerat.\nOfficia quia qui fugiat et dignissimos.\nSoluta numquam aliquid exercitationem est doloremque voluptatem labore aperiam blanditiis.", new DateTime(2025, 1, 7, 5, 6, 14, 866, DateTimeKind.Unspecified).AddTicks(4851) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "22a759bf-3ec9-457f-936f-92ac29a9a4c0", "Quae expedita repudiandae a. Et aut dolor ut vitae dolor atque incidunt. Dolor omnis quam voluptatem minus nihil ut praesentium. Odit cumque iusto aut vitae unde possimus ad consequatur est.", new DateTime(2025, 3, 26, 5, 33, 42, 326, DateTimeKind.Unspecified).AddTicks(493) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "22a759bf-3ec9-457f-936f-92ac29a9a4c0", "Qui cumque enim.\nMaiores totam iste nobis natus officia.\nIn reprehenderit dolores veniam.\nEst eligendi voluptatem nisi cupiditate quam nobis qui illo.", new DateTime(2025, 5, 25, 9, 43, 26, 849, DateTimeKind.Unspecified).AddTicks(5807) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "consequatur", new DateTime(2025, 6, 26, 10, 41, 47, 747, DateTimeKind.Unspecified).AddTicks(1068) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "0f3d69cb-418e-4810-b56b-152226572cf3", "Nostrum non iusto accusamus libero sunt vel sit.\nEx voluptatem rerum voluptatem.\nAutem eum modi ipsa reprehenderit sit deleniti et.\nFacere ducimus maxime eum quo.\nAtque vel reprehenderit dolores distinctio quasi et harum.\nReiciendis aut quo quibusdam fuga ea modi dolore non.", new DateTime(2025, 3, 12, 4, 37, 27, 410, DateTimeKind.Unspecified).AddTicks(8201) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "cf11da01-c496-4ecf-bc14-4797ef095626", "Consequuntur dolores est nemo eaque nemo.", new DateTime(2025, 1, 14, 2, 51, 2, 211, DateTimeKind.Unspecified).AddTicks(7190) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "occaecati", new DateTime(2025, 6, 25, 13, 22, 10, 69, DateTimeKind.Unspecified).AddTicks(466) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c", "Ut dolorem optio dolore est nihil facilis in explicabo.\nCommodi et sit assumenda temporibus tempora.\nEt quos dignissimos et veniam.\nHarum aut et quisquam adipisci modi.\nEt deserunt facere vitae impedit.", new DateTime(2025, 10, 9, 12, 27, 0, 790, DateTimeKind.Unspecified).AddTicks(6489) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "7030506a-b1d8-45c9-a581-3950f3f74bbe", "officiis", new DateTime(2025, 9, 25, 0, 34, 53, 927, DateTimeKind.Unspecified).AddTicks(4212) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "22a759bf-3ec9-457f-936f-92ac29a9a4c0", "Ab et occaecati. Ipsum assumenda aut. Et doloribus ut aut labore quo asperiores et. Dolorem et doloribus soluta et eum omnis vel eaque eum. Architecto quod et enim voluptatem excepturi sint vel consequatur vitae. Architecto sed natus natus totam.", new DateTime(2025, 6, 29, 3, 4, 59, 661, DateTimeKind.Unspecified).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "24d787eb-988d-48fa-997a-d051ceb30443", "Quam velit quia id et qui distinctio repellendus ut.\nAliquid animi qui cupiditate quis.\nAssumenda sunt nostrum qui vitae eaque aperiam perferendis saepe.\nVoluptatem dolor non possimus aliquam.\nNon dolorem velit minus culpa omnis modi.", new DateTime(2025, 11, 18, 15, 46, 42, 45, DateTimeKind.Unspecified).AddTicks(5065) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f9be045b-3249-4c04-b9f3-5dd92a44567b", "Quos deserunt quidem.", new DateTime(2025, 12, 24, 13, 27, 35, 116, DateTimeKind.Unspecified).AddTicks(7303) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "Officia voluptate maiores.\nSaepe ullam fuga vero et quae atque.\nFacilis consequatur incidunt voluptas.\nIpsam error voluptatem mollitia commodi et.", new DateTime(2025, 3, 28, 20, 41, 25, 846, DateTimeKind.Unspecified).AddTicks(6144) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "cf11da01-c496-4ecf-bc14-4797ef095626", "Totam molestiae deserunt earum voluptates atque atque sunt. Possimus sit iste necessitatibus accusamus aut nesciunt. Dolor necessitatibus officiis in adipisci velit aut esse alias est.", new DateTime(2025, 10, 17, 22, 1, 38, 648, DateTimeKind.Unspecified).AddTicks(1387) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "22a759bf-3ec9-457f-936f-92ac29a9a4c0", "Omnis corporis iste possimus quae molestiae.", new DateTime(2025, 2, 7, 7, 21, 0, 682, DateTimeKind.Unspecified).AddTicks(8076) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f4db7fc8-ca9f-429e-a87a-f782be825b63", "Quod quisquam eos veniam.", new DateTime(2025, 1, 10, 6, 59, 39, 524, DateTimeKind.Unspecified).AddTicks(9803) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f4db7fc8-ca9f-429e-a87a-f782be825b63", "qui", new DateTime(2025, 5, 23, 15, 0, 39, 523, DateTimeKind.Unspecified).AddTicks(5410) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", "Dolorem beatae quos distinctio dolorem et necessitatibus quas cumque.", new DateTime(2025, 7, 3, 6, 39, 36, 875, DateTimeKind.Unspecified).AddTicks(9816) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f4db7fc8-ca9f-429e-a87a-f782be825b63", "Dolores nihil quia consectetur magnam et deleniti pariatur vel esse.\nRecusandae voluptate sint cum tempora consequatur aperiam ratione placeat eos.\nUt eaque voluptatibus ut voluptas ducimus voluptatem id porro.\nHic eos nam cumque perferendis libero veritatis.", new DateTime(2025, 7, 28, 16, 47, 57, 524, DateTimeKind.Unspecified).AddTicks(2622) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "0f3d69cb-418e-4810-b56b-152226572cf3", "Odio voluptas dolore a.\nIpsum itaque aut ipsa.\nNon ut sunt.\nVoluptates dolor consequuntur omnis sint natus.\nNon fugiat aliquid omnis et officia ipsum at et.\nQui quam sunt eos voluptates nihil dolore est.", new DateTime(2025, 11, 4, 18, 32, 19, 873, DateTimeKind.Unspecified).AddTicks(8497) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f9be045b-3249-4c04-b9f3-5dd92a44567b", "Perferendis eaque cumque culpa suscipit accusantium.", new DateTime(2025, 1, 22, 22, 28, 59, 8, DateTimeKind.Unspecified).AddTicks(4384) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c", "Vel alias nesciunt maiores dolores vel explicabo sit consectetur. Quia ab voluptatem at voluptas vel dolores aut. Magni est quis quaerat doloremque voluptatem non enim voluptatem ex. Nobis accusamus voluptatem id suscipit consequatur ut sint.", new DateTime(2025, 1, 14, 21, 10, 0, 443, DateTimeKind.Unspecified).AddTicks(6607) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c", "ut", new DateTime(2025, 3, 29, 7, 56, 40, 953, DateTimeKind.Unspecified).AddTicks(5323) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c", "Illo architecto sunt in voluptas.", new DateTime(2025, 6, 28, 1, 20, 44, 244, DateTimeKind.Unspecified).AddTicks(6701) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "cf11da01-c496-4ecf-bc14-4797ef095626", "Excepturi a iusto autem dolorum sint veniam mollitia ut.", new DateTime(2025, 10, 29, 16, 46, 14, 482, DateTimeKind.Unspecified).AddTicks(5543) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "7030506a-b1d8-45c9-a581-3950f3f74bbe", "Omnis exercitationem voluptas maiores enim perferendis assumenda id harum ratione. Magnam enim molestiae. Sed vel eligendi. A facilis sit veniam. Nobis nobis ullam exercitationem expedita et ut.", new DateTime(2025, 5, 29, 2, 39, 29, 77, DateTimeKind.Unspecified).AddTicks(5525) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "24d787eb-988d-48fa-997a-d051ceb30443", "Enim ut tempora.\nOmnis voluptatem nihil voluptas rerum ipsa atque enim veniam.\nEt animi et amet assumenda.\nConsequatur ut nemo sapiente ullam inventore molestiae.\nEt sint est omnis placeat.", new DateTime(2025, 7, 11, 3, 7, 49, 287, DateTimeKind.Unspecified).AddTicks(3725) });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4c191e43-2919-4428-a98c-c59ddf08866a", null, "Coach", "COACH" },
                    { "512127ad-d7ec-44f8-afc4-6fc3abf7ba5a", null, "Client", "CLIENT" },
                    { "d01a4ba0-f4be-491f-b542-07ab6e65940b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00000000-0000-0000-0000-000000000000", 0, "4aa6a278-afe2-4472-a99c-f8825b6abab7", "alisonjoyforster@gmail.com", false, false, null, "Alison", "alisonjoyforster@gmail.com", "alisonjoyforster@gmail.com", "AQAAAAIAAYagAAAAEFDSzyGxN8Wgujb4tqYb4NdeE5dQR23ysQzoD4zcOTWrS32pWaevqZELA4IuY5K05g==", null, false, 0, "f755f7c6-2b36-4af5-8f1b-31bf78ea398a", false, "alisonjoyforster@gmail.com" },
                    { "0f3d69cb-418e-4810-b56b-152226572cf3", 0, "4bc90bf9-4961-4333-85bd-b8ee9c00dc70", "Rufus54@email.com", false, false, null, "Rufus", "rufus54@email.com", "rufus54@email.com", "AQAAAAIAAYagAAAAED7V13D1pOPpvHX7oYAgqo3q9XASSCI6Nh0/9ZQPFho3AXSy+gwA6TKfN3zvW4iXhQ==", null, false, 0, "da1dcc35-c100-4cbf-a02d-d773bf16390d", false, "rufus54@email.com" },
                    { "22a759bf-3ec9-457f-936f-92ac29a9a4c0", 0, "d2ac754f-6af4-406a-87f9-dfa00756cdbf", "Joanna15@email.com", false, false, null, "Joanna", "joanna15@email.com", "joanna15@email.com", "AQAAAAIAAYagAAAAEGz/Y+kEZORn3Bx6bFimiKuE+7thQZ5c+82GNSIFSAYKyPUCO7/Wq7Flr2nC4BHw9g==", null, false, 0, "d01510c5-72d3-42df-89c6-91b80cc3b3dc", false, "joanna15@email.com" },
                    { "24d787eb-988d-48fa-997a-d051ceb30443", 0, "28886f9d-76c7-48d7-9913-a5bb0cbae805", "Jake.Tillman@email.com", false, false, null, "Jake", "jake.tillman@email.com", "jake.tillman@email.com", "AQAAAAIAAYagAAAAEDxhS2xIwv2spfHYSiNz4d0rQhKOfj7gkQA5XvK/0i6opPiJCtBvhM7WBSPXlr4f4Q==", null, false, 0, "8a8bb477-4ee8-4089-b9b5-a6dd725fc12f", false, "jake.tillman@email.com" },
                    { "662ee75a-277e-45e9-b435-52b5f4dfd9c6", 0, "336ac572-c72c-46b8-a213-19753cc944ad", "Courtney6@email.com", false, false, null, "Courtney", "courtney6@email.com", "courtney6@email.com", "AQAAAAIAAYagAAAAEGwfFCaKZd2IWH4TjI4jbDGExX1ZVEdCqX1BpWjiczgOfr3QUcvn2Ofdpvp2Gs/ijQ==", null, false, 0, "dcecf067-cc1f-416e-900a-cdc33aeb7ba2", false, "courtney6@email.com" },
                    { "7030506a-b1d8-45c9-a581-3950f3f74bbe", 0, "7c2f761d-d0f9-45d2-a9a7-dc3dee799401", "Edwin.Zboncak@email.com", false, false, null, "Edwin", "edwin.zboncak@email.com", "edwin.zboncak@email.com", "AQAAAAIAAYagAAAAEB/HAREkc+zv0jNINJWoEY8nNwTlyO3Wsz3no2h5yVSrlSD3cPHC0CnUOW3tJyyzyA==", null, false, 0, "bca2fede-6eb6-430e-b5da-b9b9efe96660", false, "edwin.zboncak@email.com" },
                    { "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c", 0, "ef356099-d159-43cb-bf2c-164706af4039", "Tracy64@email.com", false, false, null, "Tracy", "tracy64@email.com", "tracy64@email.com", "AQAAAAIAAYagAAAAEO5al1vQ0wSw+vdOHt3YLMvRGbptRCcmpakNvkq+G6iIATGOEvu+1Ag8MblBtgkn+Q==", null, false, 0, "b16da18b-c4b3-4f2d-b2cc-41d5baa35fa4", false, "tracy64@email.com" },
                    { "cc74c0ab-64de-4626-b9df-a8031a24cb41", 0, "aa28abe9-eb97-423b-b30f-e7656ea9853b", "Bobbie66@email.com", false, false, null, "Bobbie", "bobbie66@email.com", "bobbie66@email.com", "AQAAAAIAAYagAAAAEL6J4gFyKOV43XUjGjYPb/UpllRZxV2Hy0sipPHr17G1lJkXtBiBsx5WAMce++brbA==", null, false, 0, "a94005dd-d071-4457-ac0a-165135b26b74", false, "bobbie66@email.com" },
                    { "cf11da01-c496-4ecf-bc14-4797ef095626", 0, "0ffda498-3b3a-490e-857a-f7389e43883f", "Margie99@email.com", false, false, null, "Margie", "margie99@email.com", "margie99@email.com", "AQAAAAIAAYagAAAAEKSf9oW8eZQl774G5pxzydpbBDp6xhyqTkLFnRB9wF26dBoH9cEumsJKseIvCQQE4A==", null, false, 0, "76d084f6-0425-411d-ac6a-f96c7ede0fad", false, "margie99@email.com" },
                    { "f4db7fc8-ca9f-429e-a87a-f782be825b63", 0, "2cea5f10-149c-4a3e-bf22-a1b7d091c387", "Wayne11@email.com", false, false, null, "Wayne", "wayne11@email.com", "wayne11@email.com", "AQAAAAIAAYagAAAAEL5dwWZilhgF2JO8Q4FJ8bq5cklzRmMjt8CqAYFnKXSvNMmUm02PVS0tG+M7mGOzMw==", null, false, 0, "41944c9a-af50-4968-9e76-2ba95efc6abd", false, "wayne11@email.com" },
                    { "f9be045b-3249-4c04-b9f3-5dd92a44567b", 0, "af5b2b11-a3f5-4721-8099-10a0a1c3efb5", "Gabriel56@email.com", false, false, null, "Gabriel", "gabriel56@email.com", "gabriel56@email.com", "AQAAAAIAAYagAAAAEOb7MqsB49xlq1OwDMvbZlgSvGnHJR6010FwGmOSI1xLM7Fsm/h7tYZP1gmJxE0fcQ==", null, false, 0, "9587989f-1166-4aa1-8980-e90423233c98", false, "gabriel56@email.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c191e43-2919-4428-a98c-c59ddf08866a");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "512127ad-d7ec-44f8-afc4-6fc3abf7ba5a");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d01a4ba0-f4be-491f-b542-07ab6e65940b");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f3d69cb-418e-4810-b56b-152226572cf3");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22a759bf-3ec9-457f-936f-92ac29a9a4c0");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24d787eb-988d-48fa-997a-d051ceb30443");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "662ee75a-277e-45e9-b435-52b5f4dfd9c6");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7030506a-b1d8-45c9-a581-3950f3f74bbe");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "819ef490-7486-4d9b-9e1d-2b4b6f81cb5c");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc74c0ab-64de-4626-b9df-a8031a24cb41");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf11da01-c496-4ecf-bc14-4797ef095626");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4db7fc8-ca9f-429e-a87a-f782be825b63");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9be045b-3249-4c04-b9f3-5dd92a44567b");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", "nihil", new DateTime(2025, 5, 3, 7, 54, 18, 117, DateTimeKind.Unspecified).AddTicks(3842) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "Quo ex qui reprehenderit aut eaque maiores.", new DateTime(2025, 2, 20, 20, 5, 27, 286, DateTimeKind.Unspecified).AddTicks(1655) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", "In deleniti libero vero iusto dolor perspiciatis eos.\nOdit sed est magni animi et.\nVoluptatibus suscipit et sunt quia rerum eum dolor.\nEst quo esse.\nEa similique sed nemo mollitia.", new DateTime(2025, 4, 26, 10, 18, 23, 29, DateTimeKind.Unspecified).AddTicks(8769) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "Earum unde optio mollitia officia veniam id quam.", new DateTime(2025, 1, 31, 12, 6, 5, 478, DateTimeKind.Unspecified).AddTicks(5652) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "Sint ipsa velit maiores.\nEt dolor exercitationem amet repellat ut.\nAut sed accusantium et quibusdam ut eos quo cumque quis.\nHic tempore rerum ipsa.", new DateTime(2025, 4, 13, 11, 27, 16, 141, DateTimeKind.Unspecified).AddTicks(1878) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "Nemo consectetur quasi omnis et vitae molestias sed fugit.", new DateTime(2025, 1, 30, 14, 11, 3, 467, DateTimeKind.Unspecified).AddTicks(9709) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "Dolore quisquam debitis voluptatem pariatur consequatur perspiciatis.", new DateTime(2025, 5, 5, 3, 3, 25, 780, DateTimeKind.Unspecified).AddTicks(2351) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2c073eab-8027-4b88-931f-80033082b0d9", "Aliquid rem sed sequi unde quasi exercitationem cumque tenetur.", new DateTime(2025, 6, 20, 20, 48, 47, 933, DateTimeKind.Unspecified).AddTicks(162) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "a8a8a600-ec2e-4c52-aa1d-70e1b0de6cb8", "Minus minima eius.", new DateTime(2025, 1, 8, 11, 48, 23, 827, DateTimeKind.Unspecified).AddTicks(7310) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "56644ae5-0f9b-4e28-be4e-3b06cb60457b", "Deserunt nesciunt laboriosam maiores rem.", new DateTime(2025, 4, 5, 7, 25, 30, 783, DateTimeKind.Unspecified).AddTicks(883) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "rerum", new DateTime(2025, 6, 11, 6, 4, 32, 608, DateTimeKind.Unspecified).AddTicks(9102) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2c073eab-8027-4b88-931f-80033082b0d9", "Voluptate nam eligendi consectetur. Blanditiis omnis beatae natus. Dolor delectus non sit. Sed exercitationem quos ea fuga et dolorem corrupti. Et cupiditate et consequuntur ad vitae architecto ut voluptas quasi. Sunt sit eos repellat hic inventore sunt aut illum.", new DateTime(2025, 3, 13, 0, 24, 7, 536, DateTimeKind.Unspecified).AddTicks(7412) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "470cdc87-5a39-41f5-a7fe-574f11d32c27", "Velit distinctio commodi temporibus repellendus eaque adipisci maiores accusantium reiciendis. Delectus sapiente dolorum aspernatur maxime eos reiciendis rerum atque dolores. Ratione nam esse. Et qui rerum aliquid nesciunt quod qui. Dolorum quod voluptas occaecati non beatae odio in ea illum.", new DateTime(2025, 2, 11, 22, 49, 15, 633, DateTimeKind.Unspecified).AddTicks(5720) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", "doloremque", new DateTime(2025, 6, 6, 22, 39, 23, 363, DateTimeKind.Unspecified).AddTicks(705) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", "Odit voluptate aliquid. Ratione voluptatibus dignissimos amet quisquam vel ut quis. Natus impedit quia et.", new DateTime(2025, 5, 27, 16, 48, 27, 633, DateTimeKind.Unspecified).AddTicks(5923) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "placeat", new DateTime(2025, 5, 12, 21, 37, 32, 345, DateTimeKind.Unspecified).AddTicks(9574) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", "Assumenda et necessitatibus quo sed illo qui est aspernatur dolores.\nCulpa id in quas ipsum ipsum qui illum ipsum.", new DateTime(2025, 3, 25, 22, 14, 54, 387, DateTimeKind.Unspecified).AddTicks(861) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b", "Laboriosam quod autem rerum dolores aut.", new DateTime(2025, 6, 12, 23, 21, 40, 865, DateTimeKind.Unspecified).AddTicks(2675) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", "Debitis deleniti vel ipsam dolore necessitatibus qui nobis doloremque omnis.", new DateTime(2025, 1, 6, 3, 7, 54, 357, DateTimeKind.Unspecified).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b", "Explicabo possimus cumque nisi ut iure qui. Aspernatur aut ipsa dolorem. Placeat sunt dignissimos voluptatem at autem. Velit esse esse impedit alias ea magnam blanditiis et iste. Officiis eum debitis voluptatum aut alias dolorem consequuntur ut. Voluptatem voluptatibus vel quaerat.", new DateTime(2025, 3, 23, 5, 2, 45, 948, DateTimeKind.Unspecified).AddTicks(7894) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", "Nam facere nemo perferendis sequi inventore sit harum voluptate.", new DateTime(2025, 6, 22, 21, 48, 53, 177, DateTimeKind.Unspecified).AddTicks(2818) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "Voluptas quisquam provident.", new DateTime(2025, 4, 2, 6, 27, 22, 974, DateTimeKind.Unspecified).AddTicks(5977) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "Quidem culpa non voluptas dolorem vel consequatur nobis et. Dolorem maxime sed sit. Sit excepturi corrupti dolores doloremque at. Repellendus nulla non quasi provident laboriosam qui reprehenderit asperiores. Autem commodi blanditiis adipisci voluptatem dignissimos fuga et dolores est. Quis aut et.", new DateTime(2025, 5, 11, 7, 47, 58, 499, DateTimeKind.Unspecified).AddTicks(6931) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", "Est dolorem ipsa.\nAut facilis aliquam eius quis.\nCulpa architecto sint aut.\nSit eligendi dicta.\nQui dolore eveniet et animi ea ut dolores doloremque unde.", new DateTime(2025, 3, 25, 11, 12, 18, 943, DateTimeKind.Unspecified).AddTicks(4068) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", "Quis consequatur ut doloribus harum sequi est non. Voluptatem et dolores voluptatum nihil dicta. Ut qui blanditiis aut sit vel qui in et at. Nihil minus ab quaerat pariatur non animi dicta rerum. Aut rerum et unde nam.", new DateTime(2025, 2, 18, 5, 40, 59, 893, DateTimeKind.Unspecified).AddTicks(9599) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "56644ae5-0f9b-4e28-be4e-3b06cb60457b", "Ut ullam sequi. Dignissimos debitis natus ut cumque qui aut qui. Minus dolores culpa inventore magni eveniet.", new DateTime(2025, 6, 26, 16, 8, 38, 925, DateTimeKind.Unspecified).AddTicks(336) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "est", new DateTime(2025, 2, 19, 0, 20, 58, 763, DateTimeKind.Unspecified).AddTicks(5873) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", "Quo facere vero et sint autem eius ut corporis commodi.\nDolores dolor voluptate consequatur vero.\nEnim dolorem doloribus iure consectetur veniam modi eveniet sapiente consequuntur.\nEum et iste qui ut sint repudiandae corrupti qui.", new DateTime(2025, 4, 7, 7, 44, 3, 11, DateTimeKind.Unspecified).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", "Voluptate qui laudantium officiis eius quia tenetur. Sit velit perferendis. Ipsum voluptatem eaque. Minima ab qui et et sequi laborum. Quia explicabo quia minus eveniet explicabo esse. At est maiores id.", new DateTime(2025, 2, 28, 2, 20, 9, 305, DateTimeKind.Unspecified).AddTicks(7577) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", "Illo odio voluptatem magni repudiandae et provident itaque rerum.", new DateTime(2025, 5, 10, 7, 13, 55, 368, DateTimeKind.Unspecified).AddTicks(3760) });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "832227a6-1a9d-479d-b276-1df539980696", null, "Admin", "ADMIN" },
                    { "d20c16e7-48c7-438f-97c4-c5587216c884", null, "Client", "CLIENT" }
                });

            migrationBuilder.InsertData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "026107dd-c265-48dd-9118-ce8399e47315", 0, "4e698b25-92c7-4a7e-9a72-7a15d715301c", "Charlene.Kub68@email.com", false, "Charlene", "Kub", false, null, "charlene.kub68@email.com", "charlene.kub68@email.com", "AQAAAAIAAYagAAAAEMguQb+ra+NC9eMAfRVG9IUPtSOczN9Va2e5rCDlgerpOkNEcbpjoBxwJaP2YdgOIw==", null, false, 0, "95f6f764-667c-47a4-a5a0-3138dd82d69a", false, "charlene.kub68@email.com" },
                    { "051ec062-149f-4280-9968-451ed0f27017", 0, "83b91b71-e29a-43e4-831d-24bbae89b5b1", "Anthony35@email.com", false, "Anthony", "Simonis", false, null, "anthony35@email.com", "anthony35@email.com", "AQAAAAIAAYagAAAAEP9mZyMjRlQdIJ+6aMX+RUfO8RWfKVaPuhMbZK+uzDjl7bdWVzutiH8ZhmcoLdotXQ==", null, false, 0, "af4d27eb-5981-41eb-b501-e20d22e5568d", false, "anthony35@email.com" },
                    { "2c073eab-8027-4b88-931f-80033082b0d9", 0, "c3a8128d-9a90-4837-89f3-2150ed17c6e8", "Silvia.Ward59@email.com", false, "Silvia", "Ward", false, null, "silvia.ward59@email.com", "silvia.ward59@email.com", "AQAAAAIAAYagAAAAEMIOeiRnP8R0aJufUJMl2JwFA9Yphg/Vn2FIlPSxs0j/bmMZS/vRUcO3KwK2EIyf8w==", null, false, 0, "6d43003b-b53f-471c-9342-200e864c83db", false, "silvia.ward59@email.com" },
                    { "40aedae8-36a2-4977-9867-860d5bcbbd0f", 0, "a5e07f1d-d429-4946-a508-7cd3a3852b18", "Lewis49@email.com", false, "Lewis", "Hahn", false, null, "lewis49@email.com", "lewis49@email.com", "AQAAAAIAAYagAAAAEAV9uC4NYgiLnVcGdugOFh1zEAX8InTB1j7oSlu9LZnkxeln1bYleCUntedPzQF8GQ==", null, false, 0, "e1174328-55f7-4f9f-84da-c440af329ca7", false, "lewis49@email.com" },
                    { "470cdc87-5a39-41f5-a7fe-574f11d32c27", 0, "31a460fd-2d07-4693-bb06-af9212b7a2c2", "Austin97@email.com", false, "Austin", "Hoppe", false, null, "austin97@email.com", "austin97@email.com", "AQAAAAIAAYagAAAAECALyEKT+KsSPRTZEzvIXlY9eEIj6dcEUWx2eBSj5bKkifHBd+YOCeW6vM/6gHaqxA==", null, false, 0, "6aeee979-de1d-4139-8f0f-0b980f0a0f28", false, "austin97@email.com" },
                    { "56644ae5-0f9b-4e28-be4e-3b06cb60457b", 0, "56a3eda7-9e83-4705-810b-0e89d3a1f85d", "Lauren.Shields74@email.com", false, "Lauren", "Shields", false, null, "lauren.shields74@email.com", "lauren.shields74@email.com", "AQAAAAIAAYagAAAAEOSdmceLrk3B949f5c2L8M1iposFiUOUNobn2H5oSjOXm4862ljbbp8YXvTO5w6MHA==", null, false, 0, "f28cd6a1-4c22-4d6e-abdb-76a689b94ec1", false, "lauren.shields74@email.com" },
                    { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "1f1d6442-a5d3-49c3-b36d-79979e0814fe", "Bryant_OConnell@email.com", false, "Bryant", "O'Connell", false, null, "bryant_oconnell@email.com", "bryant_oconnell@email.com", "AQAAAAIAAYagAAAAEK8Q8ii9bL1g0ZHRBrMcrx86DqZRDaXZdWdpNgLBo3buqG+4szYk35J9UxUeDMl8zw==", null, false, 0, "b786d036-bd50-47aa-908a-c3acfeaea711", false, "bryant_oconnell@email.com" },
                    { "a8a8a600-ec2e-4c52-aa1d-70e1b0de6cb8", 0, "8ed7b4e0-71d8-4bd6-a862-4c72cdea9b7f", "Jorge_Nicolas@email.com", false, "Jorge", "Nicolas", false, null, "jorge_nicolas@email.com", "jorge_nicolas@email.com", "AQAAAAIAAYagAAAAEGWjEGCMUwczwvycMziTXjIn26b4/uTfURrxe0YRIwqpCBpeObTz8QY9VbRdbK8OIg==", null, false, 0, "06d6703e-273c-49c0-8b9b-0d404073fb67", false, "jorge_nicolas@email.com" },
                    { "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b", 0, "33d4c9ff-f2ac-47ce-bc4b-a88a32f4e745", "Jessie_Mueller@email.com", false, "Jessie", "Mueller", false, null, "jessie_mueller@email.com", "jessie_mueller@email.com", "AQAAAAIAAYagAAAAEMkbLj6yZzTJHEH/ybLFBu/anHRmfma5E/875Fm3AyC9Fab0pRkpVvEND5PHBevaFw==", null, false, 0, "87269f4f-0ad6-4880-ac0a-a691a8f82567", false, "jessie_mueller@email.com" },
                    { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "c4b62ea6-cbaa-4688-aabe-04c87dddf917", "Vivian_Johnson33@email.com", false, "Vivian", "Johnson", false, null, "vivian_johnson33@email.com", "vivian_johnson33@email.com", "AQAAAAIAAYagAAAAEGWPwnpyMrh201hBZvAXNcwQ+UMf1QENKjLsfmhgx3JwxkOEqVw+/sWNeakQH1Y1RA==", null, false, 0, "f02668b9-d891-4142-b1fc-a0d47d3f6114", false, "vivian_johnson33@email.com" }
                });
        }
    }
}
