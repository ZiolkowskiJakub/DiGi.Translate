namespace DiGi.Translate.Framework.Application
{
    partial class MainForm
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
            this.Button_1 = new System.Windows.Forms.Button();
            this.Label_1 = new System.Windows.Forms.Label();
            this.Button_Translate = new System.Windows.Forms.Button();
            this.GroupBox_Test = new System.Windows.Forms.GroupBox();
            this.CheckBox_1 = new System.Windows.Forms.CheckBox();
            this.RadioButton_1 = new System.Windows.Forms.RadioButton();
            this.RadioButton_2 = new System.Windows.Forms.RadioButton();
            this.TestControl_1 = new DiGi.Translate.Framework.Application.Controls.TestControl();
            this.GroupBox_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_1
            // 
            this.Button_1.Location = new System.Drawing.Point(28, 171);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(75, 23);
            this.Button_1.TabIndex = 0;
            this.Button_1.Text = "button1";
            this.Button_1.UseVisualStyleBackColor = true;
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.Location = new System.Drawing.Point(25, 221);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(44, 16);
            this.Label_1.TabIndex = 1;
            this.Label_1.Text = "label1";
            // 
            // Button_Translate
            // 
            this.Button_Translate.Location = new System.Drawing.Point(681, 415);
            this.Button_Translate.Name = "Button_Translate";
            this.Button_Translate.Size = new System.Drawing.Size(75, 23);
            this.Button_Translate.TabIndex = 2;
            this.Button_Translate.Text = "Translate";
            this.Button_Translate.UseVisualStyleBackColor = true;
            this.Button_Translate.Click += new System.EventHandler(this.Button_Translate_Click);
            // 
            // GroupBox_Test
            // 
            this.GroupBox_Test.Controls.Add(this.RadioButton_2);
            this.GroupBox_Test.Controls.Add(this.RadioButton_1);
            this.GroupBox_Test.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Test.Name = "GroupBox_Test";
            this.GroupBox_Test.Size = new System.Drawing.Size(200, 100);
            this.GroupBox_Test.TabIndex = 3;
            this.GroupBox_Test.TabStop = false;
            this.GroupBox_Test.Text = "groupBox1";
            // 
            // CheckBox_1
            // 
            this.CheckBox_1.AutoSize = true;
            this.CheckBox_1.Location = new System.Drawing.Point(28, 131);
            this.CheckBox_1.Name = "CheckBox_1";
            this.CheckBox_1.Size = new System.Drawing.Size(95, 20);
            this.CheckBox_1.TabIndex = 4;
            this.CheckBox_1.Text = "checkBox1";
            this.CheckBox_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton_1
            // 
            this.RadioButton_1.AutoSize = true;
            this.RadioButton_1.Location = new System.Drawing.Point(16, 30);
            this.RadioButton_1.Name = "RadioButton_1";
            this.RadioButton_1.Size = new System.Drawing.Size(103, 20);
            this.RadioButton_1.TabIndex = 0;
            this.RadioButton_1.TabStop = true;
            this.RadioButton_1.Text = "radioButton1";
            this.RadioButton_1.UseVisualStyleBackColor = true;
            // 
            // RadioButton_2
            // 
            this.RadioButton_2.AutoSize = true;
            this.RadioButton_2.Location = new System.Drawing.Point(16, 56);
            this.RadioButton_2.Name = "RadioButton_2";
            this.RadioButton_2.Size = new System.Drawing.Size(103, 20);
            this.RadioButton_2.TabIndex = 0;
            this.RadioButton_2.TabStop = true;
            this.RadioButton_2.Text = "radioButton1";
            this.RadioButton_2.UseVisualStyleBackColor = true;
            // 
            // TestControl_1
            // 
            this.TestControl_1.Location = new System.Drawing.Point(252, 36);
            this.TestControl_1.Name = "TestControl_1";
            this.TestControl_1.Size = new System.Drawing.Size(150, 52);
            this.TestControl_1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestControl_1);
            this.Controls.Add(this.CheckBox_1);
            this.Controls.Add(this.GroupBox_Test);
            this.Controls.Add(this.Button_Translate);
            this.Controls.Add(this.Label_1);
            this.Controls.Add(this.Button_1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.GroupBox_Test.ResumeLayout(false);
            this.GroupBox_Test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Button Button_Translate;
        private System.Windows.Forms.GroupBox GroupBox_Test;
        private System.Windows.Forms.RadioButton RadioButton_2;
        private System.Windows.Forms.RadioButton RadioButton_1;
        private System.Windows.Forms.CheckBox CheckBox_1;
        private Controls.TestControl TestControl_1;
    }
}

