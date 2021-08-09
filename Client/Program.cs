using System;
using System.ServiceModel;

namespace Client
{
    class Program
    {
        private readonly static string _iisAddress = @"http://localhost/iiscorewcftest/basichttp";
        private readonly static string _iisExpressAddress = @"http://localhost:52836/basichttp";
        private readonly static string _iisConsoleAddress = @"http://localhost:5000/basichttp";

        static void Main(string[] args)
        {
            var factory = new ChannelFactory<IEchoService>(new BasicHttpBinding(), new EndpointAddress(_iisAddress));
            factory.Open();
            var channel = factory.CreateChannel();
            ((IClientChannel)channel).Open();
            Console.WriteLine("Echo(\"Hello World\") => " + channel.Echo("Hello World"));
            ((IClientChannel)channel).Close();
            factory.Close();
        }
    }
}
