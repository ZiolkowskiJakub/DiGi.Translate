namespace DiGi.Translate.Framework.Application.Controls
{
    partial class TestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_1
            // 
            this.Label_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(12, 18);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(55, 16);
            this.Label_1.TabIndex = 0;
            this.Label_1.Text = "Label_1";
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_1);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(150, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_1;
    }
}
