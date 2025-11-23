using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau3
{
    public partial class ShowHTML : Form
    {
        public ShowHTML(string html)
        {
            InitializeComponent();
            rtb_htmlview.Text = html;

        }
    }
}
