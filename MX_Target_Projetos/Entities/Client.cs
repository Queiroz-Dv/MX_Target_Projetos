using MX_Target_Projetos.Core;

namespace MX_Target_Projetos.Entities
{
    public class Client : Base
    {
        public Client(string name, string phone, string cpf)
        {
            Name = name;
            Phone = phone;
            CPF = cpf;
        }

        public Client()
        { }
    }
}
