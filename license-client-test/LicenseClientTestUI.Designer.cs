namespace license_client_test
{
    partial class LicenseClientTestUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.txtMacID = new System.Windows.Forms.TextBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "License Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mac ID";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(156, 39);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(399, 22);
            this.txtProductCode.TabIndex = 4;
            this.txtProductCode.Text = "ERP001";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(156, 78);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(399, 22);
            this.txtClientCode.TabIndex = 5;
            this.txtClientCode.Text = "CL1234";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Location = new System.Drawing.Point(156, 119);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(399, 22);
            this.txtLicenseKey.TabIndex = 6;
            // 
            // txtMacID
            // 
            this.txtMacID.Location = new System.Drawing.Point(156, 158);
            this.txtMacID.Name = "txtMacID";
            this.txtMacID.Size = new System.Drawing.Size(399, 22);
            this.txtMacID.TabIndex = 7;
            this.txtMacID.Text = "raunit-pc-1";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(91, 221);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(150, 38);
            this.btnActivate.TabIndex = 8;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(247, 221);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(153, 38);
            this.btnValidate.TabIndex = 9;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(406, 221);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(149, 38);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(156, 294);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(399, 143);
            this.txtResponse.TabIndex = 12;
            // 
            // LicenseClientTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 489);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.txtMacID);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.txtClientCode);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LicenseClientTestUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LicenseClientTestUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.TextBox txtMacID;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResponse;
    }
}