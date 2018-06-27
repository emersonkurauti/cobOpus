using cobOpus.Dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobOpus.Classes
{
    class csFuncoes
    {
        private static string sCaminho = Properties.Settings.Default.sCaminhoBaseDados;
        private static string sCaminhoBkp = Properties.Settings.Default.sCaminhoBaseDadosBKP;

        public static void DataTableSaveToFile(csDadosBase oDadosBase, DataTable dtDados, string sNomeArquivo)
        {
            int nColuna;
            StreamWriter arquivo = new StreamWriter(sCaminho + "\\"+ sNomeArquivo, false);

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

        public static void DataTableLoadFromFile(DataTable dtDados, string sNomeArquivo)
        {
            string sCaminhoArquivo = sCaminho + sNomeArquivo;

            if (!File.Exists(sCaminhoArquivo))
            {
                StreamWriter arquivo = new StreamWriter(sCaminhoArquivo, false);
                arquivo.Close();
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
            DirectoryInfo diretorio = new DirectoryInfo(sCaminho);
            
            foreach (FileInfo arquivo in diretorio.GetFiles("*.txt"))
            {
                File.Copy(arquivo.FullName, sCaminhoBkp + arquivo.Name, true);
            }
        }
    }
}
