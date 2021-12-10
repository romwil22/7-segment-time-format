using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_7segment_time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void digitalClock_Tick(object sender, EventArgs e)
        {
            // SECONDS
            int s1 = Convert.ToInt32(DateTime.Now.ToString("ss").Substring(DateTime.Now.ToString("ss").Length - 1));
            int s2 = Convert.ToInt32(DateTime.Now.ToString("ss").Substring(0, 1));

            // first seconds
            if (s1 == 1)
            {

                s1A.BackColor = Color.DarkGray;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.DarkGray;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.DarkGray;
                s1G.BackColor = Color.DarkGray;
            }
            else if (s1 == 2)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.DarkGray;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.Red;
                s1F.BackColor = Color.DarkGray;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 3)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.DarkGray;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 4)
            {
                s1A.BackColor = Color.DarkGray;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.DarkGray;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 5)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.DarkGray;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 6)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.DarkGray;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.Red;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 7)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.DarkGray;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.DarkGray;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 8)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.Red;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 9)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.DarkGray;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.Red;
            }
            else if (s1 == 0)
            {
                s1A.BackColor = Color.Red;
                s1B.BackColor = Color.Red;
                s1C.BackColor = Color.Red;
                s1D.BackColor = Color.Red;
                s1E.BackColor = Color.Red;
                s1F.BackColor = Color.Red;
                s1G.BackColor = Color.DarkGray;
            }

            // second seconds
            if (s2 == 1)
            {

                s2A.BackColor = Color.DarkGray;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.DarkGray;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.DarkGray;
                s2G.BackColor = Color.DarkGray;
            }
            else if (s2 == 2)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.DarkGray;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.Red;
                s2F.BackColor = Color.DarkGray;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 3)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.DarkGray;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 4)
            {
                s2A.BackColor = Color.DarkGray;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.DarkGray;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 5)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.DarkGray;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 6)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.DarkGray;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.Red;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 7)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.DarkGray;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.DarkGray;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 8)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.Red;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 9)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.DarkGray;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.Red;
            }
            else if (s2 == 0)
            {
                s2A.BackColor = Color.Red;
                s2B.BackColor = Color.Red;
                s2C.BackColor = Color.Red;
                s2D.BackColor = Color.Red;
                s2E.BackColor = Color.Red;
                s2F.BackColor = Color.Red;
                s2G.BackColor = Color.DarkGray;
            }
        }
    }
}
