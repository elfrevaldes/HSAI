using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSAI
{
    public partial class Form1 : Form
    {
        IntPtr hsgame;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hsgame = HearthstoneHelper.GetHearthstoneWindow();

            ClickOnPointTool.ClickOnPossition(hsgame, new Point(1000, 700));
        }
    }
}
