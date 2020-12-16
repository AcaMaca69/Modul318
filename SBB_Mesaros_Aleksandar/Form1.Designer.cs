namespace SBB_Mesaros_Aleksandar
{
    partial class FrmMainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainWindow));
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.rdbDeparture = new System.Windows.Forms.RadioButton();
            this.chbSpecifyTime = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.grbLocation = new System.Windows.Forms.GroupBox();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestinationLocation = new System.Windows.Forms.Label();
            this.cmbStartLocation = new System.Windows.Forms.ComboBox();
            this.cmbDestinationLocation = new System.Windows.Forms.ComboBox();
            this.ltvConnections = new System.Windows.Forms.ListView();
            this.clmStartStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDepartureTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDestinationStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArrivalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDelay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTime.SuspendLayout();
            this.grbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTime
            // 
            this.grbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTime.Controls.Add(this.rdbArrival);
            this.grbTime.Controls.Add(this.rdbDeparture);
            this.grbTime.Controls.Add(this.chbSpecifyTime);
            this.grbTime.Controls.Add(this.dtpTime);
            this.grbTime.ForeColor = System.Drawing.Color.Blue;
            this.grbTime.Location = new System.Drawing.Point(17, 113);
            this.grbTime.Margin = new System.Windows.Forms.Padding(2);
            this.grbTime.Name = "grbTime";
            this.grbTime.Padding = new System.Windows.Forms.Padding(2);
            this.grbTime.Size = new System.Drawing.Size(483, 98);
            this.grbTime.TabIndex = 6;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Zeit // Datum";
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(96, 54);
            this.rdbArrival.Margin = new System.Windows.Forms.Padding(2);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(62, 17);
            this.rdbArrival.TabIndex = 5;
            this.rdbArrival.TabStop = true;
            this.rdbArrival.Text = "Ankunft";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // rdbDeparture
            // 
            this.rdbDeparture.AutoSize = true;
            this.rdbDeparture.Location = new System.Drawing.Point(9, 54);
            this.rdbDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDeparture.Name = "rdbDeparture";
            this.rdbDeparture.Size = new System.Drawing.Size(59, 17);
            this.rdbDeparture.TabIndex = 4;
            this.rdbDeparture.TabStop = true;
            this.rdbDeparture.Text = "Abfahrt";
            this.rdbDeparture.UseVisualStyleBackColor = true;
            // 
            // chbSpecifyTime
            // 
            this.chbSpecifyTime.AutoSize = true;
            this.chbSpecifyTime.Location = new System.Drawing.Point(9, 25);
            this.chbSpecifyTime.Margin = new System.Windows.Forms.Padding(2);
            this.chbSpecifyTime.Name = "chbSpecifyTime";
            this.chbSpecifyTime.Size = new System.Drawing.Size(90, 17);
            this.chbSpecifyTime.TabIndex = 2;
            this.chbSpecifyTime.Text = "Specify &Time:";
            this.chbSpecifyTime.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(110, 25);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(357, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // grbLocation
            // 
            this.grbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLocation.Controls.Add(this.lblStartLocation);
            this.grbLocation.Controls.Add(this.lblDestinationLocation);
            this.grbLocation.Controls.Add(this.cmbStartLocation);
            this.grbLocation.Controls.Add(this.cmbDestinationLocation);
            this.grbLocation.ForeColor = System.Drawing.Color.Blue;
            this.grbLocation.Location = new System.Drawing.Point(17, 11);
            this.grbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.grbLocation.Name = "grbLocation";
            this.grbLocation.Padding = new System.Windows.Forms.Padding(2);
            this.grbLocation.Size = new System.Drawing.Size(483, 98);
            this.grbLocation.TabIndex = 5;
            this.grbLocation.TabStop = false;
            this.grbLocation.Text = "Orts Angaben";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.ForeColor = System.Drawing.Color.Blue;
            this.lblStartLocation.Location = new System.Drawing.Point(4, 26);
            this.lblStartLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(109, 14);
            this.lblStartLocation.TabIndex = 0;
            this.lblStartLocation.Text = "Startort";
            // 
            // lblDestinationLocation
            // 
            this.lblDestinationLocation.ForeColor = System.Drawing.Color.Blue;
            this.lblDestinationLocation.Location = new System.Drawing.Point(4, 54);
            this.lblDestinationLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinationLocation.Name = "lblDestinationLocation";
            this.lblDestinationLocation.Size = new System.Drawing.Size(122, 14);
            this.lblDestinationLocation.TabIndex = 0;
            this.lblDestinationLocation.Text = "Ankunftsstation:";
            // 
            // cmbStartLocation
            // 
            this.cmbStartLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStartLocation.FormattingEnabled = true;
            this.cmbStartLocation.Location = new System.Drawing.Point(130, 26);
            this.cmbStartLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStartLocation.Name = "cmbStartLocation";
            this.cmbStartLocation.Size = new System.Drawing.Size(333, 21);
            this.cmbStartLocation.TabIndex = 0;
            // 
            // cmbDestinationLocation
            // 
            this.cmbDestinationLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDestinationLocation.FormattingEnabled = true;
            this.cmbDestinationLocation.Location = new System.Drawing.Point(130, 51);
            this.cmbDestinationLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDestinationLocation.Name = "cmbDestinationLocation";
            this.cmbDestinationLocation.Size = new System.Drawing.Size(333, 21);
            this.cmbDestinationLocation.TabIndex = 1;
            // 
            // ltvConnections
            // 
            this.ltvConnections.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ltvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStartStation,
            this.clmDepartureTime,
            this.clmDestinationStation,
            this.clmArrivalTime,
            this.clmDuration,
            this.clmDelay});
            this.ltvConnections.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ltvConnections.ForeColor = System.Drawing.Color.Blue;
            this.ltvConnections.FullRowSelect = true;
            this.ltvConnections.GridLines = true;
            this.ltvConnections.HideSelection = false;
            this.ltvConnections.Location = new System.Drawing.Point(17, 215);
            this.ltvConnections.Margin = new System.Windows.Forms.Padding(2);
            this.ltvConnections.Name = "ltvConnections";
            this.ltvConnections.Size = new System.Drawing.Size(916, 331);
            this.ltvConnections.TabIndex = 7;
            this.ltvConnections.UseCompatibleStateImageBehavior = false;
            this.ltvConnections.View = System.Windows.Forms.View.Details;
            // 
            // clmStartStation
            // 
            this.clmStartStation.Text = "Startstation";
            this.clmStartStation.Width = 150;
            // 
            // clmDepartureTime
            // 
            this.clmDepartureTime.Text = "Abfahrtsuhrzeit";
            this.clmDepartureTime.Width = 150;
            // 
            // clmDestinationStation
            // 
            this.clmDestinationStation.Text = "Ankunftsstation";
            this.clmDestinationStation.Width = 150;
            // 
            // clmArrivalTime
            // 
            this.clmArrivalTime.Text = "Ankunftsuhrzeit";
            this.clmArrivalTime.Width = 150;
            // 
            // clmDuration
            // 
            this.clmDuration.Text = "Reisezeit";
            this.clmDuration.Width = 150;
            // 
            // clmDelay
            // 
            this.clmDelay.Text = "Verspätung";
            this.clmDelay.Width = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(505, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 199);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Verbindungen Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 72);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(676, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Station in der Nähe: ";
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 874);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbTime);
            this.Controls.Add(this.grbLocation);
            this.Controls.Add(this.ltvConnections);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainWindow";
            this.Text = "FrmMainWindow";
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.RadioButton rdbArrival;
        private System.Windows.Forms.RadioButton rdbDeparture;
        private System.Windows.Forms.CheckBox chbSpecifyTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.GroupBox grbLocation;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestinationLocation;
        private System.Windows.Forms.ComboBox cmbStartLocation;
        private System.Windows.Forms.ComboBox cmbDestinationLocation;
        private System.Windows.Forms.ListView ltvConnections;
        private System.Windows.Forms.ColumnHeader clmDepartureTime;
        private System.Windows.Forms.ColumnHeader clmDestinationStation;
        private System.Windows.Forms.ColumnHeader clmArrivalTime;
        private System.Windows.Forms.ColumnHeader clmDuration;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader clmStartStation;
        private System.Windows.Forms.ColumnHeader clmDelay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

