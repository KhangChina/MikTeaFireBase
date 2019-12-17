using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace MikTeaFireBase
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret= "vyIf2msa86wuKQaHlkAdjZnLuxndAtmst8Oiix1J",
            BasePath= "https://milkteaapp-4e9ef.firebaseio.com/"
        };
        IFirebaseClient client;
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

            }
            catch
            {
                MessageBox.Show("Không có internet hoặc lỗi kết nối !!!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Get(@"User");
        }
    }
}