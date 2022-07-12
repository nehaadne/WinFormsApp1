namespace WinFormsApp1
{
    partial class Form3
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(275, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 23);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(275, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 23);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(275, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBinaryWrite.Location = new System.Drawing.Point(126, 160);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(127, 23);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBinaryRead.Location = new System.Drawing.Point(275, 160);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(146, 23);
            this.btnBinaryRead.TabIndex = 7;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXmlRead.Location = new System.Drawing.Point(126, 209);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(127, 23);
            this.btnXmlRead.TabIndex = 8;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXmlWrite.Location = new System.Drawing.Point(275, 209);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(146, 23);
            this.btnXmlWrite.TabIndex = 9;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoapRead.Location = new System.Drawing.Point(126, 255);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(127, 23);
            this.btnSoapRead.TabIndex = 10;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSoapWrite.Location = new System.Drawing.Point(275, 255);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(146, 23);
            this.btnSoapWrite.TabIndex = 11;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJsonRead.Location = new System.Drawing.Point(126, 306);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(127, 23);
            this.btnJsonRead.TabIndex = 12;
            this.btnJsonRead.Text = "JSON Raed";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJsonWrite.Location = new System.Drawing.Point(275, 306);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(146, 23);
            this.btnJsonWrite.TabIndex = 13;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Serrialization demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnBinaryWrite;
        private Button btnBinaryRead;
        private Button btnXmlRead;
        private Button btnXmlWrite;
        private Button btnSoapRead;
        private Button btnSoapWrite;
        private Button btnJsonRead;
        private Button btnJsonWrite;
    }
}