using cobOpus.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void RetornarRelatorioTotalProdutos(ref DataTable pdtDadosRel, csControleDados poControleDados)
        {
            object oSumProdutos;
            DataRow drReg;
            string sAtividadesInativas = string.Empty;
            string sFiltro = string.Empty;

            sAtividadesInativas = string.Empty;
            DataRow[] drAtividadesInativas = poControleDados.oAtividadesComodos.dtDados.Select("flAtivo = 'N'");
            for (int nIndex = 0; nIndex < drAtividadesInativas.Length; nIndex++)
            {
                sAtividadesInativas += drAtividadesInativas[nIndex]["cdAtividade"] + ",";
            }

            if (drAtividadesInativas.Length > 0)
                sAtividadesInativas = sAtividadesInativas.Substring(0, sAtividadesInativas.Length - 1);

            foreach (DataRow dr in dtDados.Rows)
            {
                drReg = pdtDadosRel.NewRow();
                drReg["cdProduto"] = dr["cdProduto"];
                drReg["nmProduto"] = dr["nmProduto"];

                sFiltro = "cdProduto = " + drReg["cdProduto"].ToString();

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
