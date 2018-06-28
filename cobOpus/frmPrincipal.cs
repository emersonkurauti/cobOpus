using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cobOpus.Classes;

namespace cobOpus
{
    public partial class frmPrincipal : Form
    {
        csControleDados oControleDados;
        DataRelation drProdutosSugeridos;
        DataRelation drAtividadesComodo;
        DataRelation drProdutosAtividade;

        bool bSelecionandoAtividade;
        bool bSelecionandoProduto;

        public frmPrincipal()
        {
            InitializeComponent();
            oControleDados = new csControleDados();
            VincluarDataTables();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarRelacionamentos();
            tstbBaseDados.Text = csFuncoes.sCaminho;
        }

        private void CarregarRelacionamentos()
        {
            dsPrincipal.Tables.Add(oControleDados.oComodos.dtDados);
            dsPrincipal.Tables.Add(oControleDados.oAtividades.dtDados);
            dsPrincipal.Tables.Add(oControleDados.oProdutosSugeridos.dtDados);

            dsPrincipal.Tables.Add(oControleDados.oAtividadesComodos.dtDados);
            dsPrincipal.Tables.Add(oControleDados.oProdutosAtividade.dtDados);

            CriarRelacionamentosCadastro();
            CriarRelacionamentosControle();

            VincularDataSourceCadastros();
            VincularDataSourceControles();
        }

        private void CriarRelacionamentosCadastro()
        {
            drProdutosSugeridos = new DataRelation("ProdutosSugeridosAtividade",
                dsPrincipal.Tables["dtAtividades"].Columns["cdAtividade"],
                dsPrincipal.Tables["dtProdutosSugeridos"].Columns["cdAtividade"]);
            dsPrincipal.Relations.Add(drProdutosSugeridos);
        }

        private void CriarRelacionamentosControle()
        {
            drAtividadesComodo = new DataRelation("AtividadesComodo",
                dsPrincipal.Tables["dtComodos"].Columns["cdComodo"],
                dsPrincipal.Tables["dtAtividadesComodo"].Columns["cdComodo"]);
            dsPrincipal.Relations.Add(drAtividadesComodo);

            DataColumn[] dcAtividadesComodo = new DataColumn[2];
            DataColumn[] dcProdutosAtividade = new DataColumn[2];

            dcAtividadesComodo[0] = dsPrincipal.Tables["dtAtividadesComodo"].Columns["cdComodo"];
            dcAtividadesComodo[1] = dsPrincipal.Tables["dtAtividadesComodo"].Columns["cdAtividade"];

            dcProdutosAtividade[0] = dsPrincipal.Tables["dtProdutosAtividade"].Columns["cdComodo"];
            dcProdutosAtividade[1] = dsPrincipal.Tables["dtProdutosAtividade"].Columns["cdAtividade"];

            drProdutosAtividade = new DataRelation("ProdutosAtividadesComodo", dcAtividadesComodo, dcProdutosAtividade);
            dsPrincipal.Relations.Add(drProdutosAtividade);
        }

        private void VincularDataSourceCadastros()
        {
            bsAtividades.DataSource = dsPrincipal;
            bsProdutosSugeridos.DataSource = bsAtividades;
            dgvAtividades.DataSource = bsAtividades;
            dgvProdutosSugeridos.DataSource = bsProdutosSugeridos;
        }

        private void VincularDataSourceControles()
        {
            bsConComodos.DataSource = dsPrincipal;
            bsConAtividadesComodo.DataSource = bsConComodos;
            bsConProdutosAtividade.DataSource = bsConAtividadesComodo;

            dgvConComodos.DataSource = bsConComodos;
            dgvConAtividades.DataSource = bsConAtividadesComodo;
            dgvProdutosAtividades.DataSource = bsConProdutosAtividade;
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            oControleDados.SalvarDataTables();
            tstbStatus.Visible = true;
            tmStatus.Start();
        }

        private void tsmiFechar_Click(object sender, EventArgs e)
        {
            csFuncoes.FazerBackUp();
            Close();
        }

        private void VincluarDataTables()
        {
            dgvComodos.DataSource = oControleDados.oComodos.dtDados;
            dgvProdutos.DataSource = oControleDados.oProdutos.dtDados;            

            DataGridViewComboBoxColumn dgvcProdutos = (DataGridViewComboBoxColumn)dgvProdutosSugeridos.Columns["nmProdutoAtiv"];
            dgvcProdutos.DataSource = oControleDados.oProdutos.dtDados;
            dgvcProdutos.DisplayMember = "nmProduto";
            dgvcProdutos.ValueMember = "cdProduto";

            DataGridViewComboBoxColumn dgvcConProdutos = (DataGridViewComboBoxColumn)dgvProdutosAtividades.Columns["cdProdutoAtividade"];
            dgvcConProdutos.DataSource = oControleDados.oProdutos.dtDados;
            dgvcConProdutos.DisplayMember = "nmProduto";
            dgvcConProdutos.ValueMember = "cdProduto";

            DataGridViewComboBoxColumn dgvcConAtividades = (DataGridViewComboBoxColumn)dgvConAtividades.Columns["cdAtividadeComodo"];
            dgvcConAtividades.DataSource = oControleDados.oAtividades.dtDados;
            dgvcConAtividades.DisplayMember = "deAtividade";
            dgvcConAtividades.ValueMember = "cdAtividade";
        }

        private void dgvComodos_Leave(object sender, EventArgs e)
        {
            oControleDados.oComodos.AtualizarCodigos();
        }

        private void dgvProdutos_Leave(object sender, EventArgs e)
        {
            oControleDados.oProdutos.AtualizarCodigos();
            CarregarRelacionamentos();
        }

        private void dgvAtividades_Leave(object sender, EventArgs e)
        {
            oControleDados.oAtividades.AtualizarCodigos();
        }

        private void tmStatus_Tick(object sender, EventArgs e)
        {
            tstbStatus.Visible = false;
        }

        private void dgvConAtividades_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cbAtividade = e.Control as ComboBox;
            if (cbAtividade != null)
            {
                cbAtividade.SelectedIndexChanged -= new EventHandler(cdComodoAtividade_SelectedIndexChanged);
                cbAtividade.SelectedIndexChanged += new EventHandler(cdComodoAtividade_SelectedIndexChanged);
                bSelecionandoAtividade = true;
            }
        }

        private void cdComodoAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bSelecionandoAtividade)
            {
                return;
            }
            bSelecionandoAtividade = false;

            ComboBox cbAtividade = (ComboBox)sender;

            int cdAtividade = Convert.ToInt32(cbAtividade.SelectedValue);
            int nIndexAtividade = dgvConAtividades.SelectedRows[0].Index;
            int nIndexColValor = dgvConAtividades.Columns["vlAtividadeComodo"].Index;

            if (dgvConAtividades.Rows[nIndexAtividade].Cells[nIndexColValor].Value.ToString() == string.Empty)
            {
                DataRow[] drAtividade = oControleDados.oAtividades.dtDados.Select("cdAtividade=" + cdAtividade.ToString());
                dgvConAtividades.Rows[nIndexAtividade].Cells[nIndexColValor].Value = drAtividade[0]["vlAtividade"].ToString();
            }
        }

        private void CarregarProdutosSugeridos()
        {
            if (dgvProdutosAtividades.Rows.Count > 1)
            {
                return;
            }

            int nIndexColCodAtividadeCon = dgvConAtividades.Columns["cdAtividadeComodo"].Index;
            int nIndexColCodComodo = dgvConComodos.Columns["cdComodoCon"].Index;
            int nIndexColCodAtividade = dgvProdutosAtividades.Columns["cdAtividadeProd"].Index;
            int nIndexColCodigoProd = dgvProdutosAtividades.Columns["cdProdutoAtividade"].Index;
            int nIndexColValor = dgvProdutosAtividades.Columns["vlProdutoAtividade"].Index;
            int nIndexColUndMedida = dgvProdutosAtividades.Columns["deConUnidadeMedida"].Index;
            int nIndexColQtdProd = dgvProdutosAtividades.Columns["nuQtdProdutoAtividade"].Index;
            int nIndexColValorTot = dgvProdutosAtividades.Columns["vlTotal"].Index;
            int nCdAtividade = 0;
            int nCdComodo = 0;
            int nCdProduto;

            if (dgvConComodos.SelectedRows[0].Cells[nIndexColCodComodo].Value != null)
            {
                int.TryParse(dgvConComodos.SelectedRows[0].Cells[nIndexColCodComodo].Value.ToString(), out nCdComodo);
            }
            if (dgvConAtividades.SelectedRows[0].Cells[nIndexColCodAtividadeCon].Value != null)
            {
                int.TryParse(dgvConAtividades.SelectedRows[0].Cells[nIndexColCodAtividadeCon].Value.ToString(), out nCdAtividade);
            }
            DataRow[] drProdutosSugeridos = oControleDados.oProdutosSugeridos.dtDados.Select("cdAtividade = " + nCdAtividade);

            for (int nIndexProdSug = 0; nIndexProdSug < drProdutosSugeridos.Length; nIndexProdSug++)
            {
                nCdProduto = Convert.ToInt32(drProdutosSugeridos[nIndexProdSug]["cdProduto"].ToString());
                DataRow[] drDadosProduto = oControleDados.oProdutos.dtDados.Select("cdProduto = " + nCdProduto);

                DataRow drProduto = oControleDados.oProdutosAtividade.dtDados.NewRow();
                drProduto["cdComodo"] = nCdComodo;
                drProduto["cdAtividade"] = nCdAtividade;
                drProduto["cdProduto"] = nCdProduto;
                drProduto["vlProduto"] = drDadosProduto[0]["vlProduto"];
                drProduto["deUnidadeMedida"] = drDadosProduto[0]["deUnidadeMedida"];
                drProduto["nuQtdProduto"] = 0;
                drProduto["vlTotal"] = 0;
                oControleDados.oProdutosAtividade.dtDados.Rows.Add(drProduto);
            }

            dgvProdutosAtividades.Refresh();
        }

        private void AtualizarFiltroAtividades()
        {
            if (dgvConComodos.Rows.Count == 0)
            {
                return;
            }

            DataGridViewComboBoxColumn dgvcConAtividades = (DataGridViewComboBoxColumn)dgvConAtividades.Columns["cdAtividadeComodo"];

            DataTable dtAtividadesFiltro = new DataTable();
            dtAtividadesFiltro.Columns.Add("cdAtividade", typeof(int));
            dtAtividadesFiltro.Columns.Add("deAtividade", typeof(string));
            dtAtividadesFiltro.Columns.Add("vlAtividade", typeof(float));

            int nIndexColCodComodo = dgvConComodos.Columns["cdComodoCon"].Index;
            string sListaAtividadesVinc = string.Empty;
            string sCdComodo = string.Empty;
            dgvcConAtividades.DisplayMember = "deAtividade";
            dgvcConAtividades.ValueMember = "cdAtividade";

            sCdComodo = dgvConComodos.Rows[0].Cells[nIndexColCodComodo].Value.ToString();
            if (dgvConComodos.SelectedRows.Count > 0)
            {
                sCdComodo = dgvConComodos.SelectedRows[0].Cells[nIndexColCodComodo].Value.ToString();
            }

            DataRow[] drAvividadesVinc = oControleDados.oAtividadesComodos.dtDados.Select("cdComodo=" + sCdComodo);
            foreach (DataRow drAtividade in drAvividadesVinc)
            {
                sListaAtividadesVinc += drAtividade["cdAtividade"] + ",";
            }

            if (sListaAtividadesVinc == string.Empty)
            {
                dgvcConAtividades.DataSource = oControleDados.oAtividades.dtDados;
                return;
            }

            sListaAtividadesVinc = sListaAtividadesVinc.Substring(0, sListaAtividadesVinc.Length - 1);
            DataRow[] drAtividades = oControleDados.oAtividades.dtDados.Select("cdAtividade not in (" + sListaAtividadesVinc + ")");
            foreach (DataRow dr in drAtividades)
            {
                DataRow drAdd = dtAtividadesFiltro.NewRow();
                drAdd["cdAtividade"] = dr["cdAtividade"];
                drAdd["deAtividade"] = dr["deAtividade"];
                drAdd["vlAtividade"] = dr["vlAtividade"];
                dtAtividadesFiltro.Rows.Add(drAdd);
            }
            dgvcConAtividades.DataSource = dtAtividadesFiltro;
        }

        private void dgvProdutosAtividades_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox cbProduto = e.Control as ComboBox;
            TextBox tbQtd = e.Control as TextBox;

            if (cbProduto != null)
            {
                cbProduto.SelectedIndexChanged -= new EventHandler(cdAtividadeProduto_SelectedIndexChanged);
                cbProduto.SelectedIndexChanged += new EventHandler(cdAtividadeProduto_SelectedIndexChanged);
                bSelecionandoProduto = true;
                return;
            }

            if (tbQtd != null)
            {
                tbQtd.Leave -= new EventHandler(tbProdutos_Leave);
                tbQtd.Leave += new EventHandler(tbProdutos_Leave);
                return;
            }
        }

        private void cdAtividadeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bSelecionandoProduto)
            {
                return;
            }
            bSelecionandoAtividade = false;

            ComboBox cbProduto = (ComboBox)sender;

            if (cbProduto.SelectedValue == null || cbProduto.SelectedValue.GetType() == typeof(DataRowView))
            {
                return;
            }

            int cdProduto = Convert.ToInt32(cbProduto.SelectedValue);
            int nIndexProduto = dgvProdutosAtividades.SelectedRows[0].Index;
            int nIndexColValor = dgvProdutosAtividades.Columns["vlProdutoAtividade"].Index;
            int nIndexColUndMedida = dgvProdutosAtividades.Columns["deConUnidadeMedida"].Index;
            int nIndexColQtd = dgvProdutosAtividades.Columns["nuQtdProdutoAtividade"].Index;
            int nIndexColValorTotal = dgvProdutosAtividades.Columns["vlTotal"].Index;

            DataRow[] drProduto = oControleDados.oProdutos.dtDados.Select("cdProduto=" + cdProduto.ToString());
            if (drProduto.Length == 0)
            {
                return;
            }

            dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColUndMedida].Value = drProduto[0]["deUnidadeMedida"].ToString();
            if (dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColValor].Value.ToString() == string.Empty)
            {
                dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColValor].Value = drProduto[0]["vlProduto"].ToString();
            }
            dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColQtd].Value = 0;
            dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColValorTotal].Value = 0;
        }

        private void tbProdutos_Leave(object sender, EventArgs e)
        {
            int nIndexProduto = dgvProdutosAtividades.SelectedRows[0].Index;
            int nIndexColValor = dgvProdutosAtividades.Columns["vlProdutoAtividade"].Index;
            int nIndexColQtd = dgvProdutosAtividades.Columns["nuQtdProdutoAtividade"].Index;
            int nIndexColVlTotal = dgvProdutosAtividades.Columns["vlTotal"].Index;

            if (dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColQtd].Value.ToString() != string.Empty &&
                dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColValor].Value.ToString() != string.Empty)
            {
                double nQtd = Convert.ToDouble(dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColQtd].Value.ToString());
                double vlProduto = Convert.ToDouble(dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColValor].Value.ToString());

                dgvProdutosAtividades.Rows[nIndexProduto].Cells[nIndexColVlTotal].Value = nQtd * vlProduto;
            }

            AtualizarTotais();
        }

        private void AtualizarTotais()
        {
            double vlAtividade = RetornarTotalAtividadeSelecionada();
            double vlComodo = RetornarTotalComodoSelecionado();
            double vlTotalObra = RetornarTotalDaObra();

            tsslTotalAtividade.Text = String.Format("Total da atividade : {0:C2}", vlAtividade);
            tsslTotalComodo.Text = String.Format("Total do cômodo : {0:C2}", vlComodo);
            tstbTotalObra.Text = String.Format("Total da obra : {0:C2}", vlTotalObra);
        }

        private double RetornarTotalComodoSelecionado()
        {
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;
            int nCdComodo = Convert.ToInt32(dgvConComodos.SelectedRows[0].Cells[nIndexColCdComodo].Value.ToString());

            return RetornarTotalComodo(nCdComodo);
        }

        private double RetornarTotalAtividadeSelecionada()
        {
            object oSumProdutos;
            double vlAtividade = 0;
            int nCdComodo, nCdAtividade;
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;
            int nIndexColCdAtividade = dgvConAtividades.Columns["cdAtividadeComodo"].Index;
            int nIndexColVlAtividade = dgvConAtividades.Columns["vlAtividadeComodo"].Index;
            int nIndexColFlAtivo = dgvConAtividades.Columns["ckbContabilizaAtividade"].Index;

            if (dgvConAtividades.SelectedRows.Count == 0)
            {
                return vlAtividade;
            }

            if (dgvConAtividades.SelectedRows[0].Cells[nIndexColVlAtividade].Value == null)
            {
                return vlAtividade;
            }

            if (dgvConAtividades.SelectedRows[0].Cells[nIndexColFlAtivo].Value.ToString() == "N")
            {
                return vlAtividade;
            }

            Double.TryParse(dgvConAtividades.SelectedRows[0].Cells[nIndexColVlAtividade].Value.ToString(), out vlAtividade);
            nCdComodo = Convert.ToInt32(dgvConComodos.SelectedRows[0].Cells[nIndexColCdComodo].Value.ToString());
            int.TryParse(dgvConAtividades.SelectedRows[0].Cells[nIndexColCdAtividade].Value.ToString(), out nCdAtividade);

            oSumProdutos = oControleDados.oProdutosAtividade.dtDados.Compute("Sum(vlTotal)", "cdComodo = " + nCdComodo.ToString()
                + " and cdAtividade =" + nCdAtividade.ToString());

            if (oSumProdutos.GetType() != typeof(System.DBNull))
            {
                vlAtividade += Convert.ToDouble(oSumProdutos);
            }

            return vlAtividade;
        }

        private double RetornarTotalDaObra()
        {
            double vlTotalObra = 0;
            int nCdComodo;
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;

            for (int nIndiceComodo = 0; nIndiceComodo < dgvConComodos.RowCount - 1; nIndiceComodo++)
            {
                nCdComodo = Convert.ToInt32(dgvConComodos.Rows[nIndiceComodo].Cells[nIndexColCdComodo].Value.ToString());
                vlTotalObra += RetornarTotalComodo(nCdComodo); ;
            }

            return vlTotalObra;
        }

        private double RetornarTotalComodo(int pnCdComodo)
        {
            object oSumAtividades;
            double vlComodo = 0;
            int nCdAtividade;

            if (dgvConComodos.SelectedRows.Count > 0)
            {
                oSumAtividades = oControleDados.oAtividadesComodos.dtDados.Compute("Sum(vlAtividade)",
                    "cdComodo = " + pnCdComodo.ToString() + " and flAtivo = 'S'");

                if (oSumAtividades.GetType() != typeof(System.DBNull))
                {
                    vlComodo += Convert.ToDouble(oSumAtividades);
                }

                DataRow[] drAtividadesAtivas = oControleDados.oAtividadesComodos.dtDados.Select("cdComodo = " + pnCdComodo.ToString() +
                    " and flAtivo = 'S'");

                for (int nIndiceAtividade = 0; nIndiceAtividade < drAtividadesAtivas.Length; nIndiceAtividade++)
                {
                    nCdAtividade = Convert.ToInt32(drAtividadesAtivas[nIndiceAtividade]["cdAtividade"].ToString());
                    vlComodo += RetornarTotalProdutosAtividadesAtivas(pnCdComodo, nCdAtividade);
                }
            }

            return vlComodo;
        }

        private double RetornarTotalProdutosAtividadesAtivas(int pnCdComodo, int pnCdAtividade)
        {
            object oSumProdutos;
            double vlProdutos = 0;

            oSumProdutos = oControleDados.oProdutosAtividade.dtDados.Compute("Sum(vlTotal)", "cdComodo = " + pnCdComodo.ToString() +
                " and cdAtividade = " + pnCdAtividade.ToString());

            if (oSumProdutos.GetType() != typeof(System.DBNull))
            {
                vlProdutos += Convert.ToDouble(oSumProdutos);
            }

            return vlProdutos;
        }

        private void dgvConAtividades_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void dgvProdutosAtividades_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarTotais();
        }

        private void dgvConComodos_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void dgvConAtividades_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            int nLinhaSelecionada = dgvConAtividades.SelectedRows[0].Index;
            dgvConAtividades.Rows[nLinhaSelecionada].Selected = true;
            CarregarProdutosSugeridos();
        }
    }
}
