using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class InvisibleLable : Label
    {
        public InvisibleLable()
        {
            this.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            this.MouseEnter += new System.EventHandler(this.invisibleLable1_MouseEnter);
        }
        private void invisibleLable1_MouseEnter(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
