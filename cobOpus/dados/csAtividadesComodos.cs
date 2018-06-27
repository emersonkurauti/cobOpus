using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csAtividadesComodos : csDadosBase
    {
        public override void Inicializar()
        {
            sCampoCodigo = "";
            base.Inicializar();

            dtDados.TableName = "dtAtividadesComodo";
            dtDados.Columns.Add("cdComodo", typeof(int));
            dtDados.Columns.Add("cdAtividade", typeof(int));
            dtDados.Columns.Add("vlAtividade", typeof(float));
        }
    }
}
