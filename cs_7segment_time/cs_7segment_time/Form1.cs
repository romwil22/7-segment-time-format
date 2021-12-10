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

            //MINUTES
            int m1 = Convert.ToInt32(DateTime.Now.ToString("mm").Substring(DateTime.Now.ToString("mm").Length - 1));
            int m2 = Convert.ToInt32(DateTime.Now.ToString("mm").Substring(0, 1));

            // first minutes
            if (m1 == 1)
            {

                m1A.BackColor = Color.DarkGray;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.DarkGray;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.DarkGray;
                m1G.BackColor = Color.DarkGray;
            }
            else if (m1 == 2)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.DarkGray;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.Red;
                m1F.BackColor = Color.DarkGray;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 3)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.DarkGray;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 4)
            {
                m1A.BackColor = Color.DarkGray;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.DarkGray;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 5)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.DarkGray;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 6)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.DarkGray;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.Red;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 7)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.DarkGray;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.DarkGray;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 8)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.Red;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 9)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.DarkGray;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.Red;
            }
            else if (m1 == 0)
            {
                m1A.BackColor = Color.Red;
                m1B.BackColor = Color.Red;
                m1C.BackColor = Color.Red;
                m1D.BackColor = Color.Red;
                m1E.BackColor = Color.Red;
                m1F.BackColor = Color.Red;
                m1G.BackColor = Color.DarkGray;
            }

            // second minutes
            if (m2 == 1)
            {

                m2A.BackColor = Color.DarkGray;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.DarkGray;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.DarkGray;
                m2G.BackColor = Color.DarkGray;
            }
            else if (m2 == 2)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.DarkGray;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.Red;
                m2F.BackColor = Color.DarkGray;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 3)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.DarkGray;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 4)
            {
                m2A.BackColor = Color.DarkGray;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.DarkGray;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 5)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.DarkGray;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 6)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.DarkGray;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.Red;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 7)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.DarkGray;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.DarkGray;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 8)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.Red;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 9)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.DarkGray;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.Red;
            }
            else if (m2 == 0)
            {
                m2A.BackColor = Color.Red;
                m2B.BackColor = Color.Red;
                m2C.BackColor = Color.Red;
                m2D.BackColor = Color.Red;
                m2E.BackColor = Color.Red;
                m2F.BackColor = Color.Red;
                m2G.BackColor = Color.DarkGray;
            }
        }
    }
}
