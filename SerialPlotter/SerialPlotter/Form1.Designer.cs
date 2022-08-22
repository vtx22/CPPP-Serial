namespace SerialPlotter
{
    partial class Form1
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
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checksumCB = new MetroFramework.Controls.MetroCheckBox();
            this.serialPortCB = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.timeCB = new MetroFramework.Controls.MetroCheckBox();
            this.closePlotterBTN = new MetroFramework.Controls.MetroButton();
            this.loggingCB = new MetroFramework.Controls.MetroCheckBox();
            this.fullscreenCB = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.baudRateDD = new MetroFramework.Controls.MetroComboBox();
            this.byteorderCB = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.startButton.Location = new System.Drawing.Point(9, 258);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(147, 52);
            this.startButton.TabIndex = 0;
            this.startButton.TabStop = false;
            this.startButton.Text = "Start Plotter";
            this.startButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startButton.UseSelectable = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(9, 9);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(183, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CPPP - Serial Plotter";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // checksumCB
            // 
            this.checksumCB.AutoSize = true;
            this.checksumCB.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.checksumCB.ForeColor = System.Drawing.Color.White;
            this.checksumCB.Location = new System.Drawing.Point(12, 116);
            this.checksumCB.Name = "checksumCB";
            this.checksumCB.Size = new System.Drawing.Size(109, 25);
            this.checksumCB.TabIndex = 2;
            this.checksumCB.Text = "Checksum";
            this.checksumCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.checksumCB.UseCustomForeColor = true;
            this.checksumCB.UseSelectable = true;
            // 
            // serialPortCB
            // 
            this.serialPortCB.FormattingEnabled = true;
            this.serialPortCB.ItemHeight = 23;
            this.serialPortCB.Location = new System.Drawing.Point(12, 81);
            this.serialPortCB.Name = "serialPortCB";
            this.serialPortCB.Size = new System.Drawing.Size(121, 29);
            this.serialPortCB.TabIndex = 3;
            this.serialPortCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serialPortCB.UseSelectable = true;
            this.serialPortCB.DropDown += new System.EventHandler(this.serialPortCB_DropDown);
            this.serialPortCB.SelectedIndexChanged += new System.EventHandler(this.serialPortCB_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(12, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Serial Port:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(12, 43);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(467, 2);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Maroon;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(427, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(52, 23);
            this.closeButton.Style = MetroFramework.MetroColorStyle.Red;
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeButton.UseCustomBackColor = true;
            this.closeButton.UseSelectable = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // timeCB
            // 
            this.timeCB.AutoSize = true;
            this.timeCB.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.timeCB.ForeColor = System.Drawing.Color.White;
            this.timeCB.Location = new System.Drawing.Point(12, 147);
            this.timeCB.Name = "timeCB";
            this.timeCB.Size = new System.Drawing.Size(194, 25);
            this.timeCB.TabIndex = 7;
            this.timeCB.Text = "Evenly Spaced Points";
            this.timeCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.timeCB.UseCustomForeColor = true;
            this.timeCB.UseSelectable = true;
            // 
            // closePlotterBTN
            // 
            this.closePlotterBTN.BackColor = System.Drawing.Color.Maroon;
            this.closePlotterBTN.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.closePlotterBTN.Location = new System.Drawing.Point(162, 258);
            this.closePlotterBTN.Name = "closePlotterBTN";
            this.closePlotterBTN.Size = new System.Drawing.Size(147, 52);
            this.closePlotterBTN.TabIndex = 8;
            this.closePlotterBTN.TabStop = false;
            this.closePlotterBTN.Text = "Close Plotter";
            this.closePlotterBTN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closePlotterBTN.UseCustomBackColor = true;
            this.closePlotterBTN.UseSelectable = true;
            this.closePlotterBTN.Click += new System.EventHandler(this.closePlotterBTN_Click);
            // 
            // loggingCB
            // 
            this.loggingCB.AutoSize = true;
            this.loggingCB.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.loggingCB.ForeColor = System.Drawing.Color.White;
            this.loggingCB.Location = new System.Drawing.Point(12, 178);
            this.loggingCB.Name = "loggingCB";
            this.loggingCB.Size = new System.Drawing.Size(151, 25);
            this.loggingCB.TabIndex = 9;
            this.loggingCB.Text = "Enable Logging";
            this.loggingCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loggingCB.UseCustomForeColor = true;
            this.loggingCB.UseSelectable = true;
            // 
            // fullscreenCB
            // 
            this.fullscreenCB.AutoSize = true;
            this.fullscreenCB.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.fullscreenCB.ForeColor = System.Drawing.Color.White;
            this.fullscreenCB.Location = new System.Drawing.Point(12, 209);
            this.fullscreenCB.Name = "fullscreenCB";
            this.fullscreenCB.Size = new System.Drawing.Size(105, 25);
            this.fullscreenCB.TabIndex = 10;
            this.fullscreenCB.Text = "Fullscreen";
            this.fullscreenCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fullscreenCB.UseCustomForeColor = true;
            this.fullscreenCB.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(139, 59);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Baud Rate:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // baudRateDD
            // 
            this.baudRateDD.FormattingEnabled = true;
            this.baudRateDD.ItemHeight = 23;
            this.baudRateDD.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "115200"});
            this.baudRateDD.Location = new System.Drawing.Point(139, 81);
            this.baudRateDD.Name = "baudRateDD";
            this.baudRateDD.Size = new System.Drawing.Size(121, 29);
            this.baudRateDD.TabIndex = 11;
            this.baudRateDD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.baudRateDD.UseSelectable = true;
            // 
            // byteorderCB
            // 
            this.byteorderCB.AutoSize = true;
            this.byteorderCB.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.byteorderCB.ForeColor = System.Drawing.Color.White;
            this.byteorderCB.Location = new System.Drawing.Point(227, 116);
            this.byteorderCB.Name = "byteorderCB";
            this.byteorderCB.Size = new System.Drawing.Size(94, 25);
            this.byteorderCB.TabIndex = 13;
            this.byteorderCB.Text = "LSB First";
            this.byteorderCB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.byteorderCB.UseCustomForeColor = true;
            this.byteorderCB.UseSelectable = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(491, 322);
            this.Controls.Add(this.byteorderCB);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.baudRateDD);
            this.Controls.Add(this.fullscreenCB);
            this.Controls.Add(this.loggingCB);
            this.Controls.Add(this.closePlotterBTN);
            this.Controls.Add(this.timeCB);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.serialPortCB);
            this.Controls.Add(this.checksumCB);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CPPP - Serial Plotter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox checksumCB;
        private MetroFramework.Controls.MetroComboBox serialPortCB;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroCheckBox timeCB;
        private MetroFramework.Controls.MetroButton closePlotterBTN;
        private MetroFramework.Controls.MetroCheckBox loggingCB;
        private MetroFramework.Controls.MetroCheckBox fullscreenCB;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox baudRateDD;
        private MetroFramework.Controls.MetroCheckBox byteorderCB;
    }
}

