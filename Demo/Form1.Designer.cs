namespace Demo
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
            this.deptrai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deptrai
            // 
            this.deptrai.Location = new System.Drawing.Point(109, 81);
            this.deptrai.Name = "deptrai";
            this.deptrai.Size = new System.Drawing.Size(88, 38);
            this.deptrai.TabIndex = 0;
            this.deptrai.Text = "deptrai";
            this.deptrai.UseVisualStyleBackColor = true;
            this.deptrai.Click += new System.EventHandler(this.deptrai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deptrai);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button deptrai;
    }
}