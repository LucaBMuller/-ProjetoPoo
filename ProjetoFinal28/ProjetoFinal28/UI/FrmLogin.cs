using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoFinal28.CODE.DTO;
using ProjetoFinal28.CODE.BLL;
using ProjetoFinal28.UI;

namespace ProjetoFinal28
{
    public partial class FrmLogin : Form
    {
        UsuarioBLL BLL = new UsuarioBLL();
        UsuarioDTO DTO = new UsuarioDTO();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DTO.Email = txtEmail.Text;
            DTO.Cpf = txtCpf.Text;
            DTO.Senha = txtSenha.Text;

            if (BLL.Log(DTO) == true)
            {
                FrmOpcoes frmOpcoes = new FrmOpcoes();
                frmOpcoes.ShowDialog();
        
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }
    }
}
