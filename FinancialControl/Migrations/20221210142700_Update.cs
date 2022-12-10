using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiquorStore.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoDeVendas_Produtos_CodigoProduto",
                table: "HistoricoDeVendas");

            migrationBuilder.RenameColumn(
                name: "CodigoProduto",
                table: "HistoricoDeVendas",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoDeVendas_CodigoProduto",
                table: "HistoricoDeVendas",
                newName: "IX_HistoricoDeVendas_ProdutoId");

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("1d062100-3fc1-434d-9c3a-8be050138231"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("1d713bc5-1157-4962-9ca9-77e8e1b6616e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("28804bcf-c9cb-4b66-b21e-3a099b2cd205"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("73a08f06-7a0b-4378-a483-04125276ff23"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("75e92fbd-f222-4efd-8f61-85686ee4fa6c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("96e2aee6-b957-480d-8db4-dc91f6126385"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("9766368e-6cff-4eca-aaaf-ad51d47dfcae"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("db39ac3e-21d3-4520-b35f-976d4b247905"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("f821a712-a18f-4fc3-a877-7ccac48823c2"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("02660a38-5395-45a0-91df-d31cd2399644"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("8dbd92f9-160f-4566-8761-ed0091242c89"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("ae75e1d9-6479-40c2-8c02-20790b5792c0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("c482574b-313b-44ec-ac9b-5e0049a81455"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("d633a3ec-c604-494c-b52f-40346dcc3891"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("e50ad915-b45c-4e04-87de-9f4818e91e80"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 769, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("0157258b-dfa9-4445-a5d4-31ffeb176fb3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("103f2129-c7be-433b-8a62-34a5167823b9"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("1ec52c74-c51a-4f2c-8820-8db727e10ed6"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("243d15cd-226e-43dd-a2fb-8022cadb3053"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("24a7ab91-bfc5-4846-b268-ac715823b28a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("3b5336d8-472f-48af-87ee-309104ce2445"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("3c80653a-c85d-4602-8807-71297ae74f6f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("42bd6db1-855c-494f-bcea-2841774f49c8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("6965cec1-65e3-4ee5-abf2-f299f9f8981a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("d43cb3ef-9004-4db1-a546-0c9d65a97bf5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 773, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("06fb4a76-3aa1-40c7-9f43-183090793809"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("17005f01-a5e2-484f-8231-54b7d7d44149"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("73f09bb3-56d9-491f-b100-31786f6a4d79"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("9c06c239-c51b-4a89-b70f-902c2289ce9d"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("9d27afe4-cedd-440c-bee9-612633e6a2e3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 765, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("b8caa459-b828-47c0-8eb3-b2186b509807"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("dcd2bdb5-93ce-4810-ac85-5faff4996546"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("f9b1e80d-850e-4221-9cf0-7f72324865a6"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 768, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("fda23b7b-f8c5-4753-85b7-3dafb334967f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 767, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("6d700b6f-c1f4-49ce-99c0-c2eabd26e05e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("7b95bc36-dc41-488e-9741-cafeaaa5a495"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("8ca5419d-a561-4f61-a3ba-ee4a4dbb1cf4"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("95742b06-0dd0-45fa-81dc-706f79f9552e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("9e77f700-9538-423b-86ca-576cb7da1f17"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("c7877672-a069-49d8-aef4-3892ef4dfdf8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("d634a500-f1af-4629-991a-684e2c72c944"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("e0cde259-a819-4bed-8c06-6875594d5df0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("ebed77af-213b-498b-95f0-b5ddf1acf184"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("fd060ef5-10d7-4ac1-a799-5f2a81d883ab"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 772, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("37b1ae77-8591-4b78-96a6-9b59165acfc8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("47538b32-2f9b-4a25-b97c-b15da6332da1"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("53cee177-5425-4f77-84dc-9afd35e6b9c0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("7c7fc09c-ef38-4bb2-af69-beda911ad77b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("86337ec5-cb59-493f-8e0f-2501c2125e51"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("906aa293-31bf-4427-a3ec-64120df57b0c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a02baed8-52e8-469e-9ad3-cf256e29a9f0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e933657b-2c20-41e2-9f66-9e6836ee8ee0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 771, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("064d3464-78f3-42c2-a7bb-1dc36e4c7374"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0bd4d5b7-04a4-492f-85db-f4f390859248"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1526ebb7-0765-48c6-8e4c-7126c7e8f882"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("18776840-d661-4bd4-88fd-21d3389ba3e8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1cde39df-b5c7-4f4a-9f1a-987e148c3075"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("222c978d-3f84-4700-83b5-f930eeabdd0e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4d77813e-46d9-436b-a14c-6ff82912ae63"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("564f335f-35bd-430b-a330-541403ade35f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59315f8a-ccd3-4a63-a202-93e41629ca8c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59d200e2-5f8a-48a9-9cda-d012b9271ab3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ad5ddc8-4530-479b-8a0e-a24f3405601f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b412a8a-c604-405b-93b3-a5608f38cd15"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("776d4164-eaec-4cee-afef-3a128e33399a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dc7eac1-aa1b-4cc2-8d12-1e6e772b9352"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a6158c79-8802-485d-8e0c-12b02574c81b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b132a393-5404-4d47-b540-5d21a18449d5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2b0ad12-2aba-4635-b647-3c6861809064"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 10, 11, 26, 59, 770, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoDeVendas_Produtos_ProdutoId",
                table: "HistoricoDeVendas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoDeVendas_Produtos_ProdutoId",
                table: "HistoricoDeVendas");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "HistoricoDeVendas",
                newName: "CodigoProduto");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoDeVendas_ProdutoId",
                table: "HistoricoDeVendas",
                newName: "IX_HistoricoDeVendas_CodigoProduto");

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("1d062100-3fc1-434d-9c3a-8be050138231"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("1d713bc5-1157-4962-9ca9-77e8e1b6616e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("28804bcf-c9cb-4b66-b21e-3a099b2cd205"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("73a08f06-7a0b-4378-a483-04125276ff23"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("75e92fbd-f222-4efd-8f61-85686ee4fa6c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("96e2aee6-b957-480d-8db4-dc91f6126385"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("9766368e-6cff-4eca-aaaf-ad51d47dfcae"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("db39ac3e-21d3-4520-b35f-976d4b247905"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "CNPJ",
                keyColumn: "Id",
                keyValue: new Guid("f821a712-a18f-4fc3-a877-7ccac48823c2"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("02660a38-5395-45a0-91df-d31cd2399644"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("8dbd92f9-160f-4566-8761-ed0091242c89"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("ae75e1d9-6479-40c2-8c02-20790b5792c0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("c482574b-313b-44ec-ac9b-5e0049a81455"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("d633a3ec-c604-494c-b52f-40346dcc3891"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("e50ad915-b45c-4e04-87de-9f4818e91e80"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "CPF",
                keyColumn: "Id",
                keyValue: new Guid("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 862, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("0157258b-dfa9-4445-a5d4-31ffeb176fb3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("103f2129-c7be-433b-8a62-34a5167823b9"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("1ec52c74-c51a-4f2c-8820-8db727e10ed6"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("243d15cd-226e-43dd-a2fb-8022cadb3053"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("24a7ab91-bfc5-4846-b268-ac715823b28a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("3b5336d8-472f-48af-87ee-309104ce2445"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("3c80653a-c85d-4602-8807-71297ae74f6f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("42bd6db1-855c-494f-bcea-2841774f49c8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("6965cec1-65e3-4ee5-abf2-f299f9f8981a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3211));

            migrationBuilder.UpdateData(
                table: "CarrinhoDeCompras",
                keyColumn: "Id",
                keyValue: new Guid("d43cb3ef-9004-4db1-a546-0c9d65a97bf5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 867, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("06fb4a76-3aa1-40c7-9f43-183090793809"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("17005f01-a5e2-484f-8231-54b7d7d44149"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("73f09bb3-56d9-491f-b100-31786f6a4d79"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("9c06c239-c51b-4a89-b70f-902c2289ce9d"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("9d27afe4-cedd-440c-bee9-612633e6a2e3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 860, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("b8caa459-b828-47c0-8eb3-b2186b509807"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("dcd2bdb5-93ce-4810-ac85-5faff4996546"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("f9b1e80d-850e-4221-9cf0-7f72324865a6"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Endereco",
                keyColumn: "Id",
                keyValue: new Guid("fda23b7b-f8c5-4753-85b7-3dafb334967f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 861, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("6d700b6f-c1f4-49ce-99c0-c2eabd26e05e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("7b95bc36-dc41-488e-9741-cafeaaa5a495"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("8ca5419d-a561-4f61-a3ba-ee4a4dbb1cf4"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1698));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("95742b06-0dd0-45fa-81dc-706f79f9552e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("9e77f700-9538-423b-86ca-576cb7da1f17"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("c7877672-a069-49d8-aef4-3892ef4dfdf8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("d634a500-f1af-4629-991a-684e2c72c944"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("e0cde259-a819-4bed-8c06-6875594d5df0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("ebed77af-213b-498b-95f0-b5ddf1acf184"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "HistoricoDeVendas",
                keyColumn: "Id",
                keyValue: new Guid("fd060ef5-10d7-4ac1-a799-5f2a81d883ab"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 866, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("37b1ae77-8591-4b78-96a6-9b59165acfc8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("47538b32-2f9b-4a25-b97c-b15da6332da1"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("53cee177-5425-4f77-84dc-9afd35e6b9c0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("7c7fc09c-ef38-4bb2-af69-beda911ad77b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("86337ec5-cb59-493f-8e0f-2501c2125e51"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("906aa293-31bf-4427-a3ec-64120df57b0c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a02baed8-52e8-469e-9ad3-cf256e29a9f0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e933657b-2c20-41e2-9f66-9e6836ee8ee0"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 865, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("064d3464-78f3-42c2-a7bb-1dc36e4c7374"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0bd4d5b7-04a4-492f-85db-f4f390859248"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1526ebb7-0765-48c6-8e4c-7126c7e8f882"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("18776840-d661-4bd4-88fd-21d3389ba3e8"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1cde39df-b5c7-4f4a-9f1a-987e148c3075"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("222c978d-3f84-4700-83b5-f930eeabdd0e"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4d77813e-46d9-436b-a14c-6ff82912ae63"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("564f335f-35bd-430b-a330-541403ade35f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59315f8a-ccd3-4a63-a202-93e41629ca8c"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("59d200e2-5f8a-48a9-9cda-d012b9271ab3"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6ad5ddc8-4530-479b-8a0e-a24f3405601f"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b412a8a-c604-405b-93b3-a5608f38cd15"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("776d4164-eaec-4cee-afef-3a128e33399a"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8dc7eac1-aa1b-4cc2-8d12-1e6e772b9352"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a6158c79-8802-485d-8e0c-12b02574c81b"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b132a393-5404-4d47-b540-5d21a18449d5"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e2b0ad12-2aba-4635-b647-3c6861809064"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"),
                column: "DataDeCriacao",
                value: new DateTime(2022, 12, 7, 16, 55, 22, 864, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoDeVendas_Produtos_CodigoProduto",
                table: "HistoricoDeVendas",
                column: "CodigoProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
