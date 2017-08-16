using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XML_Picklist_Updater
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void EmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:f.dandrea.lopez@accenture.com?subject=XML Picklist Updater App: Improvement Report");
        }

        private void IconAttributeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://p.yusukekamiyamane.com/");
        }

        private void SpecialThanksLabel_Click(object sender, EventArgs e)
        {
            Form3 easterEgg = new Form3();
            easterEgg.ShowDialog();
        }
    }
}
