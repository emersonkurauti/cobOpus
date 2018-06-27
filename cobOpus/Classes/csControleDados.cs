using cobOpus.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Classes
{
    class csControleDados
    {
        public csComodos oComodos { get; set; }
        public csProdutos oProdutos { get; set; }
        public csAtividades oAtividades { get; set; }
        public csProdutosSugeridos oProdutosSugeridos { get; set; }
        public csAtividadesComodos oAtividadesComodos { get; set; }
        public csProdutosAtividade oProdutosAtividade { get; set; }

        public csControleDados()
        {
            InicializarDataTables();
        }

        public void InicializarDataTables()
        {
            oComodos = new csComodos();
            oProdutos = new csProdutos();
            oAtividades = new csAtividades();
            oProdutosSugeridos = new csProdutosSugeridos();
            oAtividadesComodos = new csAtividadesComodos();
            oProdutosAtividade = new csProdutosAtividade();
        }

        public void SalvarDataTables()
        {
            oComodos.Salvar();
            oProdutos.Salvar();
            oAtividades.Salvar();
            oProdutosSugeridos.Salvar();
            oAtividadesComodos.Salvar();
            oProdutosAtividade.Salvar();
        }
    }
}