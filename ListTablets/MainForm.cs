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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ListTablets
{
    public partial class MainForm : Form
    {
        private string filename = "tablets.dat";
        private List<Tablet> Tablets = new List<Tablet>();
        private int current = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            tbModel.Clear();
            tbDiagonal.Clear();
            tbOS.Clear();
            tbMemory.Clear();
            tbStorage.Clear();
            tbCPU.Clear();
            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void AddTablet()
        {
            Tablet buf = new Tablet();
            string[] TabletInfo = new string[6];
            TabletInfo[0] = tbModel.Text;
            TabletInfo[1] = tbDiagonal.Text;
            TabletInfo[2] = tbOS.Text;
            TabletInfo[3] = tbMemory.Text;
            TabletInfo[4] = tbStorage.Text;
            TabletInfo[5] = tbCPU.Text;

            buf.SetStringValues(TabletInfo);
            Tablets.Add(buf); 
        }

        private void SaveFile()
        {
            BinaryFormatter bf = new   BinaryFormatter(); 
            try  
            {
                using ( FileStream fs = new   FileStream(filename,  FileMode.OpenOrCreate, FileAccess.Write))  
                {              
                    bf.Serialize(fs, Tablets);
                } 
            } 
            catch ( IOException ex) 
            { 
                MessageBox.Show("Ошибка ввода-вывода: "   + ex.ToString()); 
            }
            catch ( SerializationException ex)
            {
                MessageBox.Show("Ошибка сериализации: "   + ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddTablet();
            SaveFile();
            current = Tablets.Count-1;
            btnSave.Visible = false;
            btnCancel.Visible = false; 
            MessageBox.Show("Запись добавлена"); 
        }

        private void TabletToTextBoxes(int current)
        {
            if (Tablets.Count > 0)
            { 
                string[] TabletInfo = Tablets[current].GetStringValues();
                tbModel.Text = TabletInfo[0]; 
                tbDiagonal.Text = TabletInfo[1]; 
                tbOS.Text = TabletInfo[2];
                tbMemory.Text = TabletInfo[3];
                tbStorage.Text = TabletInfo[4]; 
                tbCPU.Text = TabletInfo[5]; 
            }
            else
            {
                tbModel.Clear();
                tbDiagonal.Clear(); 
                tbOS.Clear();
                tbMemory.Clear();
                tbStorage.Clear(); 
                tbCPU.Clear(); 
            }
        }
        private void ScrollTablet(sbyte inc)
        {
            if ((current + inc <= Tablets.Count - 1) && (current + inc >= 0))
            {
                current += inc;
                TabletToTextBoxes(current);
            }
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            ScrollTablet(-1);
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            ScrollTablet(1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false; 
            TabletToTextBoxes(current);
        }
        private void DeleteTablet()
        {
            Tablets.RemoveAt(current); 
            if  (current > 0)
                current--; 
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (Tablets.Count > 0) 
                { 
                DeleteTablet();
                if  (Tablets.Count == 0) 
                {
                    tbModel.Clear(); 
                    tbDiagonal.Clear();
                    tbOS.Clear();
                    tbMemory.Clear(); 
                    tbStorage.Clear();
                    tbCPU.Clear(); 
                } 
                else
                { 
                    TabletToTextBoxes(current);
                } 
                SaveFile(); 
                MessageBox.Show("Запись удалена");
            }       
        }
    }
}