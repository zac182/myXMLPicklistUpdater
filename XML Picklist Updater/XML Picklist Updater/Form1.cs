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

namespace XML_Picklist_Updater
{
    public partial class Form1 : Form
    {
        XmlDocument doc1 = new XmlDocument();
        XmlDocument doc2 = new XmlDocument();
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = openFileDialog1.ShowDialog();
            if (result1 == DialogResult.OK)
            {
                doc1.Load(openFileDialog1.FileName);
                DialogResult result2 = openFileDialog1.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    button2.Enabled = true;
                    filename = openFileDialog1.SafeFileName;
                    label1.Text = filename;
                    doc2.Load(openFileDialog1.FileName);
                    XmlNodeList iNode = doc1.GetElementsByTagName("CustomObject");
                    XmlNodeList fNode = ((XmlElement)iNode[0]).GetElementsByTagName("fields");
                    foreach (XmlElement fElem in fNode)
                    {
                        XmlNodeList eType = fElem.GetElementsByTagName("type");
                        if (eType[0].InnerText == "Picklist" || eType[0].InnerText == "MultiselectPicklist")
                        {
                            XmlNodeList eFullName = fElem.GetElementsByTagName("fullName");
                            checkedListBox1.Items.Add(eFullName[0].InnerText);
                        }
                    }
                }
                else
                {
                    button2.Enabled = false;
                    label1.Text = "No File Selected";
                    checkedListBox1.Items.Clear();
                }
            }
            else
            {
                button2.Enabled = false;
                label1.Text = "No File Selected";
                checkedListBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                XmlNodeList iNode = doc1.GetElementsByTagName("CustomObject");
                XmlNodeList fNode = ((XmlElement)iNode[0]).GetElementsByTagName("fields");
                foreach (XmlElement fElem in fNode)
                {
                    XmlNodeList eType = fElem.GetElementsByTagName("type");
                    if (eType[0].InnerText == "Picklist" || eType[0].InnerText == "MultiselectPicklist")
                    {
                        XmlNodeList eFullName = fElem.GetElementsByTagName("fullName");
                        if (checkedListBox1.CheckedItems.Contains(eFullName[0].InnerText))
                        {
                            XmlNodeList iiNode = doc2.GetElementsByTagName("CustomObject");
                            XmlNodeList ffNode = ((XmlElement)iiNode[0]).GetElementsByTagName("fields");
                            foreach (XmlElement ffElem in fNode)
                            {
                                XmlNodeList eeType = ffElem.GetElementsByTagName("type");
                                if (eeType[0].InnerText == "Picklist" || eeType[0].InnerText == "MultiselectPicklist")
                                {
                                    XmlNodeList eeFullName = ffElem.GetElementsByTagName("fullName");
                                    if (eFullName[0].InnerText == eeFullName[0].InnerText)
                                    {
                                        fElem.ReplaceChild(ffElem.GetElementsByTagName("picklist")[0], fElem.GetElementsByTagName("picklist")[0]);
                                    }
                                }
                            }
                        }
                    }
                }
                XmlNodeList rNode = ((XmlElement)iNode[0]).GetElementsByTagName("recordTypes");
                foreach (XmlElement rElem in rNode)
                {
                    XmlNodeList ePicklistValue = rElem.GetElementsByTagName("picklistValues");
                    foreach(XmlElement pvElem in ePicklistValue)
                    {
                        if (checkedListBox1.CheckedItems.Contains(pvElem.GetElementsByTagName("picklist")[0].InnerText))
                        {
                            XmlNodeList iiNode = doc2.GetElementsByTagName("CustomObject");
                            XmlNodeList rrNode = ((XmlElement)iiNode[0]).GetElementsByTagName("recordTypes");
                            foreach (XmlElement rrElem in rrNode)
                            {
                                XmlNodeList eePicklistValue = rrElem.GetElementsByTagName("picklistValues");
                                foreach (XmlElement ppvvElem in eePicklistValue)
                                {
                                    if (pvElem.GetElementsByTagName("picklist")[0].InnerText == ppvvElem.GetElementsByTagName("picklist")[0].InnerText)
                                    {
                                        doc1.ReplaceChild(ppvvElem, pvElem);
                                    }
                                }
                            }
                        }
                    }
                }
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
                writer = XmlWriter.Create(folderBrowserDialog1.SelectedPath + "\\" + filename, settings);
                doc1.Save(writer);
                writer.Close();
                string xmlString = System.IO.File.ReadAllText(folderBrowserDialog1.SelectedPath + "\\" + filename);
                string xmlpart1 = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
                string xmlpart2 = xmlString.Substring(38);
                using (StreamWriter sw = File.CreateText(folderBrowserDialog1.SelectedPath + "\\" + filename))
                {
                    sw.Write(xmlpart1 + xmlpart2);
                    sw.WriteLine("");
                }
            }
        }
    }
}
