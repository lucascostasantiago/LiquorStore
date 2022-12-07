using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LiquorStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CNPJ",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJ = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Representante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CNPJ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPF",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoProduto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CNPJId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CPFId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Contato = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_CNPJ_CNPJId",
                        column: x => x.CNPJId,
                        principalTable: "CNPJ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_CPF_CPFId",
                        column: x => x.CPFId,
                        principalTable: "CPF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoDeVendas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoProduto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<long>(type: "bigint", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoDeVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoDeVendas_Produtos_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoDeCompras",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cliente = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoProduto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantia = table.Column<double>(type: "float", nullable: false),
                    DataDeCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoDeCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoDeCompras_Produtos_CodigoProduto",
                        column: x => x.CodigoProduto,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoDeCompras_User_Cliente",
                        column: x => x.Cliente,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CNPJ",
                columns: new[] { "Id", "CNPJ", "Empresa", "DataDeCriacao", "Representante", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("db39ac3e-21d3-4520-b35f-976d4b247905"), "36.175.312/0001-83", "Bebidas Esfera", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5823), "Carlos", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73a08f06-7a0b-4378-a483-04125276ff23"), "30.474.886/0001-76", "Atacadão das Bebidas", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5791), "Pedro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9766368e-6cff-4eca-aaaf-ad51d47dfcae"), "08.391.986/0001-80", "Barato 24H", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5775), "Lucas", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"), "41.891.718/0001-00", "BR Bebidas", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5759), "Mateus", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75e92fbd-f222-4efd-8f61-85686ee4fa6c"), "43.755.744/0001-29", "SS Distribuidora", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5698), "Iago", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28804bcf-c9cb-4b66-b21e-3a099b2cd205"), "53.388.896/0001-94", "Cervejeiro Industria de Bebidas", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5682), "Ana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d713bc5-1157-4962-9ca9-77e8e1b6616e"), "43.699.193/0001-23", "Cerveja e Amigos", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5667), "Maria", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96e2aee6-b957-480d-8db4-dc91f6126385"), "99.433.240/0001-47", "Gela Guela", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5643), "Leandro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d062100-3fc1-434d-9c3a-8be050138231"), "42.826.952/0001-09", "BlackRock Bebidas", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5058), "João", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f821a712-a18f-4fc3-a877-7ccac48823c2"), "82.531.763/0001-23", "Adega 2000", new DateTime(2022, 12, 7, 15, 52, 38, 56, DateTimeKind.Local).AddTicks(5806), "Carla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "CPF",
                columns: new[] { "Id", "DataDeNascimento", "CPF", "DataDeCriacao", "Name", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"), new DateTime(1998, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "718.274.630-15", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7319), "Maria Clara", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d633a3ec-c604-494c-b52f-40346dcc3891"), new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "635.309.750-60", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7365), "Arthur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("02660a38-5395-45a0-91df-d31cd2399644"), new DateTime(2001, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "503.443.210-29", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7382), "Arthur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e50ad915-b45c-4e04-87de-9f4818e91e80"), new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "416.121.070-10", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7402), "Theo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae75e1d9-6479-40c2-8c02-20790b5792c0"), new DateTime(1998, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "142.305.050-94", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7419), "Laura", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"), new DateTime(1998, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "102.663.320-64", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7435), "Maria Julia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8dbd92f9-160f-4566-8761-ed0091242c89"), new DateTime(1999, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "037.680.480-71", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7452), "Bernardo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"), new DateTime(2002, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "010.898.400-12", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7469), "Davi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"), new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "695.478.320-00", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(7348), "Samuel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c482574b-313b-44ec-ac9b-5e0049a81455"), new DateTime(1990, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "008.143.880-00", new DateTime(2022, 12, 7, 15, 52, 38, 52, DateTimeKind.Local).AddTicks(6349), "João Miguel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "Cidade", "DataDeCriacao", "Bairro", "Estado", "Rua", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("9d27afe4-cedd-440c-bee9-612633e6a2e3"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 49, DateTimeKind.Local).AddTicks(185), "Aerolândia", "CE", "Raul Barbosa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8caa459-b828-47c0-8eb3-b2186b509807"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9550), "Bom Fim", "CE", "Bom Fim", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c06c239-c51b-4a89-b70f-902c2289ce9d"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9532), "Jóquei Clube", "CE", "Mãe Lisboa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcd2bdb5-93ce-4810-ac85-5faff4996546"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9516), "Sapiranga", "CE", "Cantelo Branco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06fb4a76-3aa1-40c7-9f43-183090793809"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9496), "Pirambu", "CE", "Desembargador Lauro Nogueira", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73f09bb3-56d9-491f-b100-31786f6a4d79"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9375), "Papicu", "CE", "Manoel Sátiro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9351), "Mondubim", "CE", "João Gentil", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17005f01-a5e2-484f-8231-54b7d7d44149"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9335), "Bairro Ellery", "CE", "Tenente Lisboa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9b1e80d-850e-4221-9cf0-7f72324865a6"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9316), "Alvaro Weyne", "CE", "Francisco SA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fda23b7b-f8c5-4753-85b7-3dafb334967f"), "Fortaleza", new DateTime(2022, 12, 7, 15, 52, 38, 51, DateTimeKind.Local).AddTicks(9151), "Jacarecanga", "CE", "José Jatahy", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Quantidade", "DataDeCriacao", "Preco", "CodigoProduto", "NomeProduto", "Tipo", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("53cee177-5425-4f77-84dc-9afd35e6b9c0"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3328), 7.0, "9090/2022", "Guaraná 2L", "Refrigerante", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47538b32-2f9b-4a25-b97c-b15da6332da1"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3312), 9.0, "8080/2022", "Coca-Cola 2L", "Refrigerante", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3296), 3.5, "7070/2022", "Cerveja Brahma Duplo Malte Puro Malte Lata 350ml", "Cerveja", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("906aa293-31bf-4427-a3ec-64120df57b0c"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3279), 7.0, "6060/2022", "Cerveja Spaten Puro Malte, Long Neck com 355ml Spaten 355", "Cerveja", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(2293), 140.0, "1010/2022", "Whisky Jack Daniels 1000 Ml", "Whisky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3239), 7.5, "4040/2022", "Budweiser 330ml", "Cerveja", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c7fc09c-ef38-4bb2-af69-beda911ad77b"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3181), 80.0, "3030/2022", "Whisky Black & White 1L", "Whisky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3156), 100.0, "2020/2022", "WHISKY JOHNNIE WALKER RED LABEL 1L", "Whisky", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86337ec5-cb59-493f-8e0f-2501c2125e51"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3345), 7.0, "9890/2022", "Fanta Laranja 2L", "Refrigerante", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37b1ae77-8591-4b78-96a6-9b59165acfc8"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3260), 8.0, "5050/2022", "Cerveja Heineken Premium Puro Malte Lager", "Cerveja", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), 100L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(3361), 2.5, "5590/2022", "Água mineral", "Água", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "HistoricoDeVendas",
                columns: new[] { "Id", "Quantidade", "DataDeCriacao", "Preco", "CodigoProduto", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("9e77f700-9538-423b-86ca-576cb7da1f17"), 7L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9836), 17.5, new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebed77af-213b-498b-95f0-b5ddf1acf184"), 2L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9701), 14.0, new Guid("86337ec5-cb59-493f-8e0f-2501c2125e51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7877672-a069-49d8-aef4-3892ef4dfdf8"), 10L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9802), 90.0, new Guid("47538b32-2f9b-4a25-b97c-b15da6332da1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd060ef5-10d7-4ac1-a799-5f2a81d883ab"), 2L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9727), 18.0, new Guid("47538b32-2f9b-4a25-b97c-b15da6332da1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ca5419d-a561-4f61-a3ba-ee4a4dbb1cf4"), 9L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9896), 63.0, new Guid("906aa293-31bf-4427-a3ec-64120df57b0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d700b6f-c1f4-49ce-99c0-c2eabd26e05e"), 20L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9819), 150.0, new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d634a500-f1af-4629-991a-684e2c72c944"), 4L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9784), 28.0, new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0cde259-a819-4bed-8c06-6875594d5df0"), 3L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9763), 100.0, new Guid("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b95bc36-dc41-488e-9741-cafeaaa5a495"), 1L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9745), 140.0, new Guid("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95742b06-0dd0-45fa-81dc-706f79f9552e"), 3L, new DateTime(2022, 12, 7, 15, 52, 38, 55, DateTimeKind.Local).AddTicks(9029), 7.5, new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "EnderecoId", "CNPJId", "CPFId", "Contato", "DataDeCriacao", "Email", "DataDeAtualizacao", "Tipo" },
                values: new object[,]
                {
                    { new Guid("564f335f-35bd-430b-a330-541403ade35f"), new Guid("b8caa459-b828-47c0-8eb3-b2186b509807"), null, new Guid("9fbc4348-7fb5-48a6-bf77-495ab7ced1ef"), "(88) 45919-0908", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5465), "davi@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"), new Guid("9c06c239-c51b-4a89-b70f-902c2289ce9d"), null, new Guid("8dbd92f9-160f-4566-8761-ed0091242c89"), "(88) 24331-4040", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5445), "bernardo@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("776d4164-eaec-4cee-afef-3a128e33399a"), new Guid("dcd2bdb5-93ce-4810-ac85-5faff4996546"), null, new Guid("ecae8096-3c7a-4ca3-9ed8-80b918ef673c"), "(88) 76190-0685", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5425), "mariajulia@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("a6158c79-8802-485d-8e0c-12b02574c81b"), new Guid("06fb4a76-3aa1-40c7-9f43-183090793809"), null, new Guid("ae75e1d9-6479-40c2-8c02-20790b5792c0"), "(88) 31374-1367", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5402), "laura@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"), new Guid("73f09bb3-56d9-491f-b100-31786f6a4d79"), null, new Guid("e50ad915-b45c-4e04-87de-9f4818e91e80"), "(88) 36709-6920", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5382), "theo@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("064d3464-78f3-42c2-a7bb-1dc36e4c7374"), new Guid("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), null, new Guid("02660a38-5395-45a0-91df-d31cd2399644"), "(88) 18411-9343", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5360), "arthur@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("59d200e2-5f8a-48a9-9cda-d012b9271ab3"), new Guid("f9b1e80d-850e-4221-9cf0-7f72324865a6"), null, new Guid("e3ff5ee7-96f5-4202-b962-76263d5d8c4f"), "(88) 34644-3298", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5308), "samuel@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("59315f8a-ccd3-4a63-a202-93e41629ca8c"), new Guid("fda23b7b-f8c5-4753-85b7-3dafb334967f"), null, new Guid("bda2d2f8-2fa2-445d-9373-91aa6650b7d5"), "(88) 88991-2994", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5259), "mariaclara@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"), new Guid("9d27afe4-cedd-440c-bee9-612633e6a2e3"), null, new Guid("c482574b-313b-44ec-ac9b-5e0049a81455"), "(88) 84971-5917", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4973), "joaomiguel@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("e2b0ad12-2aba-4635-b647-3c6861809064"), new Guid("b8caa459-b828-47c0-8eb3-b2186b509807"), new Guid("db39ac3e-21d3-4520-b35f-976d4b247905"), null, "(88) 32751-5601", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4952), "carlos@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("4d77813e-46d9-436b-a14c-6ff82912ae63"), new Guid("9c06c239-c51b-4a89-b70f-902c2289ce9d"), new Guid("f821a712-a18f-4fc3-a877-7ccac48823c2"), null, "(88) 86602-5652", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4929), "carla@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("8dc7eac1-aa1b-4cc2-8d12-1e6e772b9352"), new Guid("dcd2bdb5-93ce-4810-ac85-5faff4996546"), new Guid("73a08f06-7a0b-4378-a483-04125276ff23"), null, "(88) 13470-1323", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4909), "pedro@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("b132a393-5404-4d47-b540-5d21a18449d5"), new Guid("06fb4a76-3aa1-40c7-9f43-183090793809"), new Guid("9766368e-6cff-4eca-aaaf-ad51d47dfcae"), null, "(88) 79824-2804", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4887), "lucas@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("18776840-d661-4bd4-88fd-21d3389ba3e8"), new Guid("73f09bb3-56d9-491f-b100-31786f6a4d79"), new Guid("a5a7b0c4-5b44-47d7-a82b-5c081eb04c6a"), null, "(88) 58046-6592", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4780), "mateus@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("1cde39df-b5c7-4f4a-9f1a-987e148c3075"), new Guid("5330bb18-fd6a-4dea-9b91-3baa22c17d2b"), new Guid("75e92fbd-f222-4efd-8f61-85686ee4fa6c"), null, "(88) 60675-1641", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4755), "iago@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("0bd4d5b7-04a4-492f-85db-f4f390859248"), new Guid("17005f01-a5e2-484f-8231-54b7d7d44149"), new Guid("28804bcf-c9cb-4b66-b21e-3a099b2cd205"), null, "(88) 89470-2432", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4733), "ana@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("6ad5ddc8-4530-479b-8a0e-a24f3405601f"), new Guid("f9b1e80d-850e-4221-9cf0-7f72324865a6"), new Guid("1d713bc5-1157-4962-9ca9-77e8e1b6616e"), null, "(88) 15138-5437", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4709), "maria@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("222c978d-3f84-4700-83b5-f930eeabdd0e"), new Guid("fda23b7b-f8c5-4753-85b7-3dafb334967f"), new Guid("96e2aee6-b957-480d-8db4-dc91f6126385"), null, "(88) 52351-7612", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(4678), "leandro@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { new Guid("6b412a8a-c604-405b-93b3-a5608f38cd15"), new Guid("17005f01-a5e2-484f-8231-54b7d7d44149"), null, new Guid("d633a3ec-c604-494c-b52f-40346dcc3891"), "(88) 66719-4833", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(5336), "arthur2022@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { new Guid("1526ebb7-0765-48c6-8e4c-7126c7e8f882"), new Guid("9d27afe4-cedd-440c-bee9-612633e6a2e3"), new Guid("1d062100-3fc1-434d-9c3a-8be050138231"), null, "(88) 37762-4466", new DateTime(2022, 12, 7, 15, 52, 38, 54, DateTimeKind.Local).AddTicks(3169), "joao@gmail.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "CarrinhoDeCompras",
                columns: new[] { "Id", "Quantia", "Cliente", "DataDeCriacao", "CodigoProduto", "DataDeAtualizacao" },
                values: new object[,]
                {
                    { new Guid("3b5336d8-472f-48af-87ee-309104ce2445"), 1.0, new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(2833), new Guid("ca488ecc-0c36-45b0-a025-6f2fbfe0aff4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("103f2129-c7be-433b-8a62-34a5167823b9"), 1.0, new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3501), new Guid("a02baed8-52e8-469e-9ad3-cf256e29a9f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c80653a-c85d-4602-8807-71297ae74f6f"), 1.0, new Guid("1949929f-ac10-4bef-a83a-f617b3f42018"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3528), new Guid("7c7fc09c-ef38-4bb2-af69-beda911ad77b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0157258b-dfa9-4445-a5d4-31ffeb176fb3"), 1.0, new Guid("59d200e2-5f8a-48a9-9cda-d012b9271ab3"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3700), new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24a7ab91-bfc5-4846-b268-ac715823b28a"), 1.0, new Guid("e3f68fb2-2004-4c8d-900d-f9ec9bd7c756"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3640), new Guid("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42bd6db1-855c-494f-bcea-2841774f49c8"), 1.0, new Guid("a6158c79-8802-485d-8e0c-12b02574c81b"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3609), new Guid("86337ec5-cb59-493f-8e0f-2501c2125e51"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ec52c74-c51a-4f2c-8820-8db727e10ed6"), 1.0, new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3549), new Guid("def251a1-69e5-4d8d-a6a6-3710154eb6b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d43cb3ef-9004-4db1-a546-0c9d65a97bf5"), 1.0, new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3660), new Guid("37b1ae77-8591-4b78-96a6-9b59165acfc8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("243d15cd-226e-43dd-a2fb-8022cadb3053"), 1.0, new Guid("6617afd4-60e4-415c-908d-4bd0ac005f14"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3681), new Guid("e933657b-2c20-41e2-9f66-9e6836ee8ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6965cec1-65e3-4ee5-abf2-f299f9f8981a"), 1.0, new Guid("564f335f-35bd-430b-a330-541403ade35f"), new DateTime(2022, 12, 7, 15, 52, 38, 57, DateTimeKind.Local).AddTicks(3721), new Guid("2d4b6438-d86c-46d4-b896-64cfa3869a4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoDeCompras_Cliente",
                table: "CarrinhoDeCompras",
                column: "Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoDeCompras_CodigoProduto",
                table: "CarrinhoDeCompras",
                column: "CodigoProduto");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoDeCompras_Id",
                table: "CarrinhoDeCompras",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CNPJ_CNPJ",
                table: "CNPJ",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CNPJ_Id",
                table: "CNPJ",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CPF_CPF",
                table: "CPF",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CPF_Id",
                table: "CPF",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoDeVendas_CodigoProduto",
                table: "HistoricoDeVendas",
                column: "CodigoProduto");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoDeVendas_Id",
                table: "HistoricoDeVendas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CodigoProduto",
                table: "Produtos",
                column: "CodigoProduto",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_Id",
                table: "Produtos",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CNPJId",
                table: "User",
                column: "CNPJId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Contato",
                table: "User",
                column: "Contato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_CPFId",
                table: "User",
                column: "CPFId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_EnderecoId",
                table: "User",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Id",
                table: "User",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoDeCompras");

            migrationBuilder.DropTable(
                name: "HistoricoDeVendas");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "CNPJ");

            migrationBuilder.DropTable(
                name: "CPF");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
