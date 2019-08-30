using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex02_FacebookApp
{
    public partial class LoginForm : FacebookForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void ButtonFriendsList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonFriendsList_Click(sender, e);
        }

        protected override void ButtonMatchFinder_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonMatchFinder_Click(sender, e);
        }

        protected override void ButtonProfile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            base.ButtonProfile_Click(sender, e);
        }
    }
}
