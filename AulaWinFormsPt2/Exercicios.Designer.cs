
namespace AulaWinFormsPt2
{
    partial class Exercicios
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
            this.btnExec01 = new System.Windows.Forms.Button();
            this.btnExec02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExec01
            // 
            this.btnExec01.Location = new System.Drawing.Point(12, 33);
            this.btnExec01.Name = "btnExec01";
            this.btnExec01.Size = new System.Drawing.Size(75, 23);
            this.btnExec01.TabIndex = 0;
            this.btnExec01.Text = "Exec01";
            this.btnExec01.UseVisualStyleBackColor = true;
            this.btnExec01.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExec02
            // 
            this.btnExec02.Location = new System.Drawing.Point(12, 110);
            this.btnExec02.Name = "btnExec02";
            this.btnExec02.Size = new System.Drawing.Size(75, 23);
            this.btnExec02.TabIndex = 1;
            this.btnExec02.Text = "Exec02";
            this.btnExec02.UseVisualStyleBackColor = true;
            this.btnExec02.Click += new System.EventHandler(this.btnExec02_Click);
            // 
            // Exercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExec02);
            this.Controls.Add(this.btnExec01);
            this.Name = "Exercicios";
            this.Text = "Exercicios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExec01;
        private System.Windows.Forms.Button btnExec02;
    }
}