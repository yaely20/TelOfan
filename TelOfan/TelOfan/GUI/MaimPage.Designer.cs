namespace TelOfan.GUI
{
    partial class MaimPage
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
            this.btnsubscription = new System.Windows.Forms.Button();
            this.btnworker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbMoked = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Txid = new System.Windows.Forms.TextBox();
            this.BtOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubscription
            // 
            this.btnsubscription.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsubscription.Location = new System.Drawing.Point(488, 183);
            this.btnsubscription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsubscription.Name = "btnsubscription";
            this.btnsubscription.Size = new System.Drawing.Size(229, 101);
            this.btnsubscription.TabIndex = 0;
            this.btnsubscription.Text = "מנוי";
            this.btnsubscription.UseVisualStyleBackColor = false;
            this.btnsubscription.Click += new System.EventHandler(this.btnsubscription_Click);
            // 
            // btnworker
            // 
            this.btnworker.BackColor = System.Drawing.Color.LimeGreen;
            this.btnworker.Location = new System.Drawing.Point(81, 183);
            this.btnworker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnworker.Name = "btnworker";
            this.btnworker.Size = new System.Drawing.Size(229, 92);
            this.btnworker.TabIndex = 1;
            this.btnworker.Text = "עובד";
            this.btnworker.UseVisualStyleBackColor = false;
            this.btnworker.Click += new System.EventHandler(this.btnworker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "הכנס תעודת זהות";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 373);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "בחר את מוקד האופניים";
            this.label2.Visible = false;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(460, 319);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(160, 22);
            this.txtid.TabIndex = 4;
            this.txtid.Text = "213722077";
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // cmbMoked
            // 
            this.cmbMoked.FormattingEnabled = true;
            this.cmbMoked.Location = new System.Drawing.Point(460, 363);
            this.cmbMoked.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMoked.Name = "cmbMoked";
            this.cmbMoked.Size = new System.Drawing.Size(160, 24);
            this.cmbMoked.TabIndex = 5;
            this.cmbMoked.Visible = false;
            // 
            // BtnOK
            // 
            this.BtnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnOK.Location = new System.Drawing.Point(544, 395);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(100, 28);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "כניסה";
            this.BtnOK.UseVisualStyleBackColor = false;
            this.BtnOK.Visible = false;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 317);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "הכנס תעודת זהות";
            this.label3.Visible = false;
            // 
            // Txid
            // 
            this.Txid.Location = new System.Drawing.Point(81, 317);
            this.Txid.Name = "Txid";
            this.Txid.Size = new System.Drawing.Size(121, 22);
            this.Txid.TabIndex = 7;
            this.Txid.Text = "335364733";
            this.Txid.Visible = false;
            // 
            // BtOk
            // 
            this.BtOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtOk.Location = new System.Drawing.Point(155, 383);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 8;
            this.BtOk.Text = "כניסה";
            this.BtOk.UseVisualStyleBackColor = false;
            this.BtOk.Visible = false;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click_1);
            // 
            // MaimPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.Txid);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.cmbMoked);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnworker);
            this.Controls.Add(this.btnsubscription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MaimPage";
            this.Text = "כניסה";
            this.Load += new System.EventHandler(this.MaimPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubscription;
        private System.Windows.Forms.Button btnworker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbMoked;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txid;
        private System.Windows.Forms.Button BtOk;
    }
}