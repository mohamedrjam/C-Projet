using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Fiche_Stagiaire
{
    public partial class Frm_StagiaireBTS : Form
    {
        DataTable dt = new DataTable();
        int index = -1;
        public Frm_StagiaireBTS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (btn_Nouveau.Image != null) btn_Nouveau.Image = new Bitmap(btn_Nouveau.Image, new Size(24, 24));
            if (btn_Ajouter.Image != null) btn_Ajouter.Image = new Bitmap(btn_Ajouter.Image, new Size(24, 24));
            if (btn_Supprimer.Image != null) btn_Supprimer.Image = new Bitmap(btn_Supprimer.Image, new Size(24, 24));
            if (btn_Effacer.Image != null) btn_Effacer.Image = new Bitmap(btn_Effacer.Image, new Size(24, 24));
            if (btn_Recherche.Image != null) btn_Recherche.Image = new Bitmap(btn_Recherche.Image, new Size(24, 24));
            if (btn_Imprimer.Image != null) btn_Imprimer.Image = new Bitmap(btn_Imprimer.Image, new Size(24, 24));
            if (btn_Fermer.Image != null) btn_Fermer.Image = new Bitmap(btn_Fermer.Image, new Size(24, 24));
            if (btn_haut.Image != null) btn_haut.Image = new Bitmap(btn_haut.Image, new Size(24, 24));
            if (btn_bas.Image != null) btn_bas.Image = new Bitmap(btn_bas.Image, new Size(24, 24));
            if (btn_Enregistrer.Image != null) btn_Enregistrer.Image = new Bitmap(btn_Enregistrer.Image, new Size(24, 24));
            if (cmb_Specialite.Items.Count == 0)
            {
                cmb_Specialite.Items.AddRange(new string[] { "Sciences Maths", "PC", "SVT", "Technique" });
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Nouveau_Click(object sender, EventArgs e)
        {
            txt_Code.Clear();
            txt_Nom.Clear();
            txt_Prenom.Clear();
            txt_Note.Clear();
            cmb_Specialite.SelectedIndex = -1;
            dtp_DateNai.Value = DateTime.Now;
            rb_Male.Checked = false;
            rb_Femelle.Checked = false;
            chk_DAI.Checked = false;
            chk_SRI.Checked = false;
            chk_MultiMedia.Checked = false;
            txt_Code.Focus();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            string code = txt_Code.Text.Trim();
            string nom = txt_Nom.Text.Trim();
            string prenom = txt_Prenom.Text.Trim();
            string note = txt_Note.Text.Trim();
            string specialite = cmb_Specialite.Text;
            string dateNai = dtp_DateNai.Value.ToShortDateString();
            string sexe = "";
            if (rb_Male.Checked) sexe = "Male";
            else if (rb_Femelle.Checked) sexe = "Femelle";
            string filiere = "";
            if (chk_DAI.Checked) filiere = "DAI";
            else if (chk_SRI.Checked) filiere = "SRI";
            else if (chk_MultiMedia.Checked) filiere = "MultiMedia";
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(nom))
            {
                MessageBox.Show("Veuillez d'abord entrer le code et le nom!", "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int rowIndex = dataGridView1.Rows.Add();
            dataGridView1.Rows[rowIndex].Cells[0].Value = code;
            dataGridView1.Rows[rowIndex].Cells[1].Value = nom;
            dataGridView1.Rows[rowIndex].Cells[2].Value = prenom;
            dataGridView1.Rows[rowIndex].Cells[3].Value = sexe;
            dataGridView1.Rows[rowIndex].Cells[4].Value = dateNai;
            dataGridView1.Rows[rowIndex].Cells[5].Value = specialite;
            dataGridView1.Rows[rowIndex].Cells[6].Value = note;
            dataGridView1.Rows[rowIndex].Cells[7].Value = filiere;
            MessageBox.Show("Le stagiaire a été ajouté avec succès au planning!", "Fait avec succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_Code.Clear();
            txt_Nom.Clear();
            txt_Prenom.Clear();
            txt_Note.Clear();
            cmb_Specialite.SelectedIndex = -1;
            dtp_DateNai.Value = DateTime.Now;
            rb_Male.Checked = false;
            rb_Femelle.Checked = false;
            chk_DAI.Checked = false;
            chk_SRI.Checked = false;
            chk_MultiMedia.Checked = false;
            txt_Code.Focus();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                MessageBox.Show("Suppression réussie!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Recherche_Click(object sender, EventArgs e)
        {
            string searchCode = txt_Recherche.Text.Trim();
            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == searchCode)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    txt_Code.Text = row.Cells[0].Value.ToString();
                    txt_Nom.Text = row.Cells[1].Value.ToString();
                    txt_Prenom.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value.ToString() == "Male") rb_Male.Checked = true; else rb_Femelle.Checked = true;
                    dtp_DateNai.Value = Convert.ToDateTime(row.Cells[4].Value);
                    cmb_Specialite.Text = row.Cells[5].Value.ToString();
                    txt_Note.Text = row.Cells[6].Value.ToString();
                    string fil = row.Cells[7].Value.ToString();
                    chk_DAI.Checked = (fil == "DAI");
                    chk_SRI.Checked = (fil == "SRI");
                    chk_MultiMedia.Checked = (fil == "MultiMedia");

                    found = true;
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Ce code n'existe pas!", "Introuvable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_haut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                index = 0;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_bas_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                index = dataGridView1.Rows.Count - 2;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[index].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            }
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Stagiaires_Export.txt"))
                {
                    sw.WriteLine("Code\t\t| Nom\t\t| Prénom\t\t| Sexe\t\t| DateNaissance\t| Spécialité\t\t| Note\t| Filière");
                    sw.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;
                        sw.WriteLine($"{row.Cells[0].Value}\t\t| {row.Cells[1].Value}\t\t| {row.Cells[2].Value}\t\t| {row.Cells[3].Value}\t\t| {row.Cells[4].Value}\t| {row.Cells[5].Value}\t\t| {row.Cells[6].Value}\t| {row.Cells[7].Value}");
                    }
                }
                MessageBox.Show("Les données ont été enregistrées avec succès dans le fichier Stagiaires_Export.txt", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Imprimer_Click(object sender, EventArgs e)
        {
            if (File.Exists("Stagiaires_Export.txt"))
            {
                System.Diagnostics.Process.Start("notepad.exe", "Stagiaires_Export.txt");
            }
            else
            {
                MessageBox.Show("Veuillez d'abord enregistrer les données!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Code_TextChanged(object sender, EventArgs e)
        {

        }
        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txt_Nom.Focus();
            }
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            btn_Nouveau_Click(sender, e);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
