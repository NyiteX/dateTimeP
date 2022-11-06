using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Basic_Window : Form
    {
        Point p;
        int kol_start = 0;
        public Basic_Window()
        {
            InitializeComponent();
        }

        //Basic_Window
        private void Basic_Window_MouseDown(object sender, MouseEventArgs e)
        {
            p = new Point(e.X, e.Y);
        }
        private void Basic_Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - p.X;
                Top += e.Y - p.Y;
            }
        }

        //Basic_buttons
        private void X_Button_MouseEnter(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.Fixed3D;
            X_Button.BackColor = Color.Thistle;
        }
        private void X_Button_MouseLeave(object sender, EventArgs e)
        {
            X_Button.BorderStyle = BorderStyle.FixedSingle;
            X_Button.BackColor = Color.WhiteSmoke;
        }
        private void X_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "";
        }

        private void start_1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dayT = new DateTime();
                dayT = dateTimePicker1.Value;
                DateTime dayNow = DateTime.Now;
                label1.Visible = true;
                if (dayT > dayNow)
                {
                    TimeSpan tempDay = dayT - dayNow;
                    label1.Text = "Секунд прошло: " + tempDay.TotalSeconds;
                }
                else
                    label1.Text = "Эта дата уже прошла!";
            }
            catch (Exception E) { MessageBox.Show(E.Message); }
        }

        private void start_1_MouseEnter(object sender, EventArgs e)
        {
            if (kol_start < 2)
            {
                start_1.Visible = false;
                label1.Visible=true;
                label1.Text = "АХАХАХАХАХААХАХАХАХАА ХААХАХ АХААХАХ!!!111";
                kol_start++;
            }
        }
        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            start_1.Visible = true;
            label1.Visible = false;
            label1.Text = "";
        }
    }
}
