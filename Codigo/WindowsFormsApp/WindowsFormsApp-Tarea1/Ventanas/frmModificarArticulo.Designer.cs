namespace WindowsFormsApp_Tarea1.Ventanas
{
    partial class frmModificarArticulo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescripcionModificada = new System.Windows.Forms.TextBox();
            this.PrecioModificado = new System.Windows.Forms.TextBox();
            this.nombreModificado = new System.Windows.Forms.TextBox();
            this.cboMarcaModificar = new System.Windows.Forms.ComboBox();
            this.cboCategoriaModificar = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbArticuloElegido = new System.Windows.Forms.ComboBox();
            this.ButtonModficar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.codigoModificado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCancelarMD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elige el  articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Completa solo los atributos a modificar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(432, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(432, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Categoria";
            // 
            // DescripcionModificada
            // 
            this.DescripcionModificada.Location = new System.Drawing.Point(162, 294);
            this.DescripcionModificada.Multiline = true;
            this.DescripcionModificada.Name = "DescripcionModificada";
            this.DescripcionModificada.Size = new System.Drawing.Size(180, 70);
            this.DescripcionModificada.TabIndex = 10;
            // 
            // PrecioModificado
            // 
            this.PrecioModificado.Location = new System.Drawing.Point(162, 254);
            this.PrecioModificado.Name = "PrecioModificado";
            this.PrecioModificado.Size = new System.Drawing.Size(139, 20);
            this.PrecioModificado.TabIndex = 11;
            this.PrecioModificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioModificado_KeyPress);
            // 
            // nombreModificado
            // 
            this.nombreModificado.Location = new System.Drawing.Point(162, 218);
            this.nombreModificado.Name = "nombreModificado";
            this.nombreModificado.Size = new System.Drawing.Size(222, 20);
            this.nombreModificado.TabIndex = 12;
            // 
            // cboMarcaModificar
            // 
            this.cboMarcaModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaModificar.FormattingEnabled = true;
            this.cboMarcaModificar.Location = new System.Drawing.Point(501, 201);
            this.cboMarcaModificar.Name = "cboMarcaModificar";
            this.cboMarcaModificar.Size = new System.Drawing.Size(121, 21);
            this.cboMarcaModificar.TabIndex = 13;
            // 
            // cboCategoriaModificar
            // 
            this.cboCategoriaModificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaModificar.FormattingEnabled = true;
            this.cboCategoriaModificar.Location = new System.Drawing.Point(501, 241);
            this.cboCategoriaModificar.Name = "cboCategoriaModificar";
            this.cboCategoriaModificar.Size = new System.Drawing.Size(121, 21);
            this.cboCategoriaModificar.TabIndex = 14;
            // 
            // cbArticuloElegido
            // 
            this.cbArticuloElegido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArticuloElegido.FormattingEnabled = true;
            this.cbArticuloElegido.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cbArticuloElegido.Location = new System.Drawing.Point(279, 117);
            this.cbArticuloElegido.Name = "cbArticuloElegido";
            this.cbArticuloElegido.Size = new System.Drawing.Size(258, 21);
            this.cbArticuloElegido.TabIndex = 16;
            // 
            // ButtonModficar
            // 
            this.ButtonModficar.Location = new System.Drawing.Point(318, 401);
            this.ButtonModficar.Name = "ButtonModficar";
            this.ButtonModficar.Size = new System.Drawing.Size(75, 23);
            this.ButtonModficar.TabIndex = 17;
            this.ButtonModficar.Text = "Modificar";
            this.ButtonModficar.UseVisualStyleBackColor = true;
            this.ButtonModficar.Click += new System.EventHandler(this.ButtonModficar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Codigo";
            // 
            // codigoModificado
            // 
            this.codigoModificado.Location = new System.Drawing.Point(162, 181);
            this.codigoModificado.Name = "codigoModificado";
            this.codigoModificado.Size = new System.Drawing.Size(139, 20);
            this.codigoModificado.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonCancelarMD
            // 
            this.buttonCancelarMD.Location = new System.Drawing.Point(423, 401);
            this.buttonCancelarMD.Name = "buttonCancelarMD";
            this.buttonCancelarMD.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarMD.TabIndex = 21;
            this.buttonCancelarMD.Text = "Cancelar";
            this.buttonCancelarMD.UseVisualStyleBackColor = true;
            this.buttonCancelarMD.Click += new System.EventHandler(this.buttonCancelarMD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 22;
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancelarMD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.codigoModificado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ButtonModficar);
            this.Controls.Add(this.cbArticuloElegido);
            this.Controls.Add(this.cboCategoriaModificar);
            this.Controls.Add(this.cboMarcaModificar);
            this.Controls.Add(this.nombreModificado);
            this.Controls.Add(this.PrecioModificado);
            this.Controls.Add(this.DescripcionModificada);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarArticulo";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.frmModificarArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescripcionModificada;
        private System.Windows.Forms.TextBox PrecioModificado;
        private System.Windows.Forms.TextBox nombreModificado;
        private System.Windows.Forms.ComboBox cboMarcaModificar;
        private System.Windows.Forms.ComboBox cboCategoriaModificar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbArticuloElegido;
        private System.Windows.Forms.Button ButtonModficar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox codigoModificado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCancelarMD;
        private System.Windows.Forms.TextBox textBox1;
    }
}