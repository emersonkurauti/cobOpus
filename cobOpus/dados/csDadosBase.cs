using cobOpus.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Dados
{
    class csDadosBase
    {
        private csFuncoes Funcoes;
        public bool pbEstahImportando;
        public string sCampoCodigo;
        public DataTable dtDados { get; set; }

        public csDadosBase()
        {
            Inicializar();
            pbEstahImportando = false;
            Carregar(this.ToString() + ".txt");
        }

        public csDadosBase(string psNomeArquivo)
        {
            Inicializar();
            pbEstahImportando = true;
            Carregar(psNomeArquivo);
        }

        public virtual void Inicializar()
        {
            Funcoes = new csFuncoes();
            dtDados = new DataTable();
        }

        public virtual void Carregar(string psNomeArquivo)
        {
            csFuncoes.DataTableLoadFromFile(dtDados, psNomeArquivo, pbEstahImportando);
        }

        public virtual void Salvar()
        {
            AtualizarCodigos();
            csFuncoes.DataTableSaveToFile(this, dtDados, this.ToString() + ".txt");
        }

        public int RetornarProximoCodigo(int nLinha = -999)
        {
            if (sCampoCodigo == string.Empty)
            {
                return 0;
            }

            int nCodigo = 1;


            DataRow[] oResultado = dtDados.Select(sCampoCodigo + "=max(" + sCampoCodigo + ")");

            if (oResultado.Length > 0)
            {
                nCodigo = Convert.ToInt32(oResultado[0][sCampoCodigo]);
                nCodigo++;
            }

            if (nLinha != -999)
            {
                dtDados.Rows[nLinha][sCampoCodigo] = nCodigo;
            }

            return nCodigo;
        }

        public void AtualizarCodigos()
        {
            if (sCampoCodigo == string.Empty)
            {
                return;
            }

            foreach (DataRow row in dtDados.Rows)
            {   
                if (row[sCampoCodigo].ToString() == string.Empty)
                {
                    RetornarProximoCodigo(dtDados.Rows.IndexOf(row)).ToString();
                }
            }
        }
    }
}
