using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal28.CODE.DTO
{
    class UsuarioDTO
    {
        private int _id;
        private string _nome;
        private string _telefone;
        private string _rua;
        private string _numero;
        private string bairro;
        private string _cidade;
        private string _estado;
        private string _pais;
        private string _cpf;
        private string _rg;
        private string _datanascimento;
        private string _email;
        private string senha;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Rua { get => _rua; set => _rua = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Pais { get => _pais; set => _pais = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Datanascimento { get => _datanascimento; set => _datanascimento = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
