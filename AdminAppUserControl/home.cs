using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminAppUserControl
{
    public partial class home : UserControl
    {
        public LogIn first2 = new LogIn();
        public home()
        {
            InitializeComponent();
            
            this.label3.Text = first2.email;
            this.label4.Text = first2.password;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PostJob post = new PostJob();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(post);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn first = new LogIn();
            this.Hide();//because usercontrols have not Close() property as forms
            this.Parent.Controls.Add(first);
        }

        private void home_Load(object sender, EventArgs e)
        {
           
        }
    }
}
