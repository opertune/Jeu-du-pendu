/**
 * Jeu du Pendu
 * Date 26/01/2020
 * Author : Romain
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace btnWinForms
{
    public partial class Form1 : Form
    {
        // Déclaration
        private char[] tAlpha = new char[26];
        string motachercher, tirets;
        int erreur = 1;
        public Form1()
        {
            InitializeComponent();
        }
        /**
         * Module création des boutons dans la groupe box
         */
        private void aButton()
        {
            int k = 0, xPos = 0, yPos = 15;
            // Boucle sur la création des 26 boutons
            while (k < tAlpha.Length)
            {
                // Remplissage du tableau avec l'alphabet
                tAlpha[k] = (char)('A' + k);
                // Création d'un bouton
                Button btn = new Button();
                grpButton.Controls.Add(btn);
                btn.Size = new Size(25, 25);
                btn.Location = new Point((xPos*25)+5, yPos);
                btn.Text = tAlpha[k].ToString(); // Attribue un caractère à chaque bouton
                grpButton.Controls[k].Enabled = false; // Désactive les boutons
                k++;
                xPos++;
                if (k == 9 || k == 18)
                {
                    xPos = 0;
                    yPos += 25;
                }
                btn.Click += new System.EventHandler(btnAlplha_Click); // Evenement clic sur un bouton
            }
        }
        /**
         * Evenement clic sur un bouton de l'alphabet
         * Action quand un clic est effectué sur un bouton
         */
         private void btnAlplha_Click(object sender, EventArgs e)
        {
            // Si le mot ne contient pas la lettre saisie on affiche l'image du pendu
            if (!motachercher.Contains(((Button)sender).Text.ToLower()))
            {
                mauvaiseLettre();
            }
            else // Sinon on recherche la position de la lettre dans le mot pour remplacer le tiret
            {
                bonneLettre(((Button)sender).Text.ToLower());
            }
            ((Button)sender).Enabled = false; // Désactivation de la lettre utilisé
            resultat(); // Vérification si le joueur a gagné ou perdu
        }
        /**
         * Module bonneLettre
         * Contient la fonction qui affiche les bonnes lettre dans la texte box
         */
        private void bonneLettre(string lettre)
        {
            for (int k = 0; k < motachercher.Length; k++)
            {
                // Recherche de la position de la lettre dans le mot d'origine
                if (lettre == motachercher.Substring(k, 1))
                {
                    tirets = tirets.Remove(k, 1).Insert(k, lettre); // Supprime le tiret à la position k et le remplace par la bonne / les bonnes lettre(s)
                    txtMot.Text = tirets; // Affichage la ligne de tirets avec les lettres à la bonne position
                }
            }
        }
        /**
         * Module mauvaiseLettre
         * Contient la fonction qui affiche les images du pendu si la lettre est incorrect
         */
        private void mauvaiseLettre()
        {
            pctPendu.ImageLocation = Application.StartupPath + "/../../Resources/pendu" + erreur + ".png";
            erreur++;
        }
        /**
         * Module resultat
         * Affiche si le joueur à gagné ou perdu
         */
         private void resultat()
        {
            if(pctPendu.ImageLocation == Application.StartupPath + "/../../Resources/pendu10.png")
            {
                lblResultat.Text = "PERDU";
                txtMot.BackColor = Color.Red;
                txtMot.Text = motachercher;
                btnRetry.Focus();
                for(int k = 0; k < tAlpha.Length; k++)
                {
                    grpButton.Controls[k].Enabled = false;
                }
            }
            else
            {
                if(txtMot.Text == motachercher)
                {
                    lblResultat.Text = "GAGNE";
                    txtMot.BackColor = Color.LightGreen;
                    btnRetry.Focus();
                    for (int k = 0; k < tAlpha.Length; k++)
                    {
                        grpButton.Controls[k].Enabled = false;
                    }
                }
            }
        }
        /**
         * Evenement initialisation de la fenetre
         * Affiche les 26 boutons avec l'alphabet
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            aButton();
        }

        /**
         * Evenement click sur le bouton rejouer
         * Remise à 0 du jeu
         */
        private void btnRetry_Click(object sender, EventArgs e)
        {
            txtMot.Clear(); // Reset de la zone de saisie du mot
            txtMot.BackColor = Color.Empty;
            lblResultat.Text = ""; // Reset de resultat
            txtMot.Enabled = true; // Activation de la zone de saisie
            // Reset de l'image
            pctPendu.ImageLocation = Application.StartupPath + "/../../Resources/pendu0.png";
            // Reset du nombre d'erreur
            erreur = 1;
        }

        /**
        * Evenement d'une touche pressée dans la zone de saisie
        * Controle du mot saisie
        */
        private void txtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                // Controle de la saisie
                if ((txtMot.Text.Length < 1) || System.Text.RegularExpressions.Regex.IsMatch(txtMot.Text, "[^a-z]"))
                {
                    e.Handled = true;
                    // Affichage du message d'erreur
                    MessageBox.Show("Le mot ne doit comporter que des lettres alphabétiques (pas d'espace, pas d'accent, pas de majuscule)");
                    txtMot.Clear(); // Reset de la txtbox
                    txtMot.Focus(); // Refocus sur la txtbox
                }
                else
                {
                    e.Handled = false;
                    motachercher = txtMot.Text;
                    // Si la saisie est bonne les lettres sont remplacé par des tirets et les boutons sont déverrouillés
                    string s = null;
                    for (int k = 0; k < txtMot.Text.Length; k++)
                    {
                        s += "-";
                    }
                    txtMot.Text = s; // Affichage des tirets dans la txtbox
                    tirets = s; // Récupération des tirets dans une variable différente
                    txtMot.Enabled = false; // Désactivation de la zone de saisie
                    // Activation des boutons avec les lettres
                    for (int k = 0; k < tAlpha.Length; k++)
                    {
                        grpButton.Controls[k].Enabled = true;
                    }
                }
            }
        }
    }
}
