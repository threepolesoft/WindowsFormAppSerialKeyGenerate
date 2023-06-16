namespace WindowsFormAppSerialKeyGenerate
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.lbCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(103, 109);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(110, 36);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(219, 118);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(242, 20);
            this.txtSl.TabIndex = 1;
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(512, 109);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(110, 36);
            this.btnValid.TabIndex = 0;
            this.btnValid.Text = "Valid";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(476, 121);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 13);
            this.lbCode.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 359);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Label lbCode;
    }
}

