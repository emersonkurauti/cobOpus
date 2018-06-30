using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csComodos : csDadosBase
    {
        public csComodos() : base()
        { }

        public csComodos(string psNomeArquivo) : base(psNomeArquivo)
        { }

        public override void Inicializar()
        {
            sCampoCodigo = "cdComodo";
            base.Inicializar();

            dtDados.TableName = "dtComodos";
            dtDados.Columns.Add(sCampoCodigo, typeof(int));
            dtDados.Columns.Add("nmComodo", typeof(string));
        }
    }
}
