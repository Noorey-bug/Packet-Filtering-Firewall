using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEMProject
{
    public partial class FormPackets : Form
    {
        private const string packetsFilePath = "C:/Users/user/Desktop/Packets.txt";

        //private readonly object DstIP_Packet_txt;

        public FormPackets()
        {
            InitializeComponent();
            ProtocolcomboBox1.DataSource = Enum.GetValues(typeof(Protocol));

        }

        private void FormPackets_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Viewpakbtn_Click(object sender, EventArgs e)
        {

            try
            {
                PacketListBox.Items.Clear();

                using (StreamReader reader = new StreamReader(packetsFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        PacketListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Savepakbtn_Click(object sender, EventArgs e)
        {
            string sourceIP = SrcIPpak_txt.Text;
            string destinationIP = DstIPpak_txt.Text;
            string sourcePort = SrcPortpak_txt.Text;
            string destinationPort = DstPortpak_txt.Text;
            Protocol protocol = (Protocol)ProtocolcomboBox1.SelectedItem;
            string data = Datapak_txt.Text;
            string timestamp = DateTime.Now.ToString(); // Get current timestamp

            string packetInfo = $"{sourceIP},{destinationIP},{sourcePort},{destinationPort},{protocol},{data},{timestamp}";

            using (StreamWriter writer = File.AppendText(packetsFilePath))
            {
                writer.WriteLine(packetInfo);
            }

            MessageBox.Show("Packet saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear text boxes
            SrcIPpak_txt.Clear();
            DstIPpak_txt.Clear();
            SrcPortpak_txt.Clear();
            DstPortpak_txt.Clear();
            ProtocolcomboBox1.SelectedIndex = 0; // Set ComboBox to default value
            Datapak_txt.Clear();
        }

        private void PacketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            // Clear items in the ListBox
            PacketListBox.Items.Clear();

            // Delete the rules file
            string packetsFilePath = "C:/Users/user/Desktop/Packets.txt"; // Path to the rules file
            if (File.Exists(packetsFilePath))
            {
                File.Delete(packetsFilePath);
                MessageBox.Show("Packets file cleared.", "File Cleared");
            }
            else
            {
                MessageBox.Show("Packets file does not exist.", "File Not Found");
            }
        }
    }
}
