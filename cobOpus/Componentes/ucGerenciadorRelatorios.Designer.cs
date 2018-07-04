namespace cobOpus.Componentes
{
    partial class ucGerenciadorRelatorios
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.scRlatorios = new System.Windows.Forms.SplitContainer();
            this.lsAvancados = new System.Windows.Forms.ListBox();
            this.tcResultado = new System.Windows.Forms.TabControl();
            this.tpGrafico = new System.Windows.Forms.TabPage();
            this.cGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tpRelatorio = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.scRlatorios)).BeginInit();
            this.scRlatorios.Panel1.SuspendLayout();
            this.scRlatorios.Panel2.SuspendLayout();
            this.scRlatorios.SuspendLayout();
            this.tcResultado.SuspendLayout();
            this.tpGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // scRlatorios
            // 
            this.scRlatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRlatorios.Location = new System.Drawing.Point(0, 0);
            this.scRlatorios.Name = "scRlatorios";
            // 
            // scRlatorios.Panel1
            // 
            this.scRlatorios.Panel1.Controls.Add(this.lsAvancados);
            // 
            // scRlatorios.Panel2
            // 
            this.scRlatorios.Panel2.Controls.Add(this.tcResultado);
            this.scRlatorios.Size = new System.Drawing.Size(762, 433);
            this.scRlatorios.SplitterDistance = 227;
            this.scRlatorios.TabIndex = 0;
            // 
            // lsAvancados
            // 
            this.lsAvancados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsAvancados.FormattingEnabled = true;
            this.lsAvancados.Items.AddRange(new object[] {
            "Atividades",
            "Comodos",
            "Produtos",
            "Atividades por cômodos",
            "Produtos por cômodos ",
            "Produtos por atividades"});
            this.lsAvancados.Location = new System.Drawing.Point(0, 0);
            this.lsAvancados.Name = "lsAvancados";
            this.lsAvancados.Size = new System.Drawing.Size(227, 433);
            this.lsAvancados.TabIndex = 7;
            this.lsAvancados.SelectedIndexChanged += new System.EventHandler(this.lsAvancados_SelectedIndexChanged);
            // 
            // tcResultado
            // 
            this.tcResultado.Controls.Add(this.tpGrafico);
            this.tcResultado.Controls.Add(this.tpRelatorio);
            this.tcResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcResultado.Location = new System.Drawing.Point(0, 0);
            this.tcResultado.Name = "tcResultado";
            this.tcResultado.SelectedIndex = 0;
            this.tcResultado.Size = new System.Drawing.Size(531, 433);
            this.tcResultado.TabIndex = 0;
            // 
            // tpGrafico
            // 
            this.tpGrafico.Controls.Add(this.cGrafico);
            this.tpGrafico.Location = new System.Drawing.Point(4, 22);
            this.tpGrafico.Name = "tpGrafico";
            this.tpGrafico.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrafico.Size = new System.Drawing.Size(523, 407);
            this.tpGrafico.TabIndex = 1;
            this.tpGrafico.Text = "Gráfico";
            this.tpGrafico.UseVisualStyleBackColor = true;
            // 
            // cGrafico
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 5;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 10;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.LabelStyle.Format = "C2";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea";
            this.cGrafico.ChartAreas.Add(chartArea1);
            this.cGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legenda";
            this.cGrafico.Legends.Add(legend1);
            this.cGrafico.Location = new System.Drawing.Point(3, 3);
            this.cGrafico.Name = "cGrafico";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.CustomProperties = "BarLabelStyle=Outside";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C2";
            series1.Legend = "Legenda";
            series1.MarkerSize = 0;
            series1.Name = "Total";
            this.cGrafico.Series.Add(series1);
            this.cGrafico.Size = new System.Drawing.Size(517, 401);
            this.cGrafico.TabIndex = 1;
            this.cGrafico.Visible = false;
            // 
            // tpRelatorio
            // 
            this.tpRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tpRelatorio.Name = "tpRelatorio";
            this.tpRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatorio.Size = new System.Drawing.Size(523, 407);
            this.tpRelatorio.TabIndex = 0;
            this.tpRelatorio.Text = "Relatório";
            this.tpRelatorio.UseVisualStyleBackColor = true;
            // 
            // ucGerenciadorRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scRlatorios);
            this.Name = "ucGerenciadorRelatorios";
            this.Size = new System.Drawing.Size(762, 433);
            this.scRlatorios.Panel1.ResumeLayout(false);
            this.scRlatorios.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRlatorios)).EndInit();
            this.scRlatorios.ResumeLayout(false);
            this.tcResultado.ResumeLayout(false);
            this.tpGrafico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpGrafico;
        public System.Windows.Forms.ListBox lsAvancados;
        public System.Windows.Forms.SplitContainer scRlatorios;
        public System.Windows.Forms.TabControl tcResultado;
        public System.Windows.Forms.TabPage tpRelatorio;
        public System.Windows.Forms.DataVisualization.Charting.Chart cGrafico;
    }
}
