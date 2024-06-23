
namespace TelOfan.GUI
{
    partial class FrmAddOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnOk = new System.Windows.Forms.Button();
            this.lblSubs = new System.Windows.Forms.Label();
            this.lblBis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "שעת לקיחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "שעת החזרה";
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(539, 186);
            this.timeStart.Margin = new System.Windows.Forms.Padding(4);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(265, 22);
            this.timeStart.TabIndex = 4;
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(539, 261);
            this.timeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(265, 22);
            this.timeEnd.TabIndex = 5;
            this.timeEnd.ValueChanged += new System.EventHandler(this.timeEnd_ValueChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(155, 425);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(100, 28);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "ביצוע";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblSubs
            // 
            this.lblSubs.AutoSize = true;
            this.lblSubs.Location = new System.Drawing.Point(861, 57);
            this.lblSubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubs.Name = "lblSubs";
            this.lblSubs.Size = new System.Drawing.Size(39, 17);
            this.lblSubs.TabIndex = 7;
            this.lblSubs.Text = "לקוח:";
            // 
            // lblBis
            // 
            this.lblBis.AutoSize = true;
            this.lblBis.Location = new System.Drawing.Point(861, 119);
            this.lblBis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBis.Name = "lblBis";
            this.lblBis.Size = new System.Drawing.Size(45, 17);
            this.lblBis.TabIndex = 8;
            this.lblBis.Text = "אופנים";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "כמות השעות";
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(639, 332);
            this.TxtCount.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(132, 22);
            this.TxtCount.TabIndex = 10;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(291, 337);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(132, 22);
            this.txtprice.TabIndex = 12;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(517, 341);
            this.lblprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(71, 17);
            this.lblprice.TabIndex = 11;
            this.lblprice.Text = "מחיר לשעה";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(459, 415);
            this.txtSum.Margin = new System.Windows.Forms.Padding(4);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(132, 22);
            this.txtSum.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "סהכ לתשלום";
            // 
            // FrmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBis);
            this.Controls.Add(this.lblSubs);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.timeEnd);
            this.Controls.Add(this.timeStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "סיכום ההזמנה";
            this.Load += new System.EventHandler(this.FrmAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label lblSubs;
        private System.Windows.Forms.Label lblBis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label4;
    }
}