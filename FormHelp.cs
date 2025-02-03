using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SEMProject
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void Rulebtn_Click(object sender, EventArgs e)
        {
            //Hide(); // Hide the current form
            FormRules rulesForm = new FormRules();
            rulesForm.FormClosed += (s, args) => Show(); // Show the current form when RulesForm is closed
            rulesForm.Show();
        }

        private void Pacetbtn_Click(object sender, EventArgs e)
        {
           // Hide(); // Hide the current form
            FormPackets rulesForm = new FormPackets();
            rulesForm.FormClosed += (s, args) => Show(); // Show the current form when RulesForm is closed
            rulesForm.Show();
        }

        private void Firewallbtn_Click(object sender, EventArgs e)
        {
            //Hide(); // Hide the current form
            FormFirewall rulesForm = new FormFirewall();
            rulesForm.FormClosed += (s, args) => Show(); // Show the current form when RulesForm is closed
            rulesForm.Show();
        }

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            Hide(); // Hide the current form
            FormHelp rulesForm = new FormHelp();
            rulesForm.FormClosed += (s, args) => Show(); // Show the current form when RulesForm is closed
            rulesForm.Show();
        }
    }
}
