using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebTrader.Migrations
{
    public partial class insert_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Tipo_Contato\"(\"Descricao\") VALUES('E-mail');");

            //migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Tipo_Produto\"(\"Descricao\") VALUES('Eletrônico');");
            //
            migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Usuario\"(\"Nome\", \"Idade\", \"Sexo\", \"CPF\", \"RG\", \"ContatosIdContato\", \"EnderecosIdEndereco\") " +
                "VALUES('Nome', '16', 'Masculino', '42321123408', '9203940211', 1, 1)");
            //
            //migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Endereco\"(\"Bairro\", \"Cidade\", \"Estado\", \"País\", \"NumeroCasa\", \"Complemento\", \"Ativo\") " +
            //    "VALUES('Bairro teste', 'Cidade teste', 'Estado teste', 'País teste', 'Numero casa teste', 'Complemento teste', true, 1)");
            //
            //migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Contato\"(\"DescricaoContato\", \"Ativo\", \"Usuario\") " +
            //    "VALUES('Teste', 1, 'Online', 1)");
            //
            //migrationBuilder.Sql("INSERT INTO \"SYSTEM\".\"T_Proposta_Negociacao\"(\"Produto\", \"Marca\", \"PermiteUsado\", \"Preco\", \"Quantidade\", \"Empresa\", \"DescricaoCurta\", \"ImagemThumbnailUrl\", \"Usuario\", \"TipoProduto\") " +
            //    "VALUES('Celular', 'Samsumg', 1, 1000.00, 10, 'Empresa teste', 'DescricaoCurta Teste', 'ImagemThumbnailUrl Teste', 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.Sql("DELETE FROM T_Tipo_Contato");
            //migrationBuilder.Sql("DELETE FROM T_Tipo_Produto");
            migrationBuilder.Sql("DELETE FROM T_Usuario");
            //migrationBuilder.Sql("DELETE FROM T_Endereco");
            //migrationBuilder.Sql("DELETE FROM T_Contato");
            //migrationBuilder.Sql("DELETE FROM T_Proposta_Negociacao");
        }
    }
}
