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
    public partial class FrmUsuario : Form
    {
        UsuarioBLL BLL = new UsuarioBLL();
        UsuarioDTO DTO = new UsuarioDTO();
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO.Nome = txtNome.Text;
            DTO.Telefone = txtTelefone.Text;
            DTO.Rua = txtRua.Text;
            DTO.Numero = txtNumero.Text;
            DTO.Bairro = txtBairro.Text;
            DTO.Cidade = txtCidade.Text;
            DTO.Estado = txtEstado.Text;
            DTO.Pais = txtPais.Text;
            DTO.Cpf = txtCpf.Text;
            DTO.Rg = txtRg.Text;
            DTO.Datanascimento = dtp1.Text;
            DTO.Email = txtEmail.Text;
            DTO.Senha = txtSenha.Text;

            BLL.Inserir(DTO);

            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);
            DTO.Nome = txtNome.Text;
            DTO.Telefone = txtTelefone.Text;
            DTO.Rua = txtRua.Text;
            DTO.Numero = txtNumero.Text;
            DTO.Bairro = txtBairro.Text;
            DTO.Cidade = txtCidade.Text;
            DTO.Estado = txtEstado.Text;
            DTO.Pais = txtPais.Text;
            DTO.Cpf = txtCpf.Text;
            DTO.Rg = txtRg.Text;
            DTO.Datanascimento = dtp1.Text;
            DTO.Email = txtEmail.Text;
            DTO.Senha = txtSenha.Text;

            BLL.Alterar(DTO);

            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO.Id = int.Parse(txtId.Text);

            BLL.Excluir(DTO);

            txtId.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPais.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtEmail.Clear();
            txtSenha.Clear();

            dataGridView1.DataSource = BLL.Listar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRua.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumero.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEstado.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPais.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCpf.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtRg.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtSenha.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.Listar();
        }
    }
}
