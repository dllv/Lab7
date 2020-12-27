using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfig
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbBorderStyle.Text = Properties.Settings.Default.BorderStyle.ToString();
            chbMinimized.Checked = Properties.Settings.Default.Minimize;
            chbMaximized.Checked = Properties.Settings.Default.Maximize;
            lblBackColor.Text = Properties.Settings.Default.BackColor.Name;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings formSettings = Properties.Settings.Default;

            formSettings.BackColor = this.BackColor; 
            formSettings.BorderStyle = this.FormBorderStyle;
            formSettings.Minimize = this.MinimizeBox;
            formSettings.Maximize = this.MaximizeBox;
            formSettings.Font = this.Font;
            
            formSettings.Save();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBorderStyle.SelectedIndex)
            {
                case 0:
                    FormBorderStyle = FormBorderStyle.None;
                    break;
                case 1:
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case 4:
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 5:
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
            }
        }

        private void chbMinimized_CheckedChanged(object sender, EventArgs e)
        {
            MinimizeBox = chbMaximized.Checked;
        }

        private void chbMaximized_CheckedChanged(object sender, EventArgs e)
        {
            MaximizeBox = chbMaximized.Checked;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                BackColor = colorDialog1.Color;
                lblBackColor.Text = colorDialog1.Color.Name;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font = fontDialog1.Font;
                btnFont.Text = fontDialog1.Font.Name;
            }
        }
    }
}
