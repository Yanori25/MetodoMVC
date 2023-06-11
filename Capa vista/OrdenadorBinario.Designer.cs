
namespace Capas_controladora_y_vista.Capa_vista
{
    partial class OrdenadorBinario
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
            this.btnconvertir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtconvertit = new System.Windows.Forms.TextBox();
            this.lbconvertir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnconvertir.Location = new System.Drawing.Point(184, 154);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(155, 36);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "CONVERTIR A BINARIO";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtconvertit
            // 
            this.txtconvertit.Location = new System.Drawing.Point(184, 102);
            this.txtconvertit.Name = "txtconvertit";
            this.txtconvertit.Size = new System.Drawing.Size(155, 20);
            this.txtconvertit.TabIndex = 2;
            this.txtconvertit.TextChanged += new System.EventHandler(this.txtconvertit_TextChanged);
            this.txtconvertit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtconvertit_KeyPress);
            // 
            // lbconvertir
            // 
            this.lbconvertir.AutoSize = true;
            this.lbconvertir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbconvertir.Location = new System.Drawing.Point(181, 38);
            this.lbconvertir.Name = "lbconvertir";
            this.lbconvertir.Size = new System.Drawing.Size(142, 13);
            this.lbconvertir.TabIndex = 3;
            this.lbconvertir.Text = "DIGITE NUMERO ENTERO";
            // 
            // OrdenadorBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(409, 274);
            this.Controls.Add(this.lbconvertir);
            this.Controls.Add(this.txtconvertit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconvertir);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "OrdenadorBinario";
            this.Text = "CONVERTIR ENTERO A BINARIO";
            this.Load += new System.EventHandler(this.OrdenadorBinario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtconvertit;
        private System.Windows.Forms.Label lbconvertir;
    }
}