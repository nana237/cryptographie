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
    public partial class btnOuvrirFichier : Form
    {
        Encrypt E = new Encrypt(); // variable de type Encrypt
        public btnOuvrirFichier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCrypter.Clear(); //vidage du textbox
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            // ouverture d'un nouveau fichier
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
            // enregistrement du fichier
            saveFileDialog1.Filter = "Fichier texte *.txt|*.txt|Fichier batch *.bat|*.bat";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtCrypter.Text);
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // cryptage avec cesar
            txtCrypter.Text = E.encryptCesar(txtSimple.Text, txtCle.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // decryptage cesar
            txtSimple.Text = E.decrypterCesar(txtCrypter.Text, txtCle.Text);
        }

        private void btnCrypter_Click(object sender, EventArgs e)
        {
            // vidage du textbox
            txtSimple.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ouverture d'un fichier
            openFileDialog1.CheckFileExists = true;


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtCrypter.Text = "";
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                txtCrypter.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
