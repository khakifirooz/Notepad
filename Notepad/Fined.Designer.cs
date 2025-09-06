namespace Notepad
{
    partial class Fined
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
            label1 = new Label();
            btnFined = new Button();
            txtFined = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "Fined:";
            // 
            // btnFined
            // 
            btnFined.BackColor = SystemColors.ActiveCaption;
            btnFined.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFined.ForeColor = SystemColors.ActiveCaptionText;
            btnFined.Location = new Point(136, 121);
            btnFined.Name = "btnFined";
            btnFined.Size = new Size(94, 35);
            btnFined.TabIndex = 1;
            btnFined.Text = "check";
            btnFined.UseVisualStyleBackColor = false;
            btnFined.Click += btnFined_Click;
            // 
            // txtFined
            // 
            txtFined.Location = new Point(25, 49);
            txtFined.Multiline = true;
            txtFined.Name = "txtFined";
            txtFined.Size = new Size(308, 60);
            txtFined.TabIndex = 2;
            // 
            // Fined
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 168);
            Controls.Add(txtFined);
            Controls.Add(btnFined);
            Controls.Add(label1);
            Name = "Fined";
            Text = "Fined";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnFined;
        private TextBox txtFined;
    }
}