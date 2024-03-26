using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Vasilena12a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();

        }

       // private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhodControl1.Show();
            vhodControl1.BringToFront();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        //private void vhodControl1_Load(object sender, EventArgs e)
        //{
           
        //}

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registraciqControl1.Show();
            registraciqControl1.BringToFront();
            vhodControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void ZaNas_Click(object sender, EventArgs e)
        {
            zaNasControl1.Show();
            zaNasControl1.BringToFront();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void контактиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontaktiControl1.Show();
            kontaktiControl1.BringToFront();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void инструментиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uslugiControl1.Show();
            uslugiControl1.BringToFront();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void китариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitariControl1.Show();
            kitariControl1.BringToFront();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            barabaniControl1.Hide();
        }

        private void синтезаториToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sintezatoriControl1.Show();
            sintezatoriControl1 .BringToFront();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void пианаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pianaControl1 .BringToFront();
            pianaControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void барабаниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            barabaniControl1 .BringToFront();
            barabaniControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
        }

        private void тонколониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tonkoloniIBassKoloniControl1 .BringToFront();
            tonkoloniIBassKoloniControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void смесителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pultoweMixeriIUsilvateliControl1 .BringToFront();
            pultoweMixeriIUsilvateliControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void микрофониToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kontroleriIMicrofoniControl1 .BringToFront();
            kontroleriIMicrofoniControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            osvetlenieControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }

        private void осветлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            osvetlenieControl1 .BringToFront();
            osvetlenieControl1.Show();
            vhodControl1.Hide();
            registraciqControl1.Hide();
            zaNasControl1.Hide();
            uslugiControl1.Hide();
            kontaktiControl1.Hide();
            tonkoloniIBassKoloniControl1.Hide();
            sintezatoriControl1.Hide();
            pultoweMixeriIUsilvateliControl1.Hide();
            pianaControl1.Hide();
            kontroleriIMicrofoniControl1.Hide();
            kitariControl1.Hide();
            barabaniControl1.Hide();
        }
    }
}
