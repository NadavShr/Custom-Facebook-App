using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class BasePanel : Panel
    {
        public BasePanel()
        {
            this.AutoSize = true;
            this.MinimumSize = new Size(850, 0);
            this.MaximumSize = new Size(850, 0);
            this.BackColor = Color.WhiteSmoke;
            this.Margin = new Padding(0, 0, 10, 10);
            this.Padding = new Padding(0, 0, 10, 10);
        }
    }
}
