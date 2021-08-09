using System;

namespace IisCoreWcfTest
{
    public class EchoService : IEchoService
    {
        public string Echo(string text)
        {
            Console.WriteLine($"Echo '{text}'");
            return text;
        }
    }
}
