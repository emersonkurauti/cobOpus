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

        public void RetornarRelatorioTotalComodo(ref DataTable pdtDadosRel, csControleDados poControleDados)
        {
            object oSumProdutos;
            DataRow drReg;
            string sAtividadesInativas = string.Empty;
            string sFiltro = string.Empty;

            foreach (DataRow dr in dtDados.Rows)
            {
                sAtividadesInativas = string.Empty;
                DataRow[] drAtividadesInativas = poControleDados.oAtividadesComodos.dtDados.Select("flAtivo = 'N' and cdComodo = " +
                    dr["cdComodo"].ToString());
                for (int nIndex = 0; nIndex < drAtividadesInativas.Length; nIndex++)
                {
                    sAtividadesInativas += drAtividadesInativas[nIndex]["cdAtividade"] + ",";
                }

                if (drAtividadesInativas.Length > 0)
                    sAtividadesInativas = sAtividadesInativas.Substring(0, sAtividadesInativas.Length - 1);

                drReg = pdtDadosRel.NewRow();
                drReg["cdComodo"] = dr["cdComodo"];
                drReg["nmComodo"] = dr["nmComodo"];

                sFiltro = "cdComodo = " + drReg["cdComodo"].ToString();

                if (sAtividadesInativas != string.Empty)
                {
                    sFiltro += " and cdAtividade not in (" + sAtividadesInativas + ")";
                }

                oSumProdutos = poControleDados.oProdutosAtividade.dtDados.Compute("SUM(vlTotal)", sFiltro);

                if (oSumProdutos.GetType() != typeof(System.DBNull) && Convert.ToDouble(oSumProdutos) != 0)
                {
                    drReg["vlTotal"] = Convert.ToDouble(oSumProdutos);
                    pdtDadosRel.Rows.Add(drReg);
                }
            }
        }
    }
}
