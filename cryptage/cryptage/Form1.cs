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
namespace cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
                openFileDialog1.CheckFileExists = true;
          
            
            if (openFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                txtSimple.Text = "";
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                txtSimple.Text = sr.ReadToEnd();
                sr.Close();
            }
            
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Fichier texte *.txt|*.txt|Fichier batch *.bat|*.bat";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtCrypter.Text);
                sw.Close();
            }
        }
    }
}
