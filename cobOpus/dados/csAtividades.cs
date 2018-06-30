using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csAtividades : csDadosBase
    {
        public csAtividades() : base()
        { }

        public csAtividades(string psNomeArquivo) : base(psNomeArquivo)
        { }

        public override void Inicializar()
        {
            sCampoCodigo = "cdAtividade";
            base.Inicializar();

            dtDados.TableName = "dtAtividades";
            dtDados.Columns.Add(sCampoCodigo, typeof(int));
            dtDados.Columns.Add("deAtividade", typeof(string));
            dtDados.Columns.Add("vlAtividade", typeof(float));
        }
    }
}
