using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            toolStrip1.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            StockFrm sf = new StockFrm();
            sf.Show();
            sf.Opacity = 0.85;
            sf.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            CatgFrm cf = new CatgFrm();
            cf.Show();
            cf.Opacity = 0.85;
            cf.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ItemFrm iff = new ItemFrm();
            iff.Show();
            iff.Opacity = 0.85;
            iff.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            EmportFrm emf = new EmportFrm();
            emf.Show();
            emf.Opacity = 0.85;
            emf.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            ExportFrm exf = new ExportFrm();
            exf.Show();
            exf.Opacity = 0.85;
            exf.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void ToolStripButton6_Click(object sender, EventArgs e)
        {
            ReportFrm repf = new ReportFrm();
            repf.Show();
            repf.Opacity = 0.85;
            repf.BackColor = ColorTranslator.FromHtml("#719AD1");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
