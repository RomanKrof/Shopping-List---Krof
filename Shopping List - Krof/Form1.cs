using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_List___Krof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Panel> list = new List<Panel>();

        private void plus_Click(object sender, EventArgs e)
        {
            Panel polozka = new Panel() { Size = new Size(720, 20), Location = new Point(10, 62) };

            TextBox text = new TextBox() { Parent = polozka, Size = new Size(345, 20), Location = new Point(85, 0) };

            CheckBox check = new CheckBox() { Parent = polozka, Size = new Size(15, 20), Location = new Point(531, 0) };

            Button del = new Button() { Parent = polozka, Size = new Size(83, 20), Location = new Point(633, 0), Text = "Smazat" };

            del.Click += new System.EventHandler(this.DeleteButton_Click);

            list.Add(polozka);
            Controls.Add(polozka);

            plus.Top += 30;

            Seradit();
        }

        private void Seradit()
        {
            foreach (Control pan in this.Controls)
            {
                if (pan.GetType().Name == "Panel")
                {
                    pan.Location = new Point(10, 70 + list.IndexOf((Panel)pan) * 30);
                }                                  
            }         
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            Controls.Remove((Panel)but.Parent);
            list.Remove((Panel)but.Parent);

            plus.Top -= 30;

            Seradit();
        }      
    }
}
