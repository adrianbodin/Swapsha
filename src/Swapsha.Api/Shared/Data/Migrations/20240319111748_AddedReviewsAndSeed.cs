using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Swapsha.Api.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviewsAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fa85f64-5717-4562-b3fc-2c963f66afa6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bb59df8-7452-4f98-a399-56fd7eabc66a");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SubSkills",
                newName: "SubSkillId");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", maxLength: 5, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostedById = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_PostedById",
                        column: x => x.PostedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", 0, "332b9529-c1c9-472f-8653-720e00b1c160", "test18@example.com", false, "Sophia", "Ramirez", true, null, "Isabella", "TEST18@EXAMPLE.COM", "TEST18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK56khZ/JNLijmvZjWPFXFawTi0JtPnRZT/Pd8hgHvfEJrcv40B2SkV5axoyoX/P1g==", null, false, null, "6260a7b2-22ad-478f-9f40-d9d2e4dc276b", false, "test18@example.com" },
                    { "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", 0, "d8525838-59e1-4041-ac21-dc627d596a87", "test4@example.com", false, "Lisa", "Andersson", true, null, "Caroline", "TEST4@EXAMPLE.COM", "TEST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKPkJ39j53yofUORN9/0kaYNjOkeztCT3WA0G4o74FgMP2WuYUpAt2B1ctNbeH9lYQ==", null, false, null, "990b8970-2390-4d49-a943-1c342db87b91", false, "test4@example.com" },
                    { "2bf0c340-5c0a-4240-85eb-c54f23e22335", 0, "bc26fb69-f847-469c-a500-852b8656b890", "test17@example.com", false, "Benjamin", "Perez", true, null, "Joseph", "TEST17@EXAMPLE.COM", "TEST17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHDvlLuS0d9c9/z3oCc0uZvneOT8UhZsZ5uafXXKzdNGUpzeN4OrehvI+qfgS67gCQ==", null, false, null, "efeec375-7921-4ff2-8ef1-eca44ca34dd9", false, "test17@example.com" },
                    { "3dc5715e-7cbb-4c35-8f68-4a6ed2109992", 0, "bc79b276-df02-45ac-8ef1-d80d62d32a08", "test19@example.com", false, "Mia", "Gomez", true, null, "Sophia", "TEST19@EXAMPLE.COM", "TEST19@EXAMPLE.COM", "AQAAAAIAAYagAAAAECMxPbZRU8HhRgIDr0SjK6hOaetwoiFy+G0wDO2w9XzIsXYEAueMAvXhq7K/vFcSlg==", null, false, null, "709c864d-8cdb-4736-b756-720eb91935a2", false, "test19@example.com" },
                    { "43f45a0c-22c0-4154-9646-2fdd6466d5e8", 0, "ed0a17b2-734c-4d68-aa55-947e96bd44ff", "test13@example.com", false, "Olivia", "Rodriguez", true, null, "Maria", "TEST13@EXAMPLE.COM", "TEST13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJhS8JYqsUvZf/veW6PvrFXaosZ0OFNhH6nHJ0kS+c3+IUqf/t52QEsvk1DC9nTl+A==", null, false, null, "441f8486-33fd-4b03-a501-2b1aa053b601", false, "test13@example.com" },
                    { "44cd546a-50e2-4fea-b742-7e9ea52d91bd", 0, "8d038c54-4640-44e5-80b0-0df63990dab6", "test3@example.com", false, "Fredrik", "Andersson", true, null, "Johan", "TEST3@EXAMPLE.COM", "TEST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL/raJg4yyWoRW3LMcSgyV3OixIk+2TbYgmLHXQ7SaVFU2yLCMJltXJXXWnq4z5OHw==", null, false, null, "4dd739ae-088d-4b51-a8c5-767378eb8f4f", false, "test3@example.com" },
                    { "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", 0, "1ad37899-0f40-4d93-9dce-4e9fae3de4c1", "test6@example.com", false, "John", "Doe", true, null, "Robert", "TEST6@EXAMPLE.COM", "TEST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEVFolRSibE1mVaVSDwJKn73Mko8IWKp9nluqdrF1v4/TcPiupc6dKnyoCVUOgpumg==", null, false, null, "ffe1d99a-0e07-484f-bf36-45b59c5c3fdc", false, "test6@example.com" },
                    { "51049fd8-e56e-4a47-83aa-613b60c9337c", 0, "0eabdccb-efe2-4b61-987c-663c8db17b13", "test2@example.com", false, "Adrian", "Bodin", true, null, "Nils", "TEST2@EXAMPLE.COM", "TEST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAECxSVdUSe5rq8rr490CD0GhQ8oQQGxbG4/wQbssb4/nHcPSNyZu6vi1Rb21bV/RWNw==", null, false, null, "fe0007e6-70a0-4f16-a599-19f130985e99", false, "test2@example.com" },
                    { "5e3cb3c0-14e1-491d-960f-d133b92f9342", 0, "662a23d8-bd8c-49bd-907c-4c2b20ffcb94", "test11@example.com", false, "Sarah", "Martinez", true, null, "Jane", "TEST11@EXAMPLE.COM", "TEST11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFfcnw4p1zX6KvB9FUky0mE9Rb7h8yFzkwnogSXFVbTKEvo+rxicQfIAHWGQBT9OuA==", null, false, null, "218cc65a-353a-4463-af1b-4e5f9ef208b7", false, "test11@example.com" },
                    { "6b911c75-94e2-4799-a813-43cd6453dfe5", 0, "f9cb0d72-4275-4a0b-9a0c-d09742c9121b", "test8@example.com", false, "Michael", "Johnson", true, null, "David", "TEST8@EXAMPLE.COM", "TEST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIeiGvg2NIaMCYPI+6bW+lWZAzt3u9GgCmhJzUws+vD2cbjsJ0uPVqJDWwOP4SpyDA==", null, false, null, "6f30a650-c153-4b09-a80a-97e61d49754f", false, "test8@example.com" },
                    { "9015a0af-042b-4436-aa91-dda0edd90efa", 0, "ba8ed013-2ff5-44c2-9b3f-a6ff60ab6c2d", "test1@example.com", false, "Adam", "Larsson", true, null, "Karl", "TEST1@EXAMPLE.COM", "TEST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHAY5v6rYzZsb3tOpGVOvb7ovsR3Do6GTboUR/YZK+95bq7TvcRsEvt5BH0POwLQAg==", null, false, null, "cc1952a6-3e8a-4c25-8057-03debaece92f", false, "test1@example.com" },
                    { "91433994-cf94-45bd-bdc5-48fed7b06215", 0, "601ebd6f-ced1-47bd-b918-4b9b241719c6", "test16@example.com", false, "James", "Hernandez", true, null, "Andrew", "TEST16@EXAMPLE.COM", "TEST16@EXAMPLE.COM", "AQAAAAIAAYagAAAAEO+KiNLLxpOMtN7sKT62kp2HWetmseMPuxhQBqCTPHNU3/Wqt5+hOEwiXcpXxrALXA==", null, false, null, "f36f60d7-6581-4fb4-b288-4319d7090c09", false, "test16@example.com" },
                    { "9a8b68e6-fae6-4504-96cc-a5941418f8cd", 0, "439b3cd2-70a0-4269-a9fc-a3fdefe7e1e0", "test12@example.com", false, "Daniel", "Garcia", true, null, "Carlos", "TEST12@EXAMPLE.COM", "TEST12@EXAMPLE.COM", "AQAAAAIAAYagAAAAECud66WYeqyRupCVgfzxqZBLDrO0/dvWIUVa1+vAgrMt7goJ0dWWra+fEwrkHNpVMw==", null, false, null, "2ce39200-5217-4b2b-b37a-dd42685f4808", false, "test12@example.com" },
                    { "a0089714-6612-4b3c-82bc-db33ee61f802", 0, "dbf6fd90-5287-4c47-9002-90e090ae622f", "test10@example.com", false, "David", "Wilson", true, null, "Paul", "TEST10@EXAMPLE.COM", "TEST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAECarkjLhb7/m0mgCZykHJnS0g70MozLZUQzDH9Vhz7+Iaq1xN9AawwlCP3g5tqCeRw==", null, false, null, "972a779f-94f5-439d-8cf5-066b71f53188", false, "test10@example.com" },
                    { "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", 0, "1c3b2473-5ab0-4eb1-b10c-996329710c2e", "test14@example.com", false, "William", "Lopez", true, null, "Alexander", "TEST14@EXAMPLE.COM", "TEST14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBqM16geE98Zrbe+AylwPQfMlu2/HeO3xMFIw+MP7Jx4AHUWNAljAYFrRCoDRdxr2w==", null, false, null, "05f2c119-359f-4bb9-8d10-7ad171bfab4b", false, "test14@example.com" },
                    { "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", 0, "bf9eeb57-95ea-4141-85b9-2bad3926044e", "test5@example.com", false, "Emma", "Johansson", true, null, "Sofia", "TEST5@EXAMPLE.COM", "TEST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMoFdXLW4jlx/WTb8CNdBAlSSXtxZtkcL8hgxcbcbweiN57IzZt7K7h7yH9usNAioA==", null, false, null, "027eed47-4780-4ff7-909f-00ae4dd1e3a8", false, "test5@example.com" },
                    { "cae6fca2-7452-4045-b259-be2fd24b3ea8", 0, "2db96af3-e78a-44af-8703-3f0e182a0243", "test7@example.com", false, "Alice", "Smith", true, null, "Grace", "TEST7@EXAMPLE.COM", "TEST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH4WS7FkHq/aL3YLK+MWXWkT/vGGtXvZ+QRLQhTz9gU9383v/yxX175rbGeQXQm2mw==", null, false, null, "3901d28c-f2fa-492d-9145-0afe96233421", false, "test7@example.com" },
                    { "e20620e8-c219-4c45-a122-0c99330f5c17", 0, "dab942b0-0b5b-4b67-813f-eb1d17be7557", "test15@example.com", false, "Ethan", "Gonzalez", true, null, "Gabriel", "TEST15@EXAMPLE.COM", "TEST15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEM+RYkngwo0iG73MdaiAAz5pbNSckLnyyM7+VnAB3kQKmLBJqIwzS2SI5NL+6eLM2g==", null, false, null, "89511c91-9d57-4bdd-95cb-50469d733ed6", false, "test15@example.com" },
                    { "f00403e8-79f1-4a56-87a6-d66a1ad65d62", 0, "61802c5d-e868-4ef2-a4a2-e830a2f9d9d3", "test9@example.com", false, "Emily", "Brown", true, null, "Anne", "TEST9@EXAMPLE.COM", "TEST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDsF1vinUt2X3Q2Bo7R7uSSVhD7/Jw5U3kwjsC+HFLsif1REhnlaZysJ/Wjx9AJlSg==", null, false, null, "569786c4-6f10-47c5-bf28-db0db2f4fe61", false, "test9@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom snickeri", "Snickeri" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom målning", "Målning" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom svetsning", "Svetsning" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom mekanik", "Mekanik" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "SkillId", "Description", "Name" },
                values: new object[,]
                {
                    { 5, "Kunskaper inom elektronik", "Elektronik" },
                    { 6, "Kunskaper inom programmering", "Programmering" },
                    { 7, "Kunskaper inom golvläggning", "Golvläggning" },
                    { 8, "Kunskaper inom VVS", "VVS" },
                    { 9, "Kunskaper inom el", "El" },
                    { 10, "Kunskaper inom trädgård", "Trädgård" },
                    { 11, "Kunskaper inom städning", "Städning" },
                    { 12, "Kunskaper inom köksarbete", "Köksarbete" },
                    { 13, "Kunskaper inom barnpassning", "Barnpassning" },
                    { 14, "Kunskaper inom äldreomsorg", "Äldreomsorg" },
                    { 15, "Kunskaper inom hundpassning", "Hundpassning" },
                    { 16, "Kunskaper inom kattvakt", "Kattvakt" },
                    { 17, "Kunskaper inom fotografering", "Fotografering" }
                });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom att bygga möbler", "Bygga möbler" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom att renovera hus", "Renovera hus" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 3,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att måla möbler", "Måla möbler", 2 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom att måla hus", "Måla hus" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 5,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att svetsa metall", "Svetsa metall", 3 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 6,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att svetsa plast", "Svetsa plast", 3 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 7,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att reparera bilar", "Reparera bilar", 4 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 8,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att reparera motorcyklar", "Reparera motorcyklar", 4 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att bygga kretskort", "Bygga kretskort", 5 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 10,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom att bygga robotar", "Bygga robotar", 5 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 11,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom webbutveckling", "Webbutveckling", 6 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "DateCreated", "PostedById", "Rating", "UserId" },
                values: new object[,]
                {
                    { "043e0c11-f806-45ac-a49e-20654307d2c1", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5316), "e20620e8-c219-4c45-a122-0c99330f5c17", (byte)2, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { "06358222-9aaf-4c27-a7bc-b3983fc3e598", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6172), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)4, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { "08ab157c-fc59-4283-bd0b-1bfb8c5b8ed0", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6160), "e20620e8-c219-4c45-a122-0c99330f5c17", (byte)1, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { "0ab2e537-2c80-4a33-99d8-161b2e2905e5", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6333), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)3, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { "0f4b103e-d620-48e4-a75c-e416ab9c7905", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5373), "cae6fca2-7452-4045-b259-be2fd24b3ea8", (byte)3, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { "1049c598-397e-4d32-b28f-8926524c2968", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6348), "51049fd8-e56e-4a47-83aa-613b60c9337c", (byte)3, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { "114a9fad-118e-4ad5-af08-be18d471da27", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5233), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)3, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { "12650d79-95c2-4816-8225-a8b26e2df79e", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6323), "51049fd8-e56e-4a47-83aa-613b60c9337c", (byte)5, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { "143d1465-a662-4dc3-a08b-2e485e4b77fc", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6285), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)1, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { "15fcef50-57aa-40b0-833b-90cd895b918b", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6380), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)5, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { "17248ba3-0415-43fd-92af-c2e9765e86b1", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6313), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)1, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { "24614b02-5c69-4c10-89f6-20f73c70f48a", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6383), "3dc5715e-7cbb-4c35-8f68-4a6ed2109992", (byte)2, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { "25f2d7b5-20bc-4ea0-bcb7-cf8c16196c53", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6344), "9a8b68e6-fae6-4504-96cc-a5941418f8cd", (byte)2, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { "298fffe1-c73c-4df2-bb6c-b94a2b220734", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6319), "a0089714-6612-4b3c-82bc-db33ee61f802", (byte)5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { "29a45e14-79a8-4979-a10e-0c38598b3d4b", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6315), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { "2d64bd38-8e11-4a3c-9874-c9622b947e68", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5329), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)1, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { "36c27747-ecd0-41d2-bf0f-b1776588a25d", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6299), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)4, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { "3b99bfa6-4bc2-4633-9060-2aa798ef1d6e", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6301), "9a8b68e6-fae6-4504-96cc-a5941418f8cd", (byte)2, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { "3c91c42d-dcd6-435f-a09b-e933d1123111", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5381), "9a8b68e6-fae6-4504-96cc-a5941418f8cd", (byte)2, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { "3eac5787-cb46-4b49-b01a-a48a299b5d68", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5385), "e20620e8-c219-4c45-a122-0c99330f5c17", (byte)3, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { "3f71566e-6aac-4199-9a68-ed2fdd34b06b", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6303), "91433994-cf94-45bd-bdc5-48fed7b06215", (byte)2, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { "3fed1970-3e3f-4ba6-bfa3-23a8044878ad", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5299), "51049fd8-e56e-4a47-83aa-613b60c9337c", (byte)5, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { "41375502-aa2c-4c0c-896d-2e3f4ba5a275", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5378), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)5, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { "41c5a41e-5d01-4214-a75e-ab2aee648207", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6263), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)2, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { "450dc877-2a9f-492e-9be9-25596ad85dcf", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6059), "e20620e8-c219-4c45-a122-0c99330f5c17", (byte)1, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { "462c29d9-8ffc-4466-bc08-f1fa6665a086", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5243), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)1, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { "4799f4e5-d9ea-4931-b609-f5b4d0eda665", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5399), "51049fd8-e56e-4a47-83aa-613b60c9337c", (byte)1, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { "4c88d251-83d9-4532-8f55-a71ea480923c", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6257), "f00403e8-79f1-4a56-87a6-d66a1ad65d62", (byte)5, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { "4dcd144a-1146-4047-82b2-27ee66aa5c48", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5393), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)3, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { "51b96f68-7adf-4daf-9101-da352a2b28f0", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6283), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)1, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { "5333216d-0b0f-4f2d-b664-eceb2885dc5c", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6400), "cae6fca2-7452-4045-b259-be2fd24b3ea8", (byte)1, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { "57f91ab0-d695-4089-a147-4c475e8bebfb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6266), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)1, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { "59de0353-7fbd-479b-b0d3-60a62627bbe5", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6174), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)1, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { "5e7e1cdb-66de-4317-9ca0-6f885b499b39", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5229), "2bf0c340-5c0a-4240-85eb-c54f23e22335", (byte)4, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { "5ee60f71-972f-4c40-919a-2528c6e5a1a2", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5389), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)4, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { "5eed9cbe-acba-436e-accb-5b793c844447", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6293), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)1, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { "60bc355f-fc03-4f28-8935-a56b5ebafe04", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6325), "5e3cb3c0-14e1-491d-960f-d133b92f9342", (byte)4, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { "6285663c-a7c1-4d35-8175-1e4bb98fe50e", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6152), "cae6fca2-7452-4045-b259-be2fd24b3ea8", (byte)3, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { "68c2aaee-ea56-4609-ac04-a4ecc3fb5f14", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5325), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)2, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { "6e609962-0629-4bbc-b344-a86636a24b92", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6270), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)4, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { "7065504c-f103-44ef-b801-5fe118117a93", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5391), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)5, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { "7175957a-393d-4036-a5d2-ffbc6ecb1131", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6338), "cae6fca2-7452-4045-b259-be2fd24b3ea8", (byte)3, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { "72ea3969-0af8-4bcf-bc24-7cfaeeca3976", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5294), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)2, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { "7641f506-377c-4934-92a8-b156d343f8fb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6305), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)1, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { "7a3b3c51-243c-45d4-b80c-cbb20e2b01c0", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6376), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)5, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { "7ad50bc3-12eb-4f6f-9863-efd7574ba5ec", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6181), "a0089714-6612-4b3c-82bc-db33ee61f802", (byte)1, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { "7f0459be-13d6-4281-88ae-24133b1014de", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6287), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)1, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { "845c9422-1d0a-49bd-9384-106e08761513", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6252), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)3, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { "8644fd64-2877-461c-883b-9babd1d21681", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6391), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)3, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { "8b9deb29-1cb1-4943-bc6b-17d3a57d2bdb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5221), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)1, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { "8d963b4d-c835-4596-8afe-33762f542b1f", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5323), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)4, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { "91745c8c-274e-4f28-9995-e8118465b2ed", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6261), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)1, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { "91e9248e-8a8c-4be3-852d-8b1c3af094d6", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6342), "5e3cb3c0-14e1-491d-960f-d133b92f9342", (byte)1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { "972e3d22-e8c4-4b67-bb75-115dc371ff93", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6289), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)1, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { "988bfbb0-cca7-4609-a394-bdb66ee36c18", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6168), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)1, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { "9d3b88b0-6e23-4eae-a898-d0333ec92cc9", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6154), "a0089714-6612-4b3c-82bc-db33ee61f802", (byte)3, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { "9e27274d-1109-4ae0-8f76-458621707bbb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5409), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)5, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { "a0a35210-4d17-4f77-ab83-95e9f5089bd6", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6346), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { "a31471aa-99fb-47a2-9984-8a8211561c29", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6394), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)2, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { "a32c7fb5-6b58-4e7b-85ea-8916b243b7ab", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6176), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)3, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { "a57ca1db-f468-411c-a0c1-929445f49b48", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6255), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)5, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { "a6e749b2-d53a-4b23-8065-79cfb716e2e2", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5313), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)3, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { "a6f082be-41c3-4bd2-bfcd-e2c2cc1d8b3a", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5387), "9a8b68e6-fae6-4504-96cc-a5941418f8cd", (byte)4, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { "a935a449-ed1f-4aaa-93f1-199e51cc4175", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6336), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)5, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { "af37395c-7511-45be-8b9e-89b3cc1aed2d", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6331), "5e3cb3c0-14e1-491d-960f-d133b92f9342", (byte)2, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { "af6b9e90-ad77-42a9-acb6-13f5dda35427", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6267), "9a8b68e6-fae6-4504-96cc-a5941418f8cd", (byte)2, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { "b2f8656d-b2e8-43e5-9d1a-9d2216140041", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5404), "43f45a0c-22c0-4154-9646-2fdd6466d5e8", (byte)1, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { "b41aeb6c-930a-4421-a4e7-cb5e57dfc729", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5225), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)1, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { "b4d6fd2a-4943-4a8c-900f-0af3e69cd9e6", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5402), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)1, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { "b8d58a91-08fb-41cd-b663-7df0cae6a972", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6281), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)2, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { "bcee86ee-cf2b-40a3-8f5b-a7067346838e", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5406), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)5, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { "bece934c-bb79-4583-a2e3-2d979be37ea1", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5396), "51049fd8-e56e-4a47-83aa-613b60c9337c", (byte)2, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { "bf0fe851-8058-42b8-86d8-1af6ae351652", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5331), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)2, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { "c19910c5-2086-40cc-8d3f-35bece8253f8", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6388), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)1, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { "c25153aa-5081-4898-9edb-261a2baccc87", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6165), "2bf0c340-5c0a-4240-85eb-c54f23e22335", (byte)3, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { "c4610e3c-3a84-4cd0-a588-606d9fbaef4a", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6327), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)1, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { "c571df8e-6072-4290-895a-fa1e3b561098", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5087), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)2, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { "c808c26e-ac13-46a4-8a2c-253587318331", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6386), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)2, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { "ca54d0e0-d49d-444e-8e2f-81c474e2ad84", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(5327), "0e1fe5a3-3f13-4892-a2c3-ddabf464984c", (byte)1, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { "ca64ed87-2e46-4171-bc58-a6ae4165f91f", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6309), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { "cfcd35c6-5d54-49dd-9722-d13ecc8f7b4f", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6148), "b75a2a3a-b56f-4b08-8e51-97783fc3cfba", (byte)4, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { "d20ef5a5-42be-4ed9-9145-cbd13e8c1bcb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6272), "2bf0c340-5c0a-4240-85eb-c54f23e22335", (byte)5, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { "d50d2b7e-fe37-4784-b906-098f92722a7c", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6162), "f00403e8-79f1-4a56-87a6-d66a1ad65d62", (byte)3, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { "d837800c-04c8-44c6-9a59-3b522624c442", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6329), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)1, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { "dd73f6d5-1b73-4bc3-9bc7-447104f7b355", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6392), "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9", (byte)4, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { "e5d9b8ac-b4e4-4963-961f-cd894146a6cf", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6321), "44cd546a-50e2-4fea-b742-7e9ea52d91bd", (byte)2, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { "eaaf8d8a-81bd-4886-9333-e5c481ffedcb", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6274), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)1, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { "ef92b3f5-d5c2-4630-8544-bdcb35bae3c4", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6340), "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c", (byte)1, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { "f081a96b-4c7c-4895-aca7-4a490a63d854", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6385), "5e3cb3c0-14e1-491d-960f-d133b92f9342", (byte)2, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { "f4250ec7-bc7d-4a87-8d07-813f2ff66f54", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6398), "91433994-cf94-45bd-bdc5-48fed7b06215", (byte)1, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { "f5f830c9-772d-4a05-bd65-a2bcb241386b", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6291), "11f3fe96-f2aa-4217-acb0-63c29e78f5ec", (byte)4, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { "f851e401-c8be-427d-8f9a-7905d497328b", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6295), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)1, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { "fa9427a2-f857-48c3-8e74-4a4c50999b13", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6311), "6b911c75-94e2-4799-a813-43cd6453dfe5", (byte)3, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { "fd73eac4-429d-4a93-815c-b6f8cc7f69cf", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6277), "9015a0af-042b-4436-aa91-dda0edd90efa", (byte)3, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { "fe7ccdc5-6972-410d-95b5-f7c37fdd7e05", new DateTime(2024, 3, 19, 12, 17, 47, 623, DateTimeKind.Local).AddTicks(6178), "91433994-cf94-45bd-bdc5-48fed7b06215", (byte)1, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" }
                });

            migrationBuilder.InsertData(
                table: "SubSkills",
                columns: new[] { "SubSkillId", "Description", "Name", "SkillId" },
                values: new object[,]
                {
                    { 12, "Kunskaper inom apputveckling", "Apputveckling", 6 },
                    { 13, "Kunskaper inom att lägga golv", "Lägga golv", 7 },
                    { 14, "Kunskaper inom att lägga kakel", "Lägga kakel", 7 },
                    { 15, "Kunskaper inom att vara rörmokare", "Rörmokare", 8 },
                    { 16, "Kunskaper inom VVS-installation", "VVS-installation", 8 },
                    { 17, "Kunskaper inom elinstallation", "Elinstallation", 9 },
                    { 18, "Kunskaper inom elreparation", "Elreparation", 9 },
                    { 19, "Kunskaper inom trädgårdsdesign", "Trädgårdsdesign", 10 },
                    { 20, "Kunskaper inom trädgårdsarbete", "Trädgårdsarbete", 10 },
                    { 21, "Kunskaper inom städning av hem", "Städning av hem", 11 },
                    { 22, "Kunskaper inom städning av kontor", "Städning av kontor", 11 },
                    { 23, "Kunskaper inom köksdesign", "Köksdesign", 12 },
                    { 24, "Kunskaper inom köksarbete", "Köksarbete", 12 },
                    { 25, "Kunskaper inom barnpassning", "Nanny", 13 },
                    { 26, "Kunskaper inom barnaktiviteter", "Barnaktiviteter", 13 },
                    { 27, "Kunskaper inom äldreomsorg", "Diabetesvård", 14 },
                    { 28, "Kunskaper inom äldreaktiviteter", "Äldreaktiviteter", 14 },
                    { 30, "Kunskaper inom hundträning", "Hundträning", 15 },
                    { 31, "Kunskaper inom kattvakt", "Kattskötsel", 16 },
                    { 32, "Kunskaper inom kattaktiviteter", "Kattaktiviteter", 16 },
                    { 33, "Kunskaper inom fotografering", "Landskapsfotografering", 17 },
                    { 34, "Kunskaper inom fotoredigering", "Fotoredigering", 17 }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 1, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 10, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 12, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 13, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 1, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 7, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 10, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 14, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 5, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 7, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 11, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 12, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 4, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 10, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 13, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 17, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 3, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 10, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 12, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 14, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 7, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 8, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 12, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 15, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 5, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 10, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 11, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 16, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 3, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 6, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 8, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 9, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 14, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 5, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 7, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 8, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 11, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 12, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 3, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 6, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 9, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 16, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 5, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 8, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 12, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 16, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 1, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 3, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 6, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 10, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 13, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 3, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 7, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 12, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 15, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 3, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 4, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 7, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 8, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 11, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 8, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 11, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 14, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 17, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 3, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 8, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 9, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 11, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 5, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 7, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 10, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 12, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 17, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 9, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 12, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 15, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 16, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 4, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 5, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 12, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 17, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" }
                });

            migrationBuilder.InsertData(
                table: "UserWantedSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 2, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 5, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 7, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 8, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 11, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" },
                    { 4, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 7, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 10, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 11, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" },
                    { 1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 4, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 12, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 15, "2bf0c340-5c0a-4240-85eb-c54f23e22335" },
                    { 1, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 6, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 10, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 11, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 13, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" },
                    { 1, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 7, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 8, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 16, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" },
                    { 3, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 5, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 8, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 11, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 12, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" },
                    { 1, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 3, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 4, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 7, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 14, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" },
                    { 2, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 8, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 9, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 10, "51049fd8-e56e-4a47-83aa-613b60c9337c" },
                    { 2, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 3, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 14, "5e3cb3c0-14e1-491d-960f-d133b92f9342" },
                    { 8, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 10, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 13, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 15, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 17, "6b911c75-94e2-4799-a813-43cd6453dfe5" },
                    { 2, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 7, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 9, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 10, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 16, "9015a0af-042b-4436-aa91-dda0edd90efa" },
                    { 4, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 6, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 8, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 16, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 17, "91433994-cf94-45bd-bdc5-48fed7b06215" },
                    { 7, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 11, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 13, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 15, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" },
                    { 7, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 11, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 14, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 15, "a0089714-6612-4b3c-82bc-db33ee61f802" },
                    { 1, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 13, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 16, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 17, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" },
                    { 7, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 8, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 9, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 11, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 17, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" },
                    { 6, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 8, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 10, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 15, "cae6fca2-7452-4045-b259-be2fd24b3ea8" },
                    { 5, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 7, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 13, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 15, "e20620e8-c219-4c45-a122-0c99330f5c17" },
                    { 1, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 2, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 12, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" },
                    { 13, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PostedById",
                table: "Reviews",
                column: "PostedById");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SubSkills",
                keyColumn: "SubSkillId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "0e1fe5a3-3f13-4892-a2c3-ddabf464984c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "11f3fe96-f2aa-4217-acb0-63c29e78f5ec" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "2bf0c340-5c0a-4240-85eb-c54f23e22335" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "3dc5715e-7cbb-4c35-8f68-4a6ed2109992" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "43f45a0c-22c0-4154-9646-2fdd6466d5e8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "44cd546a-50e2-4fea-b742-7e9ea52d91bd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "51049fd8-e56e-4a47-83aa-613b60c9337c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "5e3cb3c0-14e1-491d-960f-d133b92f9342" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "6b911c75-94e2-4799-a813-43cd6453dfe5" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "9015a0af-042b-4436-aa91-dda0edd90efa" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "91433994-cf94-45bd-bdc5-48fed7b06215" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "9a8b68e6-fae6-4504-96cc-a5941418f8cd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "a0089714-6612-4b3c-82bc-db33ee61f802" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "b75a2a3a-b56f-4b08-8e51-97783fc3cfba" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "cae6fca2-7452-4045-b259-be2fd24b3ea8" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "e20620e8-c219-4c45-a122-0c99330f5c17" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "f00403e8-79f1-4a56-87a6-d66a1ad65d62" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e1fe5a3-3f13-4892-a2c3-ddabf464984c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11f3fe96-f2aa-4217-acb0-63c29e78f5ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bf0c340-5c0a-4240-85eb-c54f23e22335");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dc5715e-7cbb-4c35-8f68-4a6ed2109992");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f45a0c-22c0-4154-9646-2fdd6466d5e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44cd546a-50e2-4fea-b742-7e9ea52d91bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e01f3b0-b5b6-4ac0-84f2-776f49a03ed9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51049fd8-e56e-4a47-83aa-613b60c9337c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e3cb3c0-14e1-491d-960f-d133b92f9342");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b911c75-94e2-4799-a813-43cd6453dfe5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9015a0af-042b-4436-aa91-dda0edd90efa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91433994-cf94-45bd-bdc5-48fed7b06215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a8b68e6-fae6-4504-96cc-a5941418f8cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0089714-6612-4b3c-82bc-db33ee61f802");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b75a2a3a-b56f-4b08-8e51-97783fc3cfba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b99ab886-0a3f-4b7a-91f7-9bdbbd9ab03c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cae6fca2-7452-4045-b259-be2fd24b3ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20620e8-c219-4c45-a122-0c99330f5c17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f00403e8-79f1-4a56-87a6-d66a1ad65d62");

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 17);

            migrationBuilder.RenameColumn(
                name: "SubSkillId",
                table: "SubSkills",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3fa85f64-5717-4562-b3fc-2c963f66afa6", 0, "d4be7ce3-71d5-4bfa-9f5f-898f7bf20994", "test@example.com", false, null, null, true, null, null, "TEST@EXAMPLE.COM", "TEST@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEnGXYvETQvdxj2nU8DkDSfseEbxQ0Qml0cSvCzXvgAiyWwsFy1G/5NfrydHp+ZNxg==", null, false, null, "d3eb1810-7821-4992-a6e1-43d73a243bba", false, "test@example.com" },
                    { "4bb59df8-7452-4f98-a399-56fd7eabc66a", 0, "d4fd9529-6ad1-4760-bce0-4ec0f09c2148", "user@example.com", false, null, null, true, null, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJMx89Hs24Bpla5Jpvb2Rn4Jydy3+viATWODMCa3v+g+mUCOQox4icbNIyk6D5n8zg==", null, false, null, "e073bd6e-5013-4f6c-9524-fc1be988d735", false, "user@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom programmering", "Programmering" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom svenska", "Svenska" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom engelska", "Engelska" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "SkillId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom matematik", "Matematik" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom C#", "C#" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom Java", "Java" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom Python", "Python", 1 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Kunskaper inom grammatik", "Grammatik" });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom ordförråd", "Ordförråd", 2 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom stavning", "Stavning", 2 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom amerikansk engelska", "Amerikansk engelska", 3 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom brittisk engelska", "Brittisk engelska", 3 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom matematik 1", "Matematik 1", 4 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom matematik 2", "Matematik 2", 4 });

            migrationBuilder.UpdateData(
                table: "SubSkills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "SkillId" },
                values: new object[] { "Kunskaper inom matematik 3", "Matematik 3", 4 });
        }
    }
}
