namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.primerNumero = new System.Windows.Forms.TextBox();
            this.segundoNumero = new System.Windows.Forms.TextBox();
            this.sumaBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.restaBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.multiplicacionBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resultadoTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE UN NÚMERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESE OTRO NÚMERO ";
            // 
            // primerNumero
            // 
            this.primerNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerNumero.Location = new System.Drawing.Point(212, 38);
            this.primerNumero.Name = "primerNumero";
            this.primerNumero.Size = new System.Drawing.Size(208, 27);
            this.primerNumero.TabIndex = 2;
            // 
            // segundoNumero
            // 
            this.segundoNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoNumero.Location = new System.Drawing.Point(212, 93);
            this.segundoNumero.Name = "segundoNumero";
            this.segundoNumero.Size = new System.Drawing.Size(208, 27);
            this.segundoNumero.TabIndex = 3;
            // 
            // sumaBtn
            // 
            this.sumaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumaBtn.Location = new System.Drawing.Point(131, 177);
            this.sumaBtn.Name = "sumaBtn";
            this.sumaBtn.Size = new System.Drawing.Size(75, 23);
            this.sumaBtn.TabIndex = 4;
            this.sumaBtn.Text = "+";
            this.sumaBtn.UseVisualStyleBackColor = true;
            this.sumaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionBtn.Location = new System.Drawing.Point(16, 177);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(75, 23);
            this.divisionBtn.TabIndex = 5;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = true;
            this.divisionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // restaBtn
            // 
            this.restaBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restaBtn.Location = new System.Drawing.Point(254, 177);
            this.restaBtn.Name = "restaBtn";
            this.restaBtn.Size = new System.Drawing.Size(75, 23);
            this.restaBtn.TabIndex = 6;
            this.restaBtn.Text = "-";
            this.restaBtn.UseVisualStyleBackColor = true;
            this.restaBtn.Click += new System.EventHandler(this.restaBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(16, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "CE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // multiplicacionBtn
            // 
            this.multiplicacionBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacionBtn.Location = new System.Drawing.Point(368, 177);
            this.multiplicacionBtn.Name = "multiplicacionBtn";
            this.multiplicacionBtn.Size = new System.Drawing.Size(75, 23);
            this.multiplicacionBtn.TabIndex = 8;
            this.multiplicacionBtn.Text = "*";
            this.multiplicacionBtn.UseVisualStyleBackColor = true;
            this.multiplicacionBtn.Click += new System.EventHandler(this.multiplicacionBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "RESULTADO:";
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.AutoSize = true;
            this.resultadoTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTxt.Location = new System.Drawing.Point(120, 325);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.Size = new System.Drawing.Size(0, 20);
            this.resultadoTxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 383);
            this.Controls.Add(this.resultadoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multiplicacionBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.restaBtn);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.sumaBtn);
            this.Controls.Add(this.segundoNumero);
            this.Controls.Add(this.primerNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox primerNumero;
        private System.Windows.Forms.TextBox segundoNumero;
        private System.Windows.Forms.Button sumaBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button restaBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button multiplicacionBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultadoTxt;
    }
}

