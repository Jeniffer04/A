
namespace AulaWinFormsPt2
{
    partial class Exec02Deposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exec02Deposito));
            this.txtContaD = new System.Windows.Forms.TextBox();
            this.txtQtdD = new System.Windows.Forms.TextBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnExtratoD = new System.Windows.Forms.Button();
            this.btnVolta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContaD
            // 
            this.txtContaD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtContaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaD.Location = new System.Drawing.Point(408, 188);
            this.txtContaD.Name = "txtContaD";
            this.txtContaD.Size = new System.Drawing.Size(298, 35);
            this.txtContaD.TabIndex = 2;
            // 
            // txtQtdD
            // 
            this.txtQtdD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtQtdD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdD.Location = new System.Drawing.Point(408, 257);
            this.txtQtdD.Name = "txtQtdD";
            this.txtQtdD.Size = new System.Drawing.Size(298, 35);
            this.txtQtdD.TabIndex = 3;
            // 
            // btnDeposito
            // 
            this.btnDeposito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposito.BackgroundImage")));
            this.btnDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(280, 334);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(403, 103);
            this.btnDeposito.TabIndex = 4;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnExtratoD
            // 
            this.btnExtratoD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExtratoD.BackgroundImage")));
            this.btnExtratoD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExtratoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtratoD.Location = new System.Drawing.Point(18, 497);
            this.btnExtratoD.Name = "btnExtratoD";
            this.btnExtratoD.Size = new System.Drawing.Size(449, 79);
            this.btnExtratoD.TabIndex = 5;
            this.btnExtratoD.Text = "Extrato";
            this.btnExtratoD.UseVisualStyleBackColor = true;
            this.btnExtratoD.Click += new System.EventHandler(this.btnExtratoD_Click);
            // 
            // btnVolta
            // 
            this.btnVolta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolta.BackgroundImage")));
            this.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolta.Location = new System.Drawing.Point(649, 497);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(257, 79);
            this.btnVolta.TabIndex = 6;
            this.btnVolta.Text = "Voltar";
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade R$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Exec02Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(946, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnExtratoD);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.txtQtdD);
            this.Controls.Add(this.txtContaD);
            this.Name = "Exec02Deposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02Deposito";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContaD;
        private System.Windows.Forms.TextBox txtQtdD;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnExtratoD;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}