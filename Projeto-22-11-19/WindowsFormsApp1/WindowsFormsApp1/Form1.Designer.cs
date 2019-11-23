namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblCodBarras = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lstCarrinho = new System.Windows.Forms.ListView();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnProx = new System.Windows.Forms.Button();
            this.btnAnt = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(142, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 26);
            this.txtNome.TabIndex = 0;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(142, 75);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(100, 26);
            this.txtCodBarras.TabIndex = 1;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(63, 114);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 26);
            this.txtPreco.TabIndex = 2;
            // 
            // lblCodBarras
            // 
            this.lblCodBarras.AutoSize = true;
            this.lblCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBarras.Location = new System.Drawing.Point(3, 75);
            this.lblCodBarras.Name = "lblCodBarras";
            this.lblCodBarras.Size = new System.Drawing.Size(136, 20);
            this.lblCodBarras.TabIndex = 4;
            this.lblCodBarras.Text = "Código de Barras:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(3, 117);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 20);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.Text = "Preço:";
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCarrinho.Location = new System.Drawing.Point(355, 37);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(154, 97);
            this.lstCarrinho.TabIndex = 7;
            this.lstCarrinho.UseCompatibleStateImageBehavior = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(137, 20);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // btnProx
            // 
            this.btnProx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProx.Location = new System.Drawing.Point(326, 38);
            this.btnProx.Name = "btnProx";
            this.btnProx.Size = new System.Drawing.Size(22, 23);
            this.btnProx.TabIndex = 9;
            this.btnProx.Text = ">";
            this.btnProx.UseVisualStyleBackColor = true;
            // 
            // btnAnt
            // 
            this.btnAnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnt.Location = new System.Drawing.Point(326, 68);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(22, 23);
            this.btnAnt.TabIndex = 10;
            this.btnAnt.Text = "<";
            this.btnAnt.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(351, 145);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(430, 142);
            this.maskedTextBox1.Mask = "$0000,00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(79, 26);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 317);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnProx);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lstCarrinho);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblCodBarras);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblCodBarras;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ListView lstCarrinho;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnProx;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

