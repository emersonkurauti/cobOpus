using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cobOpus.Classes;
using cobOpus.Dados;

namespace cobOpus.Classes
{
    class csGerenciadorRelatorios
    {
        public csControleDados oControleDados;
        public int nTipoRelatorio;
        public DataTable dtDados;
        public string sXValueMember;
        public string sYValueMembers;

        public csGerenciadorRelatorios()
        {
            dtDados = new DataTable();
        }

        public void GerarDados()
        {
            if (nTipoRelatorio == csConstantes.nAtividades)
            {
                dtDados.Columns.Add("cdAtividade", typeof(int));
                dtDados.Columns.Add("deAtividade", typeof(string));
                dtDados.Columns.Add("vlTotal", typeof(double));

                oControleDados.oAtividades.RetornarRelatorioTotalAtividades(ref dtDados, oControleDados); 

                if (dtDados.Rows.Count == 0)
                    dtDados = null;

                sXValueMember = "deAtividade";
                sYValueMembers = "vlTotal";
                return; 
            }

            if (nTipoRelatorio == csConstantes.nComodos)
            {
                dtDados.Columns.Add("cdComodo", typeof(int));
                dtDados.Columns.Add("nmComodo", typeof(string));
                dtDados.Columns.Add("vlTotal", typeof(double));

                oControleDados.oComodos.RetornarRelatorioTotalComodo(ref dtDados, oControleDados);

                if (dtDados.Rows.Count == 0)
                    dtDados = null;

                sXValueMember = "nmComodo";
                sYValueMembers = "vlTotal";
                return;
            }

            if (nTipoRelatorio == csConstantes.nProdutos)
            {
                dtDados.Columns.Add("cdProduto", typeof(int));
                dtDados.Columns.Add("nmProduto", typeof(string));
                dtDados.Columns.Add("vlTotal", typeof(double));

                oControleDados.oProdutos.RetornarRelatorioTotalProdutos(ref dtDados, oControleDados);

                if (dtDados.Rows.Count == 0)
                    dtDados = null;

                sXValueMember = "nmProduto";
                sYValueMembers = "vlTotal";
                return;
            }

            if (nTipoRelatorio == csConstantes.nAtividadesComodos)
            {
                if (dtDados.Rows.Count == 0)
                    dtDados = null;
                return;
            }

            if (nTipoRelatorio == csConstantes.nProdutosAtividades)
            {
                if (dtDados.Rows.Count == 0)
                    dtDados = null;
                return;
            }

            if (nTipoRelatorio == csConstantes.nProdutosComodos)
            {
                if (dtDados.Rows.Count == 0)
                    dtDados = null;
                return;
            }
        }
    }
}
