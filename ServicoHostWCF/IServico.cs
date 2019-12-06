using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServicoHostWCF
{
    [ServiceContract]
    public interface IServico
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        List<EntTesteCadastro> Consultar(string nome);
    }
}
