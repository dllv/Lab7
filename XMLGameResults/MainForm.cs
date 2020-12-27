﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLGameResults
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8)) e.Handled = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Change_btnSaveEnabled();
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            Change_btnSaveEnabled();
        }

        private void Change_btnSaveEnabled()
        {
            if (txtName.Text != "" && txtScore.Text != "") btnSave.Enabled = true;
        }

        private string filename = "../../results.xml";

        private void loadXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            foreach ( XmlNode xmlNode in  xmlRoot)
            {
                string id = "" ; 
                string name = "" ; 
                string score = "";
                if  (xmlNode.Attributes.Count > 0)
                {
                    XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                    if  (attr != null) 
                        id = attr.Value;
                }
                foreach ( XmlNode childNode in  xmlNode.ChildNodes)
                {
                    if  (childNode.Name == "name")
                    { 
                        name = childNode.InnerText.ToString();
                    }
                    if  (childNode.Name == "score") 
                    { 
                        score = childNode.InnerText.ToString(); 
                    } 
                }
                addPlayerToList(id, name, score);
            } 
        }
        private void addPlayerToList(string id, string name, string score)
        {   
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(score);
            listOfPlayers.Items.Add(lvi); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadXml();
        }

        private void addToXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            XmlElement playerElem = xmlDoc.CreateElement("player"); 
            XmlAttribute idAttr = xmlDoc.CreateAttribute("id");
            XmlElement nameElem = xmlDoc.CreateElement("name"); 
            XmlElement scoreElem = xmlDoc.CreateElement("score");
            XmlText idText = xmlDoc.CreateTextNode((xmlRoot.ChildNodes.Count+1).ToString());
            XmlText nameText = xmlDoc.CreateTextNode(txtName.Text); 
            XmlText scoreText = xmlDoc.CreateTextNode(txtScore.Text);
            idAttr.AppendChild(idText);
            nameElem.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);
            playerElem.Attributes.Append(idAttr);
            playerElem.AppendChild(nameElem); 
            playerElem.AppendChild(scoreElem);
            xmlRoot.AppendChild(playerElem);
            xmlDoc.Save(filename);
            string id = (xmlRoot.ChildNodes.Count + 1).ToString();
            string name = txtName.Text; 
            string score = txtScore.Text;
            addPlayerToList(id, name, score);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addToXml();
            txtName.Clear();
            txtScore.Clear();
        }
    }
}