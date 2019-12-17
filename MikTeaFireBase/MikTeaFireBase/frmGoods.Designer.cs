namespace MikTeaFireBase
{
    partial class frmGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grcGoods = new DevExpress.XtraGrid.GridControl();
            this.grvGoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.Watting = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::MikTeaFireBase.Loadding), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.grcGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // grcGoods
            // 
            this.grcGoods.Location = new System.Drawing.Point(99, 62);
            this.grcGoods.MainView = this.grvGoods;
            this.grcGoods.Name = "grcGoods";
            this.grcGoods.Size = new System.Drawing.Size(590, 342);
            this.grcGoods.TabIndex = 0;
            this.grcGoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvGoods});
            // 
            // grvGoods
            // 
            this.grvGoods.GridControl = this.grcGoods;
            this.grvGoods.Name = "grvGoods";
            this.grvGoods.OptionsView.ShowGroupPanel = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(760, 90);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(88, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Loading";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Watting
            // 
            this.Watting.ClosingDelay = 500;
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 536);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grcGoods);
            this.Name = "frmGoods";
            this.Text = "frmGood";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView grvGoods;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraSplashScreen.SplashScreenManager Watting;
    }
}