using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csProdutosSugeridos : csDadosBase
    {
        public override void Inicializar()
        {
            sCampoCodigo = "";
            base.Inicializar();

            dtDados.TableName = "dtProdutosSugeridos";
            dtDados.Columns.Add("cdAtividade", typeof(int));
            dtDados.Columns.Add("cdProduto", typeof(int));
        }
    }
}
