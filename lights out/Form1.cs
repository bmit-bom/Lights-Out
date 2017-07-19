using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lights_out
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            ChangeColorA1();
            if (!PatternSetup.Checked)
            {
                ChangeColorA2();
                ChangeColorB1();
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            ChangeColorA2();
            if (!PatternSetup.Checked)
            {
                ChangeColorA1();
                ChangeColorA3();
                ChangeColorB2();
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            ChangeColorA3();
            if (!PatternSetup.Checked)
            {
                ChangeColorA2();
                ChangeColorA4();
                ChangeColorB3();
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {
            ChangeColorA4();
            if (!PatternSetup.Checked)
            {
                ChangeColorA3();
                ChangeColorA5();
                ChangeColorB4();
            }
        }

        private void A5_Click(object sender, EventArgs e)
        {
            ChangeColorA5();
            if (!PatternSetup.Checked)
            {
                ChangeColorA4();
                ChangeColorB5();
            }
        }
        
        private void B1_Click(object sender, EventArgs e)
        {
            ChangeColorB1();
            if (!PatternSetup.Checked)
            {
                ChangeColorA1();
                ChangeColorB2();
                ChangeColorC1();
            }
        }
        
        private void B2_Click(object sender, EventArgs e)
        {
            ChangeColorB2();
            if (!PatternSetup.Checked)
            {
                ChangeColorA2();
                ChangeColorB1();
                ChangeColorB3();
                ChangeColorC2();
            }
        }
        
        private void B3_Click(object sender, EventArgs e)
        {
            ChangeColorB3();
            if (!PatternSetup.Checked)
            {
                ChangeColorA3();
                ChangeColorB2();
                ChangeColorB4();
                ChangeColorC3();
            }
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ChangeColorB4();
            if (!PatternSetup.Checked)
            {
                ChangeColorA4();
                ChangeColorB3();
                ChangeColorB5();
                ChangeColorC4();
            }
        }

        private void B5_Click(object sender, EventArgs e)
        {
            ChangeColorB5();
            if (!PatternSetup.Checked)
            {
                ChangeColorA5();
                ChangeColorB4();
                ChangeColorC5();
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            ChangeColorC1();
            if (!PatternSetup.Checked)
            {
                ChangeColorB1();
                ChangeColorC2();
                ChangeColorD1();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            ChangeColorC2();
            if (!PatternSetup.Checked)
            {
                ChangeColorB2();
                ChangeColorC1();
                ChangeColorC3();
                ChangeColorD2();
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            ChangeColorC3();
            if (!PatternSetup.Checked)
            {
                ChangeColorB3();
                ChangeColorC2();
                ChangeColorC4();
                ChangeColorD3();
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            ChangeColorC4();
            if (!PatternSetup.Checked)
            {
                ChangeColorB4();
                ChangeColorC3();
                ChangeColorC5();
                ChangeColorD4();
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            ChangeColorC5();
            if (!PatternSetup.Checked)
            {
                ChangeColorB5();
                ChangeColorC4();
                ChangeColorD5();
            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
            ChangeColorD1();
            if (!PatternSetup.Checked)
            {
                ChangeColorC1();
                ChangeColorD2();
                ChangeColorE1();
            }
        }

        private void D2_Click(object sender, EventArgs e)
        {
            ChangeColorD2();
            if (!PatternSetup.Checked)
            {
                ChangeColorC2();
                ChangeColorD1();
                ChangeColorD3();
                ChangeColorE2();
            }
        }

        private void D3_Click(object sender, EventArgs e)
        {
            ChangeColorD3();
            if (!PatternSetup.Checked)
            {
                ChangeColorC3();
                ChangeColorD2();
                ChangeColorD4();
                ChangeColorE3();
            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            ChangeColorD4();
            if (!PatternSetup.Checked)
            {
                ChangeColorC4();
                ChangeColorD3();
                ChangeColorD5();
                ChangeColorE4();
            }
        }

        private void D5_Click(object sender, EventArgs e)
        {
            ChangeColorD5();
            if (!PatternSetup.Checked)
            {
                ChangeColorC5();
                ChangeColorD4();
                ChangeColorE5();
            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            ChangeColorE1();
        if (!PatternSetup.Checked)
        {
            ChangeColorD1();
            ChangeColorE2();
}
        }

        private void E2_Click(object sender, EventArgs e)
        {
            ChangeColorE2();
            if (!PatternSetup.Checked)
            {
                ChangeColorD2();
                ChangeColorE1();
                ChangeColorE3();
            }
        }

        private void E3_Click(object sender, EventArgs e)
        {
            ChangeColorE3();
            if (!PatternSetup.Checked)
            {
                ChangeColorD3();
                ChangeColorE2();
                ChangeColorE4();
            }
        }

        private void E4_Click(object sender, EventArgs e)
        {
            ChangeColorE4();
            if (!PatternSetup.Checked)
            {
                ChangeColorD4();
                ChangeColorE3();
                ChangeColorE5();
            }
        }

        private void E5_Click(object sender, EventArgs e)
        {
            ChangeColorE5();
            if (!PatternSetup.Checked)
            {
                ChangeColorD5();
                ChangeColorE4();
            }
        }
        
        private void Reset_Click(object sender, EventArgs e)
        {
            A1.BackColor = Color.Black;
            A2.BackColor = Color.Black;
            A3.BackColor = Color.Black;
            A4.BackColor = Color.Black;
            A5.BackColor = Color.Black;
            B1.BackColor = Color.Black;
            B2.BackColor = Color.Black;
            B3.BackColor = Color.Black;
            B4.BackColor = Color.Black;
            B5.BackColor = Color.Black;
            C1.BackColor = Color.Black;
            C2.BackColor = Color.Black;
            C3.BackColor = Color.Black;
            C4.BackColor = Color.Black;
            C5.BackColor = Color.Black;
            D1.BackColor = Color.Black;
            D2.BackColor = Color.Black;
            D3.BackColor = Color.Black;
            D4.BackColor = Color.Black;
            D5.BackColor = Color.Black;
            E1.BackColor = Color.Black;
            E2.BackColor = Color.Black;
            E3.BackColor = Color.Black;
            E4.BackColor = Color.Black;
            E5.BackColor = Color.Black;
        }


        public void ChangeColorA1()
        {
            if (A1.BackColor.ToString() == "Color [Black]")
                A1.BackColor = Color.Yellow;
            else A1.BackColor = Color.Black;
        }
        public void ChangeColorA2()
        {
            if (A2.BackColor.ToString() == "Color [Black]")
                A2.BackColor = Color.Yellow;
            else A2.BackColor = Color.Black;
        }
        public void ChangeColorA3()
        {
            if (A3.BackColor.ToString() == "Color [Black]")
                A3.BackColor = Color.Yellow;
            else A3.BackColor = Color.Black;
        }
        public void ChangeColorA4()
        {
            if (A4.BackColor.ToString() == "Color [Black]")
                A4.BackColor = Color.Yellow;
            else A4.BackColor = Color.Black;
        }
        public void ChangeColorA5()
        {
            if (A5.BackColor.ToString() == "Color [Black]")
                A5.BackColor = Color.Yellow;
            else A5.BackColor = Color.Black;
        }
        public void ChangeColorB1()
        {
            if (B1.BackColor.ToString() == "Color [Black]")
                B1.BackColor = Color.Yellow;
            else B1.BackColor = Color.Black;
        }
        public void ChangeColorB2()
        {
            if (B2.BackColor.ToString() == "Color [Black]")
                B2.BackColor = Color.Yellow;
            else B2.BackColor = Color.Black;
        }
        public void ChangeColorB3()
        {
            if (B3.BackColor.ToString() == "Color [Black]")
                B3.BackColor = Color.Yellow;
            else B3.BackColor = Color.Black;
        }
        public void ChangeColorB4()
        {
            if (B4.BackColor.ToString() == "Color [Black]")
                B4.BackColor = Color.Yellow;
            else B4.BackColor = Color.Black;
        }
        public void ChangeColorB5()
        {
            if (B5.BackColor.ToString() == "Color [Black]")
                B5.BackColor = Color.Yellow;
            else B5.BackColor = Color.Black;
        }
        public void ChangeColorC1()
        {
            if (C1.BackColor.ToString() == "Color [Black]")
                C1.BackColor = Color.Yellow;
            else C1.BackColor = Color.Black;
        }
        public void ChangeColorC2()
        {
            if (C2.BackColor.ToString() == "Color [Black]")
                C2.BackColor = Color.Yellow;
            else C2.BackColor = Color.Black;
        }
        public void ChangeColorC3()
        {
            if (C3.BackColor.ToString() == "Color [Black]")
                C3.BackColor = Color.Yellow;
            else C3.BackColor = Color.Black;
        }
        public void ChangeColorC4()
        {
            if (C4.BackColor.ToString() == "Color [Black]")
                C4.BackColor = Color.Yellow;
            else C4.BackColor = Color.Black;
        }
        public void ChangeColorC5()
        {
            if (C5.BackColor.ToString() == "Color [Black]")
                C5.BackColor = Color.Yellow;
            else C5.BackColor = Color.Black;
        }
        public void ChangeColorD1()
        {
            if (D1.BackColor.ToString() == "Color [Black]")
                D1.BackColor = Color.Yellow;
            else D1.BackColor = Color.Black;
        }
        public void ChangeColorD2()
        {
            if (D2.BackColor.ToString() == "Color [Black]")
                D2.BackColor = Color.Yellow;
            else D2.BackColor = Color.Black;
        }
        public void ChangeColorD3()
        {
            if (D3.BackColor.ToString() == "Color [Black]")
                D3.BackColor = Color.Yellow;
            else D3.BackColor = Color.Black;
        }
        public void ChangeColorD4()
        {
            if (D4.BackColor.ToString() == "Color [Black]")
                D4.BackColor = Color.Yellow;
            else D4.BackColor = Color.Black;
        }
        public void ChangeColorD5()
        {
            if (D5.BackColor.ToString() == "Color [Black]")
                D5.BackColor = Color.Yellow;
            else D5.BackColor = Color.Black;
        }
        public void ChangeColorE1()
        {
            if (E1.BackColor.ToString() == "Color [Black]")
                E1.BackColor = Color.Yellow;
            else E1.BackColor = Color.Black;
        }
        public void ChangeColorE2()
        {
            if (E2.BackColor.ToString() == "Color [Black]")
                E2.BackColor = Color.Yellow;
            else E2.BackColor = Color.Black;
        }
        public void ChangeColorE3()
        {
            if (E3.BackColor.ToString() == "Color [Black]")
                E3.BackColor = Color.Yellow;
            else E3.BackColor = Color.Black;
        }
        public void ChangeColorE4()
        {
            if (E4.BackColor.ToString() == "Color [Black]")
                E4.BackColor = Color.Yellow;
            else E4.BackColor = Color.Black;
        }
        public void ChangeColorE5()
        {
            if (E5.BackColor.ToString() == "Color [Black]")
                E5.BackColor = Color.Yellow;
            else E5.BackColor = Color.Black;
        }
    }
}
