namespace DesktopApp1
{
    partial class Radio
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
            this.Blues = new System.Windows.Forms.Button();
            this.Metal = new System.Windows.Forms.Button();
            this.Dance = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Blues
            // 
            this.Blues.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Blues.ForeColor = System.Drawing.Color.Black;
            this.Blues.Location = new System.Drawing.Point(12, 32);
            this.Blues.Name = "Blues";
            this.Blues.Size = new System.Drawing.Size(123, 92);
            this.Blues.TabIndex = 0;
            this.Blues.Text = "Radio Blues";
            this.Blues.UseVisualStyleBackColor = false;
            this.Blues.Click += new System.EventHandler(this.Blues_Click);
            // 
            // Metal
            // 
            this.Metal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Metal.Location = new System.Drawing.Point(198, 32);
            this.Metal.Name = "Metal";
            this.Metal.Size = new System.Drawing.Size(123, 92);
            this.Metal.TabIndex = 1;
            this.Metal.Text = "Radio Metall";
            this.Metal.UseVisualStyleBackColor = false;
            this.Metal.Click += new System.EventHandler(this.Metal_Click);
            // 
            // Dance
            // 
            this.Dance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dance.Location = new System.Drawing.Point(398, 32);
            this.Dance.Name = "Dance";
            this.Dance.Size = new System.Drawing.Size(123, 92);
            this.Dance.TabIndex = 2;
            this.Dance.Text = "Radio Dance";
            this.Dance.UseVisualStyleBackColor = false;
            this.Dance.Click += new System.EventHandler(this.Dance_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(198, 136);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(123, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(398, 136);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(533, 210);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Dance);
            this.Controls.Add(this.Metal);
            this.Controls.Add(this.Blues);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Radio";
            this.Text = "Radio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Blues;
        private System.Windows.Forms.Button Metal;
        private System.Windows.Forms.Button Dance;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

