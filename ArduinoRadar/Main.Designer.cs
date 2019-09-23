namespace ArduinoRadar
{
    partial class Main
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
            this.pbxRadar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxPort = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRadar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxRadar
            // 
            this.pbxRadar.Location = new System.Drawing.Point(45, 30);
            this.pbxRadar.Name = "pbxRadar";
            this.pbxRadar.Size = new System.Drawing.Size(800, 410);
            this.pbxRadar.TabIndex = 0;
            this.pbxRadar.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaudRate.Location = new System.Drawing.Point(116, 21);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(121, 20);
            this.txtBaudRate.TabIndex = 2;
            this.txtBaudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // cmbxPort
            // 
            this.cmbxPort.FormattingEnabled = true;
            this.cmbxPort.Location = new System.Drawing.Point(116, 52);
            this.cmbxPort.Name = "cmbxPort";
            this.cmbxPort.Size = new System.Drawing.Size(121, 21);
            this.cmbxPort.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.btnStart.Location = new System.Drawing.Point(21, 87);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbxPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxRadar);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Radar";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRadar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxRadar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxPort;
        private System.Windows.Forms.Button btnStart;
    }
}