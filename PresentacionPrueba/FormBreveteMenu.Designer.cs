namespace PresentacionPrueba
{
    partial class FormBreveteMenu
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
            this.btn_RegistrarBrevete = new System.Windows.Forms.Button();
            this.txtfechacaducidad = new System.Windows.Forms.TextBox();
            this.txtfechaemision = new System.Windows.Forms.TextBox();
            this.txtcategoriabrevete = new System.Windows.Forms.TextBox();
            this.txtidbrevete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_RegistrarBrevete
            // 
            this.btn_RegistrarBrevete.Location = new System.Drawing.Point(161, 297);
            this.btn_RegistrarBrevete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RegistrarBrevete.Name = "btn_RegistrarBrevete";
            this.btn_RegistrarBrevete.Size = new System.Drawing.Size(100, 28);
            this.btn_RegistrarBrevete.TabIndex = 19;
            this.btn_RegistrarBrevete.Text = "Registrar";
            this.btn_RegistrarBrevete.UseVisualStyleBackColor = true;
            this.btn_RegistrarBrevete.Click += new System.EventHandler(this.btn_RegistrarBrevete_Click);
            // 
            // txtfechacaducidad
            // 
            this.txtfechacaducidad.Location = new System.Drawing.Point(217, 247);
            this.txtfechacaducidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfechacaducidad.Name = "txtfechacaducidad";
            this.txtfechacaducidad.Size = new System.Drawing.Size(188, 22);
            this.txtfechacaducidad.TabIndex = 18;
            // 
            // txtfechaemision
            // 
            this.txtfechaemision.Location = new System.Drawing.Point(217, 210);
            this.txtfechaemision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfechaemision.Name = "txtfechaemision";
            this.txtfechaemision.Size = new System.Drawing.Size(188, 22);
            this.txtfechaemision.TabIndex = 17;
            // 
            // txtcategoriabrevete
            // 
            this.txtcategoriabrevete.Location = new System.Drawing.Point(217, 170);
            this.txtcategoriabrevete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcategoriabrevete.Name = "txtcategoriabrevete";
            this.txtcategoriabrevete.Size = new System.Drawing.Size(188, 22);
            this.txtcategoriabrevete.TabIndex = 16;
            // 
            // txtidbrevete
            // 
            this.txtidbrevete.Location = new System.Drawing.Point(217, 129);
            this.txtidbrevete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidbrevete.Name = "txtidbrevete";
            this.txtidbrevete.Size = new System.Drawing.Size(188, 22);
            this.txtidbrevete.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de caducidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingrese los datos de su Brevete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de emisión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // FormBreveteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 394);
            this.Controls.Add(this.btn_RegistrarBrevete);
            this.Controls.Add(this.txtfechacaducidad);
            this.Controls.Add(this.txtfechaemision);
            this.Controls.Add(this.txtcategoriabrevete);
            this.Controls.Add(this.txtidbrevete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBreveteMenu";
            this.Text = "FormBreveteMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegistrarBrevete;
        private System.Windows.Forms.TextBox txtfechacaducidad;
        private System.Windows.Forms.TextBox txtfechaemision;
        private System.Windows.Forms.TextBox txtcategoriabrevete;
        private System.Windows.Forms.TextBox txtidbrevete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}