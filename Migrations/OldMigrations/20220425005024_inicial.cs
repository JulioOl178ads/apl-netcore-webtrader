using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTrader.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    CategoriaNome = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "T_Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Bairro = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    País = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NumeroCasa = table.Column<int>(type: "NUMBER(10)", maxLength: 5, nullable: false),
                    Complemento = table.Column<string>(type: "NVARCHAR2(2)", maxLength: 2, nullable: false),
                    Ativo = table.Column<bool>(type: "NUMBER(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Endereco", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "T_Tipo_Contato",
                columns: table => new
                {
                    IdTipoContato = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tipo_Contato", x => x.IdTipoContato);
                });

            migrationBuilder.CreateTable(
                name: "T_Tipo_Endereco",
                columns: table => new
                {
                    IdTipoEndereco = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tipo_Endereco", x => x.IdTipoEndereco);
                });

            migrationBuilder.CreateTable(
                name: "T_Tipo_Produto",
                columns: table => new
                {
                    IdTipoProduto = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Tipo_Produto", x => x.IdTipoProduto);
                });

            migrationBuilder.CreateTable(
                name: "Lanches",
                columns: table => new
                {
                    LancheId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(80)", maxLength: 80, nullable: false),
                    DescricaoCurta = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    DescricaoDetalhada = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    ImagemThumbnailUrl = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    IsLanchePreferido = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    EmEstoque = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    CategoriaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanches", x => x.LancheId);
                    table.ForeignKey(
                        name: "FK_Lanches_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Contato",
                columns: table => new
                {
                    IdContato = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DescricaoContato = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: false),
                    Ativo = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    TipoContatoIdTipoContato = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    T_Tipo_EnderecoIdTipoEndereco = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Contato", x => x.IdContato);
                    table.ForeignKey(
                        name: "FK_T_Contato_T_Tipo_Contato_TipoContatoIdTipoContato",
                        column: x => x.TipoContatoIdTipoContato,
                        principalTable: "T_Tipo_Contato",
                        principalColumn: "IdTipoContato");
                    table.ForeignKey(
                        name: "FK_T_Contato_T_Tipo_Endereco_T_Tipo_EnderecoIdTipoEndereco",
                        column: x => x.T_Tipo_EnderecoIdTipoEndereco,
                        principalTable: "T_Tipo_Endereco",
                        principalColumn: "IdTipoEndereco");
                });

            migrationBuilder.CreateTable(
                name: "T_Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Idade = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    Sexo = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    CPF = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    RG = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    ContatosIdContato = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EnderecosIdEndereco = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_T_Usuario_T_Contato_ContatosIdContato",
                        column: x => x.ContatosIdContato,
                        principalTable: "T_Contato",
                        principalColumn: "IdContato");
                    table.ForeignKey(
                        name: "FK_T_Usuario_T_Endereco_EnderecosIdEndereco",
                        column: x => x.EnderecosIdEndereco,
                        principalTable: "T_Endereco",
                        principalColumn: "IdEndereco");
                });

            migrationBuilder.CreateTable(
                name: "T_Proposta_Negociacao",
                columns: table => new
                {
                    IdPropostaNegociacao = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Produto = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Marca = table.Column<string>(type: "NVARCHAR2(25)", maxLength: 25, nullable: true),
                    PermiteUsado = table.Column<string>(type: "NVARCHAR2(3)", maxLength: 3, nullable: false),
                    Preco = table.Column<decimal>(type: "DECIMAL(18, 2)", maxLength: 25, nullable: false),
                    Quantidade = table.Column<int>(type: "NUMBER(10)", maxLength: 5, nullable: false),
                    Empresa = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: true),
                    DescricaoCurta = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    ImagemThumbnailUrl = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: true),
                    UsuarioIdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    TipoProdutoIdTipoProduto = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Proposta_Negociacao", x => x.IdPropostaNegociacao);
                    table.ForeignKey(
                        name: "FK_T_Proposta_Negociacao_T_Tipo_Produto_TipoProdutoIdTipoProduto",
                        column: x => x.TipoProdutoIdTipoProduto,
                        principalTable: "T_Tipo_Produto",
                        principalColumn: "IdTipoProduto");
                    table.ForeignKey(
                        name: "FK_T_Proposta_Negociacao_T_Usuario_UsuarioIdUsuario",
                        column: x => x.UsuarioIdUsuario,
                        principalTable: "T_Usuario",
                        principalColumn: "IdUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lanches_CategoriaId",
                table: "Lanches",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Contato_T_Tipo_EnderecoIdTipoEndereco",
                table: "T_Contato",
                column: "T_Tipo_EnderecoIdTipoEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_T_Contato_TipoContatoIdTipoContato",
                table: "T_Contato",
                column: "TipoContatoIdTipoContato");

            migrationBuilder.CreateIndex(
                name: "IX_T_Proposta_Negociacao_TipoProdutoIdTipoProduto",
                table: "T_Proposta_Negociacao",
                column: "TipoProdutoIdTipoProduto");

            migrationBuilder.CreateIndex(
                name: "IX_T_Proposta_Negociacao_UsuarioIdUsuario",
                table: "T_Proposta_Negociacao",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_ContatosIdContato",
                table: "T_Usuario",
                column: "ContatosIdContato");

            migrationBuilder.CreateIndex(
                name: "IX_T_Usuario_EnderecosIdEndereco",
                table: "T_Usuario",
                column: "EnderecosIdEndereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lanches");

            migrationBuilder.DropTable(
                name: "T_Proposta_Negociacao");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "T_Tipo_Produto");

            migrationBuilder.DropTable(
                name: "T_Usuario");

            migrationBuilder.DropTable(
                name: "T_Contato");

            migrationBuilder.DropTable(
                name: "T_Endereco");

            migrationBuilder.DropTable(
                name: "T_Tipo_Contato");

            migrationBuilder.DropTable(
                name: "T_Tipo_Endereco");
        }
    }
}
