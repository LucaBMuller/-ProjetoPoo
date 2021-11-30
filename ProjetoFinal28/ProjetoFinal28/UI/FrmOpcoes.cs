using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal28.UI
{
    public partial class FrmOpcoes : Form
    {
        public FrmOpcoes()
        {
            InitializeComponent();
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            FrmDados frmDados = new FrmDados();
            frmDados.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
