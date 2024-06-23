namespace TelOfan.GUI
{
    partial class FrmSubscription
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
            this.button1 = new System.Windows.Forms.Button();
            this.Renting = new System.Windows.Forms.Button();
            this.btnRenting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "החזרה";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Renting
            // 
            this.Renting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Renting.Location = new System.Drawing.Point(384, 135);
            this.Renting.Margin = new System.Windows.Forms.Padding(2);
            this.Renting.Name = "Renting";
            this.Renting.Size = new System.Drawing.Size(183, 81);
            this.Renting.TabIndex = 0;
            this.Renting.Text = "השאלה";
            this.Renting.UseVisualStyleBackColor = false;
            this.Renting.Click += new System.EventHandler(this.Renting_Click);
            // 
            // btnRenting
            // 
            this.btnRenting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRenting.Location = new System.Drawing.Point(384, 233);
            this.btnRenting.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenting.Name = "btnRenting";
            this.btnRenting.Size = new System.Drawing.Size(183, 86);
            this.btnRenting.TabIndex = 1;
            this.btnRenting.Text = "הצגת השכרות";
            this.btnRenting.UseVisualStyleBackColor = false;
            this.btnRenting.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRenting);
            this.Controls.Add(this.Renting);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSubscription";
            this.Text = "לקיחה , החזרה";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Renting;
        private System.Windows.Forms.Button btnRenting;
    }
}