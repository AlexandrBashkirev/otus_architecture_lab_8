
namespace otus_architecture_lab_8
{
    public interface IHandler
    {
        void SetParrent(IHandler parent);
        void Handle(object request);
    }
}
