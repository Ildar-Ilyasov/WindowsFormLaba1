using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLaba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeButtonRound(button8);
            MakeButtonRound(button9);
            MakeButtonRound(button10);
            MakeButtonRound(button11); 
            MakeButtonRound(button13);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Абоненты", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }
        private void MakeButtonRound(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, button.Width, button.Height);
            button.Region = new Region(path);

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            SobranieMenedjerov sobranieMenedjerov = new SobranieMenedjerov();
            sobranieMenedjerov.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Управление оборудованием", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Активы", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Биллинг", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поддержка пользователей", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRM", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SobranieAks sobranieAks = new SobranieAks();
            sobranieAks.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            OtchetR otchetR = new OtchetR();
            otchetR.Show();
        }
    }
}
