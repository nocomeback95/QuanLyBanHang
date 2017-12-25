namespace WindowsFormsApplication1.Presentation
{
    partial class UCKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCKhachHang));
            this.btnSuaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuaKhachHang
            // 
            this.btnSuaKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKhachHang.Appearance.Options.UseFont = true;
            this.btnSuaKhachHang.Enabled = false;
            this.btnSuaKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKhachHang.ImageOptions.Image")));
            this.btnSuaKhachHang.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013";
            this.btnSuaKhachHang.Location = new System.Drawing.Point(191, 16);
            this.btnSuaKhachHang.Name = "btnSuaKhachHang";
            this.btnSuaKhachHang.Size = new System.Drawing.Size(115, 35);
            this.btnSuaKhachHang.TabIndex = 2;
            this.btnSuaKhachHang.Text = "Sửa";
            this.btnSuaKhachHang.Click += new System.EventHandler(this.btnSuaKhachHang_Click);
            // 
            // btnXoaKhachHang
            // 
            this.btnXoaKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhachHang.Appearance.Options.UseFont = true;
            this.btnXoaKhachHang.Enabled = false;
            this.btnXoaKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKhachHang.ImageOptions.Image")));
            this.btnXoaKhachHang.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013";
            this.btnXoaKhachHang.Location = new System.Drawing.Point(350, 16);
            this.btnXoaKhachHang.Name = "btnXoaKhachHang";
            this.btnXoaKhachHang.Size = new System.Drawing.Size(115, 35);
            this.btnXoaKhachHang.TabIndex = 3;
            this.btnXoaKhachHang.Text = "Xóa";
            this.btnXoaKhachHang.Click += new System.EventHandler(this.btnXoaKhachHang_Click);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.Appearance.Options.UseFont = true;
            this.btnThemKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhachHang.ImageOptions.Image")));
            this.btnThemKhachHang.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013";
            this.btnThemKhachHang.Location = new System.Drawing.Point(34, 16);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(115, 35);
            this.btnThemKhachHang.TabIndex = 1;
            this.btnThemKhachHang.Text = "Thêm";
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gridControlKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 411);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSuaKhachHang);
            this.panel2.Controls.Add(this.btnThemKhachHang);
            this.panel2.Controls.Add(this.btnXoaKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 72);
            this.panel2.TabIndex = 4;
            // 
            // gridControlKhachHang
            // 
            this.gridControlKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gridControlKhachHang.MainView = this.gridViewKhachHang;
            this.gridControlKhachHang.Name = "gridControlKhachHang";
            this.gridControlKhachHang.Size = new System.Drawing.Size(731, 339);
            this.gridControlKhachHang.TabIndex = 1;
            this.gridControlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            this.gridControlKhachHang.Click += new System.EventHandler(this.gridControlKhachHang_Click);
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridViewKhachHang.GridControl = this.gridControlKhachHang;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.OptionsBehavior.Editable = false;
            this.gridViewKhachHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã Khách Hàng";
            this.gridColumn1.FieldName = "MAKH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên Khách Hàng";
            this.gridColumn2.FieldName = "TenKH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số Điện Thoại";
            this.gridColumn3.FieldName = "SDT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số Tài Khoản";
            this.gridColumn4.FieldName = "STK";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ngân Hàng";
            this.gridColumn5.FieldName = "NGANHANG";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã Khu Vực";
            this.gridColumn6.FieldName = "MAKV";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Địa Chỉ";
            this.gridColumn7.FieldName = "DIACHI";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Giới Tính";
            this.gridColumn8.FieldName = "GIOITINH";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Ghi Chú";
            this.gridColumn9.FieldName = "GHICHU";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // UCKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCKhachHang";
            this.Size = new System.Drawing.Size(731, 411);
            this.Load += new System.EventHandler(this.UCKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSuaKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnXoaKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnThemKhachHang;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControlKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.Panel panel2;
    }
}
