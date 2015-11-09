using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private MemberBUS memberBUS;
        private Member member;

        public frmLogin()
        {
            InitializeComponent();
            memberBUS = new MemberBUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                member = memberBUS.getMemberByID(txtbID.Text);
                if(member.IsCorrectPassword(txtbPassword.Text))
                {
                    
                }
                else
                {
                    throw new Exception("Mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
