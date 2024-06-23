namespace TelOfan.GUI
{
    partial class FrmWorkers
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnsub = new System.Windows.Forms.Button();
            this.btnbic = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsub.Location = new System.Drawing.Point(585, 245);
            this.btnsub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(157, 66);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "מנויים";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnbic
            // 
            this.btnbic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnbic.Location = new System.Drawing.Point(585, 144);
            this.btnbic.Margin = new System.Windows.Forms.Padding(4);
            this.btnbic.Name = "btnbic";
            this.btnbic.Size = new System.Drawing.Size(157, 69);
            this.btnbic.TabIndex = 2;
            this.btnbic.Text = "אופניים";
            this.btnbic.UseVisualStyleBackColor = false;
            this.btnbic.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnpay.Location = new System.Drawing.Point(585, 337);
            this.btnpay.Margin = new System.Windows.Forms.Padding(4);
            this.btnpay.Name = "btnpay";
            this.btnpay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnpay.Size = new System.Drawing.Size(157, 60);
            this.btnpay.TabIndex = 3;
            this.btnpay.Text = "תשלומים";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.btnbic);
            this.Controls.Add(this.btnsub);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmWorkers";
            this.Text = "עובדים";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnbic;
        private System.Windows.Forms.Button btnpay;
    }
}