using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Registro_Elettronico.Form1;

namespace Registro_Elettronico
{
    public partial class Form3 : Form
    {
        private GestioneDati gestioneDati;
        private Form1 form1;
        private string materia;

        public Form3(Form1 form1, string materia)
        {
            InitializeComponent();
            gestioneDati = new GestioneDati();
            this.form1 = form1;
            this.materia = materia;
        }

        private void GeneraPannelliStudenti(string classe, string materia)
        {
            pHome.Hide();
            List<Studente> studenti = gestioneDati.CaricaStudenti();
            List<Studente> studentiClasse = studenti.FindAll(s => s.Classe == classe);

            Label lblTitolo = new Label
            {
                Text = $"REGISTRO DELLA CLASSE {classe}",
                Font = new Font("Segoe UI", 35, FontStyle.Bold),
                Location = new Point(500, 25),
                Tag = "panelStudenti",
                AutoSize = true
            };

            Button backButton = new Button
            {
                Text = "BACK",
                Size = new Size(180, 70),
                Location = new Point(17, 18),
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                Tag = "panelStudenti",
                BackColor = Color.Linen,
            };

            backButton.Click += (sender, e) =>
            {
                pHome.Show();
                canellaElementi();
            };

            Controls.Add(lblTitolo);
            Controls.Add(backButton);

            int y = 150;
            int n = 1;

            foreach (var studente in studentiClasse)
            {

                Panel panel = new Panel
                {
                    BackColor = Color.Linen,
                    Size = new Size(1200, 100),
                    Location = new Point(200, y),
                    Tag = "panelStudenti"
                };

                Label lblNomeStudente = new Label
                {
                    Text = $"{n}      {studente.Nome} {studente.Cognome} {studente.Data_nascita:dd/MM/yyyy}",
                    Location = new Point(30, 30),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 20, FontStyle.Bold)
                };

                Button btnDettagli = new Button
                {
                    Text = "DETTAGLI",
                    Location = new Point(1000, 25),
                    Size = new Size(140, 50),
                    Font = new Font("Segoe UI", 15, FontStyle.Bold)
                };

                y += panel.Height + 10;
                n++;

                panel.Controls.Add(btnDettagli);
                panel.Controls.Add(lblNomeStudente);
                Controls.Add(panel);

                btnDettagli.Click += (sender, e) =>
                {
                    canellaElementi();

                    Button backButton2 = new Button
                    {
                        Text = "BACK",
                        Size = new Size(180, 70),
                        Location = new Point(17, 18),
                        Font = new Font("Segoe UI", 15, FontStyle.Bold),
                        Tag = "panelStudenti",
                        BackColor = Color.Linen,
                    };

                    backButton2.Click += (s, ev) =>
                    {
                        canellaElementi();
                        RimuoviPannelliVoti();
                        GeneraPannelliStudenti(studente.Classe, materia);
                    };

                    Panel panel2 = new Panel
                    {
                        BackColor = Color.Linen,
                        Width = ClientSize.Width,
                        Height = 100,
                        Location = new Point(0, 0),
                        Tag = "panelStudenti",
                    };

                    Label lblDettagliStudente = new Label
                    {
                        Text = $"Nome: {studente.Nome} {studente.Cognome}     Classe: {studente.Classe}    Data di nascita: {studente.Data_nascita.ToString("dd/MM/yyyy")}     Luogo di nascita: {studente.Luogo_nascita}     Matricola: {studente.Matricola}",
                        Location = new Point(250, 40),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 15)
                    };

                    panel2.Controls.Add(backButton2);
                    panel2.Controls.Add(lblDettagliStudente);
                    Controls.Add(panel2);

                    Panel panel3 = new Panel
                    {
                        BackColor = Color.Linen,
                        Size = new Size(400, 150),
                        Location = new Point(200, 200),
                        Tag = "panelStudenti"
                    };

                    Label votiStudente = new Label
                    {
                        Text = $"Voti di {materia}: ",
                        Location = new Point(10, 30),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 20, FontStyle.Bold)
                    };

                    Label votiStudente2 = new Label
                    {
                        Text = "Clicca un voto per modificarlo",
                        Location = new Point(10, votiStudente.Bottom + 30),
                        AutoSize = true,
                        Width = votiStudente.Width,
                        Font = new Font("Segoe UI", 10)
                    };

                    panel3.Controls.Add(votiStudente2);
                    panel3.Controls.Add(votiStudente);
                    Controls.Add(panel3);

                    Panel panel4 = new Panel
                    {
                        Size = new Size(200, 50),
                        Location = new Point(200, panel3.Bottom + 30),
                        Tag = "panelStudenti",
                        BackColor = Color.Linen,
                    };

                    Label aggiungi = new Label
                    {
                        Text = "Aggiungi un voto",
                        AutoSize = true,
                        Location = new Point(15, 15),
                        Font = new Font("Segoe UI", 14, FontStyle.Bold)
                    };

                    panel4.Controls.Add(aggiungi);
                    Controls.Add(panel4);

                    
                    aggiungi.Click += (s, ev) =>
                    {
                        string nuovoVoto = Interaction.InputBox("Inserisci un nuovo voto");

                        if (decimal.TryParse(nuovoVoto, out decimal votoModificato) && votoModificato >= 1 && votoModificato <= 10)
                        {
                            studente.Voti[materia].Add(votoModificato);
                            gestioneDati.SalvaStudenti(studenti);
                            RimuoviPannelliVoti();
                            GeneraPannelliVoti(studente, materia, studenti);
                        }
                        else
                        {
                            MessageBox.Show("Inserisci un voto valido da 1 a 10.");
                        }
                    };
                    
                    GeneraPannelliVoti(studente, materia, studenti);
                };
            }

            
        }

        private void GeneraPannelliVoti(Studente studente, string materia, List<Studente> studenti)
        {
            int y = 200; 

            for (int i = 0; i < studente.Voti[materia].Count; i++)
            {

                decimal voto = studente.Voti[materia][i];

                Panel panelVoto = new Panel
                {
                    BackColor = Color.Linen,
                    Size = new Size(300, 50),
                    Location = new Point(650, y),
                    Tag = "panelVoto"
                };

                Label lblVoto = new Label
                {
                    Text = voto.ToString("N2"),
                    Location = new Point(10, 15),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12),  
                };

                panelVoto.Controls.Add(lblVoto);
                Controls.Add(panelVoto);
                y += 60;

                int index = i;
                panelVoto.Click += (s, ev) =>
                {
                    string nuovoVoto = Interaction.InputBox("Inserisci il voto modificato\nInserire uno spazio vuoto per eliminare", voto.ToString());

                    if (nuovoVoto == " ")
                    {
                        studente.Voti[materia].RemoveAt(index);
                        gestioneDati.SalvaStudenti(studenti);
                        
                        RimuoviPannelliVoti();
                        GeneraPannelliVoti(studente, materia, studenti);
                    }
                    else if (decimal.TryParse(nuovoVoto, out decimal votoModificato) && votoModificato >= 1 && votoModificato <= 10)
                    {
                        studente.Voti[materia][index] = votoModificato;
                        gestioneDati.SalvaStudenti(studenti);
                        lblVoto.Text = votoModificato.ToString("N2");
                    }
                    else MessageBox.Show("Inserisci un voto valido da 1 a 10.");
                };
            }
        }

        private void RimuoviPannelliVoti() { for (int i = Controls.Count - 1; i >= 0; i--) if (Controls[i].Tag?.ToString() == "panelVoto") Controls.Remove(Controls[i]);}
        
        void canellaElementi() {for (int i = Controls.Count - 1; i >= 0; i--) if (Controls[i].Tag?.ToString() == "panelStudenti") Controls.Remove(Controls[i]);}

        private void p3cii_Click(object sender, System.EventArgs e) => GeneraPannelliStudenti("3CII", materia);

        private void p4cii_Click(object sender, System.EventArgs e) => GeneraPannelliStudenti("4CII", materia);

        private void p5cii_Click(object sender, System.EventArgs e) => GeneraPannelliStudenti("5CII", materia);

        private void button1_Click(object sender, System.EventArgs e)
        {
            form1.Show();
            Hide();
        }
    }
}