﻿namespace cobOpus
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpControle = new System.Windows.Forms.TabPage();
            this.scControle = new System.Windows.Forms.SplitContainer();
            this.ssTotalizadorComodo = new System.Windows.Forms.StatusStrip();
            this.tsslTotalComodo = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvConComodos = new System.Windows.Forms.DataGridView();
            this.cdComodoCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmComodoCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scControleSub = new System.Windows.Forms.SplitContainer();
            this.dgvConAtividades = new System.Windows.Forms.DataGridView();
            this.cdComodoAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbContabilizaAtividade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cdAtividadeComodo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vlAtividadeComodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssTotalizador = new System.Windows.Forms.StatusStrip();
            this.tsslTotalAtividade = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvProdutosAtividades = new System.Windows.Forms.DataGridView();
            this.cdComodoAtividadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAtividadeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdProdutoAtividade = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.vlProdutoAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deConUnidadeMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuQtdProdutoAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpCadastros = new System.Windows.Forms.TabPage();
            this.scCadastros = new System.Windows.Forms.SplitContainer();
            this.scSuperior = new System.Windows.Forms.SplitContainer();
            this.dgvComodos = new System.Windows.Forms.DataGridView();
            this.cdComodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmComodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.cdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deUnidadeMedida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.scInferior = new System.Windows.Forms.SplitContainer();
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.cdAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deAtividade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlAtividadeOrcado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutosSugeridos = new System.Windows.Forms.DataGridView();
            this.cdProdAtividadeSug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmProdutoAtiv = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.msControle = new System.Windows.Forms.MenuStrip();
            this.tsmiSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbStatus = new System.Windows.Forms.ToolStripTextBox();
            this.tstbImportacao = new System.Windows.Forms.ToolStripTextBox();
            this.tstbTotalObra = new System.Windows.Forms.ToolStripTextBox();
            this.tstbBaseDados = new System.Windows.Forms.ToolStripTextBox();
            this.dsPrincipal = new System.Data.DataSet();
            this.tmStatus = new System.Windows.Forms.Timer(this.components);
            this.cmsFuncoes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiImportarComodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportarAtividades = new System.Windows.Forms.ToolStripMenuItem();
            this.pnProcessamento = new System.Windows.Forms.Panel();
            this.pbProgresso = new System.Windows.Forms.ProgressBar();
            this.lbMensagemProcessamento = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.bsAtividades = new System.Windows.Forms.BindingSource(this.components);
            this.bsProdutosSugeridos = new System.Windows.Forms.BindingSource(this.components);
            this.bsConComodos = new System.Windows.Forms.BindingSource(this.components);
            this.bsConAtividadesComodo = new System.Windows.Forms.BindingSource(this.components);
            this.bsConProdutosAtividade = new System.Windows.Forms.BindingSource(this.components);
            this.ucRelatorios = new cobOpus.Componentes.ucGerenciadorRelatorios();
            this.tcPrincipal.SuspendLayout();
            this.tpControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scControle)).BeginInit();
            this.scControle.Panel1.SuspendLayout();
            this.scControle.Panel2.SuspendLayout();
            this.scControle.SuspendLayout();
            this.ssTotalizadorComodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConComodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scControleSub)).BeginInit();
            this.scControleSub.Panel1.SuspendLayout();
            this.scControleSub.Panel2.SuspendLayout();
            this.scControleSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConAtividades)).BeginInit();
            this.ssTotalizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAtividades)).BeginInit();
            this.tpCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCadastros)).BeginInit();
            this.scCadastros.Panel1.SuspendLayout();
            this.scCadastros.Panel2.SuspendLayout();
            this.scCadastros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSuperior)).BeginInit();
            this.scSuperior.Panel1.SuspendLayout();
            this.scSuperior.Panel2.SuspendLayout();
            this.scSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scInferior)).BeginInit();
            this.scInferior.Panel1.SuspendLayout();
            this.scInferior.Panel2.SuspendLayout();
            this.scInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSugeridos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.msControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.cmsFuncoes.SuspendLayout();
            this.pnProcessamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAtividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutosSugeridos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConComodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConAtividadesComodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConProdutosAtividade)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpControle);
            this.tcPrincipal.Controls.Add(this.tpCadastros);
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(884, 386);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpControle
            // 
            this.tpControle.Controls.Add(this.scControle);
            this.tpControle.Location = new System.Drawing.Point(4, 22);
            this.tpControle.Name = "tpControle";
            this.tpControle.Padding = new System.Windows.Forms.Padding(3);
            this.tpControle.Size = new System.Drawing.Size(876, 360);
            this.tpControle.TabIndex = 0;
            this.tpControle.Text = "Controle";
            this.tpControle.UseVisualStyleBackColor = true;
            // 
            // scControle
            // 
            this.scControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scControle.Location = new System.Drawing.Point(3, 3);
            this.scControle.Name = "scControle";
            // 
            // scControle.Panel1
            // 
            this.scControle.Panel1.Controls.Add(this.ssTotalizadorComodo);
            this.scControle.Panel1.Controls.Add(this.dgvConComodos);
            // 
            // scControle.Panel2
            // 
            this.scControle.Panel2.Controls.Add(this.scControleSub);
            this.scControle.Size = new System.Drawing.Size(870, 354);
            this.scControle.SplitterDistance = 289;
            this.scControle.TabIndex = 0;
            // 
            // ssTotalizadorComodo
            // 
            this.ssTotalizadorComodo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalComodo});
            this.ssTotalizadorComodo.Location = new System.Drawing.Point(0, 332);
            this.ssTotalizadorComodo.Name = "ssTotalizadorComodo";
            this.ssTotalizadorComodo.Size = new System.Drawing.Size(289, 22);
            this.ssTotalizadorComodo.TabIndex = 1;
            this.ssTotalizadorComodo.Text = "statusStrip1";
            // 
            // tsslTotalComodo
            // 
            this.tsslTotalComodo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslTotalComodo.Name = "tsslTotalComodo";
            this.tsslTotalComodo.Size = new System.Drawing.Size(103, 17);
            this.tsslTotalComodo.Text = "Total do cômodo:";
            // 
            // dgvConComodos
            // 
            this.dgvConComodos.AllowUserToAddRows = false;
            this.dgvConComodos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvConComodos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConComodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConComodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdComodoCon,
            this.nmComodoCon});
            this.dgvConComodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConComodos.Location = new System.Drawing.Point(0, 0);
            this.dgvConComodos.Name = "dgvConComodos";
            this.dgvConComodos.ReadOnly = true;
            this.dgvConComodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConComodos.Size = new System.Drawing.Size(289, 354);
            this.dgvConComodos.TabIndex = 0;
            this.dgvConComodos.SelectionChanged += new System.EventHandler(this.dgvConComodos_SelectionChanged);
            this.dgvConComodos.Enter += new System.EventHandler(this.AtivarFoco);
            this.dgvConComodos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvConComodos_KeyUp);
            this.dgvConComodos.Leave += new System.EventHandler(this.DesativarFoco);
            // 
            // cdComodoCon
            // 
            this.cdComodoCon.DataPropertyName = "cdComodo";
            this.cdComodoCon.HeaderText = "Cód. Cômodo";
            this.cdComodoCon.Name = "cdComodoCon";
            this.cdComodoCon.ReadOnly = true;
            this.cdComodoCon.Visible = false;
            // 
            // nmComodoCon
            // 
            this.nmComodoCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmComodoCon.DataPropertyName = "nmComodo";
            this.nmComodoCon.HeaderText = "Cômodo";
            this.nmComodoCon.Name = "nmComodoCon";
            this.nmComodoCon.ReadOnly = true;
            // 
            // scControleSub
            // 
            this.scControleSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scControleSub.Location = new System.Drawing.Point(0, 0);
            this.scControleSub.Name = "scControleSub";
            this.scControleSub.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scControleSub.Panel1
            // 
            this.scControleSub.Panel1.Controls.Add(this.dgvConAtividades);
            // 
            // scControleSub.Panel2
            // 
            this.scControleSub.Panel2.Controls.Add(this.ssTotalizador);
            this.scControleSub.Panel2.Controls.Add(this.dgvProdutosAtividades);
            this.scControleSub.Size = new System.Drawing.Size(577, 354);
            this.scControleSub.SplitterDistance = 125;
            this.scControleSub.TabIndex = 0;
            // 
            // dgvConAtividades
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvConAtividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdComodoAtividade,
            this.ckbContabilizaAtividade,
            this.cdAtividadeComodo,
            this.vlAtividadeComodo});
            this.dgvConAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConAtividades.Location = new System.Drawing.Point(0, 0);
            this.dgvConAtividades.Name = "dgvConAtividades";
            this.dgvConAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConAtividades.Size = new System.Drawing.Size(577, 125);
            this.dgvConAtividades.TabIndex = 0;
            this.dgvConAtividades.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvConAtividades_EditingControlShowing);
            this.dgvConAtividades.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConAtividades_RowValidated);
            this.dgvConAtividades.SelectionChanged += new System.EventHandler(this.dgvConAtividades_SelectionChanged);
            this.dgvConAtividades.Enter += new System.EventHandler(this.AtivarFoco);
            this.dgvConAtividades.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvConAtividades_KeyUp);
            this.dgvConAtividades.Leave += new System.EventHandler(this.DesativarFoco);
            // 
            // cdComodoAtividade
            // 
            this.cdComodoAtividade.DataPropertyName = "cdComodo";
            this.cdComodoAtividade.HeaderText = "Cód. Cômodo";
            this.cdComodoAtividade.Name = "cdComodoAtividade";
            this.cdComodoAtividade.Visible = false;
            this.cdComodoAtividade.Width = 80;
            // 
            // ckbContabilizaAtividade
            // 
            this.ckbContabilizaAtividade.DataPropertyName = "flAtivo";
            this.ckbContabilizaAtividade.FalseValue = "N";
            this.ckbContabilizaAtividade.HeaderText = "Ativa";
            this.ckbContabilizaAtividade.IndeterminateValue = "N";
            this.ckbContabilizaAtividade.Name = "ckbContabilizaAtividade";
            this.ckbContabilizaAtividade.TrueValue = "S";
            this.ckbContabilizaAtividade.Width = 40;
            // 
            // cdAtividadeComodo
            // 
            this.cdAtividadeComodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdAtividadeComodo.DataPropertyName = "cdAtividade";
            this.cdAtividadeComodo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cdAtividadeComodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdAtividadeComodo.HeaderText = "Atividade";
            this.cdAtividadeComodo.Name = "cdAtividadeComodo";
            // 
            // vlAtividadeComodo
            // 
            this.vlAtividadeComodo.DataPropertyName = "vlAtividade";
            dataGridViewCellStyle3.Format = "C2";
            this.vlAtividadeComodo.DefaultCellStyle = dataGridViewCellStyle3;
            this.vlAtividadeComodo.HeaderText = "Valor";
            this.vlAtividadeComodo.Name = "vlAtividadeComodo";
            this.vlAtividadeComodo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vlAtividadeComodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ssTotalizador
            // 
            this.ssTotalizador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalAtividade});
            this.ssTotalizador.Location = new System.Drawing.Point(0, 203);
            this.ssTotalizador.Name = "ssTotalizador";
            this.ssTotalizador.Size = new System.Drawing.Size(577, 22);
            this.ssTotalizador.TabIndex = 1;
            // 
            // tsslTotalAtividade
            // 
            this.tsslTotalAtividade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsslTotalAtividade.Name = "tsslTotalAtividade";
            this.tsslTotalAtividade.Size = new System.Drawing.Size(108, 17);
            this.tsslTotalAtividade.Text = "Total da atividade:";
            // 
            // dgvProdutosAtividades
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdutosAtividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutosAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdComodoAtividadeProduto,
            this.cdAtividadeProd,
            this.cdProdutoAtividade,
            this.vlProdutoAtividade,
            this.deConUnidadeMedida,
            this.nuQtdProdutoAtividade,
            this.vlTotal});
            this.dgvProdutosAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosAtividades.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutosAtividades.Name = "dgvProdutosAtividades";
            this.dgvProdutosAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosAtividades.Size = new System.Drawing.Size(577, 225);
            this.dgvProdutosAtividades.TabIndex = 0;
            this.dgvProdutosAtividades.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosAtividades_CellLeave);
            this.dgvProdutosAtividades.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvProdutosAtividades_EditingControlShowing);
            this.dgvProdutosAtividades.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosAtividades_RowValidated);
            this.dgvProdutosAtividades.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvProdutosAtividades_KeyUp);
            // 
            // cdComodoAtividadeProduto
            // 
            this.cdComodoAtividadeProduto.DataPropertyName = "cdComodo";
            this.cdComodoAtividadeProduto.HeaderText = "Cód. Cômodo";
            this.cdComodoAtividadeProduto.Name = "cdComodoAtividadeProduto";
            this.cdComodoAtividadeProduto.Visible = false;
            // 
            // cdAtividadeProd
            // 
            this.cdAtividadeProd.DataPropertyName = "cdAtividade";
            this.cdAtividadeProd.HeaderText = "Cód. Atividade";
            this.cdAtividadeProd.Name = "cdAtividadeProd";
            this.cdAtividadeProd.Visible = false;
            // 
            // cdProdutoAtividade
            // 
            this.cdProdutoAtividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdProdutoAtividade.DataPropertyName = "cdProduto";
            this.cdProdutoAtividade.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cdProdutoAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cdProdutoAtividade.HeaderText = "Produto";
            this.cdProdutoAtividade.Name = "cdProdutoAtividade";
            // 
            // vlProdutoAtividade
            // 
            this.vlProdutoAtividade.DataPropertyName = "vlProduto";
            dataGridViewCellStyle5.Format = "C2";
            this.vlProdutoAtividade.DefaultCellStyle = dataGridViewCellStyle5;
            this.vlProdutoAtividade.HeaderText = "Valor";
            this.vlProdutoAtividade.Name = "vlProdutoAtividade";
            this.vlProdutoAtividade.Width = 80;
            // 
            // deConUnidadeMedida
            // 
            this.deConUnidadeMedida.DataPropertyName = "deUnidadeMedida";
            this.deConUnidadeMedida.HeaderText = "Und. Medida";
            this.deConUnidadeMedida.Name = "deConUnidadeMedida";
            this.deConUnidadeMedida.ReadOnly = true;
            this.deConUnidadeMedida.Width = 50;
            // 
            // nuQtdProdutoAtividade
            // 
            this.nuQtdProdutoAtividade.DataPropertyName = "nuQtdProduto";
            this.nuQtdProdutoAtividade.HeaderText = "Qtd.";
            this.nuQtdProdutoAtividade.Name = "nuQtdProdutoAtividade";
            this.nuQtdProdutoAtividade.Width = 60;
            // 
            // vlTotal
            // 
            this.vlTotal.DataPropertyName = "vlTotal";
            dataGridViewCellStyle6.Format = "C2";
            this.vlTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.vlTotal.HeaderText = "Total";
            this.vlTotal.Name = "vlTotal";
            this.vlTotal.ReadOnly = true;
            this.vlTotal.Width = 80;
            // 
            // tpCadastros
            // 
            this.tpCadastros.Controls.Add(this.scCadastros);
            this.tpCadastros.Location = new System.Drawing.Point(4, 22);
            this.tpCadastros.Name = "tpCadastros";
            this.tpCadastros.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastros.Size = new System.Drawing.Size(876, 360);
            this.tpCadastros.TabIndex = 1;
            this.tpCadastros.Text = "Cadastros";
            this.tpCadastros.UseVisualStyleBackColor = true;
            // 
            // scCadastros
            // 
            this.scCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCadastros.Location = new System.Drawing.Point(3, 3);
            this.scCadastros.Name = "scCadastros";
            this.scCadastros.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCadastros.Panel1
            // 
            this.scCadastros.Panel1.Controls.Add(this.scSuperior);
            // 
            // scCadastros.Panel2
            // 
            this.scCadastros.Panel2.Controls.Add(this.scInferior);
            this.scCadastros.Size = new System.Drawing.Size(870, 354);
            this.scCadastros.SplitterDistance = 128;
            this.scCadastros.TabIndex = 4;
            // 
            // scSuperior
            // 
            this.scSuperior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSuperior.Location = new System.Drawing.Point(0, 0);
            this.scSuperior.Name = "scSuperior";
            // 
            // scSuperior.Panel1
            // 
            this.scSuperior.Panel1.Controls.Add(this.dgvComodos);
            // 
            // scSuperior.Panel2
            // 
            this.scSuperior.Panel2.Controls.Add(this.dgvProdutos);
            this.scSuperior.Size = new System.Drawing.Size(870, 128);
            this.scSuperior.SplitterDistance = 228;
            this.scSuperior.TabIndex = 0;
            // 
            // dgvComodos
            // 
            this.dgvComodos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComodos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvComodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdComodo,
            this.nmComodo});
            this.dgvComodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComodos.Location = new System.Drawing.Point(0, 0);
            this.dgvComodos.MultiSelect = false;
            this.dgvComodos.Name = "dgvComodos";
            this.dgvComodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComodos.Size = new System.Drawing.Size(228, 128);
            this.dgvComodos.TabIndex = 1;
            // 
            // cdComodo
            // 
            this.cdComodo.DataPropertyName = "cdComodo";
            this.cdComodo.HeaderText = "Cód. Comodo";
            this.cdComodo.Name = "cdComodo";
            this.cdComodo.Visible = false;
            // 
            // nmComodo
            // 
            this.nmComodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmComodo.DataPropertyName = "nmComodo";
            this.nmComodo.HeaderText = "Cômodo";
            this.nmComodo.Name = "nmComodo";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdProduto,
            this.nmProduto,
            this.vlProduto,
            this.deUnidadeMedida});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(638, 128);
            this.dgvProdutos.TabIndex = 1;
            // 
            // cdProduto
            // 
            this.cdProduto.DataPropertyName = "cdProduto";
            this.cdProduto.HeaderText = "Cód. Produto";
            this.cdProduto.Name = "cdProduto";
            this.cdProduto.Visible = false;
            // 
            // nmProduto
            // 
            this.nmProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmProduto.DataPropertyName = "nmProduto";
            this.nmProduto.HeaderText = "Produto";
            this.nmProduto.Name = "nmProduto";
            // 
            // vlProduto
            // 
            this.vlProduto.DataPropertyName = "vlProduto";
            dataGridViewCellStyle9.Format = "C2";
            this.vlProduto.DefaultCellStyle = dataGridViewCellStyle9;
            this.vlProduto.HeaderText = "Valor";
            this.vlProduto.Name = "vlProduto";
            // 
            // deUnidadeMedida
            // 
            this.deUnidadeMedida.DataPropertyName = "deUnidadeMedida";
            this.deUnidadeMedida.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.deUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deUnidadeMedida.HeaderText = "Und. Medida";
            this.deUnidadeMedida.Items.AddRange(new object[] {
            "UND",
            "M²",
            "M³",
            "M",
            "L"});
            this.deUnidadeMedida.Name = "deUnidadeMedida";
            this.deUnidadeMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deUnidadeMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deUnidadeMedida.Width = 60;
            // 
            // scInferior
            // 
            this.scInferior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scInferior.Location = new System.Drawing.Point(0, 0);
            this.scInferior.Name = "scInferior";
            this.scInferior.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scInferior.Panel1
            // 
            this.scInferior.Panel1.Controls.Add(this.dgvAtividades);
            // 
            // scInferior.Panel2
            // 
            this.scInferior.Panel2.Controls.Add(this.dgvProdutosSugeridos);
            this.scInferior.Size = new System.Drawing.Size(870, 222);
            this.scInferior.SplitterDistance = 112;
            this.scInferior.TabIndex = 0;
            // 
            // dgvAtividades
            // 
            this.dgvAtividades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAtividades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAtividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdAtividade,
            this.deAtividade,
            this.vlAtividadeOrcado});
            this.dgvAtividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtividades.Location = new System.Drawing.Point(0, 0);
            this.dgvAtividades.MultiSelect = false;
            this.dgvAtividades.Name = "dgvAtividades";
            this.dgvAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividades.Size = new System.Drawing.Size(870, 112);
            this.dgvAtividades.TabIndex = 1;
            this.dgvAtividades.Leave += new System.EventHandler(this.dgvAtividades_Leave);
            // 
            // cdAtividade
            // 
            this.cdAtividade.DataPropertyName = "cdAtividade";
            this.cdAtividade.HeaderText = "Cód. Atividade";
            this.cdAtividade.Name = "cdAtividade";
            this.cdAtividade.Visible = false;
            // 
            // deAtividade
            // 
            this.deAtividade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deAtividade.DataPropertyName = "deAtividade";
            this.deAtividade.FillWeight = 42.59644F;
            this.deAtividade.HeaderText = "Atividade";
            this.deAtividade.Name = "deAtividade";
            // 
            // vlAtividadeOrcado
            // 
            this.vlAtividadeOrcado.DataPropertyName = "vlAtividade";
            dataGridViewCellStyle11.Format = "C2";
            this.vlAtividadeOrcado.DefaultCellStyle = dataGridViewCellStyle11;
            this.vlAtividadeOrcado.FillWeight = 228.4264F;
            this.vlAtividadeOrcado.HeaderText = "Valor";
            this.vlAtividadeOrcado.Name = "vlAtividadeOrcado";
            // 
            // dgvProdutosSugeridos
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProdutosSugeridos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProdutosSugeridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosSugeridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdProdAtividadeSug,
            this.nmProdutoAtiv});
            this.dgvProdutosSugeridos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutosSugeridos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutosSugeridos.MultiSelect = false;
            this.dgvProdutosSugeridos.Name = "dgvProdutosSugeridos";
            this.dgvProdutosSugeridos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutosSugeridos.Size = new System.Drawing.Size(870, 106);
            this.dgvProdutosSugeridos.TabIndex = 1;
            // 
            // cdProdAtividadeSug
            // 
            this.cdProdAtividadeSug.DataPropertyName = "cdAtividade";
            this.cdProdAtividadeSug.HeaderText = "Cód. Atividade";
            this.cdProdAtividadeSug.Name = "cdProdAtividadeSug";
            this.cdProdAtividadeSug.Visible = false;
            // 
            // nmProdutoAtiv
            // 
            this.nmProdutoAtiv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmProdutoAtiv.DataPropertyName = "cdProduto";
            this.nmProdutoAtiv.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.nmProdutoAtiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nmProdutoAtiv.HeaderText = "Produto sugerido";
            this.nmProdutoAtiv.Name = "nmProdutoAtiv";
            this.nmProdutoAtiv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nmProdutoAtiv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucRelatorios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 360);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Relatórios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // msControle
            // 
            this.msControle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.msControle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalvar,
            this.tsmiFechar,
            this.tstbStatus,
            this.tstbImportacao,
            this.tstbTotalObra,
            this.tstbBaseDados});
            this.msControle.Location = new System.Drawing.Point(0, 386);
            this.msControle.Name = "msControle";
            this.msControle.Size = new System.Drawing.Size(884, 24);
            this.msControle.TabIndex = 1;
            this.msControle.Text = "msControle";
            // 
            // tsmiSalvar
            // 
            this.tsmiSalvar.Name = "tsmiSalvar";
            this.tsmiSalvar.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsmiSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSalvar.Size = new System.Drawing.Size(50, 20);
            this.tsmiSalvar.Text = "Salvar";
            this.tsmiSalvar.Click += new System.EventHandler(this.tsmiSalvar_Click);
            // 
            // tsmiFechar
            // 
            this.tsmiFechar.Name = "tsmiFechar";
            this.tsmiFechar.Size = new System.Drawing.Size(54, 20);
            this.tsmiFechar.Text = "Fechar";
            this.tsmiFechar.Click += new System.EventHandler(this.tsmiFechar_Click);
            // 
            // tstbStatus
            // 
            this.tstbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.tstbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstbStatus.ForeColor = System.Drawing.Color.Green;
            this.tstbStatus.Name = "tstbStatus";
            this.tstbStatus.Size = new System.Drawing.Size(110, 20);
            this.tstbStatus.Text = "REGISTRO SALVO ";
            this.tstbStatus.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstbStatus.Visible = false;
            // 
            // tstbImportacao
            // 
            this.tstbImportacao.BackColor = System.Drawing.SystemColors.Window;
            this.tstbImportacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstbImportacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tstbImportacao.ForeColor = System.Drawing.Color.SteelBlue;
            this.tstbImportacao.Name = "tstbImportacao";
            this.tstbImportacao.Size = new System.Drawing.Size(160, 20);
            this.tstbImportacao.Text = "IMPORTAÇÃO CONCLUÍDA";
            this.tstbImportacao.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tstbImportacao.Visible = false;
            // 
            // tstbTotalObra
            // 
            this.tstbTotalObra.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbTotalObra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstbTotalObra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tstbTotalObra.ForeColor = System.Drawing.Color.Blue;
            this.tstbTotalObra.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.tstbTotalObra.Name = "tstbTotalObra";
            this.tstbTotalObra.Size = new System.Drawing.Size(220, 20);
            this.tstbTotalObra.Text = "Total da obra:";
            this.tstbTotalObra.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tstbBaseDados
            // 
            this.tstbBaseDados.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbBaseDados.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.tstbBaseDados.Name = "tstbBaseDados";
            this.tstbBaseDados.ReadOnly = true;
            this.tstbBaseDados.Size = new System.Drawing.Size(250, 20);
            this.tstbBaseDados.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            // 
            // tmStatus
            // 
            this.tmStatus.Interval = 2500;
            this.tmStatus.Tick += new System.EventHandler(this.tmStatus_Tick);
            // 
            // cmsFuncoes
            // 
            this.cmsFuncoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportarComodos,
            this.tsmiImportarProdutos,
            this.tsmiImportarAtividades});
            this.cmsFuncoes.Name = "cmsFuncoes";
            this.cmsFuncoes.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsFuncoes.Size = new System.Drawing.Size(177, 70);
            // 
            // tsmiImportarComodos
            // 
            this.tsmiImportarComodos.Name = "tsmiImportarComodos";
            this.tsmiImportarComodos.Size = new System.Drawing.Size(176, 22);
            this.tsmiImportarComodos.Text = "Importar cômodos";
            this.tsmiImportarComodos.Click += new System.EventHandler(this.tsmiImportarComodos_Click);
            // 
            // tsmiImportarProdutos
            // 
            this.tsmiImportarProdutos.Name = "tsmiImportarProdutos";
            this.tsmiImportarProdutos.Size = new System.Drawing.Size(176, 22);
            this.tsmiImportarProdutos.Text = "Importar produtos";
            this.tsmiImportarProdutos.Click += new System.EventHandler(this.tsmiImportarProdutos_Click);
            // 
            // tsmiImportarAtividades
            // 
            this.tsmiImportarAtividades.Name = "tsmiImportarAtividades";
            this.tsmiImportarAtividades.Size = new System.Drawing.Size(176, 22);
            this.tsmiImportarAtividades.Text = "Importar atividades";
            this.tsmiImportarAtividades.Click += new System.EventHandler(this.tsmiImportarAtividades_Click);
            // 
            // pnProcessamento
            // 
            this.pnProcessamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnProcessamento.BackColor = System.Drawing.Color.White;
            this.pnProcessamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnProcessamento.Controls.Add(this.pbProgresso);
            this.pnProcessamento.Controls.Add(this.lbMensagemProcessamento);
            this.pnProcessamento.Location = new System.Drawing.Point(250, 76);
            this.pnProcessamento.Name = "pnProcessamento";
            this.pnProcessamento.Size = new System.Drawing.Size(400, 88);
            this.pnProcessamento.TabIndex = 4;
            this.pnProcessamento.Visible = false;
            // 
            // pbProgresso
            // 
            this.pbProgresso.Location = new System.Drawing.Point(3, 58);
            this.pbProgresso.Name = "pbProgresso";
            this.pbProgresso.Size = new System.Drawing.Size(392, 23);
            this.pbProgresso.TabIndex = 3;
            // 
            // lbMensagemProcessamento
            // 
            this.lbMensagemProcessamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMensagemProcessamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensagemProcessamento.Location = new System.Drawing.Point(3, 0);
            this.lbMensagemProcessamento.Name = "lbMensagemProcessamento";
            this.lbMensagemProcessamento.Size = new System.Drawing.Size(392, 55);
            this.lbMensagemProcessamento.TabIndex = 2;
            this.lbMensagemProcessamento.Text = "Importando registros...";
            this.lbMensagemProcessamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bsAtividades
            // 
            this.bsAtividades.DataMember = "dtAtividades";
            // 
            // bsProdutosSugeridos
            // 
            this.bsProdutosSugeridos.DataMember = "ProdutosSugeridosAtividade";
            this.bsProdutosSugeridos.Filter = "";
            // 
            // bsConComodos
            // 
            this.bsConComodos.DataMember = "dtComodos";
            this.bsConComodos.Sort = "";
            // 
            // bsConAtividadesComodo
            // 
            this.bsConAtividadesComodo.DataMember = "AtividadesComodo";
            // 
            // bsConProdutosAtividade
            // 
            this.bsConProdutosAtividade.DataMember = "ProdutosAtividadesComodo";
            // 
            // ucRelatorios
            // 
            this.ucRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRelatorios.Location = new System.Drawing.Point(3, 3);
            this.ucRelatorios.Name = "ucRelatorios";
            this.ucRelatorios.Size = new System.Drawing.Size(870, 354);
            this.ucRelatorios.TabIndex = 0;
            this.ucRelatorios.SelectedIndexChanged += new cobOpus.Componentes.ucGerenciadorRelatorios.OnSelectedIndexChanged(this.ucGerenciadorRelatorios_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 410);
            this.ContextMenuStrip = this.cmsFuncoes;
            this.Controls.Add(this.tcPrincipal);
            this.Controls.Add(this.pnProcessamento);
            this.Controls.Add(this.msControle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opus 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tpControle.ResumeLayout(false);
            this.scControle.Panel1.ResumeLayout(false);
            this.scControle.Panel1.PerformLayout();
            this.scControle.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scControle)).EndInit();
            this.scControle.ResumeLayout(false);
            this.ssTotalizadorComodo.ResumeLayout(false);
            this.ssTotalizadorComodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConComodos)).EndInit();
            this.scControleSub.Panel1.ResumeLayout(false);
            this.scControleSub.Panel2.ResumeLayout(false);
            this.scControleSub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scControleSub)).EndInit();
            this.scControleSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConAtividades)).EndInit();
            this.ssTotalizador.ResumeLayout(false);
            this.ssTotalizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosAtividades)).EndInit();
            this.tpCadastros.ResumeLayout(false);
            this.scCadastros.Panel1.ResumeLayout(false);
            this.scCadastros.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCadastros)).EndInit();
            this.scCadastros.ResumeLayout(false);
            this.scSuperior.Panel1.ResumeLayout(false);
            this.scSuperior.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSuperior)).EndInit();
            this.scSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.scInferior.Panel1.ResumeLayout(false);
            this.scInferior.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInferior)).EndInit();
            this.scInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosSugeridos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.msControle.ResumeLayout(false);
            this.msControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.cmsFuncoes.ResumeLayout(false);
            this.pnProcessamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsAtividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProdutosSugeridos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConComodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConAtividadesComodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConProdutosAtividade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpControle;
        private System.Windows.Forms.TabPage tpCadastros;
        private System.Windows.Forms.MenuStrip msControle;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalvar;
        private System.Windows.Forms.ToolStripMenuItem tsmiFechar;
        private System.Windows.Forms.SplitContainer scControle;
        private System.Windows.Forms.DataGridView dgvConComodos;
        private System.Windows.Forms.SplitContainer scControleSub;
        private System.Windows.Forms.DataGridView dgvConAtividades;
        private System.Windows.Forms.DataGridView dgvProdutosAtividades;
        private System.Windows.Forms.StatusStrip ssTotalizador;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalAtividade;
        private System.Windows.Forms.SplitContainer scCadastros;
        private System.Windows.Forms.SplitContainer scSuperior;
        private System.Windows.Forms.DataGridView dgvComodos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.SplitContainer scInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn deAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlAtividadeOrcado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdProdAtividadeSug;
        private System.Windows.Forms.DataGridViewComboBoxColumn nmProdutoAtiv;
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.DataGridView dgvProdutosSugeridos;
        private System.Windows.Forms.BindingSource bsAtividades;
        private System.Windows.Forms.BindingSource bsProdutosSugeridos;
        private System.Data.DataSet dsPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdComodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmComodo;
        private System.Windows.Forms.ToolStripTextBox tstbImportacao;
        private System.Windows.Forms.Timer tmStatus;
        private System.Windows.Forms.BindingSource bsConComodos;
        private System.Windows.Forms.BindingSource bsConAtividadesComodo;
        private System.Windows.Forms.StatusStrip ssTotalizadorComodo;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalComodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlProduto;
        private System.Windows.Forms.DataGridViewComboBoxColumn deUnidadeMedida;
        private System.Windows.Forms.ToolStripTextBox tstbTotalObra;
        private System.Windows.Forms.ToolStripTextBox tstbBaseDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdComodoAtividadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAtividadeProd;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdProdutoAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlProdutoAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn deConUnidadeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nuQtdProdutoAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlTotal;
        private System.Windows.Forms.BindingSource bsConProdutosAtividade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdComodoCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmComodoCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdComodoAtividade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckbContabilizaAtividade;
        private System.Windows.Forms.DataGridViewComboBoxColumn cdAtividadeComodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlAtividadeComodo;
        private System.Windows.Forms.ContextMenuStrip cmsFuncoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportarComodos;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportarProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportarAtividades;
        private System.Windows.Forms.Panel pnProcessamento;
        private System.Windows.Forms.ProgressBar pbProgresso;
        private System.Windows.Forms.Label lbMensagemProcessamento;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.ToolStripTextBox tstbStatus;
        private System.Windows.Forms.TabPage tabPage1;
        private Componentes.ucGerenciadorRelatorios ucRelatorios;
    }
}

