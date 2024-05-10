using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Swapsha.Api.Shared.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBioToCustomUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "03164271-a1e7-4350-a635-d9d5836069ba");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "03ce2bd7-ac22-48eb-a757-ee1a31a09743");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "098fd2c0-112e-45b1-898b-230638ebd495");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "148286ac-4e6f-4709-a733-cde83fb53d98");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "14b6664d-e72a-4467-9105-fe40dd4124ea");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "16e7de56-2f81-4fd2-bdcb-a34e2f8511e2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "176a9262-62f4-48ee-84a6-71e0a1f2e31e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "19432760-8cbf-4c45-aa59-e53a14ef534d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1b7cf255-5fff-4967-a5fd-de04c480b540");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1cabb7b3-b2c3-4276-93b6-559e35bf3f27");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1fce6aaf-1ab7-44c9-868f-d5f4b8acfd8c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1ff6b66d-e2ce-4dbf-92d9-aef686de3c23");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "20407ab6-06ff-4a16-873f-519d6e81c073");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "20d1cbb2-3e96-41a6-8887-2f08b89a2777");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "22095779-0f1a-498c-bb41-06f1cba2be7c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "222a266c-90ad-4c86-a6ca-b82bb0ee9d19");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "24853c4d-f145-4c3a-9c7c-7af86b7bf4c9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2759b788-229a-48ad-8c8c-6e307d5f39ba");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2a932e79-245d-4dcd-8531-5b459a604c2d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2e6ed4ca-c4e4-4eba-bea0-59a529fb85d7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3078a273-fba0-4b7e-a0e9-338554dc24ad");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "352d4841-86c4-4b9b-974f-efe04a08d541");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "381593bf-75d7-473c-a557-f67315e4b999");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3adfbd4a-4ea6-4b35-8f5d-a514fd1a0873");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3c512029-a9db-4ebf-b64f-796cd5ea754f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3d161104-2a4c-4a0f-a3e0-941f512d2058");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3d3d255c-56c1-4627-b4dd-805f72c5b2fe");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3dbafffb-6565-4789-a791-c6aee5b34e90");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "40f7efde-3723-4443-a25d-5e629f4f8203");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "41c7cecb-7d1e-4a48-8c2f-e161459db03f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "41f8c71b-7d7b-4d14-86f5-42ad94a1eab0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4373aa87-4409-4245-8d41-087710febdf2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "43be773e-fcff-4f06-9a70-129e82152749");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "44f82ce0-e48f-4f8b-8047-d636ef47505e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "49dd2579-cb3b-4a3d-967b-0050f36a2ce2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4bb3ee88-dfe0-4cee-8aed-63d95c58f20a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4dd39015-34f9-4e50-9e23-cba16e496614");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4f8fa8a1-cbe0-4c0b-8542-f8209ad6b8ed");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4fc314a4-a31d-4c70-a030-b4b022e81578");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "50bb47b4-b6e2-46b7-9505-408588f099cf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "52b02a23-eef8-4853-9c11-343ec47da4c5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "533f7b77-7582-421c-91a8-2d4033c82b4f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "54019fe6-7093-4a92-96f7-3222108e3464");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "54305513-424c-4789-85ce-6fc0044f4cb7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "54e06c4a-8e83-40fb-b27e-f3ee906b64d8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "56094aae-29e9-48c7-b3c7-6082e7bf8ddb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "56bd262b-e3a0-4cd4-8ffa-03f4b1e43e84");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "58eb715f-eb59-479f-8d12-faa179c5c1b6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5bd1e2a4-c6ba-4576-bbd3-0e5e23f786ad");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5c8305d3-f0f2-4d58-9603-ffad99129d5a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5d7e8765-8508-458f-a7a0-e34d6b63bfe7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5e65dea7-d97a-4804-9610-ead4b94f0207");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "66ffdcb5-0b12-45e4-80a5-0391a9776f90");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "6d9ee98d-08c4-4143-b5ca-c5414da5d564");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "6f431f80-51e2-486a-b384-dc28b6e2b34e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "71012449-5ecc-40d7-b813-1780f921ca0d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "73cfe4bc-98d1-4d04-9d57-17eaf668029d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7c315c86-feaf-4214-935f-755733c23130");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7d385ad0-e8dc-4ae6-8df4-c7449c2b946c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "82f05534-228f-4213-8e1b-befe4f55a083");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "83e2a5de-ff94-4be4-b3f3-0857197c5017");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "89bcd78e-3288-4a0c-84a3-1ff1bd3987f8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "8ba45322-57e5-4e5d-98f2-0633851e5ee7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "8c663ce1-ca47-4848-8485-9cd96d26b7d9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "8d800997-d868-4da4-8c78-339050767794");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "914c4c00-a6d0-4581-a4a5-e574d1e83276");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "91e62ed5-5d55-45fe-81f4-748a3a2798fb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "96df853d-604b-4347-8059-07d79eba5926");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9831b0e7-1a7b-428c-8cf6-35a1c04b048a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9a0aec08-9ed4-4ac0-be61-65fda80b2afc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9c4044d9-6b8f-4817-a2ba-06dff558efe1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9f484d6a-a10e-4259-bb1f-a94dc15e80b7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9fa6d9fd-04e3-44d0-8937-d3a77d48d2c0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a261ebb4-228f-43d3-81be-c859f949df62");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a2bee7f4-2647-42d2-b17b-393cc9264e79");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a8e6f2eb-aa72-4926-949a-a29bacd74457");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "aaf2f0b5-6392-419e-bb84-fa5f87897b34");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "ab9b640a-9563-4d4a-aad1-c4a0a2be8459");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "adf6b9d1-027a-4202-b273-ad34594e5bdf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "afac9a71-6624-49d4-a26b-8ddb63f8df4f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "b1fba8a6-cf4b-4f0e-a736-fac7ab17808b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "bf5c7eef-0b88-43ca-ad15-88fd413c2ab1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c343629b-0b64-4742-bc0c-a1849e1517de");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c868f630-8cd4-468c-a521-a11a6e911958");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c9984f10-52de-45d7-8ee4-1a5564b3ef9f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c9a58fd9-57b6-4012-a523-879f487fe773");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "ca998bbd-9fb1-4f19-8270-948b9a5ebcc8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "cbc3aeb3-06c0-4bf6-992d-d5596c98a5e7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "cfc954dd-e707-4931-9f3f-8bbee131e448");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "d8408a63-312e-44c2-9864-2b4fb2b6ce1b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "dbd8b166-c557-47f8-9bb8-4b54a43bfe2c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "dc461225-4e85-4acc-80e4-59107481824e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "efff15d9-04ce-4c3d-949c-96f776cb5488");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "f4e42f01-635c-4b44-ad83-b142acac53ec");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "faf01fc9-b5c5-4358-a00c-d039c38eaf45");

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "053018b7-c54b-49f6-ad5c-1bb0cae96463" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "25baf4b9-4fea-423c-a2cb-d80b62d11466" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "542f0577-edba-4664-b5c5-c0b917d8c81a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "83936903-1ad5-4024-b057-07b6616ea5e7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "a418f1c2-fe7d-49a4-8619-2849305b5812" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "a6480d64-0466-461d-b179-be55c4c0c4a3" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "f03d0f94-585e-4b41-a125-88d122a67a58" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "fbe71162-0523-49cd-b2a7-562621ba4c8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03ee79a0-ad3e-41d8-b3df-e1841a2c551f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "053018b7-c54b-49f6-ad5c-1bb0cae96463");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "098abccc-d3f2-4fbf-b37c-d302e9ffc432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18a9b3b4-4777-42c7-93e1-29f046fb9a5e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25baf4b9-4fea-423c-a2cb-d80b62d11466");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "542f0577-edba-4664-b5c5-c0b917d8c81a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83936903-1ad5-4024-b057-07b6616ea5e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a418f1c2-fe7d-49a4-8619-2849305b5812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6480d64-0466-461d-b179-be55c4c0c4a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9728f52-9dfc-400e-8368-e3ca3ad159ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb464ae2-b328-42dc-8fa3-b948cfefd90e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebea6cc4-0fb8-41b7-910d-b06fd9221180");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f03d0f94-585e-4b41-a125-88d122a67a58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbe71162-0523-49cd-b2a7-562621ba4c8c");

            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "CityId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10051508-4b64-487d-8781-d13b6625926b", 0, "Hi, I'm Mia. I'm a dedicated professional with a passion for learning. I'm always looking for opportunities to expand my skill set and contribute to a team.", 11, "38a8e88c-0d27-4847-9fc0-066e83fde288", "test19@example.com", false, "Mia", "Gomez", true, null, "Sophia", "TEST19@EXAMPLE.COM", "TEST19@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAMUwaruYbsvtZmbFod9D5B3tNR+zkuksheSFe2u/ehfKcpe4K+T5xVrK+n2MlEhBw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser19/profilepic.jpg", "ec520ce5-6331-4bd8-8fb2-1935f41f077a", false, "test19@example.com" },
                    { "1e581e52-4f85-4d61-90f8-fcfa5cecc837", 0, "I'm Fredrik, a dedicated and hardworking individual. I enjoy problem-solving and always strive for excellence in everything I do.", 8, "71e8e52c-6fab-4fcb-a0ff-f3e11bc176a1", "test3@example.com", false, "Fredrik", "Andersson", true, null, "Johan", "TEST3@EXAMPLE.COM", "TEST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAECihB72YaPoTxQNHmjh0446izS2ufOkM+xdP41yOmpzMs4knlpb+haUjKySIoWzC2w==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser3/profilepic.jpg", "ff3368d5-392f-4cca-96be-5abf3b1ec9f2", false, "test3@example.com" },
                    { "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", 0, "Hi, I'm Ethan. I'm a proactive individual with a passion for learning and growth. I'm always looking for ways to improve and take on new challenges.", 5, "aec20d99-1290-4236-8dce-8cd8df353e45", "test15@example.com", false, "Ethan", "Gonzalez", true, null, "Gabriel", "TEST15@EXAMPLE.COM", "TEST15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN5l0XNRKbtfn5NDY13BFFd77eV9Bu9Uyw+83HEFbGVoMOl/wqfVjpc+MAhJCnk26g==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser15/profilepic.jpg", "00b66566-7c36-4045-8f0c-b7bc0760f1e6", false, "test15@example.com" },
                    { "43eb00c1-7c1b-4946-84b9-760e965c905b", 0, "Hi, I'm Alice. I'm a detail-oriented professional who takes pride in producing high-quality work. I'm always eager to learn and grow professionally.", 10, "a00cfbda-f2b3-4da9-8326-348f8a6dbb9c", "test7@example.com", false, "Alice", "Smith", true, null, "Grace", "TEST7@EXAMPLE.COM", "TEST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBSOZizpRzzVD+DCgQcFeeLMxPUefnH+sZJ7ZWe9hUEz60N7aE/Rp5LJoTI/92DySw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser7/profilepic.jpg", "8e6515e0-c21c-402b-a118-45da74a81ae3", false, "test7@example.com" },
                    { "53afaaaf-a23b-4f35-8334-c18bbd554148", 0, "I'm Michael, a dedicated professional with a passion for learning. I'm always looking for opportunities to expand my skill set and contribute to a team.", 9, "bbc83993-44c0-465a-9412-7370be61a0ba", "test8@example.com", false, "Michael", "Johnson", true, null, "David", "TEST8@EXAMPLE.COM", "TEST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL1Lia5ac5kYHmN3Uz/mdIU1nsXQe3TyYbL9PhqsMUKAcxXYvgAwurmJMjgbFtzFFg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser8/profilepic.jpg", "b6c83100-5092-481e-9757-d449168cd2ab", false, "test8@example.com" },
                    { "68be42b9-0168-4556-8b46-a028fa13e57e", 0, "Hello, I'm John. I'm a highly motivated individual with a strong work ethic. I'm always ready to take on new challenges and learn new skills.", 11, "3e4fd32e-cd82-477d-88ca-05ef8740f1e8", "test6@example.com", false, "John", "Doe", true, null, "Robert", "TEST6@EXAMPLE.COM", "TEST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEEVfnTOKF+6CcaVEIwK4YOENMujcgQ68vA10vUZqbnsRyYmLEFBnGin3ZeKkkSfpEw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser6/profilepic.jpg", "34f13408-c145-4b45-b41a-c0689da29c34", false, "test6@example.com" },
                    { "80c0c078-093d-4182-8382-cf4dc1984a05", 0, "Hi, I'm Sarah. I'm a dedicated professional with a passion for learning. I'm always looking for opportunities to expand my skill set and contribute to a team.", 12, "e946392b-3741-44c4-a6cf-0cb3ca909fb2", "test11@example.com", false, "Sarah", "Martinez", true, null, "Jane", "TEST11@EXAMPLE.COM", "TEST11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMs1sk5tZq4axAtaNBqg5De0ZLBIyuQK3Mn6E3iCFKQmJoDV9tCZ18fvyFz13X7gAA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser11/profilepic.jpg", "3aa3bcdf-9740-4081-b739-5e246605cdee", false, "test11@example.com" },
                    { "8fa2a882-8f80-4569-8f71-205cf0fd8f70", 0, "I'm Daniel, a motivated individual with a strong work ethic. I'm always ready to take on new challenges and learn new skills.", 14, "e21d89dc-16e1-49c7-ad65-8bce1ac0c323", "test12@example.com", false, "Daniel", "Garcia", true, null, "Carlos", "TEST12@EXAMPLE.COM", "TEST12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIswlxYYx94ICTepeufA3AdbFwL5ms8+MJx6SbsXCL2QE0Dh87E81zijU8N5PGvsvA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser12/profilepic.jpg", "bcc90e29-3be3-4133-833a-891ce6c40190", false, "test12@example.com" },
                    { "97843ada-0a67-40bb-a820-95d6b81d6125", 0, "Hello, I'm Olivia. I'm a detail-oriented professional who takes pride in producing high-quality work. I'm always eager to learn and grow professionally.", 15, "cd905a7f-8950-41ca-8191-975fb758ea61", "test13@example.com", false, "Olivia", "Rodriguez", true, null, "Maria", "TEST13@EXAMPLE.COM", "TEST13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP+EwQ/qTAq/0+FP0MO0ViLS6BjvpCnqveG/mxXyFC74rXZyDSAixrjb8gD02+Fzxw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser13/profilepic.jpg", "52f69db7-f82a-405b-8412-d8b1eaf1e9ff", false, "test13@example.com" },
                    { "9afa7a71-6291-4aba-a163-22c825f94739", 0, "I'm David, a hardworking professional with a passion for excellence. I'm always ready to take on new challenges and learn new skills.", 13, "fb3d302e-aa45-48f6-a504-db61eb0e1783", "test10@example.com", false, "David", "Wilson", true, null, "Paul", "TEST10@EXAMPLE.COM", "TEST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEN4QufU1YGCfLizGqAAFlfl9twRGIlih9vY2gvEcluNNLICl5qoDlMkwPjCuAohDEg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser10/profilepic.jpg", "13e225f2-fb9f-4528-8651-c542b1461f98", false, "test10@example.com" },
                    { "9d43f094-bf6a-4f9d-a626-6d7d45455ff7", 0, "I'm Adam, a cheerful individual with a passion for helping others. My expertise lies in gardening and I'm seeking assistance with bricklaying projects.", 2, "24a0275b-2555-4757-b286-a5f9c492056f", "test1@example.com", false, "Adam", "Larsson", true, null, "Karl", "TEST1@EXAMPLE.COM", "TEST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAED6pDVmB9qoB/qe+XiKTeWVNkz1lmI88cfIu5l6h52JTGxJOFykui1xCprsRqX6OKA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser1/profilepic.jpg", "c0514ba3-10da-471d-bf54-76af470f37ca", false, "test1@example.com" },
                    { "9fe10390-8248-4176-9617-ba817c7b0cbd", 0, "I'm James, a hardworking professional with a passion for excellence. I'm always ready to take on new challenges and learn new skills.", 3, "1484063c-117b-4463-b562-6398eb548582", "test16@example.com", false, "James", "Hernandez", true, null, "Andrew", "TEST16@EXAMPLE.COM", "TEST16@EXAMPLE.COM", "AQAAAAIAAYagAAAAECUCBxhsO07BW0FTTgwKbV53LrHfMaSXX7bCdTOfty2iRenM3ExsacP/LkeV7qpgYw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser16/profilepic.jpg", "83e3cef4-e304-40ee-a860-0eab5e687b90", false, "test16@example.com" },
                    { "b60712de-2af1-43b6-8423-03ad0b17b126", 0, "Hello, I'm Benjamin. I'm a motivated individual with a strong work ethic. I'm always ready to take on new challenges and learn new skills.", 1, "ae2bc1cd-0e84-4917-84cd-66fad8826c3b", "test17@example.com", false, "Benjamin", "Perez", true, null, "Joseph", "TEST17@EXAMPLE.COM", "TEST17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAI3K3mOx5G+6Rz/HRYJLET24jiG6FB/42VSxBPPqlR/HYzC3gRSP8drEigqLdoE4g==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser17/profilepic.jpg", "c927f77b-0ff5-4dc9-910a-bdab174da6fc", false, "test17@example.com" },
                    { "bd6fb7cb-3be0-4190-9746-bb9069865552", 0, "I'm Sophia, a detail-oriented professional who takes pride in producing high-quality work. I'm always eager to learn and grow professionally.", 9, "8d01e9f5-7388-4053-8136-664efc002d80", "test18@example.com", false, "Sophia", "Ramirez", true, null, "Isabella", "TEST18@EXAMPLE.COM", "TEST18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEE50bqK7VMIUYvlBCYxmkZiFj/P1Kvmm7S/HGgDjwMc/pDM8cucku8An04H29MrEXg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser18/profilepic.jpg", "f947b553-f2fa-4865-bfd7-c5ef7bc6585f", false, "test18@example.com" },
                    { "c38ab79b-6a47-41d7-89e8-2651741f6f14", 0, "I'm Emma, a creative thinker with a knack for finding innovative solutions. I love to explore new ideas and concepts.", 1, "dedd060a-dc81-45a6-ab1e-bb99302eb7c2", "test5@example.com", false, "Emma", "Johansson", true, null, "Sofia", "TEST5@EXAMPLE.COM", "TEST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDrD07nMNrQpmLVImR8DkTKvV5zPUvwTUifRecnWw0RRLzCpbIh4STsm5edtesCJvg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser5/profilepic.jpg", "86c6c3d6-07a5-4973-90b4-dce65e95995b", false, "test5@example.com" },
                    { "d563ef92-9359-43bb-b21f-6ceb23606392", 0, "Hi, I'm Lisa. I'm passionate about continuous learning and improvement. I believe in the power of positivity and hard work.", 8, "4b41b732-f8a1-4a64-aa8d-9f84a44ccd97", "test4@example.com", false, "Lisa", "Andersson", true, null, "Caroline", "TEST4@EXAMPLE.COM", "TEST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAffIb+gFyHOrnneH4B1stUezCu7PtBHBtB3surcn+ZspHxYIhVslLvrQyZ7wipSXA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser4/profilepic.jpg", "e93f825e-c67c-47f9-9bfa-f14610f71236", false, "test4@example.com" },
                    { "dae1eb95-5b2e-412c-b426-d35e5a4d1b84", 0, "Hello, I'm Emily. I'm a proactive individual with a passion for learning and growth. I'm always looking for ways to improve and take on new challenges.", 7, "653584a1-18b5-42ea-92bd-d8c48ca57752", "test9@example.com", false, "Emily", "Brown", true, null, "Anne", "TEST9@EXAMPLE.COM", "TEST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEF6gpqe5EHBkAc58FcmllbbjdRQzjOb2y3MBF0CHd3bUjiastUV5qcyxm6TznLenig==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser9/profilepic.jpg", "e629b389-16dc-41fd-bcac-bd1932077e31", false, "test9@example.com" },
                    { "e7c0c419-8eab-40c5-b802-b626b70872f9", 0, "I'm William, a dedicated professional with a passion for learning. I'm always looking for opportunities to expand my skill set and contribute to a team.", 16, "b96e562c-e598-4537-81d9-7b9843b83163", "test14@example.com", false, "William", "Lopez", true, null, "Alexander", "TEST14@EXAMPLE.COM", "TEST14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMhQB2Y08btALAsFa46FEO8eA24lUKHmiKSBsbnB4Uep3bz7yiDvqTTNYnNKsuBVcA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser14/profilepic.jpg", "c12386f9-5fc2-48e8-8f5a-54c4a31cc1a9", false, "test14@example.com" },
                    { "fc584c5d-c637-47f2-96e2-7eb4a560dbac", 0, "Hello, I'm Adrian. I'm a professional with a diverse skill set, always ready to learn and take on new challenges.", 5, "0a2cd26e-fec3-4e5c-8ff1-d5c3fbb8d8b2", "test2@example.com", false, "Adrian", "Bodin", true, null, "Nils", "TEST2@EXAMPLE.COM", "TEST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEMcnbtIhQAA00ZvtZm7BED75mD9f5c3PHPljkcua2UQVsoYTF48QGkcUktCI8kVCZA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser2/profilepic.jpg", "666bee40-3c8c-43e1-a030-fc309271e68e", false, "test2@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "DateCreated", "PostedById", "Rating", "UserId" },
                values: new object[,]
                {
                    { "006a19fb-518c-47a4-89d1-0614be7d33b4", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7511), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)2, "10051508-4b64-487d-8781-d13b6625926b" },
                    { "056e3ad6-143a-44fc-a639-93bd1f587a8e", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7267), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)1, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { "05e062a1-761e-4e36-b7b6-0284dd294240", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7172), "10051508-4b64-487d-8781-d13b6625926b", (byte)2, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { "09dc8009-40f2-451b-b74c-fffa63a744c2", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6768), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)2, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { "0b58704a-b72a-4c18-87cc-0adc0f490c65", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7420), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)4, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { "0be0193e-105d-4a41-98a4-01cc3999b5c2", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7463), "10051508-4b64-487d-8781-d13b6625926b", (byte)1, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { "0e4bdb0c-b98a-429a-b781-7e344b96e4e0", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7454), "d563ef92-9359-43bb-b21f-6ceb23606392", (byte)1, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { "0ec57fe5-4105-4b1d-ae54-a539f3a8d725", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7431), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)4, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { "0eef21c3-3f38-461f-bbd7-f23bb165d2a7", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7513), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)2, "10051508-4b64-487d-8781-d13b6625926b" },
                    { "0fb90d99-e387-44a9-a971-d36b5cef08e2", "Great service!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7299), "43eb00c1-7c1b-4946-84b9-760e965c905b", (byte)4, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { "126625ee-c125-437e-bb53-fd55403629e4", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7461), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)4, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { "140aa4ba-3d3f-495b-af2a-82b3c6d325d9", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6643), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)5, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { "19a74858-bb33-4cba-b025-623e81de3664", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7288), "43eb00c1-7c1b-4946-84b9-760e965c905b", (byte)2, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { "1a00cdca-aa38-4afa-9c84-4563b05547f4", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7476), "9d43f094-bf6a-4f9d-a626-6d7d45455ff7", (byte)3, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { "1b51feaa-29a7-4dd0-af12-f5af8a8ac478", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7276), "dae1eb95-5b2e-412c-b426-d35e5a4d1b84", (byte)2, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { "1b6f92eb-fbd2-481d-8896-e5884dcd55d8", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7469), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)1, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { "1f55a557-e4d5-4858-84d9-b94bf06f1d02", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7294), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)5, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { "209d544f-83a4-4ebf-b553-0d7f82137f09", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7506), "53afaaaf-a23b-4f35-8334-c18bbd554148", (byte)1, "10051508-4b64-487d-8781-d13b6625926b" },
                    { "22f98f43-f987-45b0-ad1a-bbbdee9f5bcd", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7312), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)5, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { "2351d359-77dc-4840-a8b3-b33bdcdc97a9", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7457), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)2, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { "23e4be20-546d-4375-8788-55d3153715c3", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7146), "b60712de-2af1-43b6-8423-03ad0b17b126", (byte)5, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { "24365ab7-2f39-42c5-9975-e60a9563ec8d", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7281), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)2, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { "2444c8f8-026a-4103-89ea-3e4bbcec35cc", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7472), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)3, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { "251ea220-ad14-4e1f-910a-b970e249b543", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6660), "dae1eb95-5b2e-412c-b426-d35e5a4d1b84", (byte)2, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { "256e8722-03c4-423c-b977-f2d84bc94047", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7203), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)1, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { "2df2b9e2-8551-40c5-953a-889a4b2ab7b6", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7494), "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", (byte)3, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { "3084837e-7283-42bc-b0c8-c2160dc5ebaa", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6806), "43eb00c1-7c1b-4946-84b9-760e965c905b", (byte)1, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { "30fc6835-b29f-486f-adcd-9be438dc89b6", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7467), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)1, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { "33501ae9-5490-42a8-b021-342623946abd", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7273), "dae1eb95-5b2e-412c-b426-d35e5a4d1b84", (byte)5, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { "38dc81d4-6ae2-4718-829a-639c60e9b97e", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7478), "fc584c5d-c637-47f2-96e2-7eb4a560dbac", (byte)4, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { "3b0c0668-19b4-45f7-b2d5-d9c79fea42fb", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7498), "fc584c5d-c637-47f2-96e2-7eb4a560dbac", (byte)2, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { "3dafa71c-a2b1-4dc5-903c-3f04bf730016", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7433), "53afaaaf-a23b-4f35-8334-c18bbd554148", (byte)1, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { "3dd8c23e-9a31-498f-a889-24d4ca64f8cb", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7422), "9afa7a71-6291-4aba-a163-22c825f94739", (byte)1, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { "425a1efb-5c28-4ce0-a34f-f72f8250b20a", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7286), "9afa7a71-6291-4aba-a163-22c825f94739", (byte)3, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { "437c423d-c4ad-487c-9bb5-6e6a0ce8a1d4", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6499), "c38ab79b-6a47-41d7-89e8-2651741f6f14", (byte)4, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { "4ac258f4-b989-4c8d-b537-7f3e522d768f", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7264), "10051508-4b64-487d-8781-d13b6625926b", (byte)3, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { "4c6e7dbe-c4b8-46f6-b4fa-7c51bf79aed8", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7258), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)2, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { "4cd4b0f3-2376-4a48-afd5-1aeabdddc6bb", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6782), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)2, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { "51b78c7b-c25d-4c38-9ce7-7fc851af9db1", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7502), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)5, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { "53b3ef4f-47ca-4dd9-8a37-cb9fc8e9c66e", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7418), "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", (byte)5, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { "54aca593-1f67-41c7-836a-819ccfda9fe0", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6803), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)2, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { "5524f6cf-3468-4ecd-9951-dd4c65bac055", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6855), "c38ab79b-6a47-41d7-89e8-2651741f6f14", (byte)5, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { "5952b4b6-feb6-4c8b-bd75-5d6f6a6cae8f", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7450), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)5, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { "5a1e2107-dbfa-4e74-b98d-b4d2eb6a27c4", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7271), "c38ab79b-6a47-41d7-89e8-2651741f6f14", (byte)5, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { "5a50f1e2-e8be-4e0e-b08a-5d2c32c9e6c3", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7436), "b60712de-2af1-43b6-8423-03ad0b17b126", (byte)4, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { "5bc7f3e8-08b3-463f-bef5-9c32225f2345", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7174), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)5, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { "5bf7cb45-4cc1-4324-8e60-b9e33bc02e52", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7185), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)2, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { "5e815a97-d31d-4816-b950-3ca4849bea9f", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7181), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)2, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { "61828211-d717-4588-9441-4ff4bcab94fd", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6668), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)5, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { "63844202-1f83-4273-bebb-42d929bec4c1", "Great service!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7306), "b60712de-2af1-43b6-8423-03ad0b17b126", (byte)2, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { "63a98cab-138b-43bf-a2e1-4314dfc751b1", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7487), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)1, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { "650ee60f-6c22-43f0-97da-f7620a438e00", "Great service!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7304), "53afaaaf-a23b-4f35-8334-c18bbd554148", (byte)2, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { "65f64b0c-03b9-459c-a09a-b35d51497b8f", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6799), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)1, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { "6b82de74-d326-4239-96bd-41db9b498e23", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7548), "97843ada-0a67-40bb-a820-95d6b81d6125", (byte)2, "10051508-4b64-487d-8781-d13b6625926b" },
                    { "6be8a27d-ab47-440d-9599-cb1082d5edc1", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7189), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)4, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { "73331673-4409-4c0e-8768-bc0ae7c6ae72", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7496), "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", (byte)2, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { "736767d7-9211-4ee1-80cd-15af966c2f96", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7284), "c38ab79b-6a47-41d7-89e8-2651741f6f14", (byte)4, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { "7381c692-0eb0-4a8f-81fc-a67bd9517a9c", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7165), "fc584c5d-c637-47f2-96e2-7eb4a560dbac", (byte)4, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { "7af61879-a61d-4d4d-9ba1-8c04e4a3a0cf", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7481), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)4, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { "7d88e87f-8cb2-48cf-8311-82964e40e959", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7317), "97843ada-0a67-40bb-a820-95d6b81d6125", (byte)3, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { "7fdc8952-d6f1-4ef2-a7a3-58586c67649e", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7426), "fc584c5d-c637-47f2-96e2-7eb4a560dbac", (byte)5, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { "81826256-75f5-4e0e-98fd-dba05929fd9e", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7094), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)1, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { "83ebbede-2c2f-4c3d-8a6b-ae9e639fba68", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7309), "1e581e52-4f85-4d61-90f8-fcfa5cecc837", (byte)4, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { "882a9e46-1c1f-41a7-97c0-75cb6de920d4", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7319), "43eb00c1-7c1b-4946-84b9-760e965c905b", (byte)5, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { "9132e749-264c-4841-a50d-ab1104722c7a", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7489), "97843ada-0a67-40bb-a820-95d6b81d6125", (byte)2, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { "9195b8db-9167-4cef-bc8d-53e08c05b779", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7459), "1e581e52-4f85-4d61-90f8-fcfa5cecc837", (byte)5, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { "983ecf7a-560c-4a4e-b30a-9bb52658c2a7", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7297), "10051508-4b64-487d-8781-d13b6625926b", (byte)5, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { "9ade42d6-5eac-432d-a06f-20775208b63b", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7178), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)5, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { "9ea76f73-1af2-4236-8c95-b855afcdd5b9", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7509), "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", (byte)2, "10051508-4b64-487d-8781-d13b6625926b" },
                    { "a1d6dd97-dace-4bbf-a460-746902855847", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7176), "68be42b9-0168-4556-8b46-a028fa13e57e", (byte)2, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { "a2f1d44c-70be-46b6-ba2f-0c6eb0477e57", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7443), "9afa7a71-6291-4aba-a163-22c825f94739", (byte)5, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { "a4c0c7f5-4de4-4e9b-9143-4ec9b4d5e23b", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7301), "97843ada-0a67-40bb-a820-95d6b81d6125", (byte)4, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { "a547ee6a-e0bd-471a-ae35-225ba157aa14", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7474), "bd6fb7cb-3be0-4190-9746-bb9069865552", (byte)4, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { "aed60aa4-bc97-4e8c-a03a-ec4393c28079", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7491), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)3, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { "b167a531-bbeb-482d-b483-bbd5a1e34adf", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7156), "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71", (byte)3, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { "b874f9f1-3164-455d-a2bf-13ad0244672a", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7169), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)4, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { "b923e986-0988-4095-971b-0f5ec5b4254c", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7440), "d563ef92-9359-43bb-b21f-6ceb23606392", (byte)5, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { "bb70ba7c-4356-4544-9545-c298aa964d82", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6785), "9afa7a71-6291-4aba-a163-22c825f94739", (byte)4, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { "bb8115fb-66de-4b3e-8494-52a0986d719e", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7292), "1e581e52-4f85-4d61-90f8-fcfa5cecc837", (byte)2, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { "c0a97e3e-bb52-4e4d-9536-bbb81e97ac55", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7167), "9fe10390-8248-4176-9617-ba817c7b0cbd", (byte)1, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { "c469ecb5-9376-4955-871e-9d0296415736", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6779), "8fa2a882-8f80-4569-8f71-205cf0fd8f70", (byte)4, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { "c49310f5-dbdd-48b3-9444-383f55d13c9a", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7438), "97843ada-0a67-40bb-a820-95d6b81d6125", (byte)5, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { "c4dcd830-6851-4fd2-ae71-519514296f27", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7261), "1e581e52-4f85-4d61-90f8-fcfa5cecc837", (byte)5, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { "c56d21cc-f946-4842-b89f-037f226aa9b6", "Great service!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7187), "10051508-4b64-487d-8781-d13b6625926b", (byte)5, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { "c8a9bb8a-2c6f-4031-a6bb-ef3feb4f7bed", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7500), "9d43f094-bf6a-4f9d-a626-6d7d45455ff7", (byte)3, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { "ca04f25a-c9e9-4e45-9beb-e831ddce2ffa", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7150), "d563ef92-9359-43bb-b21f-6ceb23606392", (byte)1, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { "cd044dd2-7d9f-4954-ab44-4173a389d9a7", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7315), "d563ef92-9359-43bb-b21f-6ceb23606392", (byte)2, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { "d576fefc-029d-4330-a997-79b522fee890", "I would recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6665), "10051508-4b64-487d-8781-d13b6625926b", (byte)5, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { "db2da711-97a0-4cee-864c-92087a74175e", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7278), "b60712de-2af1-43b6-8423-03ad0b17b126", (byte)4, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { "dd4998e7-9944-4f70-9b4b-09cea1677963", "I'm not very satisfied.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(6791), "d563ef92-9359-43bb-b21f-6ceb23606392", (byte)5, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { "e64bbb84-a05d-4aa5-b565-840f0abc5cd0", "Could be better.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7483), "c38ab79b-6a47-41d7-89e8-2651741f6f14", (byte)4, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { "e677bce8-21f5-4052-a67a-4020ad20ce47", "I had a wonderful experience.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7414), "9afa7a71-6291-4aba-a163-22c825f94739", (byte)5, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { "e6783844-d392-4767-8f04-1b51b7d52953", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7452), "80c0c078-093d-4182-8382-cf4dc1984a05", (byte)4, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { "f1c107ff-bd8b-4caa-84ef-4bc4a54d4f9b", "Excellent!", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7429), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)4, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { "f7e07ba5-b123-423d-928f-e545418d8a61", "I would not recommend this service to anyone.", new DateTime(2024, 5, 10, 9, 49, 7, 243, DateTimeKind.Local).AddTicks(7447), "e7c0c419-8eab-40c5-b802-b626b70872f9", (byte)3, "e7c0c419-8eab-40c5-b802-b626b70872f9" }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 4, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 9, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 13, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 17, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 1, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 2, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 15, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 16, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 17, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 2, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 3, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 17, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 2, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 4, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 6, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 10, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 14, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 7, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 10, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 11, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 17, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 4, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 5, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 10, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 14, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 17, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 2, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 6, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 14, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 17, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 5, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 7, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 13, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 16, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 2, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 8, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 15, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 1, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 2, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 4, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 14, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 3, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 4, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 7, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 8, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 14, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 2, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 6, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 12, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 13, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 16, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 2, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 4, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 5, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 14, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 5, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 6, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 8, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 12, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 16, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 1, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 6, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 10, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 14, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 16, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 4, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 9, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 12, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 16, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 2, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 8, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 11, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 13, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 14, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 1, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 2, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 6, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 10, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 13, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 6, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 13, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 15, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 16, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 17, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" }
                });

            migrationBuilder.InsertData(
                table: "UserWantedSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 5, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 11, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 14, "10051508-4b64-487d-8781-d13b6625926b" },
                    { 2, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 12, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 13, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 15, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" },
                    { 6, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 9, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 10, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 16, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 17, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" },
                    { 4, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 13, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 15, "43eb00c1-7c1b-4946-84b9-760e965c905b" },
                    { 3, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 6, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 8, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 11, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 13, "53afaaaf-a23b-4f35-8334-c18bbd554148" },
                    { 2, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 10, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 12, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 16, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 17, "68be42b9-0168-4556-8b46-a028fa13e57e" },
                    { 5, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 12, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 13, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 14, "80c0c078-093d-4182-8382-cf4dc1984a05" },
                    { 2, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 8, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 15, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 16, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" },
                    { 3, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 5, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 8, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 14, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 16, "97843ada-0a67-40bb-a820-95d6b81d6125" },
                    { 1, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 2, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 10, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 13, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 14, "9afa7a71-6291-4aba-a163-22c825f94739" },
                    { 4, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 6, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 8, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 10, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 17, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" },
                    { 2, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 5, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 8, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 9, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 15, "9fe10390-8248-4176-9617-ba817c7b0cbd" },
                    { 6, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 8, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 13, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 14, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 15, "b60712de-2af1-43b6-8423-03ad0b17b126" },
                    { 5, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 8, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 9, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 10, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 13, "bd6fb7cb-3be0-4190-9746-bb9069865552" },
                    { 1, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 6, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 7, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 10, "c38ab79b-6a47-41d7-89e8-2651741f6f14" },
                    { 2, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 4, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 5, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 15, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 16, "d563ef92-9359-43bb-b21f-6ceb23606392" },
                    { 3, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 8, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 10, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 12, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 16, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" },
                    { 5, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 10, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 13, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 16, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 17, "e7c0c419-8eab-40c5-b802-b626b70872f9" },
                    { 2, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 3, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 6, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 12, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" },
                    { 15, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "006a19fb-518c-47a4-89d1-0614be7d33b4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "056e3ad6-143a-44fc-a639-93bd1f587a8e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "05e062a1-761e-4e36-b7b6-0284dd294240");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "09dc8009-40f2-451b-b74c-fffa63a744c2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0b58704a-b72a-4c18-87cc-0adc0f490c65");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0be0193e-105d-4a41-98a4-01cc3999b5c2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0e4bdb0c-b98a-429a-b781-7e344b96e4e0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0ec57fe5-4105-4b1d-ae54-a539f3a8d725");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0eef21c3-3f38-461f-bbd7-f23bb165d2a7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "0fb90d99-e387-44a9-a971-d36b5cef08e2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "126625ee-c125-437e-bb53-fd55403629e4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "140aa4ba-3d3f-495b-af2a-82b3c6d325d9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "19a74858-bb33-4cba-b025-623e81de3664");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1a00cdca-aa38-4afa-9c84-4563b05547f4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1b51feaa-29a7-4dd0-af12-f5af8a8ac478");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1b6f92eb-fbd2-481d-8896-e5884dcd55d8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "1f55a557-e4d5-4858-84d9-b94bf06f1d02");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "209d544f-83a4-4ebf-b553-0d7f82137f09");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "22f98f43-f987-45b0-ad1a-bbbdee9f5bcd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2351d359-77dc-4840-a8b3-b33bdcdc97a9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "23e4be20-546d-4375-8788-55d3153715c3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "24365ab7-2f39-42c5-9975-e60a9563ec8d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2444c8f8-026a-4103-89ea-3e4bbcec35cc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "251ea220-ad14-4e1f-910a-b970e249b543");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "256e8722-03c4-423c-b977-f2d84bc94047");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "2df2b9e2-8551-40c5-953a-889a4b2ab7b6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3084837e-7283-42bc-b0c8-c2160dc5ebaa");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "30fc6835-b29f-486f-adcd-9be438dc89b6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "33501ae9-5490-42a8-b021-342623946abd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "38dc81d4-6ae2-4718-829a-639c60e9b97e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3b0c0668-19b4-45f7-b2d5-d9c79fea42fb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3dafa71c-a2b1-4dc5-903c-3f04bf730016");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "3dd8c23e-9a31-498f-a889-24d4ca64f8cb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "425a1efb-5c28-4ce0-a34f-f72f8250b20a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "437c423d-c4ad-487c-9bb5-6e6a0ce8a1d4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4ac258f4-b989-4c8d-b537-7f3e522d768f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4c6e7dbe-c4b8-46f6-b4fa-7c51bf79aed8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "4cd4b0f3-2376-4a48-afd5-1aeabdddc6bb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "51b78c7b-c25d-4c38-9ce7-7fc851af9db1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "53b3ef4f-47ca-4dd9-8a37-cb9fc8e9c66e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "54aca593-1f67-41c7-836a-819ccfda9fe0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5524f6cf-3468-4ecd-9951-dd4c65bac055");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5952b4b6-feb6-4c8b-bd75-5d6f6a6cae8f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5a1e2107-dbfa-4e74-b98d-b4d2eb6a27c4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5a50f1e2-e8be-4e0e-b08a-5d2c32c9e6c3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5bc7f3e8-08b3-463f-bef5-9c32225f2345");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5bf7cb45-4cc1-4324-8e60-b9e33bc02e52");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "5e815a97-d31d-4816-b950-3ca4849bea9f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "61828211-d717-4588-9441-4ff4bcab94fd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "63844202-1f83-4273-bebb-42d929bec4c1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "63a98cab-138b-43bf-a2e1-4314dfc751b1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "650ee60f-6c22-43f0-97da-f7620a438e00");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "65f64b0c-03b9-459c-a09a-b35d51497b8f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "6b82de74-d326-4239-96bd-41db9b498e23");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "6be8a27d-ab47-440d-9599-cb1082d5edc1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "73331673-4409-4c0e-8768-bc0ae7c6ae72");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "736767d7-9211-4ee1-80cd-15af966c2f96");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7381c692-0eb0-4a8f-81fc-a67bd9517a9c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7af61879-a61d-4d4d-9ba1-8c04e4a3a0cf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7d88e87f-8cb2-48cf-8311-82964e40e959");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "7fdc8952-d6f1-4ef2-a7a3-58586c67649e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "81826256-75f5-4e0e-98fd-dba05929fd9e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "83ebbede-2c2f-4c3d-8a6b-ae9e639fba68");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "882a9e46-1c1f-41a7-97c0-75cb6de920d4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9132e749-264c-4841-a50d-ab1104722c7a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9195b8db-9167-4cef-bc8d-53e08c05b779");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "983ecf7a-560c-4a4e-b30a-9bb52658c2a7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9ade42d6-5eac-432d-a06f-20775208b63b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "9ea76f73-1af2-4236-8c95-b855afcdd5b9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a1d6dd97-dace-4bbf-a460-746902855847");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a2f1d44c-70be-46b6-ba2f-0c6eb0477e57");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a4c0c7f5-4de4-4e9b-9143-4ec9b4d5e23b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "a547ee6a-e0bd-471a-ae35-225ba157aa14");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "aed60aa4-bc97-4e8c-a03a-ec4393c28079");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "b167a531-bbeb-482d-b483-bbd5a1e34adf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "b874f9f1-3164-455d-a2bf-13ad0244672a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "b923e986-0988-4095-971b-0f5ec5b4254c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "bb70ba7c-4356-4544-9545-c298aa964d82");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "bb8115fb-66de-4b3e-8494-52a0986d719e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c0a97e3e-bb52-4e4d-9536-bbb81e97ac55");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c469ecb5-9376-4955-871e-9d0296415736");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c49310f5-dbdd-48b3-9444-383f55d13c9a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c4dcd830-6851-4fd2-ae71-519514296f27");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c56d21cc-f946-4842-b89f-037f226aa9b6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "c8a9bb8a-2c6f-4031-a6bb-ef3feb4f7bed");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "ca04f25a-c9e9-4e45-9beb-e831ddce2ffa");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "cd044dd2-7d9f-4954-ab44-4173a389d9a7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "d576fefc-029d-4330-a997-79b522fee890");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "db2da711-97a0-4cee-864c-92087a74175e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "dd4998e7-9944-4f70-9b4b-09cea1677963");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "e64bbb84-a05d-4aa5-b565-840f0abc5cd0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "e677bce8-21f5-4052-a67a-4020ad20ce47");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "e6783844-d392-4767-8f04-1b51b7d52953");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "f1c107ff-bd8b-4caa-84ef-4bc4a54d4f9b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "f7e07ba5-b123-423d-928f-e545418d8a61");

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "10051508-4b64-487d-8781-d13b6625926b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "1e581e52-4f85-4d61-90f8-fcfa5cecc837" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "43eb00c1-7c1b-4946-84b9-760e965c905b" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "53afaaaf-a23b-4f35-8334-c18bbd554148" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "68be42b9-0168-4556-8b46-a028fa13e57e" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "80c0c078-093d-4182-8382-cf4dc1984a05" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "8fa2a882-8f80-4569-8f71-205cf0fd8f70" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "97843ada-0a67-40bb-a820-95d6b81d6125" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "9afa7a71-6291-4aba-a163-22c825f94739" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "9d43f094-bf6a-4f9d-a626-6d7d45455ff7" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "9fe10390-8248-4176-9617-ba817c7b0cbd" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "b60712de-2af1-43b6-8423-03ad0b17b126" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "bd6fb7cb-3be0-4190-9746-bb9069865552" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "c38ab79b-6a47-41d7-89e8-2651741f6f14" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "d563ef92-9359-43bb-b21f-6ceb23606392" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "dae1eb95-5b2e-412c-b426-d35e5a4d1b84" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, "e7c0c419-8eab-40c5-b802-b626b70872f9" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "UserWantedSkills",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, "fc584c5d-c637-47f2-96e2-7eb4a560dbac" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10051508-4b64-487d-8781-d13b6625926b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e581e52-4f85-4d61-90f8-fcfa5cecc837");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c9fd4c5-b814-40ba-80ad-f2fdb89d5d71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43eb00c1-7c1b-4946-84b9-760e965c905b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53afaaaf-a23b-4f35-8334-c18bbd554148");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68be42b9-0168-4556-8b46-a028fa13e57e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80c0c078-093d-4182-8382-cf4dc1984a05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fa2a882-8f80-4569-8f71-205cf0fd8f70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97843ada-0a67-40bb-a820-95d6b81d6125");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9afa7a71-6291-4aba-a163-22c825f94739");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d43f094-bf6a-4f9d-a626-6d7d45455ff7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fe10390-8248-4176-9617-ba817c7b0cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b60712de-2af1-43b6-8423-03ad0b17b126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd6fb7cb-3be0-4190-9746-bb9069865552");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38ab79b-6a47-41d7-89e8-2651741f6f14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d563ef92-9359-43bb-b21f-6ceb23606392");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dae1eb95-5b2e-412c-b426-d35e5a4d1b84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7c0c419-8eab-40c5-b802-b626b70872f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc584c5d-c637-47f2-96e2-7eb4a560dbac");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03ee79a0-ad3e-41d8-b3df-e1841a2c551f", 0, 16, "3f6b59b5-44a2-4e0b-bd52-3ff1165fb860", "test14@example.com", false, "William", "Lopez", true, null, "Alexander", "TEST14@EXAMPLE.COM", "TEST14@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPIpVHXXsvKQH8hXdEzbPJOoTlZdXfH0FosHoa2HddG49eUHpkxxcJ6HCIqfyZ0q2A==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser14/profilepic.jpg", "afcdbd7e-5c5c-48bb-bdf8-d8ffcc6cd889", false, "test14@example.com" },
                    { "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", 0, 7, "02c85c1f-1cfe-49e2-ac69-a59de693ad59", "test9@example.com", false, "Emily", "Brown", true, null, "Anne", "TEST9@EXAMPLE.COM", "TEST9@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFYqOB8We9dIe93kEcSogl2Ph19r6X6cfI+5P0m9Y6/IXm1r60XfCiUp23UIdyaRlw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser9/profilepic.jpg", "67a93435-9166-4a90-b71f-9cc352981e88", false, "test9@example.com" },
                    { "053018b7-c54b-49f6-ad5c-1bb0cae96463", 0, 9, "5004302a-221c-4e48-bead-5808136ed178", "test18@example.com", false, "Sophia", "Ramirez", true, null, "Isabella", "TEST18@EXAMPLE.COM", "TEST18@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKm+lzZA2l07aHF50GA5BQETWxJgoEuoF/8mRgj7bDhKxqKM4zpR6EzSwLyQFIIR6g==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser18/profilepic.jpg", "6aee19c7-a411-4758-9e2a-8130cde35f32", false, "test18@example.com" },
                    { "098abccc-d3f2-4fbf-b37c-d302e9ffc432", 0, 15, "cba261e5-cc78-42d5-9c47-cc6ce66f6b9a", "test13@example.com", false, "Olivia", "Rodriguez", true, null, "Maria", "TEST13@EXAMPLE.COM", "TEST13@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP4Rpqj+u8NOSe0tsPeN8xobA7Dx8M8P9BnD9iJOYfyK8ThE5IqK5M9og2FEwAjCbw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser13/profilepic.jpg", "55abd1eb-b8df-4113-a94f-4f52c199439d", false, "test13@example.com" },
                    { "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", 0, 2, "84612504-620a-4eef-9347-d61f30cc42aa", "test1@example.com", false, "Adam", "Larsson", true, null, "Karl", "TEST1@EXAMPLE.COM", "TEST1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHKok4LuuVKVKrO1fQXW02Rh6/LX57qaPt6rD/FOlp19v16qbeu5fiPheXsEv47THg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser1/profilepic.jpg", "26b32d2c-c733-4653-9379-5dc17e12fc2a", false, "test1@example.com" },
                    { "25baf4b9-4fea-423c-a2cb-d80b62d11466", 0, 3, "8d7fcec6-287e-400c-b58e-b27ec8bb48cc", "test16@example.com", false, "James", "Hernandez", true, null, "Andrew", "TEST16@EXAMPLE.COM", "TEST16@EXAMPLE.COM", "AQAAAAIAAYagAAAAEELPJZcRVLfKAHv99R/QOnVKSgkIb1xIy5s+vpCuNxha29iam5jWO41AKu1/SEIOUw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser16/profilepic.jpg", "db65114d-eb2c-4de4-9e38-433003d8be56", false, "test16@example.com" },
                    { "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", 0, 5, "38271ee1-fd13-41f1-a78c-7154b07fa3b4", "test15@example.com", false, "Ethan", "Gonzalez", true, null, "Gabriel", "TEST15@EXAMPLE.COM", "TEST15@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBjMpHN3+xnh8QPF9iglXK7RRzcyqImUvMpG5ju705NtDeLBWpEYh3xwndCeWQhFbw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser15/profilepic.jpg", "c66d92a6-9cce-465e-a57f-0645f26370c8", false, "test15@example.com" },
                    { "542f0577-edba-4664-b5c5-c0b917d8c81a", 0, 8, "de7e81cd-97a2-418c-b63d-3ade94aa57d1", "test3@example.com", false, "Fredrik", "Andersson", true, null, "Johan", "TEST3@EXAMPLE.COM", "TEST3@EXAMPLE.COM", "AQAAAAIAAYagAAAAEBAoIgIb+4k8gaoFLdojedRRKzb+mL010qZ/+YUr6bD6F4WZPnk93gwpwVx/M+uXMQ==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser3/profilepic.jpg", "f4fdac83-cccd-4ce8-8c85-9fec40b84313", false, "test3@example.com" },
                    { "83936903-1ad5-4024-b057-07b6616ea5e7", 0, 14, "eaeec4e3-831b-469b-9a41-deb24d5230c4", "test12@example.com", false, "Daniel", "Garcia", true, null, "Carlos", "TEST12@EXAMPLE.COM", "TEST12@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHKxAzWeQZiM8IYxKdlKpqCA7XsahzxY6Tavu6EyBhQFFKLzjAgaFJuZOZ5tmpZZmA==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser12/profilepic.jpg", "876b154a-cd70-45d1-b9da-72d630f53f31", false, "test12@example.com" },
                    { "a418f1c2-fe7d-49a4-8619-2849305b5812", 0, 1, "0b17566a-abc9-4bfb-ad55-badb1062458e", "test17@example.com", false, "Benjamin", "Perez", true, null, "Joseph", "TEST17@EXAMPLE.COM", "TEST17@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGO8oKoNvWpM0zMIIsoLB+7urkEB42BA1pUZjmNWB8X5gXZ1+YHWc2RXGFqz/Zr1FQ==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser17/profilepic.jpg", "ba763d8b-bb8a-4b8e-87b8-6bc20172eb53", false, "test17@example.com" },
                    { "a6480d64-0466-461d-b179-be55c4c0c4a3", 0, 1, "0a670d5a-7168-4f57-adc4-fd222a81a8b3", "test5@example.com", false, "Emma", "Johansson", true, null, "Sofia", "TEST5@EXAMPLE.COM", "TEST5@EXAMPLE.COM", "AQAAAAIAAYagAAAAEId6N9/8tLn6lNxgbzj3ePwGYImh+CGU8eUcV4nimZcRlhek3D/6F6Vf/lVTQ5Ib9g==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser5/profilepic.jpg", "a7152759-dad3-4ce0-b191-db20aa29f569", false, "test5@example.com" },
                    { "c9728f52-9dfc-400e-8368-e3ca3ad159ef", 0, 8, "5d8d21f5-7622-4f3e-a245-93884ac7b569", "test4@example.com", false, "Lisa", "Andersson", true, null, "Caroline", "TEST4@EXAMPLE.COM", "TEST4@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOYq5zpF/uWVAbeUXkbxPgbbJa2suXx8XAR7P8M23uYdqgjMzgsIwtlJLqK/7hwDuw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser4/profilepic.jpg", "f632f435-2762-4e63-b85d-64e9455b8885", false, "test4@example.com" },
                    { "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59", 0, 11, "a3c73788-3a7b-4326-84a0-99cebba587d6", "test6@example.com", false, "John", "Doe", true, null, "Robert", "TEST6@EXAMPLE.COM", "TEST6@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAcI26z0TpsO14eX02MtajHDgsOgO6DkNFJs84tXYuIHU+9HsezmVovxW/XXJny2tQ==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser6/profilepic.jpg", "f7300c67-c4d7-4541-934a-ce72f5277634", false, "test6@example.com" },
                    { "cb464ae2-b328-42dc-8fa3-b948cfefd90e", 0, 13, "2bdc9f1e-dd2a-4f0b-b0b6-6e51bee25409", "test10@example.com", false, "David", "Wilson", true, null, "Paul", "TEST10@EXAMPLE.COM", "TEST10@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAeHIkMKgfSl8phW2TFTaxTeM8GTN985OFTfX1VYDWR6YTTDEvlyAKtAeZvM8G2LDg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser10/profilepic.jpg", "a076f150-fbaa-4957-9040-7a3e866761a5", false, "test10@example.com" },
                    { "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4", 0, 9, "7cafe8dd-036a-45b1-8c1a-50be67d6f194", "test8@example.com", false, "Michael", "Johnson", true, null, "David", "TEST8@EXAMPLE.COM", "TEST8@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJi04xLM2Eq4DIaCluWSnIHcLq7oasXgW1GYWEjmyQXK1Azg40c5InaO6H04R0O0Kg==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser8/profilepic.jpg", "9369a468-cf48-4c54-a9af-a7aa3252e5a4", false, "test8@example.com" },
                    { "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a", 0, 10, "942c7272-dc53-4b54-ac54-403b989b11c1", "test7@example.com", false, "Alice", "Smith", true, null, "Grace", "TEST7@EXAMPLE.COM", "TEST7@EXAMPLE.COM", "AQAAAAIAAYagAAAAENJXLHuIQaEVfkZSejfZ+uEAWXYJydsBknL3qXNTc16uWPi1XrjKXKBSSe+4UpqdYw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser7/profilepic.jpg", "4087b52a-244c-4ccb-a1b7-ae21e059beeb", false, "test7@example.com" },
                    { "ebea6cc4-0fb8-41b7-910d-b06fd9221180", 0, 5, "68c64021-52c4-4ba9-a332-402af342087a", "test2@example.com", false, "Adrian", "Bodin", true, null, "Nils", "TEST2@EXAMPLE.COM", "TEST2@EXAMPLE.COM", "AQAAAAIAAYagAAAAEK0wngBVdWE5uCIzhI7fiIJ0ia/3cTe8PzhZEoDB/mYNl8V22PKr7EotL3c+Cku4bw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser2/profilepic.jpg", "46bbdc56-11d5-4707-98b0-6f74721735a1", false, "test2@example.com" },
                    { "f03d0f94-585e-4b41-a125-88d122a67a58", 0, 12, "b4ebc568-31cd-4445-8de0-cacec2b65951", "test11@example.com", false, "Sarah", "Martinez", true, null, "Jane", "TEST11@EXAMPLE.COM", "TEST11@EXAMPLE.COM", "AQAAAAIAAYagAAAAEG0nNb4OgdE3+TDeJxfnvaEcWXmubiIsnart+Nkbpm8vRNnZwvd4fF44lziV4um5bQ==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser11/profilepic.jpg", "9097522c-e116-45b9-a42a-768b120f7786", false, "test11@example.com" },
                    { "fbe71162-0523-49cd-b2a7-562621ba4c8c", 0, 11, "5c3243b4-0aa9-40c2-a1bc-7a2be1c3f7f6", "test19@example.com", false, "Mia", "Gomez", true, null, "Sophia", "TEST19@EXAMPLE.COM", "TEST19@EXAMPLE.COM", "AQAAAAIAAYagAAAAEL5oJLsRbzO16yoqOmK+ncRZDuOkdqExIawfigVlnjo6rStz4hu+JeIhrzBMVxV6xw==", null, false, "https://swapshastorage.blob.core.windows.net/seeduser19/profilepic.jpg", "bc76efce-7932-4394-a53b-6c2f44c4dea1", false, "test19@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Comment", "DateCreated", "PostedById", "Rating", "UserId" },
                values: new object[,]
                {
                    { "03164271-a1e7-4350-a635-d9d5836069ba", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2460), "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59", (byte)4, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { "03ce2bd7-ac22-48eb-a757-ee1a31a09743", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2181), "fbe71162-0523-49cd-b2a7-562621ba4c8c", (byte)1, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { "098fd2c0-112e-45b1-898b-230638ebd495", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2491), "c9728f52-9dfc-400e-8368-e3ca3ad159ef", (byte)1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { "148286ac-4e6f-4709-a733-cde83fb53d98", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2462), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)1, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { "14b6664d-e72a-4467-9105-fe40dd4124ea", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1856), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)2, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { "16e7de56-2f81-4fd2-bdcb-a34e2f8511e2", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2174), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)5, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { "176a9262-62f4-48ee-84a6-71e0a1f2e31e", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2567), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { "19432760-8cbf-4c45-aa59-e53a14ef534d", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2333), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)4, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { "1b7cf255-5fff-4967-a5fd-de04c480b540", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2376), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)2, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { "1cabb7b3-b2c3-4276-93b6-559e35bf3f27", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2452), "c9728f52-9dfc-400e-8368-e3ca3ad159ef", (byte)1, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { "1fce6aaf-1ab7-44c9-868f-d5f4b8acfd8c", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2439), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)2, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { "1ff6b66d-e2ce-4dbf-92d9-aef686de3c23", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2505), "fbe71162-0523-49cd-b2a7-562621ba4c8c", (byte)3, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { "20407ab6-06ff-4a16-873f-519d6e81c073", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2053), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)2, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { "20d1cbb2-3e96-41a6-8887-2f08b89a2777", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2517), "c9728f52-9dfc-400e-8368-e3ca3ad159ef", (byte)4, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { "22095779-0f1a-498c-bb41-06f1cba2be7c", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1854), "542f0577-edba-4664-b5c5-c0b917d8c81a", (byte)2, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { "222a266c-90ad-4c86-a6ca-b82bb0ee9d19", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2341), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)4, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { "24853c4d-f145-4c3a-9c7c-7af86b7bf4c9", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2365), "a6480d64-0466-461d-b179-be55c4c0c4a3", (byte)2, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { "2759b788-229a-48ad-8c8c-6e307d5f39ba", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2484), "ebea6cc4-0fb8-41b7-910d-b06fd9221180", (byte)1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { "2a932e79-245d-4dcd-8531-5b459a604c2d", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2477), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)1, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { "2e6ed4ca-c4e4-4eba-bea0-59a529fb85d7", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1962), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)2, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { "3078a273-fba0-4b7e-a0e9-338554dc24ad", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2500), "a6480d64-0466-461d-b179-be55c4c0c4a3", (byte)3, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { "352d4841-86c4-4b9b-974f-efe04a08d541", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2430), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)3, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { "381593bf-75d7-473c-a557-f67315e4b999", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2434), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)5, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { "3adfbd4a-4ea6-4b35-8f5d-a514fd1a0873", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2322), "542f0577-edba-4664-b5c5-c0b917d8c81a", (byte)3, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { "3c512029-a9db-4ebf-b64f-796cd5ea754f", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2200), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)1, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { "3d161104-2a4c-4a0f-a3e0-941f512d2058", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2168), "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", (byte)4, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { "3d3d255c-56c1-4627-b4dd-805f72c5b2fe", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2473), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)4, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { "3dbafffb-6565-4789-a791-c6aee5b34e90", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2378), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)3, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { "40f7efde-3723-4443-a25d-5e629f4f8203", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2467), "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", (byte)1, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { "41c7cecb-7d1e-4a48-8c2f-e161459db03f", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2339), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)4, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { "41f8c71b-7d7b-4d14-86f5-42ad94a1eab0", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2420), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)3, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { "4373aa87-4409-4245-8d41-087710febdf2", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2423), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)1, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { "43be773e-fcff-4f06-9a70-129e82152749", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2196), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)2, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { "44f82ce0-e48f-4f8b-8047-d636ef47505e", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2059), "cb464ae2-b328-42dc-8fa3-b948cfefd90e", (byte)4, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { "49dd2579-cb3b-4a3d-967b-0050f36a2ce2", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2350), "cb464ae2-b328-42dc-8fa3-b948cfefd90e", (byte)4, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { "4bb3ee88-dfe0-4cee-8aed-63d95c58f20a", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2515), "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59", (byte)2, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { "4dd39015-34f9-4e50-9e23-cba16e496614", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1863), "cb464ae2-b328-42dc-8fa3-b948cfefd90e", (byte)4, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { "4f8fa8a1-cbe0-4c0b-8542-f8209ad6b8ed", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2480), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)4, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { "4fc314a4-a31d-4c70-a030-b4b022e81578", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2356), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)5, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { "50bb47b4-b6e2-46b7-9505-408588f099cf", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2363), "a6480d64-0466-461d-b179-be55c4c0c4a3", (byte)1, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { "52b02a23-eef8-4853-9c11-343ec47da4c5", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2441), "fbe71162-0523-49cd-b2a7-562621ba4c8c", (byte)4, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { "533f7b77-7582-421c-91a8-2d4033c82b4f", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2495), "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", (byte)1, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { "54019fe6-7093-4a92-96f7-3222108e3464", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2464), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)2, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { "54305513-424c-4789-85ce-6fc0044f4cb7", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2361), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { "54e06c4a-8e83-40fb-b27e-f3ee906b64d8", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2347), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)3, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { "56094aae-29e9-48c7-b3c7-6082e7bf8ddb", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2457), "542f0577-edba-4664-b5c5-c0b917d8c81a", (byte)1, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { "56bd262b-e3a0-4cd4-8ffa-03f4b1e43e84", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2432), "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a", (byte)2, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { "58eb715f-eb59-479f-8d12-faa179c5c1b6", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2487), "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59", (byte)3, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { "5bd1e2a4-c6ba-4576-bbd3-0e5e23f786ad", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2513), "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a", (byte)2, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { "5c8305d3-f0f2-4d58-9603-ffad99129d5a", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2507), "098abccc-d3f2-4fbf-b37c-d302e9ffc432", (byte)3, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { "5d7e8765-8508-458f-a7a0-e34d6b63bfe7", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1848), "542f0577-edba-4664-b5c5-c0b917d8c81a", (byte)3, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { "5e65dea7-d97a-4804-9610-ead4b94f0207", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2381), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)4, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { "66ffdcb5-0b12-45e4-80a5-0391a9776f90", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2192), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)3, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { "6d9ee98d-08c4-4143-b5ca-c5414da5d564", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2203), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)1, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { "6f431f80-51e2-486a-b384-dc28b6e2b34e", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2475), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)4, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { "71012449-5ecc-40d7-b813-1780f921ca0d", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2358), "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4", (byte)4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { "73cfe4bc-98d1-4d04-9d57-17eaf668029d", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2383), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)3, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { "7c315c86-feaf-4214-935f-755733c23130", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2132), "542f0577-edba-4664-b5c5-c0b917d8c81a", (byte)3, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { "7d385ad0-e8dc-4ae6-8df4-c7449c2b946c", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2330), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)2, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { "82f05534-228f-4213-8e1b-befe4f55a083", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2570), "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4", (byte)5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { "83e2a5de-ff94-4be4-b3f3-0857197c5017", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2446), "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", (byte)3, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { "89bcd78e-3288-4a0c-84a3-1ff1bd3987f8", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1959), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)5, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { "8ba45322-57e5-4e5d-98f2-0633851e5ee7", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2471), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)2, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { "8c663ce1-ca47-4848-8485-9cd96d26b7d9", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2502), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)1, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { "8d800997-d868-4da4-8c78-339050767794", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2177), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)2, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { "914c4c00-a6d0-4581-a4a5-e574d1e83276", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2345), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)4, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { "91e62ed5-5d55-45fe-81f4-748a3a2798fb", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2368), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)1, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { "96df853d-604b-4347-8059-07d79eba5926", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2208), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)3, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { "9831b0e7-1a7b-428c-8cf6-35a1c04b048a", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2520), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)4, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { "9a0aec08-9ed4-4ac0-be61-65fda80b2afc", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2179), "c9728f52-9dfc-400e-8368-e3ca3ad159ef", (byte)5, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { "9c4044d9-6b8f-4817-a2ba-06dff558efe1", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2510), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)1, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { "9f484d6a-a10e-4259-bb1f-a94dc15e80b7", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2497), "cb464ae2-b328-42dc-8fa3-b948cfefd90e", (byte)3, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { "9fa6d9fd-04e3-44d0-8937-d3a77d48d2c0", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2443), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)3, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { "a261ebb4-228f-43d3-81be-c859f949df62", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2493), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)1, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { "a2bee7f4-2647-42d2-b17b-393cc9264e79", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2436), "053018b7-c54b-49f6-ad5c-1bb0cae96463", (byte)2, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { "a8e6f2eb-aa72-4926-949a-a29bacd74457", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2184), "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f", (byte)5, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { "aaf2f0b5-6392-419e-bb84-fa5f87897b34", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2188), "098abccc-d3f2-4fbf-b37c-d302e9ffc432", (byte)3, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { "ab9b640a-9563-4d4a-aad1-c4a0a2be8459", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2210), "83936903-1ad5-4024-b057-07b6616ea5e7", (byte)1, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { "adf6b9d1-027a-4202-b273-ad34594e5bdf", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1649), "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6", (byte)4, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { "afac9a71-6624-49d4-a26b-8ddb63f8df4f", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2482), "fbe71162-0523-49cd-b2a7-562621ba4c8c", (byte)2, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { "b1fba8a6-cf4b-4f0e-a736-fac7ab17808b", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2425), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)3, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { "bf5c7eef-0b88-43ca-ad15-88fd413c2ab1", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2374), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)4, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { "c343629b-0b64-4742-bc0c-a1849e1517de", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2354), "f03d0f94-585e-4b41-a125-88d122a67a58", (byte)2, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { "c868f630-8cd4-468c-a521-a11a6e911958", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1954), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)4, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { "c9984f10-52de-45d7-8ee4-1a5564b3ef9f", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1948), "03ee79a0-ad3e-41d8-b3df-e1841a2c551f", (byte)4, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { "c9a58fd9-57b6-4012-a523-879f487fe773", "I'm not very satisfied.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2116), "ebea6cc4-0fb8-41b7-910d-b06fd9221180", (byte)3, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { "ca998bbd-9fb1-4f19-8270-948b9a5ebcc8", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2450), "25baf4b9-4fea-423c-a2cb-d80b62d11466", (byte)2, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { "cbc3aeb3-06c0-4bf6-992d-d5596c98a5e7", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2061), "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59", (byte)2, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { "cfc954dd-e707-4931-9f3f-8bbee131e448", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2246), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)1, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { "d8408a63-312e-44c2-9864-2b4fb2b6ce1b", "Great service!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2370), "a418f1c2-fe7d-49a4-8619-2849305b5812", (byte)3, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { "dbd8b166-c557-47f8-9bb8-4b54a43bfe2c", "Excellent!", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2564), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)4, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { "dc461225-4e85-4acc-80e4-59107481824e", "I would recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(1931), "18a9b3b4-4777-42c7-93e1-29f046fb9a5e", (byte)5, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { "efff15d9-04ce-4c3d-949c-96f776cb5488", "I would not recommend this service to anyone.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2206), "098abccc-d3f2-4fbf-b37c-d302e9ffc432", (byte)1, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { "f4e42f01-635c-4b44-ad83-b142acac53ec", "I had a wonderful experience.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2455), "a6480d64-0466-461d-b179-be55c4c0c4a3", (byte)2, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { "faf01fc9-b5c5-4358-a00c-d039c38eaf45", "Could be better.", new DateTime(2024, 5, 8, 10, 13, 33, 388, DateTimeKind.Local).AddTicks(2336), "cb464ae2-b328-42dc-8fa3-b948cfefd90e", (byte)3, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" }
                });

            migrationBuilder.InsertData(
                table: "UserSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 4, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 7, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 14, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 17, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 3, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 6, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 13, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 6, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 8, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 13, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 14, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 1, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 4, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 8, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 11, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 1, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 2, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 3, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 11, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 17, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 4, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 6, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 7, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 16, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 3, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 4, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 9, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 15, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 4, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 10, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 11, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 16, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 7, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 8, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 14, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 16, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 17, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 7, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 9, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 10, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 13, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 17, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 6, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 10, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 12, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 16, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 1, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 2, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 13, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 15, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 17, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 4, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 5, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 7, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 9, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 16, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 4, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 5, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 9, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 15, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 2, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 5, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 7, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 12, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 14, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 4, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 10, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 17, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 1, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 9, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 10, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 12, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 15, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 3, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 6, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 10, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 14, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 17, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 3, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 7, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 13, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 15, "fbe71162-0523-49cd-b2a7-562621ba4c8c" }
                });

            migrationBuilder.InsertData(
                table: "UserWantedSkills",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 1, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 2, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 6, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 17, "03ee79a0-ad3e-41d8-b3df-e1841a2c551f" },
                    { 4, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 5, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 10, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 14, "04b508a6-595b-4e1d-abf8-b96f8ac1d0c6" },
                    { 4, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 5, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 13, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 14, "053018b7-c54b-49f6-ad5c-1bb0cae96463" },
                    { 6, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 7, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 8, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 12, "098abccc-d3f2-4fbf-b37c-d302e9ffc432" },
                    { 3, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 6, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 11, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 14, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 16, "18a9b3b4-4777-42c7-93e1-29f046fb9a5e" },
                    { 1, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 3, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 10, "25baf4b9-4fea-423c-a2cb-d80b62d11466" },
                    { 2, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 9, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 11, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 13, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 14, "2bfc7fc9-7579-4cc3-be76-87eb4dfd307f" },
                    { 1, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 4, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 8, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 16, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 17, "542f0577-edba-4664-b5c5-c0b917d8c81a" },
                    { 4, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 7, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 11, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 12, "83936903-1ad5-4024-b057-07b6616ea5e7" },
                    { 5, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 13, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 14, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 17, "a418f1c2-fe7d-49a4-8619-2849305b5812" },
                    { 2, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 9, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 12, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 14, "a6480d64-0466-461d-b179-be55c4c0c4a3" },
                    { 4, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 6, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 8, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 9, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 10, "c9728f52-9dfc-400e-8368-e3ca3ad159ef" },
                    { 6, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 7, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 11, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 15, "ca22ee7c-93cf-46b0-ad18-fb5ac28ebb59" },
                    { 4, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 5, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 8, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 9, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 14, "cb464ae2-b328-42dc-8fa3-b948cfefd90e" },
                    { 4, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 11, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 15, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 16, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 17, "e568d8ba-a4b2-4650-b98d-9ddf12ef07b4" },
                    { 2, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 11, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 14, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 16, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 17, "eb1bdee3-886a-4fb9-b2ff-8a89b08e5c9a" },
                    { 2, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 7, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 11, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 14, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 17, "ebea6cc4-0fb8-41b7-910d-b06fd9221180" },
                    { 1, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 4, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 9, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 10, "f03d0f94-585e-4b41-a125-88d122a67a58" },
                    { 2, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 4, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 5, "fbe71162-0523-49cd-b2a7-562621ba4c8c" },
                    { 8, "fbe71162-0523-49cd-b2a7-562621ba4c8c" }
                });
        }
    }
}
