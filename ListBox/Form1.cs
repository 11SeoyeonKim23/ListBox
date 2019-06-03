using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        string strName;
        string strAge;
        string strJob;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtJob.Text == "")
            {
                MessageBox.Show("직업을 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtJob.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 입력해주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAge.Focus();
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.strName = this.txtName.Text;
                this.strAge = this.txtAge.Text;
                this.strJob = this.txtJob.Text;
                ListViewItem lvi =          //리스트뷰에 들어갈 항목 생성
                     new ListViewItem(
                         new string[] { strName, strAge, strJob }
                     );


                this.lvView.Items.Add(lvi);
                this.txtName.Text = "";
                this.txtAge.Text = "";
                this.txtJob.Text = "";
                this.txtName.Focus();
            }
        }

        private void LvView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi = this.lvView.SelectedItems[0];
            string name = lvi.SubItems[0].Text;
            String age = lvi.SubItems[1].Text;
            String job = lvi.SubItems[2].Text;

            MessageBox.Show("이름 : " + name + "\n나이 : " + age + "\n직업 : " + job, "자세히 보기", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
