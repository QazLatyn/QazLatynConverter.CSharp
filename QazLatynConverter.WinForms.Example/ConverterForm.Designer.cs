namespace QazLatynConverter.WinForms.Example
{
    partial class ConverterForm
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
            this.txtCyrl = new System.Windows.Forms.TextBox();
            this.txtLatyn = new System.Windows.Forms.TextBox();
            this.btnCyrl2Latyn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCyrl
            // 
            this.txtCyrl.Location = new System.Drawing.Point(23, 31);
            this.txtCyrl.Multiline = true;
            this.txtCyrl.Name = "txtCyrl";
            this.txtCyrl.Size = new System.Drawing.Size(602, 176);
            this.txtCyrl.TabIndex = 0;
            // 
            // txtLatyn
            // 
            this.txtLatyn.Location = new System.Drawing.Point(23, 253);
            this.txtLatyn.Multiline = true;
            this.txtLatyn.Name = "txtLatyn";
            this.txtLatyn.Size = new System.Drawing.Size(602, 176);
            this.txtLatyn.TabIndex = 1;
            // 
            // btnCyrl2Latyn
            // 
            this.btnCyrl2Latyn.Location = new System.Drawing.Point(222, 213);
            this.btnCyrl2Latyn.Name = "btnCyrl2Latyn";
            this.btnCyrl2Latyn.Size = new System.Drawing.Size(205, 34);
            this.btnCyrl2Latyn.TabIndex = 2;
            this.btnCyrl2Latyn.Text = "Кирилл » Латын";
            this.btnCyrl2Latyn.UseVisualStyleBackColor = true;
            this.btnCyrl2Latyn.Click += new System.EventHandler(this.btnCyrl2Latyn_Click);
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 453);
            this.Controls.Add(this.btnCyrl2Latyn);
            this.Controls.Add(this.txtLatyn);
            this.Controls.Add(this.txtCyrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QazLatynConverter.WinForms.Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCyrl;
        private System.Windows.Forms.TextBox txtLatyn;
        private System.Windows.Forms.Button btnCyrl2Latyn;
    }
}

