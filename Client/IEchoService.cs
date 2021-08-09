using System.ServiceModel;

namespace Client
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string text);
    }
}
