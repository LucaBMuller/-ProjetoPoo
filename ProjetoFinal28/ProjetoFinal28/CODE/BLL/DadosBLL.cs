using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ProjetoFinal28.CODE.DAL;
using ProjetoFinal28.CODE.DTO;

namespace ProjetoFinal28.CODE.BLL
{
    class DadosBLL
    {
        Conexao x = new Conexao();
        string tabela = "dados";

        public void Inserir(DadosDTO DTO)
        {
            string inserir = $"insert into {tabela} values(null, '{DTO.Lbm}', '{DTO.L6}', '{DTO.M23}')";
            x.ExecutarComando(inserir);
        }

        public void Alterar(DadosDTO DTO)
        {
            string alterar = $@"update {tabela} set lbm = '{DTO.Lbm}',
                                l6 ='{DTO.L6}',
                                m23 ='{DTO.M23}' where id ='{DTO.Id}';";
            x.ExecutarComando(alterar);
        }

        public void Excluir(DadosDTO DTO)
        {
            string excluir = $"delete from {tabela} where id = {DTO.Id}";
            x.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string listar = $"select * from {tabela} order by id";
            return x.ExecutarConsulta(listar);
        }
    }
}
