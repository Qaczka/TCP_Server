namespace TCP_Server
{
    partial class Form1
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.adress = new System.Windows.Forms.TextBox();
            this.myPort = new System.Windows.Forms.NumericUpDown();
            this.info_about_connections = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(133, 262);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(171, 73);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(625, 262);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(161, 73);
            this.stop.TabIndex = 1;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(16, 15);
            this.adress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(287, 22);
            this.adress.TabIndex = 2;
            this.adress.Text = "adress";
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(625, 15);
            this.myPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.myPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(289, 22);
            this.myPort.TabIndex = 3;
            // 
            // info_about_connections
            // 
            this.info_about_connections.FormattingEnabled = true;
            this.info_about_connections.ItemHeight = 16;
            this.info_about_connections.Location = new System.Drawing.Point(16, 70);
            this.info_about_connections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.info_about_connections.Name = "info_about_connections";
            this.info_about_connections.Size = new System.Drawing.Size(897, 164);
            this.info_about_connections.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(377, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCP SERVER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info_about_connections);
            this.Controls.Add(this.myPort);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.NumericUpDown myPort;
        private System.Windows.Forms.ListBox info_about_connections;
        private System.Windows.Forms.Label label1;
    }
}

