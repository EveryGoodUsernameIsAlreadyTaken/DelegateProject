namespace DelegateProject
{
    partial class fmMain
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
            this.lbSpread = new System.Windows.Forms.ListBox();
            this.lbSubNotify = new System.Windows.Forms.ListBox();
            this.btnPubSpread = new System.Windows.Forms.Button();
            this.btnUnsub2 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnUnsub1 = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSpread
            // 
            this.lbSpread.FormattingEnabled = true;
            this.lbSpread.Location = new System.Drawing.Point(12, 236);
            this.lbSpread.Name = "lbSpread";
            this.lbSpread.Size = new System.Drawing.Size(565, 82);
            this.lbSpread.TabIndex = 13;
            // 
            // lbSubNotify
            // 
            this.lbSubNotify.FormattingEnabled = true;
            this.lbSubNotify.Location = new System.Drawing.Point(154, 12);
            this.lbSubNotify.Name = "lbSubNotify";
            this.lbSubNotify.Size = new System.Drawing.Size(423, 134);
            this.lbSubNotify.TabIndex = 12;
            // 
            // btnPubSpread
            // 
            this.btnPubSpread.Location = new System.Drawing.Point(12, 207);
            this.btnPubSpread.Name = "btnPubSpread";
            this.btnPubSpread.Size = new System.Drawing.Size(136, 24);
            this.btnPubSpread.TabIndex = 11;
            this.btnPubSpread.Text = "Spread";
            this.btnPubSpread.UseVisualStyleBackColor = true;
            this.btnPubSpread.Click += new System.EventHandler(this.btnPubSpread_Click);
            // 
            // btnUnsub2
            // 
            this.btnUnsub2.Location = new System.Drawing.Point(12, 114);
            this.btnUnsub2.Name = "btnUnsub2";
            this.btnUnsub2.Size = new System.Drawing.Size(136, 24);
            this.btnUnsub2.TabIndex = 10;
            this.btnUnsub2.Text = "Unsubscribe2";
            this.btnUnsub2.UseVisualStyleBackColor = true;
            this.btnUnsub2.Click += new System.EventHandler(this.btnUnsub2_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(12, 85);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(136, 24);
            this.btnSub2.TabIndex = 9;
            this.btnSub2.Text = "Subscriber2";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnUnsub1
            // 
            this.btnUnsub1.Location = new System.Drawing.Point(12, 41);
            this.btnUnsub1.Name = "btnUnsub1";
            this.btnUnsub1.Size = new System.Drawing.Size(136, 24);
            this.btnUnsub1.TabIndex = 8;
            this.btnUnsub1.Text = "Unsubscribe1";
            this.btnUnsub1.UseVisualStyleBackColor = true;
            this.btnUnsub1.Click += new System.EventHandler(this.btnUnsub1_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(12, 12);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(136, 24);
            this.btnSub1.TabIndex = 7;
            this.btnSub1.Text = "Subscriber1";
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(502, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 337);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbSpread);
            this.Controls.Add(this.lbSubNotify);
            this.Controls.Add(this.btnPubSpread);
            this.Controls.Add(this.btnUnsub2);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.btnUnsub1);
            this.Controls.Add(this.btnSub1);
            this.Name = "fmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSpread;
        private System.Windows.Forms.ListBox lbSubNotify;
        private System.Windows.Forms.Button btnPubSpread;
        private System.Windows.Forms.Button btnUnsub2;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnUnsub1;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnClear;
    }
}

