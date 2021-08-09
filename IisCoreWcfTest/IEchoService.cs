using CoreWCF;

namespace IisCoreWcfTest
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string text);
    }
}
