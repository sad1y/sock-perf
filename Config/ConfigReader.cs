using System.Net.Sockets;
using System.Threading.Tasks;

namespace SockPerf.Config
{
    public class ConfigReader : IConfigReader
    {
        public Task<Scenario> GetScenario(string name)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IConfigReader
    {
        Task<Scenario> GetScenario(string name);
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Scenario
    {
        public string Host;
        public string Port;
        public string Name;
        public ProtocolType ProtocolType;

        public Step[] Steps;
    }

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Step
    {
        public string Name;
        public int WorkersCount;
        public byte[][] Payload;
        public int? MinAwaitBefore;
        public int? MaxAwaitBefore;
        public int? MinAwaitAfter;
        public int? MaxAwaitAfter;
    }
}