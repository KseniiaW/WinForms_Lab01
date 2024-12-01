namespace WinForms_L1
{
    partial class nForm
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
            checkBoxClose = new CheckBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // checkBoxClose
            // 
            checkBoxClose.AutoSize = true;
            checkBoxClose.Location = new Point(682, 419);
            checkBoxClose.Name = "checkBoxClose";
            checkBoxClose.Size = new Size(106, 19);
            checkBoxClose.TabIndex = 0;
            checkBoxClose.Text = "checkBoxClose";
            checkBoxClose.UseVisualStyleBackColor = true;
            checkBoxClose.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(74, 56);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(644, 320);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(checkBoxClose);
            Name = "nForm";
            Text = "nForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxClose;
        private Button closeButton;
    }
}