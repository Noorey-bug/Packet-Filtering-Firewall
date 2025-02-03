using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEMProject
{
    public partial class FormRules : Form

    {


        private const string rulesFilePath = "C:/Users/user/Desktop/Rules.txt";
        private FireWall firewall = new FireWall();
        public FormRules()
        {
            InitializeComponent();
            protocolcomboBox.DataSource = Enum.GetValues(typeof(Protocol));
            allowradioButton.Checked = true;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                RulesListBox.Items.Clear();

                using (StreamReader reader = new StreamReader(rulesFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        RulesListBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SrcPort_lable_Click(object sender, EventArgs e)
        {

        }

        private void SrNo_Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Saverulebtn_Click(object sender, EventArgs e)
        {
            //int ruleName = int.Parse(SrNo_Txt.Text);
            string sourceIP = SrcIP_txt.Text;
            string destinationIP = DstIP_text.Text;
            int sourcePort = int.Parse(SrcPort_txt.Text);
            int destinationPort = int.Parse(DstPort_txt.Text);
            Protocol protocol = (Protocol)protocolcomboBox.SelectedItem;
            Decision decision = allowradioButton.Checked ? Decision.Allow : Decision.Deny;

            //Protocol protocol = (Protocol)Enum.Parse(typeof(Protocol), Protocol_txt.Text);
            // Decision decision = (Decision)Enum.Parse(typeof(Decision), Decision_txt.Text);

            Rules rule = new Rules( sourceIP, destinationIP, sourcePort, destinationPort, protocol, decision);
            SaveRule(rule);
            ClearFields();

        }

        private void SaveRule(Rules rule)
        {
            using (StreamWriter writer = File.AppendText(rulesFilePath))
            {
                writer.WriteLine($"{rule.Name},{rule.SourceIP},{rule.DestinationIP},{rule.SourcePort},{rule.DestinationPort},{rule.Protocol},{rule.Decision}");
            }

            MessageBox.Show("Rules saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
            
            // Clear items in the ListBox
            RulesListBox.Items.Clear();

            // Delete the rules file
            string rulesFilePath = "C:/Users/user/Desktop/Rules.txt"; // Path to the rules file
            if (File.Exists(rulesFilePath))
            {
                File.Delete(rulesFilePath);
                MessageBox.Show("Rules file cleared.", "File Cleared");
            }
            else
            {
                MessageBox.Show("Rules file does not exist.", "File Not Found");
            }
        }
        private void ClearFields()
        {
           // SrNo_Txt.Clear();
            SrcIP_txt.Clear();
            DstIP_text.Clear();
            SrcPort_txt.Clear();
            DstPort_txt.Clear();
            protocolcomboBox.SelectedIndex = 0; // Set ComboBox to default value
            allowradioButton.Checked = true;
        }
    }
}

