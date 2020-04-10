namespace GUI.UC
{
    partial class TimKiem
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
            this.dgv_tknv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.cmb_pb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tk = new GUI.ComponentForm.Thin_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tknv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tknv
            // 
            this.dgv_tknv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tknv.Location = new System.Drawing.Point(0, 253);
            this.dgv_tknv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgv_tknv.Name = "dgv_tknv";
            this.dgv_tknv.Size = new System.Drawing.Size(1092, 289);
            this.dgv_tknv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Nhân Viên";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(156, 142);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(301, 22);
            this.txt_tennv.TabIndex = 2;
            this.txt_tennv.Text = "Nhập tên nhân viên";
            this.txt_tennv.Click += new System.EventHandler(this.txt_tennv_Click);
            this.txt_tennv.TextChanged += new System.EventHandler(this.txt_tennv_TextChanged);
            // 
            // cmb_pb
            // 
            this.cmb_pb.FormattingEnabled = true;
            this.cmb_pb.Location = new System.Drawing.Point(688, 139);
            this.cmb_pb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmb_pb.Name = "cmb_pb";
            this.cmb_pb.Size = new System.Drawing.Size(345, 24);
            this.cmb_pb.TabIndex = 3;
            this.cmb_pb.SelectedIndexChanged += new System.EventHandler(this.cmb_pb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phòng Ban";
            // 
            // btn_tk
            // 
            this.btn_tk.Active = false;
            this.btn_tk.BackColor = System.Drawing.Color.Transparent;
            this.btn_tk.BoderColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorClick = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorHover = System.Drawing.Color.Empty;
            this.btn_tk.BorderColorNomal = System.Drawing.Color.Green;
            this.btn_tk.InnerColorClick = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorHover = System.Drawing.Color.Empty;
            this.btn_tk.InnerColorNomal = System.Drawing.Color.Transparent;
            this.btn_tk.Location = new System.Drawing.Point(935, 189);
            this.btn_tk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(100, 29);
            this.btn_tk.SizeBorder = 1;
            this.btn_tk.TabIndex = 6;
            this.btn_tk.Text = "Tìm Kiếm";
            this.btn_tk.TextAlignmentHorizontal = System.Drawing.StringAlignment.Center;
            this.btn_tk.TextAlignmentVertical = System.Drawing.StringAlignment.Center;
            this.btn_tk.TextColorClick = System.Drawing.Color.Empty;
            this.btn_tk.TextColorDisable = System.Drawing.Color.Empty;
            this.btn_tk.TextColorHover = System.Drawing.Color.Empty;
            this.btn_tk.TextColorNomal = System.Drawing.Color.Black;
            this.btn_tk.UseActive = false;
            this.btn_tk.UseBorderColorHoverClick = false;
            this.btn_tk.UseInnerColorHoverClick = false;
            this.btn_tk.UseTextColorHoverClick = false;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_pb);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_tknv);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TimKiem";
            this.Size = new System.Drawing.Size(1096, 545);
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tknv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tknv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.ComboBox cmb_pb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComponentForm.Thin_Button btn_tk;
    }
}
