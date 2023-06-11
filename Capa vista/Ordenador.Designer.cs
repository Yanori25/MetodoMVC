
namespace Capas_controladora_y_vista.Capa_vista
{
    partial class Ordenador
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
            this.txtvalor_A = new System.Windows.Forms.TextBox();
            this.btnASCENDENTE = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btnDESCENDENTE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvalor_D = new System.Windows.Forms.TextBox();
            this.txtvalor_B = new System.Windows.Forms.TextBox();
            this.txtvalor_C = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalor_A
            // 
            this.txtvalor_A.Location = new System.Drawing.Point(119, 38);
            this.txtvalor_A.Name = "txtvalor_A";
            this.txtvalor_A.Size = new System.Drawing.Size(100, 20);
            this.txtvalor_A.TabIndex = 0;
            this.txtvalor_A.Text = "3";
            this.txtvalor_A.TextChanged += new System.EventHandler(this.txtvalor_A_TextChanged);
            this.txtvalor_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_A_KeyPress);
            // 
            // btnASCENDENTE
            // 
            this.btnASCENDENTE.Location = new System.Drawing.Point(267, 28);
            this.btnASCENDENTE.Name = "btnASCENDENTE";
            this.btnASCENDENTE.Size = new System.Drawing.Size(149, 23);
            this.btnASCENDENTE.TabIndex = 1;
            this.btnASCENDENTE.Text = "ORDEN ASCENDENTE";
            this.btnASCENDENTE.UseVisualStyleBackColor = true;
            this.btnASCENDENTE.Click += new System.EventHandler(this.btnascendente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbresultado);
            this.groupBox1.Controls.Add(this.btnDESCENDENTE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtvalor_D);
            this.groupBox1.Controls.Add(this.txtvalor_B);
            this.groupBox1.Controls.Add(this.txtvalor_C);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtvalor_A);
            this.groupBox1.Controls.Add(this.btnASCENDENTE);
            this.groupBox1.Location = new System.Drawing.Point(47, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 259);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(145, 216);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(0, 13);
            this.lbresultado.TabIndex = 10;
            // 
            // btnDESCENDENTE
            // 
            this.btnDESCENDENTE.Location = new System.Drawing.Point(267, 120);
            this.btnDESCENDENTE.Name = "btnDESCENDENTE";
            this.btnDESCENDENTE.Size = new System.Drawing.Size(149, 23);
            this.btnDESCENDENTE.TabIndex = 9;
            this.btnDESCENDENTE.Text = "ORDEN DESCENDENTE";
            this.btnDESCENDENTE.UseVisualStyleBackColor = true;
            this.btnDESCENDENTE.Click += new System.EventHandler(this.btnDESCENDENTE_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "VALOR 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALOR 3";
            // 
            // txtvalor_D
            // 
            this.txtvalor_D.Location = new System.Drawing.Point(119, 163);
            this.txtvalor_D.Name = "txtvalor_D";
            this.txtvalor_D.Size = new System.Drawing.Size(100, 20);
            this.txtvalor_D.TabIndex = 6;
            this.txtvalor_D.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtvalor_D.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_D_KeyPress);
            // 
            // txtvalor_B
            // 
            this.txtvalor_B.Location = new System.Drawing.Point(119, 77);
            this.txtvalor_B.Name = "txtvalor_B";
            this.txtvalor_B.Size = new System.Drawing.Size(100, 20);
            this.txtvalor_B.TabIndex = 5;
            this.txtvalor_B.Text = "24";
            this.txtvalor_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_B_KeyPress);
            // 
            // txtvalor_C
            // 
            this.txtvalor_C.Location = new System.Drawing.Point(119, 123);
            this.txtvalor_C.Name = "txtvalor_C";
            this.txtvalor_C.Size = new System.Drawing.Size(100, 20);
            this.txtvalor_C.TabIndex = 4;
            this.txtvalor_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_C_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VALOR 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VALOR 1";
            // 
            // Ordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ordenador";
            this.Text = "Ordenador de Valores";
            this.Load += new System.EventHandler(this.Ordenador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor_A;
        private System.Windows.Forms.Button btnASCENDENTE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDESCENDENTE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtvalor_D;
        private System.Windows.Forms.TextBox txtvalor_B;
        private System.Windows.Forms.TextBox txtvalor_C;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbresultado;
    }
}