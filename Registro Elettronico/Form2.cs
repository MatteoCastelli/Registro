using System;
using System.Windows.Forms;
using static Registro_Elettronico.Form1;

namespace Registro_Elettronico
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2(Studente studente, Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            lblNome.Text = studente.Nome;
            lblCognome.Text = studente.Cognome;
            lblClasse.Text = studente.Classe;
            lblDataNascita.Text = studente.Data_nascita.ToString("dd/MM/yyyy");
            lblLuogoNascita.Text = studente.Luogo_nascita;
            lblMatricola.Text = studente.Matricola.ToString(); 
            lblInformatica.Text = string.Join("     ", studente.Voti["Informatica"]); 
            lblInglese.Text = string.Join("     ", studente.Voti["Inglese"]);
            lblItaliano.Text = string.Join("     ", studente.Voti["Italiano"]);
            lblStoria.Text = string.Join("     ", studente.Voti["Storia"]);
            lblTele.Text = string.Join("     ", studente.Voti["Telecomunicazioni"]);
            lblTpsit.Text = string.Join("     ", studente.Voti["Tpsit"]);
            lblSistemi.Text = string.Join("     ", studente.Voti["Sistemi e Reti"]);
            lblMatematica.Text = string.Join("     ", studente.Voti["Matematica"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }
    }
}
