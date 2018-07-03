using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobOpus.Componentes
{
    public partial class ucGerenciadorRelatorios : UserControl
    {
        public DataTable dtDados;
        public string sXValueMember;
        public string sYValueMembers;
        public int nTipoRelatorio;

        public delegate void OnSelectedIndexChanged(object sender, EventArgs e);
        public event OnSelectedIndexChanged SelectedIndexChanged;

        public ucGerenciadorRelatorios()
        {
            InitializeComponent();
        }

        private void lsAvancados_SelectedIndexChanged(object sender, EventArgs e)
        {
            nTipoRelatorio = lsAvancados.SelectedIndex;

            if (SelectedIndexChanged != null)
                SelectedIndexChanged(sender, e);

            cGrafico.Series[0].IsValueShownAsLabel = true;
            cGrafico.Series[0].XValueMember = sXValueMember;
            cGrafico.Series[0].YValueMembers = sYValueMembers;

            cGrafico.Visible = false;
            if (dtDados != null)
                cGrafico.Visible = true;
            cGrafico.DataSource = dtDados;
        }
    }
}
