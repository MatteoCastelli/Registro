using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Registro_Elettronico
{
    public partial class Form1 : Form
    {
        private GestioneDati gestioneDati;

        public Form1()
        {
            InitializeComponent();
            gestioneDati = new GestioneDati();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginDocente.Hide();
            loginStudente.Hide();
            Controls.Add(loginDocente);
            Controls.Add(loginStudente);
            Controls.Add(pHome);
        }

        public class Studente
        {
            public int Matricola { get; set; }
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public DateTime Data_nascita { get; set; }
            public string Luogo_nascita { get; set; }
            public string Classe { get; set; }
            public Dictionary<string, List<decimal>> Voti { get; set; }
        }

        private void imgDocente_Click(object sender, EventArgs e)
        {
            loginDocente.Show();
            pHome.Hide();
        }

        private void imgStudente_Click(object sender, EventArgs e)
        {
            loginStudente.Show();
            pHome.Hide();
        }

        private void btnBackDocente_Click(object sender, EventArgs e)
        {
            loginDocente.Hide();
            pHome.Show();
            usernameDocente.Text = string.Empty;
            passwordDocente.Text = string.Empty;
        }

        private void btnBackStudente_Click(object sender, EventArgs e)
        {
            loginStudente.Hide();
            pHome.Show();
            usernameStudente.Text = string.Empty;
            passwordStudente.Text = string.Empty;
        }

        public class GestioneDati
        {
            public string filePath = "students.json";

            public List<Studente> CaricaStudenti()
            {
                if (!File.Exists(filePath)) return new List<Studente>();
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<Studente>>(json);
            }

            public void SalvaStudenti(List<Studente> studenti)
            {
                string json = JsonConvert.SerializeObject(studenti, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
        }

        private void btnLoginStudente_Click(object sender, EventArgs e)
        {
            string usrnStudente = usernameStudente.Text.Trim();
            string psswrdStudente = passwordStudente.Text.Trim();
            
            List<Studente> studenti = gestioneDati.CaricaStudenti();
            var studente = studenti.Find(s => s.Nome.Equals(usrnStudente) && s.Matricola.ToString() == psswrdStudente);

            if (studente != null)
            {
                MessageBox.Show("accesso effettuatuo");
                Form2 secondForm = new Form2(studente, this);
                secondForm.Show();
                usernameStudente.Text = string.Empty;
                passwordStudente.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Username e/o Password non validi.\nRiprova.");
            }
        }

        private void btnLoginDocente_Click(object sender, EventArgs e)
        {
            string usrnDocente = usernameDocente.Text.Trim();
            string psswrdDocente = passwordDocente.Text.Trim();

            string credenziali = usrnDocente + "_" + psswrdDocente;

            switch (credenziali)
            {
                case "Docente_passwordInformatica":
                    MessageBox.Show("Accesso effettuato come docente di Informatica.");
                    Form3 thirdForm = new Form3(this, "Informatica");
                    thirdForm.Show();
                    break;
                case "Docente_passwordInglese":
                    MessageBox.Show("Accesso effettuato come docente di Inglese.");
                    Form3 thirdFormEnglish = new Form3(this, "Inglese");
                    thirdFormEnglish.Show();
                    break;
                case "Docente_passwordItaliano":
                    MessageBox.Show("Accesso effettuato come docente di Italiano.");
                    Form3 thirdFormItalian = new Form3(this, "Italiano");
                    thirdFormItalian.Show();
                    break;
                case "Docente_passwordStoria":
                    MessageBox.Show("Accesso effettuato come docente di Storia.");
                    Form3 thirdFormHistory = new Form3(this, "Storia");
                    thirdFormHistory.Show();
                    break;
                case "Docente_passwordTelecomunicazioni":
                    MessageBox.Show("Accesso effettuato come docente di Telecomunicazioni.");
                    Form3 thirdFormTele = new Form3(this, "Telecomunicazioni");
                    thirdFormTele.Show();
                    break;
                case "Docente_passwordTpsit":
                    MessageBox.Show("Accesso effettuato come docente di Tpsit.");
                    Form3 thirdFormTpsit = new Form3(this, "Tpsit");
                    thirdFormTpsit.Show();
                    break;
                case "Docente_passwordSistemi":
                    MessageBox.Show("Accesso effettuato come docente di Sistemi e Reti.");
                    Form3 thirdFormSistemi = new Form3(this, "Sistemi e Reti");
                    thirdFormSistemi.Show();
                    break;
                case "Docente_passwordMatematica":
                    MessageBox.Show("Accesso effettuato come docente di Matematica.");
                    Form3 thirdFormMath = new Form3(this, "Matematica");
                    thirdFormMath.Show();
                    break;
                default:
                    MessageBox.Show("Username e/o Password non validi.\nRiprova.");
                    break;
            }

            usernameDocente.Text = string.Empty;
            passwordDocente.Text = string.Empty;

        }
    }
}