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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblHasilTanggal = new System.Windows.Forms.Label();
            this.lblHasilSkor = new System.Windows.Forms.Label();
            this.dgvHasil = new System.Windows.Forms.DataGridView();
            this.minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // cBTimHome
            // 
            this.cBTimHome.FormattingEnabled = true;
            this.cBTimHome.Location = new System.Drawing.Point(13, 13);
            this.cBTimHome.Margin = new System.Windows.Forms.Padding(4);
            this.cBTimHome.Name = "cBTimHome";
            this.cBTimHome.Size = new System.Drawing.Size(180, 27);
            this.cBTimHome.TabIndex = 0;
            this.cBTimHome.SelectedIndexChanged += new System.EventHandler(this.cBTimHome_SelectedIndexChanged);
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(253, 13);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(29, 19);
            this.lblVS.TabIndex = 1;
            this.lblVS.Text = "VS";
            this.lblVS.Click += new System.EventHandler(this.lblVS_Click);
            // 
            // cBTimLuar
            // 
            this.cBTimLuar.FormattingEnabled = true;
            this.cBTimLuar.Location = new System.Drawing.Point(379, 13);
            this.cBTimLuar.Name = "cBTimLuar";
            this.cBTimLuar.Size = new System.Drawing.Size(186, 27);
            this.cBTimLuar.TabIndex = 2;
            this.cBTimLuar.SelectedIndexChanged += new System.EventHandler(this.cBTimLuar_SelectedIndexChanged);
            // 
            // lblManagerTHome
            // 
            this.lblManagerTHome.AutoSize = true;
            this.lblManagerTHome.Location = new System.Drawing.Point(9, 58);
            this.lblManagerTHome.Name = "lblManagerTHome";
            this.lblManagerTHome.Size = new System.Drawing.Size(74, 19);
            this.lblManagerTHome.TabIndex = 3;
            this.lblManagerTHome.Text = "Manager : ";
            // 
            // lblCaptainTHome
            // 
            this.lblCaptainTHome.AutoSize = true;
            this.lblCaptainTHome.Location = new System.Drawing.Point(16, 99);
            this.lblCaptainTHome.Name = "lblCaptainTHome";
            this.lblCaptainTHome.Size = new System.Drawing.Size(67, 19);
            this.lblCaptainTHome.TabIndex = 4;
            this.lblCaptainTHome.Text = "Captain : ";
            this.lblCaptainTHome.Click += new System.EventHandler(this.lblCaptainTHome_Click);
            // 
            // lblManagerTHomeHasil
            // 
            this.lblManagerTHomeHasil.AutoSize = true;
            this.lblManagerTHomeHasil.Location = new System.Drawing.Point(89, 58);
            this.lblManagerTHomeHasil.Name = "lblManagerTHomeHasil";
            this.lblManagerTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblManagerTHomeHasil.TabIndex = 5;
            this.lblManagerTHomeHasil.Text = ".....";
            // 
            // lblCaptainTHomeHasil
            // 
            this.lblCaptainTHomeHasil.AutoSize = true;
            this.lblCaptainTHomeHasil.Location = new System.Drawing.Point(89, 99);
            this.lblCaptainTHomeHasil.Name = "lblCaptainTHomeHasil";
            this.lblCaptainTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCaptainTHomeHasil.TabIndex = 6;
            this.lblCaptainTHomeHasil.Text = ".....";
            // 
            // lblManagerTLuar
            // 
            this.lblManagerTLuar.AutoSize = true;
            this.lblManagerTLuar.Location = new System.Drawing.Point(375, 58);
            this.lblManagerTLuar.Name = "lblManagerTLuar";
            this.lblManagerTLuar.Size = new System.Drawing.Size(74, 19);
            this.lblManagerTLuar.TabIndex = 7;
            this.lblManagerTLuar.Text = "Manager : ";
            // 
            // lblCaptainTLuar
            // 
            this.lblCaptainTLuar.AutoSize = true;
            this.lblCaptainTLuar.Location = new System.Drawing.Point(382, 99);
            this.lblCaptainTLuar.Name = "lblCaptainTLuar";
            this.lblCaptainTLuar.Size = new System.Drawing.Size(67, 19);
            this.lblCaptainTLuar.TabIndex = 8;
            this.lblCaptainTLuar.Text = "Captain : ";
            // 
            // lblManagerTLuarHasil
            // 
            this.lblManagerTLuarHasil.AutoSize = true;
            this.lblManagerTLuarHasil.Location = new System.Drawing.Point(455, 58);
            this.lblManagerTLuarHasil.Name = "lblManagerTLuarHasil";
            this.lblManagerTLuarHasil.Size = new System.Drawing.Size(29, 19);
            this.lblManagerTLuarHasil.TabIndex = 9;
            this.lblManagerTLuarHasil.Text = ".....";
            // 
            // lblCaptainTLuarHasil
            // 
            this.lblCaptainTLuarHasil.AutoSize = true;
            this.lblCaptainTLuarHasil.Location = new System.Drawing.Point(455, 99);
            this.lblCaptainTLuarHasil.Name = "lblCaptainTLuarHasil";
            this.lblCaptainTLuarHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCaptainTLuarHasil.TabIndex = 10;
            this.lblCaptainTLuarHasil.Text = ".....";
            // 
            // lblStadiumTHome
            // 
            this.lblStadiumTHome.AutoSize = true;
            this.lblStadiumTHome.Location = new System.Drawing.Point(213, 144);
            this.lblStadiumTHome.Name = "lblStadiumTHome";
            this.lblStadiumTHome.Size = new System.Drawing.Size(69, 19);
            this.lblStadiumTHome.TabIndex = 11;
            this.lblStadiumTHome.Text = "Stadium : ";
            // 
            // lblCapacityTHome
            // 
            this.lblCapacityTHome.AutoSize = true;
            this.lblCapacityTHome.Location = new System.Drawing.Point(208, 173);
            this.lblCapacityTHome.Name = "lblCapacityTHome";
            this.lblCapacityTHome.Size = new System.Drawing.Size(74, 19);
            this.lblCapacityTHome.TabIndex = 12;
            this.lblCapacityTHome.Text = "Capacity : ";
            // 
            // lblStadiumTHomeHasil
            // 
            this.lblStadiumTHomeHasil.AutoSize = true;
            this.lblStadiumTHomeHasil.Location = new System.Drawing.Point(288, 144);
            this.lblStadiumTHomeHasil.Name = "lblStadiumTHomeHasil";
            this.lblStadiumTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblStadiumTHomeHasil.TabIndex = 13;
            this.lblStadiumTHomeHasil.Text = ".....";
            // 
            // lblCapacityTHomeHasil
            // 
            this.lblCapacityTHomeHasil.AutoSize = true;
            this.lblCapacityTHomeHasil.Location = new System.Drawing.Point(288, 173);
            this.lblCapacityTHomeHasil.Name = "lblCapacityTHomeHasil";
            this.lblCapacityTHomeHasil.Size = new System.Drawing.Size(29, 19);
            this.lblCapacityTHomeHasil.TabIndex = 14;
            this.lblCapacityTHomeHasil.Text = ".....";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(231, 213);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(213, 254);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(62, 19);
            this.lblTanggal.TabIndex = 16;
            this.lblTanggal.Text = "Tanggal :";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(229, 285);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(46, 19);
            this.lblSkor.TabIndex = 17;
            this.lblSkor.Text = "Skor :";
            // 
            // lblHasilTanggal
            // 
            this.lblHasilTanggal.AutoSize = true;
            this.lblHasilTanggal.Location = new System.Drawing.Point(281, 254);
            this.lblHasilTanggal.Name = "lblHasilTanggal";
            this.lblHasilTanggal.Size = new System.Drawing.Size(29, 19);
            this.lblHasilTanggal.TabIndex = 18;
            this.lblHasilTanggal.Text = ".....";
            // 
            // lblHasilSkor
            // 
            this.lblHasilSkor.AutoSize = true;
            this.lblHasilSkor.Location = new System.Drawing.Point(281, 285);
            this.lblHasilSkor.Name = "lblHasilSkor";
            this.lblHasilSkor.Size = new System.Drawing.Size(29, 19);
            this.lblHasilSkor.TabIndex = 19;
            this.lblHasilSkor.Text = ".....";
            // 
            // dgvHasil
            // 
            this.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.minute,
            this.PlayerName1,
            this.Type1,
            this.PlayerName2,
            this.Type2});
            this.dgvHasil.Location = new System.Drawing.Point(20, 349);
            this.dgvHasil.Name = "dgvHasil";
            this.dgvHasil.Size = new System.Drawing.Size(545, 175);
            this.dgvHasil.TabIndex = 20;
            this.dgvHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHasil_CellContentClick);
            // 
            // minute
            // 
            this.minute.HeaderText = "minute";
            this.minute.Name = "minute";
            // 
            // PlayerName1
            // 
            this.PlayerName1.HeaderText = "Player Name 1";
            this.PlayerName1.Name = "PlayerName1";
            // 
            // Type1
            // 
            this.Type1.HeaderText = "Type 1";
            this.Type1.Name = "Type1";
            // 
            // PlayerName2
            // 
            this.PlayerName2.HeaderText = "Player Name 2";
            this.PlayerName2.Name = "PlayerName2";
            // 
            // Type2
            // 
            this.Type2.HeaderText = "Type 2";
            this.Type2.Name = "Type2";
            // 
            // FormHasilPertandingan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 536);
            this.Controls.Add(this.dgvHasil);
            this.Controls.Add(this.lblHasilSkor);
            this.Controls.Add(this.lblHasilTanggal);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.btnCheck);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHasilPertandingan";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.FormHasilPertandingan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).EndInit();
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
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblHasilTanggal;
        private System.Windows.Forms.Label lblHasilSkor;
        private System.Windows.Forms.DataGridView dgvHasil;
        private System.Windows.Forms.DataGridViewTextBoxColumn minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type2;
    }
}

