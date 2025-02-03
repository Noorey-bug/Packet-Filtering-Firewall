using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEMProject
{

   
    public class Packets
    {
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public string SourcePort { get; set; }
        public string DestinationPort { get; set; }
        public Protocol Protocol { get; set; }
        public string Data { get; set; }
        public DateTime Timestamp { get; set; }
        public int AppliedRuleNo { get; set; }
        public Decision Decision { get; set; }



        public Packets(string sourceIP, string destinationIP, string sourcePort, string destinationPort, Protocol protocol, string data, DateTime timestamp, int appliedRuleNo, Decision decision)
        {
            SourceIP = sourceIP;
            DestinationIP = destinationIP;
            SourcePort = sourcePort;
            DestinationPort = destinationPort;
            Protocol = protocol;
            Data = data;
            Timestamp = timestamp;
            AppliedRuleNo = appliedRuleNo;
            Decision = decision;
        }

        public override string ToString()
        {
            return $"{SourceIP} -> {DestinationIP} ({Protocol}), Data: {Data}, Timestamp: {Timestamp}";
        }
    }
}
