using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PirateAPpp_17_1_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temp()
        {
            Booty[] booties = {
                new Booty(BountyType.Diamonds, 100),
                new Booty(BountyType.Diamonds, 350)
            };
        }
    }
}
