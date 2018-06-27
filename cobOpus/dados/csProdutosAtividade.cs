using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csProdutosAtividade : csDadosBase
    {
        public override void Inicializar()
        {
            sCampoCodigo = "";
            base.Inicializar();

            dtDados.TableName = "dtProdutosAtividade";
            dtDados.Columns.Add("cdComodo", typeof(int));
            dtDados.Columns.Add("cdAtividade", typeof(int));
            dtDados.Columns.Add("cdProduto", typeof(int));
            dtDados.Columns.Add("vlProduto", typeof(float));
            dtDados.Columns.Add("deUnidadeMedida", typeof(string));
            dtDados.Columns.Add("nuQtdProduto", typeof(float));
            dtDados.Columns.Add("vlTotal", typeof(float));
        }
    }
}
