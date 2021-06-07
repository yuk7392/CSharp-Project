
namespace Prac9_6_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstCheck = new System.Windows.Forms.CheckBox();
            this.secondCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // firstCheck
            // 
            this.firstCheck.AutoSize = true;
            this.firstCheck.Location = new System.Drawing.Point(40, 42);
            this.firstCheck.Name = "firstCheck";
            this.firstCheck.Size = new System.Drawing.Size(50, 19);
            this.firstCheck.TabIndex = 0;
            this.firstCheck.Text = "적용";
            this.firstCheck.UseVisualStyleBackColor = true;
            // 
            // secondCheck
            // 
            this.secondCheck.AutoSize = true;
            this.secondCheck.Location = new System.Drawing.Point(207, 42);
            this.secondCheck.Name = "secondCheck";
            this.secondCheck.Size = new System.Drawing.Size(50, 19);
            this.secondCheck.TabIndex = 1;
            this.secondCheck.Text = "색상";
            this.secondCheck.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "글꼴 대화상자 열기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 176);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondCheck);
            this.Controls.Add(this.firstCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox firstCheck;
        private System.Windows.Forms.CheckBox secondCheck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

