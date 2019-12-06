using Entidade;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicoHostWCF
{
    public class Servico : IServico
    {
        TesteCadastroBO boTesteCadastro;

        public List<EntTesteCadastro>  Consultar(string nome)
        {
            boTesteCadastro = new TesteCadastroBO();
            EntTesteCadastro cliente = new EntTesteCadastro();
            cliente.Nome = nome;
            return boTesteCadastro.BuscarCliente(cliente);
        }

        public List<empresa> listarEmpresas()
        {
            return new aulawcf2Entities().empresa.ToList<empresa>();
        }

        public String inserir(String nome, String endereco, int qtdFuncionarios)
        {
            empresa empresa = new empresa()
            {
                nome = nome,
                endereco = endereco,
                qtdFuncionarios = qtdFuncionarios
            };

            aulawcf2Entities context = new aulawcf2Entities();

            try
            {

            context.empresa.Add(empresa);
            context.SaveChanges();
                return "Empresa salva com sucesso!";
            } catch(Exception e)
            {
                return "Erro ao inserir empresa";
            }

        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
