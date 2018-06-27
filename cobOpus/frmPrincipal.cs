﻿using System;
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

            DataGridViewComboBoxColumn dgvcConProdutos = (DataGridViewComboBoxColumn)dgvProdutosAtividades.Columns["nmProdutoAtividade"];
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
            CarregarRelacionamentos();
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
            object oSumAtividades;
            object oSumProdutos;
            double vlComodo = 0;

            int nCdComodo;
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;

            if (dgvConComodos.SelectedRows.Count > 0)
            {
                nCdComodo = Convert.ToInt32(dgvConComodos.SelectedRows[0].Cells[nIndexColCdComodo].Value.ToString());
                oSumAtividades = oControleDados.oAtividadesComodos.dtDados.Compute("Sum(vlAtividade)", "cdComodo = " + nCdComodo.ToString());
                oSumProdutos = oControleDados.oProdutosAtividade.dtDados.Compute("Sum(vlTotal)", "cdComodo = " + nCdComodo.ToString());

                if (oSumAtividades.GetType() != typeof(System.DBNull))
                {
                    vlComodo += Convert.ToDouble(oSumAtividades);
                }

                if (oSumProdutos.GetType() != typeof(System.DBNull))
                {
                    vlComodo += Convert.ToDouble(oSumProdutos);
                }
            }

            return vlComodo;
        }

        private double RetornarTotalAtividadeSelecionada()
        {
            object oSumProdutos;
            double vlAtividade = 0;
            int nCdComodo, nCdAtividade;
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;
            int nIndexColCdAtividade = dgvConAtividades.Columns["cdAtividadeComodo"].Index;
            int nIndexColVlAtividade = dgvConAtividades.Columns["vlAtividadeComodo"].Index;

            if (dgvConAtividades.SelectedRows.Count > 0)
            {
                Double.TryParse(dgvConAtividades.SelectedRows[0].Cells[nIndexColVlAtividade].Value.ToString(), out vlAtividade);
                nCdComodo = Convert.ToInt32(dgvConComodos.SelectedRows[0].Cells[nIndexColCdComodo].Value.ToString());
                int.TryParse(dgvConAtividades.SelectedRows[0].Cells[nIndexColCdAtividade].Value.ToString(), out nCdAtividade);

                oSumProdutos = oControleDados.oProdutosAtividade.dtDados.Compute("Sum(vlTotal)", "cdComodo = " + nCdComodo.ToString()
                    + " and cdAtividade =" + nCdAtividade.ToString());

                if (oSumProdutos.GetType() != typeof(System.DBNull))
                {
                    vlAtividade += Convert.ToDouble(oSumProdutos);
                }
            }

            return vlAtividade;
        }

        private double RetornarTotalDaObra()
        {
            object oSumAtividades;
            object oSumProdutos;
            double vlComodo = 0;
            double vlTotalObra = 0;

            int nCdComodo;
            int nIndexColCdComodo = dgvConComodos.Columns["cdComodoCon"].Index;

            for (int nIndiceComodo = 0; nIndiceComodo < dgvConComodos.RowCount - 1; nIndiceComodo++)
            {
                vlComodo = 0;
                nCdComodo = Convert.ToInt32(dgvConComodos.Rows[nIndiceComodo].Cells[nIndexColCdComodo].Value.ToString());
                oSumAtividades = oControleDados.oAtividadesComodos.dtDados.Compute("Sum(vlAtividade)", "cdComodo = " + nCdComodo.ToString());
                oSumProdutos = oControleDados.oProdutosAtividade.dtDados.Compute("Sum(vlTotal)", "cdComodo = " + nCdComodo.ToString());

                if (oSumAtividades.GetType() != typeof(System.DBNull))
                {
                    vlComodo += Convert.ToDouble(oSumAtividades);
                }

                if (oSumProdutos.GetType() != typeof(System.DBNull))
                {
                    vlComodo += Convert.ToDouble(oSumProdutos);
                }

                vlTotalObra += vlComodo;
            }

            return vlTotalObra;
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
    }
}