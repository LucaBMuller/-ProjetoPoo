using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ProjetoFinal28.CODE.DAL;
using ProjetoFinal28.CODE.DTO;

namespace ProjetoFinal28.CODE.BLL
{
    class UsuarioBLL
    {
        Conexao x = new Conexao();
        string tabela = "usuarios";

        public void Inserir(UsuarioDTO DTO)
        {
            string inserir = $"insert into {tabela} values(null, '{DTO.Nome}', '{DTO.Telefone}', '{DTO.Rua}', '{DTO.Numero}', '{DTO.Bairro}', '{DTO.Cidade}', '{DTO.Estado}', '{DTO.Pais}', '{DTO.Cpf}', '{DTO.Rg}', '{DTO.Datanascimento}', '{DTO.Email}', '{DTO.Senha}')";
            x.ExecutarComando(inserir);
        }

        public void Alterar(UsuarioDTO DTO)
        {
            string alterar = $@"update {tabela} set nome = '{DTO.Nome}',
                                telefone ='{DTO.Telefone}',
                                rua ='{DTO.Rua}',
                                numero ='{DTO.Numero}',
                                bairro ='{DTO.Bairro}',
                                cidade ='{DTO.Cidade}',
                                estado ='{DTO.Estado}',
                                pais ='{DTO.Pais}',
                                cpf ='{DTO.Cpf}',
                                rg ='{DTO.Rg}',
                                dataNascimento ='{DTO.Datanascimento}',
                                email ='{DTO.Email}',
                                senha ='{DTO.Senha}' where id ='{DTO.Id}';";
            x.ExecutarComando(alterar);
        }

        public void Excluir(UsuarioDTO DTO)
        {
            string excluir = $"delete from {tabela} where id = {DTO.Id}";
            x.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return x.ExecutarConsulta(listar);
        }

        public bool Log(UsuarioDTO DTO)
        {
            string sql = $"select * from {tabela} where email ='{DTO.Email}' and senha ='{DTO.Senha}' and cpf ='{DTO.Cpf}'";
            DataTable dt = x.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
