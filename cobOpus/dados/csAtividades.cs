using cobOpus.Classes;
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

        public void RetornarRelatorioTotalAtividades(ref DataTable pdtDadosRel, csControleDados poControleDados)
        {
            object oSumProdutos;
            DataRow drReg;
            string sFiltro = string.Empty;

            DataRow[] drAtividades = poControleDados.oAtividadesComodos.dtDados.Select("flAtivo = 'S'");

            for (int nIndex = 0; nIndex < drAtividades.Length; nIndex++)
            {
                drReg = pdtDadosRel.NewRow();
                drReg["cdAtividade"] = drAtividades[nIndex]["cdAtividade"];
                sFiltro = "cdAtividade = " + drReg["cdAtividade"].ToString();

                DataRow[] drDdadosAtividade = poControleDados.oAtividades.dtDados.Select(sFiltro);
                drReg["deAtividade"] = drDdadosAtividade[0]["deAtividade"].ToString();

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
