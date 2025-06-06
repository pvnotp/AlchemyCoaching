using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlchemyCoaching.Server.Migrations
{
    /// <inheritdoc />
    public partial class updated_appointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53c128ff-e28d-4f22-908c-12abed534cc5");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "761481ad-b971-49b9-9389-1f0599751dd6");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e0ff4af-05e6-4dc4-ad25-edec7652ff45");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2618f4d1-f4a8-4584-901c-57b233900da2");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41ef70d3-b947-4099-b772-b77df022cc23");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bb53c7e-feae-47c3-9bf8-d47e4b66055b");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8356b7ff-89f7-4835-b16a-7eca2102bd5b");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9844b374-0a9a-486f-8d6d-86fc85c6ceb0");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2d15849-5376-4e4b-af5d-accb1ffa3935");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d61ac6e5-72e0-4e5a-9946-10c694abeef6");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988");

            migrationBuilder.DeleteData(
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8294be2-341c-4a94-97c6-6e9f2a189070");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                schema: "AlchemyCoaching",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Coach",
                schema: "AlchemyCoaching",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "nihil", new DateTime(2025, 5, 3, 7, 54, 18, 117, DateTimeKind.Unspecified).AddTicks(3842) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "Quo ex qui reprehenderit aut eaque maiores.", new DateTime(2025, 2, 20, 20, 5, 27, 286, DateTimeKind.Unspecified).AddTicks(1655) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "In deleniti libero vero iusto dolor perspiciatis eos.\nOdit sed est magni animi et.\nVoluptatibus suscipit et sunt quia rerum eum dolor.\nEst quo esse.\nEa similique sed nemo mollitia.", new DateTime(2025, 4, 26, 10, 18, 23, 29, DateTimeKind.Unspecified).AddTicks(8769) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "Earum unde optio mollitia officia veniam id quam.", new DateTime(2025, 1, 31, 12, 6, 5, 478, DateTimeKind.Unspecified).AddTicks(5652) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "Sint ipsa velit maiores.\nEt dolor exercitationem amet repellat ut.\nAut sed accusantium et quibusdam ut eos quo cumque quis.\nHic tempore rerum ipsa.", new DateTime(2025, 4, 13, 11, 27, 16, 141, DateTimeKind.Unspecified).AddTicks(1878) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "Nemo consectetur quasi omnis et vitae molestias sed fugit.", new DateTime(2025, 1, 30, 14, 11, 3, 467, DateTimeKind.Unspecified).AddTicks(9709) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "Dolore quisquam debitis voluptatem pariatur consequatur perspiciatis.", new DateTime(2025, 5, 5, 3, 3, 25, 780, DateTimeKind.Unspecified).AddTicks(2351) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "2c073eab-8027-4b88-931f-80033082b0d9", 0, "Aliquid rem sed sequi unde quasi exercitationem cumque tenetur.", new DateTime(2025, 6, 20, 20, 48, 47, 933, DateTimeKind.Unspecified).AddTicks(162) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "a8a8a600-ec2e-4c52-aa1d-70e1b0de6cb8", 0, "Minus minima eius.", new DateTime(2025, 1, 8, 11, 48, 23, 827, DateTimeKind.Unspecified).AddTicks(7310) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "56644ae5-0f9b-4e28-be4e-3b06cb60457b", 0, "Deserunt nesciunt laboriosam maiores rem.", new DateTime(2025, 4, 5, 7, 25, 30, 783, DateTimeKind.Unspecified).AddTicks(883) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "rerum", new DateTime(2025, 6, 11, 6, 4, 32, 608, DateTimeKind.Unspecified).AddTicks(9102) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "2c073eab-8027-4b88-931f-80033082b0d9", 0, "Voluptate nam eligendi consectetur. Blanditiis omnis beatae natus. Dolor delectus non sit. Sed exercitationem quos ea fuga et dolorem corrupti. Et cupiditate et consequuntur ad vitae architecto ut voluptas quasi. Sunt sit eos repellat hic inventore sunt aut illum.", new DateTime(2025, 3, 13, 0, 24, 7, 536, DateTimeKind.Unspecified).AddTicks(7412) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "470cdc87-5a39-41f5-a7fe-574f11d32c27", 0, "Velit distinctio commodi temporibus repellendus eaque adipisci maiores accusantium reiciendis. Delectus sapiente dolorum aspernatur maxime eos reiciendis rerum atque dolores. Ratione nam esse. Et qui rerum aliquid nesciunt quod qui. Dolorum quod voluptas occaecati non beatae odio in ea illum.", new DateTime(2025, 2, 11, 22, 49, 15, 633, DateTimeKind.Unspecified).AddTicks(5720) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", 0, "doloremque", new DateTime(2025, 6, 6, 22, 39, 23, 363, DateTimeKind.Unspecified).AddTicks(705) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "Odit voluptate aliquid. Ratione voluptatibus dignissimos amet quisquam vel ut quis. Natus impedit quia et.", new DateTime(2025, 5, 27, 16, 48, 27, 633, DateTimeKind.Unspecified).AddTicks(5923) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "placeat", new DateTime(2025, 5, 12, 21, 37, 32, 345, DateTimeKind.Unspecified).AddTicks(9574) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", 0, "Assumenda et necessitatibus quo sed illo qui est aspernatur dolores.\nCulpa id in quas ipsum ipsum qui illum ipsum.", new DateTime(2025, 3, 25, 22, 14, 54, 387, DateTimeKind.Unspecified).AddTicks(861) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b", 0, "Laboriosam quod autem rerum dolores aut.", new DateTime(2025, 6, 12, 23, 21, 40, 865, DateTimeKind.Unspecified).AddTicks(2675) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "Debitis deleniti vel ipsam dolore necessitatibus qui nobis doloremque omnis.", new DateTime(2025, 1, 6, 3, 7, 54, 357, DateTimeKind.Unspecified).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "b51ecdc4-cf9e-403d-89ff-c8ce3f9f137b", 0, "Explicabo possimus cumque nisi ut iure qui. Aspernatur aut ipsa dolorem. Placeat sunt dignissimos voluptatem at autem. Velit esse esse impedit alias ea magnam blanditiis et iste. Officiis eum debitis voluptatum aut alias dolorem consequuntur ut. Voluptatem voluptatibus vel quaerat.", new DateTime(2025, 3, 23, 5, 2, 45, 948, DateTimeKind.Unspecified).AddTicks(7894) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", 0, "Nam facere nemo perferendis sequi inventore sit harum voluptate.", new DateTime(2025, 6, 22, 21, 48, 53, 177, DateTimeKind.Unspecified).AddTicks(2818) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "Voluptas quisquam provident.", new DateTime(2025, 4, 2, 6, 27, 22, 974, DateTimeKind.Unspecified).AddTicks(5977) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "Quidem culpa non voluptas dolorem vel consequatur nobis et. Dolorem maxime sed sit. Sit excepturi corrupti dolores doloremque at. Repellendus nulla non quasi provident laboriosam qui reprehenderit asperiores. Autem commodi blanditiis adipisci voluptatem dignissimos fuga et dolores est. Quis aut et.", new DateTime(2025, 5, 11, 7, 47, 58, 499, DateTimeKind.Unspecified).AddTicks(6931) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "5bedddae-6d72-4538-aaab-0461e2ff2c75", 0, "Est dolorem ipsa.\nAut facilis aliquam eius quis.\nCulpa architecto sint aut.\nSit eligendi dicta.\nQui dolore eveniet et animi ea ut dolores doloremque unde.", new DateTime(2025, 3, 25, 11, 12, 18, 943, DateTimeKind.Unspecified).AddTicks(4068) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "026107dd-c265-48dd-9118-ce8399e47315", 0, "Quis consequatur ut doloribus harum sequi est non. Voluptatem et dolores voluptatum nihil dicta. Ut qui blanditiis aut sit vel qui in et at. Nihil minus ab quaerat pariatur non animi dicta rerum. Aut rerum et unde nam.", new DateTime(2025, 2, 18, 5, 40, 59, 893, DateTimeKind.Unspecified).AddTicks(9599) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "56644ae5-0f9b-4e28-be4e-3b06cb60457b", 0, "Ut ullam sequi. Dignissimos debitis natus ut cumque qui aut qui. Minus dolores culpa inventore magni eveniet.", new DateTime(2025, 6, 26, 16, 8, 38, 925, DateTimeKind.Unspecified).AddTicks(336) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "est", new DateTime(2025, 2, 19, 0, 20, 58, 763, DateTimeKind.Unspecified).AddTicks(5873) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", 0, "Quo facere vero et sint autem eius ut corporis commodi.\nDolores dolor voluptate consequatur vero.\nEnim dolorem doloribus iure consectetur veniam modi eveniet sapiente consequuntur.\nEum et iste qui ut sint repudiandae corrupti qui.", new DateTime(2025, 4, 7, 7, 44, 3, 11, DateTimeKind.Unspecified).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "051ec062-149f-4280-9968-451ed0f27017", 0, "Voluptate qui laudantium officiis eius quia tenetur. Sit velit perferendis. Ipsum voluptatem eaque. Minima ab qui et et sequi laborum. Quia explicabo quia minus eveniet explicabo esse. At est maiores id.", new DateTime(2025, 2, 28, 2, 20, 9, 305, DateTimeKind.Unspecified).AddTicks(7577) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClientId", "Coach", "Note", "Time" },
                values: new object[] { "bff1a9ce-5b3e-4762-9f87-679898fab278", 0, "Illo odio voluptatem magni repudiandae et provident itaque rerum.", new DateTime(2025, 5, 10, 7, 13, 55, 368, DateTimeKind.Unspecified).AddTicks(3760) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Role",
                schema: "AlchemyCoaching",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Coach",
                schema: "AlchemyCoaching",
                table: "Appointment");

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", "Suscipit ipsum ea aliquid aut ut omnis et quo. Natus nisi est vero consequuntur qui. Quibusdam nihil sit. Itaque repellat excepturi accusamus sed. Enim praesentium voluptas optio tenetur et et similique magni.", new DateTime(2025, 2, 23, 19, 59, 53, 108, DateTimeKind.Unspecified).AddTicks(3833) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", "Eius facilis id quis architecto.\nNon voluptas iusto sint sit et autem consequatur.\nEst et voluptatem magni illo delectus est.\nVelit tempora libero omnis et sit autem laborum.\nVoluptatem similique consectetur reprehenderit modi est quia et corrupti.", new DateTime(2025, 3, 11, 23, 13, 56, 761, DateTimeKind.Unspecified).AddTicks(3110) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", "Aliquam ut et dicta velit quibusdam ut numquam voluptatum.\nDolores eius at debitis sint.", new DateTime(2025, 1, 25, 23, 37, 28, 112, DateTimeKind.Unspecified).AddTicks(7457) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", "Consectetur aliquam sunt et corrupti molestiae aut accusamus aperiam. Excepturi suscipit aliquam autem sunt vitae quia. Reiciendis tempora autem qui dolore.", new DateTime(2025, 3, 29, 7, 2, 13, 33, DateTimeKind.Unspecified).AddTicks(7589) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", "Consectetur libero pariatur aut sed. Explicabo porro ut qui quis qui recusandae. Tenetur hic in qui quis. Asperiores sunt ducimus quo. Ducimus quae est tempora sed.", new DateTime(2025, 6, 13, 14, 10, 46, 477, DateTimeKind.Unspecified).AddTicks(4921) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "a2d15849-5376-4e4b-af5d-accb1ffa3935", "Occaecati minus voluptatum non velit qui earum.", new DateTime(2025, 4, 24, 0, 2, 9, 39, DateTimeKind.Unspecified).AddTicks(4056) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "d61ac6e5-72e0-4e5a-9946-10c694abeef6", "eos", new DateTime(2025, 1, 6, 23, 47, 20, 969, DateTimeKind.Unspecified).AddTicks(6472) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "Veniam ut facilis consequatur soluta.", new DateTime(2025, 2, 22, 14, 5, 43, 187, DateTimeKind.Unspecified).AddTicks(9180) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "Expedita repellendus odit.\nQuas unde est quo cumque.\nUt odit dolores rem omnis illo.", new DateTime(2025, 6, 3, 19, 18, 18, 215, DateTimeKind.Unspecified).AddTicks(5637) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f8294be2-341c-4a94-97c6-6e9f2a189070", "Ullam earum minus. Mollitia doloremque ea maiores. Expedita qui aliquid illum eum fugit.", new DateTime(2025, 3, 3, 20, 11, 38, 254, DateTimeKind.Unspecified).AddTicks(6213) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f8294be2-341c-4a94-97c6-6e9f2a189070", "Quia consequatur rerum dolores eligendi voluptas temporibus est officiis.", new DateTime(2025, 1, 12, 7, 12, 51, 681, DateTimeKind.Unspecified).AddTicks(421) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "Ducimus perspiciatis dolores.\nQuo ut odio cumque amet vel.\nVoluptas repudiandae eveniet quis odio dignissimos facilis dolorem fugiat.\nNostrum earum vitae.\nBlanditiis cum expedita maiores ducimus eos nam libero.", new DateTime(2025, 4, 3, 1, 6, 59, 344, DateTimeKind.Unspecified).AddTicks(4658) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "a2d15849-5376-4e4b-af5d-accb1ffa3935", "At animi id officiis nesciunt rerum non soluta.", new DateTime(2025, 6, 4, 2, 2, 30, 798, DateTimeKind.Unspecified).AddTicks(918) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2618f4d1-f4a8-4584-901c-57b233900da2", "Sed et labore maxime.", new DateTime(2025, 1, 27, 2, 42, 39, 692, DateTimeKind.Unspecified).AddTicks(8840) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", "Cupiditate explicabo nesciunt sint quam nostrum laboriosam autem suscipit repellendus. Rerum quia rerum. Libero animi aliquid quibusdam. Animi dolorem error eius adipisci molestiae dolorem deleniti. Molestias eaque corrupti et recusandae earum voluptas deserunt minima.", new DateTime(2025, 4, 6, 15, 58, 38, 318, DateTimeKind.Unspecified).AddTicks(4020) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "omnis", new DateTime(2025, 3, 20, 18, 41, 11, 605, DateTimeKind.Unspecified).AddTicks(2365) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2618f4d1-f4a8-4584-901c-57b233900da2", "Maiores vero qui.\nQui consequatur eos qui qui cupiditate quia alias.\nVoluptas est est molestiae alias ut asperiores.\nRepellat tenetur explicabo provident aliquid ea quia.", new DateTime(2025, 3, 28, 22, 47, 17, 551, DateTimeKind.Unspecified).AddTicks(1237) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "Magnam placeat est repudiandae quaerat id ut minima omnis occaecati. Et non consequatur qui ipsa perferendis. Enim commodi repudiandae quisquam ab. Est sint autem est dicta.", new DateTime(2025, 4, 21, 18, 44, 45, 87, DateTimeKind.Unspecified).AddTicks(6746) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "f8294be2-341c-4a94-97c6-6e9f2a189070", "Ut sint consequatur unde ut.\nQuasi facere eligendi et id saepe.\nQuae repudiandae animi et eos numquam dolorem voluptas.\nAliquam qui harum qui aliquid placeat eligendi expedita.", new DateTime(2025, 5, 21, 23, 44, 47, 614, DateTimeKind.Unspecified).AddTicks(6450) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "e0b1b8e1-31c9-495d-bc9b-8f3a47c20988", "Commodi quaerat enim repellat et quaerat.\nSequi hic neque.\nIpsa ad rem porro explicabo pariatur adipisci consequatur.", new DateTime(2025, 1, 2, 13, 44, 19, 315, DateTimeKind.Unspecified).AddTicks(3556) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", "Non sed ad odio deserunt voluptatum ut.\nEum aut veniam nemo non ipsam delectus fugiat cupiditate unde.", new DateTime(2025, 3, 4, 20, 14, 6, 883, DateTimeKind.Unspecified).AddTicks(4956) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "9844b374-0a9a-486f-8d6d-86fc85c6ceb0", "aut", new DateTime(2025, 2, 25, 8, 28, 49, 583, DateTimeKind.Unspecified).AddTicks(8992) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2618f4d1-f4a8-4584-901c-57b233900da2", "Labore repellendus eius sit et cupiditate.", new DateTime(2025, 2, 16, 2, 11, 53, 451, DateTimeKind.Unspecified).AddTicks(6484) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", "Error sunt id iure. Autem aut est. A nihil eos voluptatem quibusdam voluptatem ea fugit quis dolorem. Ratione quibusdam rerum.", new DateTime(2025, 3, 30, 11, 36, 59, 627, DateTimeKind.Unspecified).AddTicks(8774) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "d61ac6e5-72e0-4e5a-9946-10c694abeef6", "Nihil cum sit rerum.", new DateTime(2025, 3, 8, 23, 42, 16, 784, DateTimeKind.Unspecified).AddTicks(7634) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "1e0ff4af-05e6-4dc4-ad25-edec7652ff45", "Unde qui nemo autem provident atque. Aut voluptate ab omnis quaerat exercitationem dicta. Ad commodi maiores eius est in nostrum autem maiores et. Impedit repellendus autem.", new DateTime(2025, 4, 19, 17, 8, 1, 513, DateTimeKind.Unspecified).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2618f4d1-f4a8-4584-901c-57b233900da2", "explicabo", new DateTime(2025, 4, 27, 18, 54, 57, 919, DateTimeKind.Unspecified).AddTicks(2434) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "2618f4d1-f4a8-4584-901c-57b233900da2", "Praesentium molestias aut praesentium consequatur quibusdam natus ullam odio.\nAsperiores quia labore quae eius.", new DateTime(2025, 6, 2, 19, 29, 35, 637, DateTimeKind.Unspecified).AddTicks(2515) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "8356b7ff-89f7-4835-b16a-7eca2102bd5b", "Dicta incidunt aliquid ratione sit saepe ut. Assumenda nihil minus soluta natus amet sit. Aut laboriosam occaecati qui. Nobis eius ut dicta debitis laborum non illo.", new DateTime(2025, 5, 14, 5, 24, 13, 621, DateTimeKind.Unspecified).AddTicks(9668) });

            migrationBuilder.UpdateData(
                schema: "AlchemyCoaching",
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ClientId", "Note", "Time" },
                values: new object[] { "7bb53c7e-feae-47c3-9bf8-d47e4b66055b", "Fuga vel perferendis. Voluptatem quo quos perspiciatis. Natus eos recusandae. Neque et qui voluptatem earum quisquam suscipit voluptates. Doloribus et est ipsum aut quia ut. Quisquam velit architecto voluptas nam modi quod commodi nulla.", new DateTime(2025, 2, 5, 7, 55, 26, 861, DateTimeKind.Unspecified).AddTicks(1445) });

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
        }
    }
}
