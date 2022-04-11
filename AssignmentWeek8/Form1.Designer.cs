namespace AssignmentWeek8
{
    partial class FormHasilPertandingan
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
            this.cBTimHome = new System.Windows.Forms.ComboBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.cBTimLuar = new System.Windows.Forms.ComboBox();
            this.lblManagerTHome = new System.Windows.Forms.Label();
            this.lblCaptainTHome = new System.Windows.Forms.Label();
            this.lblManagerTHomeHasil = new System.Windows.Forms.Label();
            this.lblCaptainTHomeHasil = new System.Windows.Forms.Label();
            this.lblManagerTLuar = new System.Windows.Forms.Label();
            this.lblCaptainTLuar = new System.Windows.Forms.Label();
            this.lblManagerTLuarHasil = new System.Windows.Forms.Label();
            this.lblCaptainTLuarHasil = new System.Windows.Forms.Label();
            this.lblStadiumTHome = new System.Windows.Forms.Label();
            this.lblCapacityTHome = new System.Windows.Forms.Label();
            this.lblStadiumTHomeHasil = new System.Windows.Forms.Label();
            this.lblCapacityTHomeHasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBTimHome
            // 
            this.cBTimHome.FormattingEnabled = true;
            this.cBTimHome.Location = new System.Drawing.Point(18, 18);
            this.cBTimHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBTimHome.Name = "cBTimHome";
            this.cBTimHome.Size = new System.Drawing.Size(180, 27);
            this.cBTimHome.TabIndex = 0;
            this.cBTimHome.SelectedIndexChanged += new System.EventHandler(this.cBTimHome_SelectedIndexChanged);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(274, 21);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(29, 19);
            this.lblVS.TabIndex = 1;
            this.lblVS.Text = "VS";
            // 
            // cBTimLuar
            // 
            this.cBTimLuar.FormattingEnabled = true;
            this.cBTimLuar.Location = new System.Drawing.Point(371, 21);
            this.cBTimLuar.Name = "cBTimLuar";
            this.cBTimLuar.Size = new System.Drawing.Size(186, 27);
            this.cBTimLuar.TabIndex = 2;
            this.cBTimLuar.SelectedIndexChanged += new System.EventHandler(this.cBTimLuar_SelectedIndexChanged);
            // 
            // lblManagerTHome
            // 
            this.lblManagerTHome.AutoSize = true;
            this.lblManagerTHome.Location = new System.Drawing.Point(14, 66);
            this.lblManagerTHome.Name = "lblManagerTHome";
            this.lblManagerTHome.Size = new System.Drawing.Size(74, 19);
            this.lblManagerTHome.TabIndex = 3;
            this.lblManagerTHome.Text = "Manager : ";
            // 
            // lblCaptainTHome
            // 
            this.lblCaptainTHome.AutoSize = true;
            this.lblCaptainTHome.Location = new System.Drawing.Point(14, 107);
            this.lblCaptainTHome.Name = "lblCaptainTHome";
            this.lblCaptainTHome.Size = new System.Drawing.Size(67, 19);
            this.lblCaptainTHome.TabIndex = 4;
            this.lblCaptainTHome.Text = "Captain : ";
            // 
            // lblManagerTHomeHasil
            // 
            this.lblManagerTHomeHasil.AutoSize = true;
            this.lblManagerTHomeHasil.Location = new System.Drawing.Point(94, 66);
            this.lblManagerTHomeHasil.Name = "lblManagerTHomeHasil";
            this.lblManagerTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblManagerTHomeHasil.TabIndex = 5;
            this.lblManagerTHomeHasil.Text = ".....";
            // 
            // lblCaptainTHomeHasil
            // 
            this.lblCaptainTHomeHasil.AutoSize = true;
            this.lblCaptainTHomeHasil.Location = new System.Drawing.Point(94, 107);
            this.lblCaptainTHomeHasil.Name = "lblCaptainTHomeHasil";
            this.lblCaptainTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCaptainTHomeHasil.TabIndex = 6;
            this.lblCaptainTHomeHasil.Text = ".....";
            // 
            // lblManagerTLuar
            // 
            this.lblManagerTLuar.AutoSize = true;
            this.lblManagerTLuar.Location = new System.Drawing.Point(367, 66);
            this.lblManagerTLuar.Name = "lblManagerTLuar";
            this.lblManagerTLuar.Size = new System.Drawing.Size(74, 19);
            this.lblManagerTLuar.TabIndex = 7;
            this.lblManagerTLuar.Text = "Manager : ";
            // 
            // lblCaptainTLuar
            // 
            this.lblCaptainTLuar.AutoSize = true;
            this.lblCaptainTLuar.Location = new System.Drawing.Point(367, 107);
            this.lblCaptainTLuar.Name = "lblCaptainTLuar";
            this.lblCaptainTLuar.Size = new System.Drawing.Size(67, 19);
            this.lblCaptainTLuar.TabIndex = 8;
            this.lblCaptainTLuar.Text = "Captain : ";
            // 
            // lblManagerTLuarHasil
            // 
            this.lblManagerTLuarHasil.AutoSize = true;
            this.lblManagerTLuarHasil.Location = new System.Drawing.Point(447, 66);
            this.lblManagerTLuarHasil.Name = "lblManagerTLuarHasil";
            this.lblManagerTLuarHasil.Size = new System.Drawing.Size(29, 19);
            this.lblManagerTLuarHasil.TabIndex = 9;
            this.lblManagerTLuarHasil.Text = ".....";
            // 
            // lblCaptainTLuarHasil
            // 
            this.lblCaptainTLuarHasil.AutoSize = true;
            this.lblCaptainTLuarHasil.Location = new System.Drawing.Point(447, 107);
            this.lblCaptainTLuarHasil.Name = "lblCaptainTLuarHasil";
            this.lblCaptainTLuarHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCaptainTLuarHasil.TabIndex = 10;
            this.lblCaptainTLuarHasil.Text = ".....";
            // 
            // lblStadiumTHome
            // 
            this.lblStadiumTHome.AutoSize = true;
            this.lblStadiumTHome.Location = new System.Drawing.Point(199, 165);
            this.lblStadiumTHome.Name = "lblStadiumTHome";
            this.lblStadiumTHome.Size = new System.Drawing.Size(69, 19);
            this.lblStadiumTHome.TabIndex = 11;
            this.lblStadiumTHome.Text = "Stadium : ";
            // 
            // lblCapacityTHome
            // 
            this.lblCapacityTHome.AutoSize = true;
            this.lblCapacityTHome.Location = new System.Drawing.Point(199, 194);
            this.lblCapacityTHome.Name = "lblCapacityTHome";
            this.lblCapacityTHome.Size = new System.Drawing.Size(74, 19);
            this.lblCapacityTHome.TabIndex = 12;
            this.lblCapacityTHome.Text = "Capacity : ";
            // 
            // lblStadiumTHomeHasil
            // 
            this.lblStadiumTHomeHasil.AutoSize = true;
            this.lblStadiumTHomeHasil.Location = new System.Drawing.Point(274, 165);
            this.lblStadiumTHomeHasil.Name = "lblStadiumTHomeHasil";
            this.lblStadiumTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblStadiumTHomeHasil.TabIndex = 13;
            this.lblStadiumTHomeHasil.Text = ".....";
            // 
            // lblCapacityTHomeHasil
            // 
            this.lblCapacityTHomeHasil.AutoSize = true;
            this.lblCapacityTHomeHasil.Location = new System.Drawing.Point(274, 194);
            this.lblCapacityTHomeHasil.Name = "lblCapacityTHomeHasil";
            this.lblCapacityTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCapacityTHomeHasil.TabIndex = 14;
            this.lblCapacityTHomeHasil.Text = ".....";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 226);
            this.Controls.Add(this.lblCapacityTHomeHasil);
            this.Controls.Add(this.lblStadiumTHomeHasil);
            this.Controls.Add(this.lblCapacityTHome);
            this.Controls.Add(this.lblStadiumTHome);
            this.Controls.Add(this.lblCaptainTLuarHasil);
            this.Controls.Add(this.lblManagerTLuarHasil);
            this.Controls.Add(this.lblCaptainTLuar);
            this.Controls.Add(this.lblManagerTLuar);
            this.Controls.Add(this.lblCaptainTHomeHasil);
            this.Controls.Add(this.lblManagerTHomeHasil);
            this.Controls.Add(this.lblCaptainTHome);
            this.Controls.Add(this.lblManagerTHome);
            this.Controls.Add(this.cBTimLuar);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.cBTimHome);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBTimHome;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.ComboBox cBTimLuar;
        private System.Windows.Forms.Label lblManagerTHome;
        private System.Windows.Forms.Label lblCaptainTHome;
        private System.Windows.Forms.Label lblManagerTHomeHasil;
        private System.Windows.Forms.Label lblCaptainTHomeHasil;
        private System.Windows.Forms.Label lblManagerTLuar;
        private System.Windows.Forms.Label lblCaptainTLuar;
        private System.Windows.Forms.Label lblManagerTLuarHasil;
        private System.Windows.Forms.Label lblCaptainTLuarHasil;
        private System.Windows.Forms.Label lblStadiumTHome;
        private System.Windows.Forms.Label lblCapacityTHome;
        private System.Windows.Forms.Label lblStadiumTHomeHasil;
        private System.Windows.Forms.Label lblCapacityTHomeHasil;
    }
}

