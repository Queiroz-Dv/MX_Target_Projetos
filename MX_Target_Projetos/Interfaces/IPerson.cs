using MX_Target_Projetos.ValueObjects;

namespace MX_Target_Projetos.Interfaces
{
    public interface IPerson
    {
        void SetName(Name name);
        void SetAge(int age);
        void SetPhone(string phone);
        void SetDocument(Document document);
        void Save();
    }
}
