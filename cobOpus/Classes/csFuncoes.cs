using cobOpus.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobOpus.Classes
{
    class csFuncoes
    {
        public enum TipoImportacao
        {
            Comodos,
            Produtos,
            Atividades
        };

        public static string sCaminho = AppDomain.CurrentDomain.BaseDirectory.ToString() + "DataBase\\";
        private static string sCaminhoBkp = sCaminho + "BackUp\\";

        public static void DataTableSaveToFile(csDadosBase oDadosBase, DataTable dtDados, string sNomeArquivo)
        {
            int nColuna;
            StreamWriter arquivo = new StreamWriter(sCaminho + "\\" + sNomeArquivo, false);

            foreach (DataRow row in dtDados.Rows)
            {
                object[] array = row.ItemArray;

                for (nColuna = 0; nColuna < array.Length - 1; nColuna++)
                {
                    arquivo.Write(array[nColuna].ToString() + ";");
                }
                arquivo.Write(array[nColuna].ToString());
                arquivo.WriteLine();
            }

            arquivo.Close();
        }

        public static void DataTableLoadFromFile(DataTable dtDados, string sNomeArquivo, bool pbEstahImportando = false)
        {
            string sCaminhoArquivo;
            if (pbEstahImportando)
            {
                sCaminhoArquivo = sNomeArquivo;
            }
            else
            {
                sCaminhoArquivo = sCaminho + sNomeArquivo;

                if (!File.Exists(sCaminhoArquivo))
                {
                    StreamWriter arquivo = new StreamWriter(sCaminhoArquivo, false);
                    arquivo.Close();
                }
            }

            string[] sLinhas = System.IO.File.ReadAllLines(sCaminhoArquivo);

            foreach (string sLinha in sLinhas)
            {
                var vColunas = sLinha.Split(';');

                DataRow drRegistro = dtDados.NewRow();
                for (int nIndex = 0; nIndex < vColunas.Length; nIndex++)
                {
                    drRegistro[nIndex] = vColunas[nIndex];
                }

                dtDados.Rows.Add(drRegistro);
            }
        }

        public static void FazerBackUp()
        {
            sCaminhoBkp = sCaminhoBkp.Replace("Bkp", "Bkp_" +
                DateTime.Now.ToString().Substring(0, 16).Replace("/", "-").Replace(" ", "_").Replace(":", "-"));

            DirectoryInfo diretorio = new DirectoryInfo(sCaminho);
            if (!Directory.Exists(sCaminho))
            {
                Directory.CreateDirectory(sCaminho);
            }

            if (!Directory.Exists(sCaminhoBkp))
            {
                Directory.CreateDirectory(sCaminhoBkp);
            }

            foreach (FileInfo arquivo in diretorio.GetFiles("*.txt"))
            {
                File.Copy(arquivo.FullName, sCaminhoBkp + arquivo.Name, true);
            }
        }

        public static void ImportarDados(TipoImportacao peTpImportacao, string psNomeArquivo, csControleDados poControleDados,
            ProgressBar pbProgresso)
        {
            DataTable dtRegistros = RetornarDataTable(peTpImportacao, psNomeArquivo);

            if (peTpImportacao == TipoImportacao.Comodos)
            {
                ImportarComodos(dtRegistros, poControleDados, pbProgresso);
                return;
            }

            if (peTpImportacao == TipoImportacao.Produtos)
            {
                ImportarProdutos(dtRegistros, poControleDados, pbProgresso);
                return;
            }

            if (peTpImportacao == TipoImportacao.Atividades)
            {
                ImportarAtividades(dtRegistros, poControleDados, pbProgresso);
                return;
            }
        }

        public static void ImportarComodos(DataTable dtRegistros, csControleDados poControleDados, ProgressBar pbProgresso)
        {
            pbProgresso.Maximum = dtRegistros.Rows.Count;
            foreach (DataRow drRegistro in dtRegistros.Rows)
            {
                pbProgresso.Value = dtRegistros.Rows.IndexOf(drRegistro);
                DataRow drComodo = poControleDados.oComodos.dtDados.NewRow();
                drComodo["cdComodo"] = poControleDados.oComodos.RetornarProximoCodigo();
                drComodo["nmComodo"] = drRegistro["nmComodo"];
                poControleDados.oComodos.dtDados.Rows.Add(drComodo);
            }
        }

        public static void ImportarProdutos(DataTable dtRegistros, csControleDados poControleDados, ProgressBar pbProgresso)
        {
            pbProgresso.Maximum = dtRegistros.Rows.Count;
            foreach (DataRow drRegistro in dtRegistros.Rows)
            {
                pbProgresso.Value = dtRegistros.Rows.IndexOf(drRegistro);
                DataRow drProduto = poControleDados.oProdutos.dtDados.NewRow();
                drProduto["cdProduto"] = poControleDados.oProdutos.RetornarProximoCodigo();
                drProduto["nmProduto"] = drRegistro["nmProduto"];
                drProduto["vlProduto"] = drRegistro["vlProduto"];
                drProduto["deUnidadeMedida"] = drRegistro["deUnidadeMedida"];
                poControleDados.oProdutos.dtDados.Rows.Add(drProduto);
            }
        }

        public static void ImportarAtividades(DataTable dtRegistros, csControleDados poControleDados, ProgressBar pbProgresso)
        {
            pbProgresso.Maximum = dtRegistros.Rows.Count;
            foreach (DataRow drRegistro in dtRegistros.Rows)
            {
                pbProgresso.Value = dtRegistros.Rows.IndexOf(drRegistro);
                DataRow drAtividade = poControleDados.oAtividades.dtDados.NewRow();
                drAtividade["cdAtividade"] = poControleDados.oAtividades.RetornarProximoCodigo();
                drAtividade["deAtividade"] = drRegistro["deAtividade"];
                drAtividade["vlAtividade"] = drRegistro["vlAtividade"];
                poControleDados.oAtividades.dtDados.Rows.Add(drAtividade);
            }
        }

        public static DataTable RetornarDataTable(TipoImportacao peTpImportacao, string psNomeArquivo)
        {
            DataTable dtDados = new DataTable();

            if (peTpImportacao == TipoImportacao.Comodos)
            {
                csComodos oComodos = new csComodos(psNomeArquivo);
                dtDados = oComodos.dtDados;
                return dtDados;
            }

            if (peTpImportacao == TipoImportacao.Produtos)
            {
                csProdutos oProdutos = new csProdutos(psNomeArquivo);
                dtDados = oProdutos.dtDados;
                return dtDados;
            }

            if (peTpImportacao == TipoImportacao.Atividades)
            {
                csAtividades oAtividades = new csAtividades(psNomeArquivo);
                dtDados = oAtividades.dtDados;
                return dtDados;
            }

            return dtDados;
        }
    }
}
