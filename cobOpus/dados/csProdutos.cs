using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csProdutos : csDadosBase
    {
        public csProdutos() : base()
        { }

        public csProdutos(string psNomeArquivo) : base(psNomeArquivo)
        { }

        public override void Inicializar()
        {
            sCampoCodigo = "cdProduto";
            base.Inicializar();

            dtDados.TableName = "dtProdutos";
            dtDados.Columns.Add(sCampoCodigo, typeof(int));
            dtDados.Columns.Add("nmProduto", typeof(string));
            dtDados.Columns.Add("vlProduto", typeof(float));
            dtDados.Columns.Add("deUnidadeMedida", typeof(string));
        }
    }
}
