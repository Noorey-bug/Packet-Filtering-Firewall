using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SEMProject
{
    internal class FireWall
    {
        private List<Rules> rules = new List<Rules>();

        public void AddRule(Rules rule)
        {
            rules.Add(rule);
        }

        //using list container to temporarily store rules from file
        public List<Rules> LoadRulesFromFile(string filePath)
        {
            List<Rules> rules = new List<Rules>();

            try
            {
                // Read rules from file and add them to the list
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine($"Total lines read from rules file: {lines.Length}");
                foreach (string line in lines)
                {
                    Console.WriteLine($"Parsing line: {line}");
                    string[] parts = line.Split(',');

                    if (parts.Length == 7)
                    {
                        // Parsing each part to construct a Rule object
                        int name = int.Parse(parts[0]);
                        string sourceIP = parts[1];
                        string destinationIP = parts[2];
                        int sourcePort = int.Parse(parts[3]); // Parse as integer
                        int destinationPort = int.Parse(parts[4]); // Parse as integer
                        Protocol protocol = (Protocol)Enum.Parse(typeof(Protocol), parts[5], true);
                        Decision decision = (Decision)Enum.Parse(typeof(Decision), parts[6], true);

                        // Add the rule to the list
                        rules.Add(new Rules(sourceIP, destinationIP, sourcePort, destinationPort, protocol, decision));
                    }
                    else
                    {
                        Console.WriteLine($"Error: Invalid rule format at line: {line}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading rules: {ex.Message}");
            }

            return rules;
        }


        //Again using List container to temporarily store packet file
        public List<Packets> LoadPacketsFromFile(string filePath)
        {
            List<Packets> packets = new List<Packets>();

            try
            {
                // Read packets from file and add them to the list
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine($"Total lines read from packets file: {lines.Length}");
                foreach (string line in lines)
                {
                    Console.WriteLine($"Parsing line: {line}");
                    // Parsing each part to construct a Packet object
                    string[] parts = line.Split(',');

                    if (parts.Length == 7) // Adjusted to match the expected number of fields
                    {
                        // Parsing the fields from the packet file
                        string sourceIP = parts[0].Trim();
                        string destinationIP = parts[1].Trim();
                        int sourcePort = int.Parse(parts[2].Trim()); // Parse as integer
                        int destinationPort = int.Parse(parts[3].Trim()); // Parse as integer
                        Protocol protocol = (Protocol)Enum.Parse(typeof(Protocol), parts[4].Trim(), true);
                        string data = parts[5].Trim();
                        DateTime timestamp;

                        // Parsing timestamp, assuming it's in the format "M/d/yyyy h:mm:ss tt"
                        if (DateTime.TryParseExact(parts[6].Trim(), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out timestamp))
                        {
                            // Add the packet to the list
                            packets.Add(new Packets(sourceIP, destinationIP, sourcePort.ToString(), destinationPort.ToString(), protocol, data, timestamp, -1, Decision.Allow));
                        }
                        else
                        {
                            // Timestamp parsing failed
                            Console.WriteLine($"Error parsing timestamp at line: {line}");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while loading packets: {ex.Message}");
            }

            return packets;
        }



        //Apply method to match rules and packets
        public int ApplyRules(Packets packet, List<Rules> rules)
        {
            foreach (var rule in rules)
            {
                if (compareIP(rule.SourceIP, packet.SourceIP) &&
                    compareIP(rule.DestinationIP, packet.DestinationIP) &&
                    (rule.SourcePort == 0 || rule.SourcePort.ToString() == packet.SourcePort) &&
                    (rule.DestinationPort == 0 || rule.DestinationPort.ToString() == packet.DestinationPort) &&
                    rule.Protocol == packet.Protocol)
                {
                    packet.Decision = rule.Decision;
                    packet.AppliedRuleNo = rule.Name;
                    return 0;
                }
            }

            // If no matching rule is found, set the decision to default (Assuming Decision.Allow) and return 1
            packet.Decision = Decision.Allow;
            packet.AppliedRuleNo = -1; // Or any other default value you prefer
            return 1; // No matching rule found
        }


        //Temporary function to check wether my function is wokring or not 
        private void AppendToFile(string filePath, string title, IEnumerable<object> items)
        {
            File.AppendAllText(filePath, title + Environment.NewLine);
            foreach (var item in items)
            {
                File.AppendAllText(filePath, item.ToString() + Environment.NewLine);
            }
            File.AppendAllText(filePath, Environment.NewLine);
        }


        //this function is 
        private bool compareIP(string ruleIP, string packetIP)
        {
            if (ruleIP.Contains("/"))
            {
                // Subnet matching
                string[] parts = ruleIP.Split('/');
                string baseIP = parts[0];
                int subnetMaskLength = int.Parse(parts[1]);

                // Convert IPs to binary representation
                uint ruleIPBinary = IPToUInt32(baseIP);
                uint packetIPBinary = IPToUInt32(packetIP);

                // Calculate the subnet mask
                uint mask = ~(uint.MaxValue >> subnetMaskLength);

                // Apply the subnet mask and compare
                return (ruleIPBinary & mask) == (packetIPBinary & mask);
            }
            else if (ruleIP.Contains("-"))
            {
                // IP range matching
                string[] parts = ruleIP.Split('-');
                string startIP = parts[0].Trim();
                string endIP = parts[1].Trim();

                // Convert IPs to binary representation
                uint startIPBinary = IPToUInt32(startIP);
                uint endIPBinary = IPToUInt32(endIP);
                uint packetIPBinary = IPToUInt32(packetIP);

                // Check if packetIP is within the range
                return packetIPBinary >= startIPBinary && packetIPBinary <= endIPBinary;
            }
            else
            {
                // Exact IP match or wildcard
                return ruleIP == "0.0.0.0" || ruleIP.Equals(packetIP, StringComparison.OrdinalIgnoreCase);
            }
        }

        private uint IPToUInt32(string ipAddress)
        {
            byte[] bytes = System.Net.IPAddress.Parse(ipAddress).GetAddressBytes();
            Array.Reverse(bytes); // Convert to big-endian
            return BitConverter.ToUInt32(bytes, 0);
        }



    }
}

