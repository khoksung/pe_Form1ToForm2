using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe_Form1ToForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, op2, op3, op4;
            // str = str + "ท่านเคยเคลมสินค้าไซเซลหรือไม่ : ";
            if (radioButton1.Checked == true)
            {
                str = "เคย";
            }
            else
            {
                str = "ไม่เคย";
            }
            // str = str + "ท่านเคลมสินค้าไซเซลผ่านช่องทางใด : ";
            if (radioButton3.Checked == true)
            {
                op2 = "ร้านค้าที่ท่านซื้อสินค้า ";
            }
            else if (radioButton4.Checked == true)
            {
                op2 = "(ZyXEL Authorized Service Point)";
            }
            else if (radioButton5.Checked == true)
            {
                op2 = "ตัวแทนจำหน่ายค้าส่ง (Distributor)";
            }
            else if (radioButton6.Checked == true)
            {
                op2 = "ส่งพัสดุไปรษณีย์มายังสำนักงานใหญ่ไซเซล";
            }

            else
            {
                op2 = "ส่งเคลมด้วยตนเองที่สำนักงานใหญ่ไซเซล ";
            }
            //  str = str + "ท่านได้รับสินค้าเคลมหลังจากส่งเคลมภายในกี่วันโดยเฉลี่ย : ";
            if (radioButton9.Checked == true)
            {
                op3 = "ได้รับสินค้าคืนทันที";
            }
            else if (radioButton10.Checked == true)
            {
                op3 = "ภายใน 1-3 วัน";

            }
            else if (radioButton11.Checked == true)
            {
                op3 = "ภายใน 4-7 วัน";
            }
            else
            {
                op3 = "มากกว่า 7 วัน";
            }
            // str = str + "ท่านพอใจกับบริการเคลมสินค้าไซเซลโดยรวมในระดับใด : ";
            if (radioButton13.Checked == true)
            {
                op4 = "มากที่สุด";

            }
            else if (radioButton14.Checked == true)
            {
                op4 = "มาก";

            }
            else if (radioButton15.Checked == true)
            {
                op4 = "ปานกลาว";
            }
            else if (radioButton16.Checked == true)
            {
                op4 = "น้อย";

            }
            else
            {
                op4 = "น้อยทีสุด";
            }
            Form2 frm = new Form2(str, op2, op3, op4);
            frm.Show();

        }
    }
}
