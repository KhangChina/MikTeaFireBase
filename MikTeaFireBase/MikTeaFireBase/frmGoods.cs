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
using FireSharp.Interfaces;
using FireSharp.Response;
using MikTeaFireBase.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

using Firebase.Database;
using Firebase.Database.Query;

namespace MikTeaFireBase
{
    public partial class frmGoods : DevExpress.XtraEditors.XtraForm
    {
        IFirebaseConfig config = new FirebaseConfig { AuthSecret = "vyIf2msa86wuKQaHlkAdjZnLuxndAtmst8Oiix1J", BasePath = "https://milkteaapp-4e9ef.firebaseio.com/" };
        IFirebaseClient client;
        public frmGoods()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            if(client!=null)
            {
                MessageBox.Show("OK");
            }
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            Watting.ShowWaitForm();


            var firebase = new FirebaseClient("https://milkteaapp-4e9ef.firebaseio.com/");

            var theloai= await firebase.Child("theloaisanpham").OrderByKey().OnceAsync<theloaisanpham>();
            List<theloaisanpham> tl = new List<theloaisanpham>();

            DataTable dt = new DataTable();

            foreach (var item in theloai)
            {
               
                MessageBox.Show(item.Key);
                MessageBox.Show(item.Object.Ten);
            }

            //var observable = firebase.Child("theloaisanpham").AsObservable<theloaisanpham>().Subscribe(d => MessageBox.Show(d.Key));



            Watting.CloseWaitForm();

           // string uniqueKey = 




        }
    }
}