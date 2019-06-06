using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;

namespace CreaPW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void btEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Verifica()
        {
            pbVocali.Image = CreaPW.Properties.Resources.uncheck;
            pbConsonanti.Image = CreaPW.Properties.Resources.uncheck;
            pbNumeri.Image = CreaPW.Properties.Resources.uncheck;
            pbMaiuscole.Image = CreaPW.Properties.Resources.uncheck;
            pbMinuscole.Image = CreaPW.Properties.Resources.uncheck;
            pbSpeciali.Image = CreaPW.Properties.Resources.uncheck;
            
            string password = tbFinale.Text;
            char[] vocali = new char[] { 'a', 'e', 'i', 'o', 'u', 'à', 'è', 'é', 'ì', 'ò', 'ù', 'y'};
            char[] numeri = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] consonanti = new char[] { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};

            lbLunghezza.Text = "Lunghezza: " + Convert.ToString(password.Length);
            pbLunghezza.Value = password.Length;

            foreach (char lettera in password)
            {
                // MAIUSCOLE
                if (Char.IsLower(lettera))
                {
                    pbMinuscole.Image = CreaPW.Properties.Resources.check;
                }
                else if (Char.IsUpper(lettera))
                {
                    pbMaiuscole.Image = CreaPW.Properties.Resources.check;
                }
                
                // VOCALI
                if (vocali.Contains(Char.ToLower(lettera)))
                {
                    pbVocali.Image = CreaPW.Properties.Resources.check;
                    continue;
                }

                // CONSONANTI
                if (consonanti.Contains(Char.ToLower(lettera)))
                {
                    pbConsonanti.Image = CreaPW.Properties.Resources.check;
                    continue;
                }

                // NUMERI
                if (numeri.Contains(Char.ToLower(lettera)))
                {
                    pbNumeri.Image = CreaPW.Properties.Resources.check;
                    continue;
                }

                // CARATTERI SPECIALI
                if (!((numeri.Contains(lettera)) & (consonanti.Contains(Char.ToLower(lettera))) & (vocali.Contains(Char.ToLower(lettera))) ))
                {
                    pbSpeciali.Image = CreaPW.Properties.Resources.check;
                    continue;
                }
            }    
        }


        private void btCrea_Click(object sender, EventArgs e)
        {
            // dichiarazione variabili
            string indirizzo = tbIndirizzo.Text;
            string matrice = tbMatrice.Text.Trim();
            tbUtente.Text = tbUtente.Text.ToLower();
            tbUtente.Text = tbUtente.Text.Replace(" ", string.Empty);
            matrice = matrice.Replace(" ", string.Empty);
            tbMatrice.Text = matrice;
            indirizzo = indirizzo.Replace(" ", string.Empty);
            
            // verifica iniziale
            if (indirizzo.Length < 3)
                tbFinale.Text = "Inserire l'indirizzo web del sito";
            else
            {
                // se la verifica iniziale è passata calcola in base alla matrice
                
                // tolgo gli spazi vuoti iniziali e finali
                indirizzo = indirizzo.Trim();
                
                // trasformo l'indirizzo in minuscolo
                indirizzo = indirizzo.ToLower();
                
                // controllo che non sia stato inserito www.
                int indiceWWW = indirizzo.IndexOf("www.");
                if (indiceWWW != -1)
                    indirizzo = indirizzo.Substring(indiceWWW+4,indirizzo.Length-indiceWWW-4);
                
                int indicePrimoPunto = indirizzo.IndexOf(".");
                if (indicePrimoPunto != -1)
                    indirizzo = indirizzo.Substring(0, indicePrimoPunto);
                
                using (MD5 md5Hash = MD5.Create())
                {
                    indirizzo = GetMd5Hash(md5Hash, indirizzo);
                }

                string password = indirizzo.Substring(0,3) + tbUtente.Text.Trim() + matrice;
                tbPassword.Text = password;
                
                using (MD5 md5Hash = MD5.Create())
                {
                    tbMD5.Text = GetMd5Hash(md5Hash, password);
                }

                char[] vocali = new char[] { 'a', 'e', 'i', 'o', 'u', 'à', 'è', 'é', 'ì', 'ò', 'ù', 'y'};
                char[] numeri = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                char[] consonanti = new char[] { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};

                string finale = "";

                foreach (char lettera in password)
                {
                    
                    // VOCALI
                    if (vocali.Contains(Char.ToLower(lettera)))
                    {
                        int indice = Array.IndexOf(vocali, Char.ToLower(lettera));
                        if(indice != -1)
                        {
                            if (indice + 1 >= vocali.Length)
                                indice = 0;
                            else
                                indice = indice + 1;
                            // Controlla se è maiuscolo o minuscolo e mettilo nella stessa situazione
                            if (char.IsLower(lettera))
                                finale = finale + vocali[indice];
                            else
                                finale = finale + char.ToUpper(vocali[indice]);
                            continue;
                        }
                    }

                    // NUMERI
                    if (numeri.Contains(Char.ToLower(lettera)))
                    {
                        int indice = Array.IndexOf(numeri, Char.ToLower(lettera));
                        if (indice != -1)
                        {
                            if (indice + 1 >= numeri.Length)
                                indice = 0;
                            else
                                indice = indice + 1;
                            finale = finale + numeri[indice];
                            continue;
                        }
                    }

                    // CONSONANTI
                    if (consonanti.Contains(Char.ToLower(lettera)))
                    {
                        int indice = Array.IndexOf(consonanti, Char.ToLower(lettera));
                        if (indice != -1)
                        {
                            if (indice + 1 >= consonanti.Length)
                                indice = 0;
                            else
                                indice = indice + 1;
                            // Controlla se è maiuscolo o minuscolo e mettilo nella stessa situazione
                            if (char.IsLower(lettera))
                                finale = finale + consonanti[indice];
                            else
                                finale = finale + char.ToUpper(consonanti[indice]);
                            continue;
                        }
                    }

                    // ALTRI CARATTERI - COPIATI
                    finale = finale + lettera;
                }

                int lunghezza = finale.Length;
                int lunghezzaMD5 = 1;

                if (lunghezza < 16)
                {
                    lunghezzaMD5 = 16 - lunghezza;
                }

                Debug.WriteLine("----------------------------");
                Debug.WriteLine("Password intera   : " + finale);
                
                if (lunghezza>15)
                    finale = finale.Substring(0, 15) + tbMD5.Text.Substring(0, lunghezzaMD5);
                else
                    finale = finale + tbMD5.Text.Substring(0, lunghezzaMD5);

                Debug.WriteLine("Password tagliata : " + finale);

                // SOSTITUZIONE DELLA PRIMA CON L'ULTIMA LETTERA
                lunghezza = finale.Length;
                string[] testo = new string[lunghezza+1];
                string[] mixato = new string[lunghezza+1];

                //Debug.WriteLine("Password non mixata : " + finale);
                //Debug.WriteLine("Lunghezza :" + lunghezza);

                // trasformo la string in array
                for (int i = 0; i < lunghezza; i++)
                {
                    testo[i] = finale[i].ToString();
                }

                // faccio il mix
                for (int i = 0; i<=((lunghezza)/2); i++)
                {
                    if(!((i%2) == 0))
                    { 
                        mixato[i] = testo[lunghezza - i-1];
                        mixato[lunghezza - i-1] = testo[i];
                    }
                    else
                    {
                        //Debug.WriteLine("indice {0}, carattere non mixato {1}", i, testo[i]);
                        mixato[i] = testo[i];
                        mixato[lunghezza - i-1] = testo[lunghezza - i-1];
                    }
                }

                finale = String.Join("", mixato);

                // Aggiungi almeno una maiuscola
                bool soloMinuscole = true;
                foreach (char lettera in finale)
                {
                    if (char.IsUpper(lettera))
                        soloMinuscole = false;
                }
                if (soloMinuscole==true)
                { 
                    int primaMinuscola = finale.IndexOfAny("qwertyuiopasdfghjklzxcvbnm".ToCharArray());
                    Debug.WriteLine("indice prima minuscola {0}", primaMinuscola );
                    if ((primaMinuscola != -1) & (primaMinuscola > 0))
                        finale = finale.Substring(0, primaMinuscola -1) + char.ToUpper(finale[primaMinuscola]) + finale.Substring(primaMinuscola + 1);
                    else if (primaMinuscola == 0)
                        finale = char.ToUpper(finale[primaMinuscola]) + finale.Substring(primaMinuscola + 1);
                    else if (primaMinuscola == lunghezza)
                        finale = finale.Substring(0, primaMinuscola - 1) + char.ToUpper(finale[primaMinuscola]);
                }

                tbFinale.Text = finale;
                if(finale!="")
                    System.Windows.Forms.Clipboard.SetText(finale);

                Verifica();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CreaPW.Properties.Settings .Default .Registra  == "OK")
            {
                chbRegistra.Checked = true;
                tbIndirizzo.Text=CreaPW.Properties.Settings.Default.Sito;
                tbUtente.Text = CreaPW.Properties.Settings.Default.Utente;
                tbMatrice.Text = CreaPW.Properties.Settings.Default.Matrice;
            }
            else
                chbRegistra.Checked = false;
        }

        private void chbRegistra_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRegistra.Checked)
               CreaPW.Properties.Settings.Default.Registra  = "OK";
            else
               CreaPW.Properties.Settings.Default.Registra = "NO";
            
            // Ricordarsi di salvare i settings
            CreaPW.Properties.Settings.Default.Save( );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CreaPW.Properties.Settings.Default.Registra == "OK")
            {
                CreaPW.Properties.Settings.Default.Sito = tbIndirizzo.Text;
                CreaPW.Properties.Settings.Default.Utente = tbUtente.Text;
                CreaPW.Properties.Settings.Default.Matrice = tbMatrice.Text;

                // Ricordarsi di salvare i settings
                CreaPW.Properties.Settings.Default.Save();
            }
        }
    }
}
