using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Net;

namespace XML_Picklist_Updater
{
    public partial class Form1 : Form
    {
        XmlDocument doc1 = new XmlDocument();
        XmlDocument doc2 = new XmlDocument();
        string gitFileName = "";
        string orgFileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void loadGitXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(gitXMLPathTextBox.Text))
                {
                    openFileDialog1.InitialDirectory = gitXMLPathTextBox.Text;
                }
                DialogResult result1 = openFileDialog1.ShowDialog();
                if (result1 == DialogResult.OK)
                {
                    if (openFileDialog1.SafeFileName.EndsWith(".object"))
                    {
                        gitXMLPathTextBox.Text = openFileDialog1.FileName;
                        doc1.Load(gitXMLPathTextBox.Text);
                        gitFileName = openFileDialog1.SafeFileName;
                        Properties.Settings.Default.PathReminderGit = gitXMLPathTextBox.Text.Substring(0, gitXMLPathTextBox.Text.Length - gitFileName.Length);
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Please select an object type component.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    enableSeachButton(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("There was an error in the execution, please restart the app and try again.\nIf the issue persist please reach the dev.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void loadOrgXMLButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(orgXMLPathTextBox.Text))
            {
                openFileDialog2.InitialDirectory = orgXMLPathTextBox.Text;
            }
            DialogResult result2 = openFileDialog2.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                if (openFileDialog2.SafeFileName.EndsWith(".object"))
                {
                    orgXMLPathTextBox.Text = openFileDialog2.FileName;
                    doc2.Load(orgXMLPathTextBox.Text);
                    orgFileName = openFileDialog2.SafeFileName;
                    Properties.Settings.Default.PathReminderEnv = orgXMLPathTextBox.Text.Substring(0, orgXMLPathTextBox.Text.Length - orgFileName.Length);
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Please select an object type component.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                enableSeachButton(sender, e);
            }
        }

        private void analyzeFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkedListBox1.Items.Clear();
                XmlNodeList iNode = doc1.GetElementsByTagName("CustomObject");
                XmlNodeList fNode = ((XmlElement)iNode[0]).GetElementsByTagName("fields");
                foreach (XmlElement fElem in fNode)
                {
                    XmlNodeList eType = fElem.GetElementsByTagName("type");
                    if (eType.Count != 0)
                    {
                        if (eType[0].InnerText == "Picklist" || eType[0].InnerText == "MultiselectPicklist")
                        {
                            if (fElem.GetElementsByTagName("valueSet").Count != 0)
                            {
                                XmlNodeList eFullName = fElem.GetElementsByTagName("fullName");
                                checkedListBox1.Items.Add(eFullName[0].InnerText);
                            }
                        }
                    }
                }
                if (checkedListBox1.Items.Count != 0)
                {
                    MessageBox.Show("Analysis completed!\nPicklists found: " + checkedListBox1.Items.Count, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectLabel.Text = "Selected picklists: 0";
                    createNewXMLButton.Enabled = true;
                    selectAllButton.Enabled = true;
                    unselectAllButton.Enabled = true;
                    checkedListBox1.Enabled = true;
                    CBLCoverImg.Hide();
                }
                else
                {
                    MessageBox.Show("Analysis completed...\nNo picklists were found.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("There was an error in the execution, please restart the app and try again.\nIf the issue persist please reach the dev.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void createNewXMLButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool writefile = true;
                string destFile = "";
                bool failed = false;
                if (srcAsDestCheckBox.Checked)
                {
                    destFile = gitXMLPathTextBox.Text;
                }
                else
                {
                    DialogResult result = folderBrowserDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        destFile = folderBrowserDialog1.SelectedPath + "\\" + gitFileName;
                    }
                }
                if (File.Exists(destFile))
                {
                    DialogResult yesno = MessageBox.Show("The file already exists in that folder.\r\nOverwrite that file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (yesno == DialogResult.No)
                    {
                        writefile = false;
                    }
                }
                if (writefile)
                {
                    XmlNodeList iNode = doc1.GetElementsByTagName("CustomObject");
                    XmlNodeList fNode = ((XmlElement)iNode[0]).GetElementsByTagName("fields");
                    foreach (XmlElement fElem in fNode)
                    {
                        XmlNodeList eType = fElem.GetElementsByTagName("type");
                        if (eType.Count != 0)
                        {
                            if (eType[0].InnerText == "Picklist" || eType[0].InnerText == "MultiselectPicklist")
                            {
                                XmlNodeList eFullName = fElem.GetElementsByTagName("fullName");
                                if (checkedListBox1.CheckedItems.Contains(eFullName[0].InnerText))
                                {
                                    XmlNodeList iiNode = doc2.GetElementsByTagName("CustomObject");
                                    XmlNodeList ffNode = ((XmlElement)iiNode[0]).GetElementsByTagName("fields");
                                    foreach (XmlElement ffElem in ffNode)
                                    {
                                        XmlNodeList eeType = ffElem.GetElementsByTagName("type");
                                        if (eeType.Count != 0)
                                        {
                                            if (eeType[0].InnerText == "Picklist" || eeType[0].InnerText == "MultiselectPicklist")
                                            {
                                                XmlNodeList eeFullName = ffElem.GetElementsByTagName("fullName");
                                                if (eFullName[0].InnerText == eeFullName[0].InnerText)
                                                {
                                                    try
                                                    {
                                                        XmlNode vsNode = fElem.GetElementsByTagName("valueSet")[0];
                                                        XmlNode vvssNode = doc1.ImportNode(ffElem.GetElementsByTagName("valueSet")[0], true);
                                                        fElem.ReplaceChild(vvssNode, vsNode);
                                                    }
                                                    catch
                                                    {
                                                        failed = true;
                                                        MessageBox.Show("Please verify that the files are corresponding to Salesforce API 39", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        break;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    if (failed)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (!failed)
                    {
                        XmlNodeList rNode = ((XmlElement)iNode[0]).GetElementsByTagName("recordTypes");
                        foreach (XmlElement rElem in rNode)
                        {
                            XmlNodeList ePicklistValue = rElem.GetElementsByTagName("picklistValues");
                            foreach (XmlElement pvElem in ePicklistValue)
                            {
                                if (checkedListBox1.CheckedItems.Contains(pvElem.GetElementsByTagName("picklist")[0].InnerText))
                                {
                                    bool brk = false;
                                    XmlNodeList iiNode = doc2.GetElementsByTagName("CustomObject");
                                    XmlNodeList rrNode = ((XmlElement)iiNode[0]).GetElementsByTagName("recordTypes");
                                    foreach (XmlElement rrElem in rrNode)
                                    {
                                        if (rrElem.GetElementsByTagName("fullName")[0].InnerText == rElem.GetElementsByTagName("fullName")[0].InnerText)
                                        {
                                            XmlNodeList eePicklistValue = rrElem.GetElementsByTagName("picklistValues");
                                            foreach (XmlElement ppvvElem in eePicklistValue)
                                            {
                                                if (pvElem.GetElementsByTagName("picklist")[0].InnerText == ppvvElem.GetElementsByTagName("picklist")[0].InnerText)
                                                {
                                                    if (!pvElem.HasChildNodes || !ppvvElem.HasChildNodes)
                                                    {
                                                        MessageBox.Show("Please verify that the files are corresponding to Salesforce API 39", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        brk = true;
                                                        break;
                                                    }
                                                    pvElem.RemoveAll();
                                                    foreach (XmlElement node in ppvvElem)
                                                    {
                                                        XmlNode importNode = doc1.ImportNode(node, true);
                                                        pvElem.AppendChild(importNode);
                                                    }
                                                    brk = true;
                                                    break;
                                                }
                                            }
                                            if (brk)
                                            {
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!failed)
                    {
                        XmlWriterSettings settings = new XmlWriterSettings
                        {
                            Encoding = Encoding.UTF8,
                            Indent = true,
                            IndentChars = "    ",
                            NewLineChars = "\r\n",
                            NewLineHandling = NewLineHandling.Replace,
                            CloseOutput = true
                        };
                        XmlWriter writer = null;
                        writer = XmlWriter.Create(destFile, settings);
                        doc1.Save(writer);
                        writer.Close();
                        string xmlString = System.IO.File.ReadAllText(destFile);
                        string xmlpart1 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                        string xmlpart2 = xmlString.Substring(38, 65);
                        string xmlpart3 = xmlString.Substring(103);
                        string removable1 = "\'";
                        string removable2 = "\"";
                        string removable3 = " />";
                        while (xmlpart3.Contains(removable1))
                        {
                            xmlpart3 = xmlpart3.Replace(removable1, "&apos;");
                        }
                        while (xmlpart3.Contains(removable2))
                        {
                            xmlpart3 = xmlpart3.Replace(removable2, "&quot;");
                        }
                        while (xmlpart3.Contains(removable3))
                        {
                            xmlpart3 = xmlpart3.Replace(removable3, "/>");
                        }
                        using (StreamWriter sw = File.CreateText(destFile))
                        {
                            sw.Write(xmlpart1 + xmlpart2 + xmlpart3);
                            sw.WriteLine("");
                        }
                        MessageBox.Show("Process finished successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error in the execution, please restart the app and try again.\nIf the issue persist please reach the dev.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.ShowDialog();
        }

        private Timer timer1;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Text = "XML Picklist Updater v1.1";
                gitXMLPathTextBox.Text = Properties.Settings.Default.PathReminderGit;
                orgXMLPathTextBox.Text = Properties.Settings.Default.PathReminderEnv;
                timer1 = new Timer();
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Interval = 10; // in miliseconds
                timer1.Start();
                checkedListBox1.Enabled = false;
                try
                {
                    WebClient download = new WebClient();
                    string orig = download.DownloadString("https://raw.githubusercontent.com/fabriziodandrea/myXMLPicklistUpdater/master/XML%20Picklist%20Updater/XML%20Picklist%20Updater/Form1.cs");
                    if (!orig.Contains(Text))
                    {
                        DialogResult result = MessageBox.Show("There is a new version available!\nDownload it now?", "Good News", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start("https://myoffice.accenture.com/personal/f_dandrea_lopez_accenture_com/_layouts/15/guestaccess.aspx?guestaccesstoken=Asizh3G1rOPyFwTvR1jriHV1juDxRvjYrWRwDRX7IGI%3d&docid=2_0d67cf356d8364050b52ff75d5144f36a&rev=1");
                            Close();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please verify your internet connection\n there might be a new version available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("There was an error in the execution, please restart the app and try again.\nIf the issue persist please reach the dev.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkedListBox1.Enabled)
            {
                selectLabel.ForeColor = System.Drawing.Color.Black;
                selectLabel.Text = "Selected picklists: " + checkedListBox1.CheckedItems.Count.ToString();
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //selectLabel.ForeColor = System.Drawing.Color.Black;
            //selectLabel.Text = "Selected picklists: " +  checkedListBox1.CheckedItems.Count.ToString();
        }

        private void enableSeachButton(object sender, EventArgs e)
        {
            if (gitXMLPathTextBox.Text.Trim() != "" && orgXMLPathTextBox.Text.Trim() != "" && gitFileName == orgFileName && gitFileName != "")
            {
                selectLabel.ForeColor = System.Drawing.Color.Black;
                selectLabel.Text = "";
                analyzeFilesButton.Enabled = true;
                createNewXMLButton.Enabled = false;
                selectAllButton.Enabled = false;
                unselectAllButton.Enabled = false;
            }
            else if (gitXMLPathTextBox.Text.Trim() != "" && orgXMLPathTextBox.Text.Trim() != "" && gitFileName != orgFileName && (gitFileName == "" || orgFileName == ""))
            {
                selectLabel.ForeColor = System.Drawing.Color.Black;
                selectLabel.Text = "";
                analyzeFilesButton.Enabled = false;
                createNewXMLButton.Enabled = false;
                checkedListBox1.Enabled = false;
                selectAllButton.Enabled = false;
                unselectAllButton.Enabled = false;
            }
            else if (gitXMLPathTextBox.Text.Trim() != "" && orgXMLPathTextBox.Text.Trim() != "" && gitFileName != orgFileName && (gitFileName != "" && orgFileName != ""))
            {
                selectLabel.ForeColor = System.Drawing.Color.Red;
                selectLabel.Text = "Files should match.";
                analyzeFilesButton.Enabled = false;
                createNewXMLButton.Enabled = false;
                checkedListBox1.Enabled = false;
                selectAllButton.Enabled = false;
                unselectAllButton.Enabled = false;
            }
            else
            {
                selectLabel.ForeColor = System.Drawing.Color.Black;
                selectLabel.Text = "";
                analyzeFilesButton.Enabled = false;
                createNewXMLButton.Enabled = false;
                selectAllButton.Enabled = false;
                unselectAllButton.Enabled = false;
            }

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void unselectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }
    }
}
