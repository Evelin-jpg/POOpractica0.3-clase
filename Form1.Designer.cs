namespace POOpractica0._3__clase_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1_Escribir = new System.Windows.Forms.Button();
            this.btn2_Subrayar = new System.Windows.Forms.Button();
            this.btnLeerRecortar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1_Escribir
            // 
            this.btn1_Escribir.Location = new System.Drawing.Point(222, 28);
            this.btn1_Escribir.Name = "btn1_Escribir";
            this.btn1_Escribir.Size = new System.Drawing.Size(316, 116);
            this.btn1_Escribir.TabIndex = 0;
            this.btn1_Escribir.Text = "Escribir";
            this.btn1_Escribir.UseVisualStyleBackColor = true;
            this.btn1_Escribir.Click += new System.EventHandler(this.btn1_Escribir_Click);
            // 
            // btn2_Subrayar
            // 
            this.btn2_Subrayar.Location = new System.Drawing.Point(222, 162);
            this.btn2_Subrayar.Name = "btn2_Subrayar";
            this.btn2_Subrayar.Size = new System.Drawing.Size(316, 116);
            this.btn2_Subrayar.TabIndex = 1;
            this.btn2_Subrayar.Text = "Subrayar";
            this.btn2_Subrayar.UseVisualStyleBackColor = true;
            this.btn2_Subrayar.Click += new System.EventHandler(this.btn2_Subrayar_Click);
            // 
            // btnLeerRecortar
            // 
            this.btnLeerRecortar.Location = new System.Drawing.Point(222, 301);
            this.btnLeerRecortar.Name = "btnLeerRecortar";
            this.btnLeerRecortar.Size = new System.Drawing.Size(316, 116);
            this.btnLeerRecortar.TabIndex = 2;
            this.btnLeerRecortar.Text = "Leer Y Recortar";
            this.btnLeerRecortar.UseVisualStyleBackColor = true;
            this.btnLeerRecortar.Click += new System.EventHandler(this.btnLeerRecortar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeerRecortar);
            this.Controls.Add(this.btn2_Subrayar);
            this.Controls.Add(this.btn1_Escribir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1_Escribir;
        private System.Windows.Forms.Button btn2_Subrayar;
        private System.Windows.Forms.Button btnLeerRecortar;
    }
}

