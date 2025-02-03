using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEMProject
{
    public enum Protocol
    {
        TCP,
        UDP,
        ICMP,
        Other
    }
    public enum Decision
    {
        Allow,
        Deny
    }



    public class Rules
    {
        private static int ruleCount = 0; // Static field to keep track of rule count
        public int Name { get; set; }
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public int SourcePort { get; set; }
        public int DestinationPort { get; set; }
        public Protocol Protocol { get; set; }
        public Decision Decision { get; set; }
        public Rules(string sourceIP, string destinationIP, int sourcePort, int destinationPort, Protocol protocol, Decision decision)
        {
            ruleCount++; // Increment rule count
            Name = ruleCount;
           // Name = name;
            SourceIP = sourceIP;
            DestinationIP = destinationIP;
            SourcePort = sourcePort;
            DestinationPort = destinationPort;
            Protocol = protocol;
            Decision = decision;
        }


        public override string ToString()
        {
            return $"{Name}: {SourceIP} -> {DestinationIP} ({Protocol}), Decision: {Decision}";
        }
    }
    
}
