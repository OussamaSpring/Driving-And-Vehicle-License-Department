using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.UserControls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();

            pl_user.ContextMenuStrip = cms_user_properties;
        }

        private void pl_user_Click(object sender, EventArgs e)
        {
            cms_user_properties.Show(pl_user, new Point(0, pl_user.Height));
        }

        public void SetUserInfo(string name, byte[] profileImage)
        {
            lb_username.Text = name;
            if (profileImage != null)
            {
                using (var ms = new System.IO.MemoryStream(profileImage))
                {
                    pb_profileImage.Image = Image.FromStream(ms);
                }
            }
        }
    }
}
