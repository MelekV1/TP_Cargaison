using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class CargaisonUI : Form
    {
        public CargaisonUI()
        {
            InitializeComponent();
        }

        private void buttonAddCargaison_Click(object sender, EventArgs e)
        {
            int Distance = Int32.Parse(textBoxDistance.Text);
            String type = (String)comboBoxType.SelectedItem;
            Cargaison carg;
            if (type.Equals("Routiére"))
                carg = new CargaisonRoutiere(Distance);
            else
                carg = new CargaisonAerienne(Distance);
            listBox1.Items.Add(carg);
        }

        private void buttonAddMarchandise_Click(object sender, EventArgs e)
        {
            Cargaison carg;
            Object obj = listBox1.SelectedItem;
            if (obj != null)
            {
                carg = (Cargaison)obj;
                int n = Int32.Parse(textBoxNum.Text);
                double p = double.Parse(textBoxPoids.Text);
                double v = double.Parse(textBoxVolume.Text);
                Marchandise marchandise = new Marchandise(n, p, v);
                carg.Add(marchandise);
                dataGridViewMarchandise.Rows.Add(marchandise.Numero, marchandise.Poids, marchandise.Volume);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cargaison carg = null;
            Object obj = listBox1.SelectedItem;
            if (obj != null)
            {
                carg = (Cargaison)obj;
                List<Marchandise> listmarchands = carg.GetMarchandises();
                dataGridViewMarchandise.Rows.Clear();
                foreach (Marchandise m in listmarchands)
                {
                    dataGridViewMarchandise.Rows.Add(m.Numero, m.Poids, m.Volume);
                }
                textBoxCost.Text = carg.Cout().ToString();

            }

        }

        private void buttonRemoveMarchandise_Click(object sender, EventArgs e)
        {
            Cargaison carg;
            Object obj = listBox1.SelectedItem;
            if (obj != null)
            {
                carg = (Cargaison)obj;
            }
        }
    }
}
