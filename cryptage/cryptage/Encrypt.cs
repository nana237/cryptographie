using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptage
{
    class Encrypt
    {
        private int modelEncrypt;


        public int ModelEncrypt
        {
            get { return modelEncrypt; }
            set { modelEncrypt = value; }
        }

        public string convertirEnLettre(int a) {
            // conversion en lettre
            string b = "";
            switch (a)
            {
                case 1: b = "A";
                    break;
                case 2: b = "B";
                    break;
                case 3: b = "C";
                    break;
                case 4: b = "D";
                    break;
                case 5: b = "E";
                    break;
                case 6: b = "F";
                    break;
                case 7: b = "G";
                    break;
                case 8: b = "H";
                    break;
                case 9: b = "I";
                    break;
                case 10: b = "J";
                    break;
                case 11: b = "K";
                    break;
                case 12: b = "L";
                    break;
                case 13: b = "M";
                    break;
                case 14: b = "N";
                    break;
                case 15: b = "O";
                    break;
                case 16: b = "P";
                    break;
                case 17: b = "Q";
                    break;
                case 18: b = "R";
                    break;
                case 19: b = "S";
                    break;
                case 20: b = "T";
                    break;
                case 21: b = "U";
                    break;
                case 22: b = "V";
                    break;
                case 23: b = "W";
                    break;
                case 24: b = "X";
                    break;
                case 25: b = "Y";
                    break;
                case 26: b = "Z";
                    break;
               
                default: b = "";
                    
                    break;
            }
            return b;
        }

        public int convertirEnChiffre(string a)
        {
            // conversion en chiffre
            int b = 0;
            switch (a.ToUpper())
            {
                case "A": b = 1;
                    break;
                case "B": b = 2;
                    break;
                case "C": b = 3;
                    break;
                case "D": b = 4;
                    break;
                case "E": b = 5;
                    break;
                case "F": b = 6;
                    break;
                case "G": b = 7;
                    break;
                case "H": b = 8;
                    break;
                case "I": b = 9;
                    break;
                case "J": b = 10;
                    break;
                case "K": b = 11;
                    break;
                case "L": b = 12;
                    break;
                case "M": b = 13;
                    break;
                case "N": b = 14;
                    break;
                case "O": b = 15;
                    break;
                case "P": b = 16;
                    break;
                case "Q": b = 17;
                    break;
                case "R": b = 18;
                    break;
                case "S": b = 19;
                    break;
                case "T": b = 20;
                    break;
                case "U": b = 21;
                    break;
                case "V": b = 22;
                    break;
                case "W": b = 23;
                    break;
                case "X": b = 24;
                    break;
                case "Y": b = 25;
                    break;
                case "Z": b = 26;
                    break;
                default: b = 0;

                    break;
            }

            return b;
        }

        public int changerChiffre(int a, int cle) {
            // changement de la valeur de cette lettre
            int b = 0;
            b = a + cle;
            if (b>26)
            {
                b = b - 26;
            }
            return b;
        }

        public int remettreChiffre(int a, int cle) {
            // recherche de la vrai valeur de cette lettre
            int b = 0;
            b = a - cle;
            if (b<=0)
            {
                b = b + 26;
            }
           
            return b;
        }
        public string encryptCesar(string texteSimple,string cle) {
            // place au cryptage
            int cle_chiffre = convertirEnChiffre(cle);
            int a = 0;
            string b = "",c="";
            string crypter="";

            foreach (char lettre in texteSimple.ToCharArray())
            {
                                c = lettre.ToString().ToUpper();
                // on verifie si ce caractere n'est pas une lettre normale de l'alphabet
                if ((c == "A") || (c == "B") || (c == "C") || (c == "D") || (c == "E") || (c == "F") || (c == "G") || (c == "H") || (c == "I") || (c == "J") || (c == "K") || (c == "L") || (c == "M") || (c == "N") || (c == "O") || (c == "P") || (c == "Q") || (c == "R") || (c == "S") || (c == "T") || (c == "U") || (c == "V") || (c == "W") || (c == "X") || (c == "Y") || (c == "Z"))
                {
                    a = convertirEnChiffre(lettre.ToString());
                    a = changerChiffre(a,cle_chiffre);
                    b = convertirEnLettre(a);
                }
                else
                {
                    b = lettre.ToString();
                }
                crypter = crypter + b.ToLower();
            }

            return crypter;
        }

        public string decrypterCesar(string texteCrypter, string cle) {
            // Place au decryptage
            int cle_chiffre = convertirEnChiffre(cle);
            int a = 0;
            string b = "",c="";
            string simple = "";

            foreach (char lettre in texteCrypter.ToCharArray())
            {
                c = lettre.ToString().ToUpper();
                // on verifie si ce caractere n'est pas une lettre normale de l'alphabet
                if ((c == "A") || (c == "B") || (c == "C") || (c == "D") || (c == "E") || (c == "F") || (c == "G") || (c == "H") || (c == "I") || (c == "J") || (c == "K") || (c == "L") || (c == "M") || (c == "N") || (c == "O") || (c == "P") || (c == "Q") || (c == "R") || (c == "S") || (c == "T") || (c == "U") || (c == "V") || (c == "W") || (c == "X") || (c == "Y") || (c == "Z"))
                {
                    a = convertirEnChiffre(lettre.ToString());
                    a = remettreChiffre(a, cle_chiffre);
                    b = convertirEnLettre(a);
                }
                else
                {
                    b = lettre.ToString();
                }
                
                simple = simple + b.ToLower();
            }

            return simple;
        }
        
    }
}
