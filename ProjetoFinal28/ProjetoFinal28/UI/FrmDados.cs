using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoFinal28.CODE.DTO;
using ProjetoFinal28.CODE.BLL;

namespace ProjetoFinal28.UI
{
    public partial class FrmDados : Form
    {
        DadosBLL BLL = new DadosBLL();
        DadosDTO DTO = new DadosDTO();
        public FrmDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO.Lbm = txtLBM.Text;
            DTO.L6 = txtL6.Text;
            DTO.M23 = txtM23.Text;

            BLL.Inserir(DTO);

            txtLBM.Clear();
            txtL6.Clear();
            txtM23.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);
            DTO.Lbm = txtLBM.Text;
            DTO.L6 = txtL6.Text;
            DTO.M23 = txtM23.Text;

            BLL.Alterar(DTO);

            txtId.Clear();
            txtLBM.Clear();
            txtL6.Clear();
            txtM23.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);

            BLL.Excluir(DTO);

            txtId.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLBM.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtL6.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtM23.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void FrmDados_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Listar();
        }
    }
}
