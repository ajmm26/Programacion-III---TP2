namespace WindowsFormsApp_Tarea1.Ventanas
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEleccionAtributo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEleccionItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombreModificado = new System.Windows.Forms.TextBox();
            this.buttonModificarMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Marca o Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modificar: ";
            // 
            // cbEleccionAtributo
            // 
            this.cbEleccionAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleccionAtributo.FormattingEnabled = true;
            this.cbEleccionAtributo.Location = new System.Drawing.Point(358, 112);
            this.cbEleccionAtributo.Name = "cbEleccionAtributo";
            this.cbEleccionAtributo.Size = new System.Drawing.Size(121, 21);
            this.cbEleccionAtributo.TabIndex = 2;
            this.cbEleccionAtributo.SelectedIndexChanged += new System.EventHandler(this.cbEleccionAtributo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eligue la marca o categoria a modificar";
            // 
            // cbEleccionItem
            // 
            this.cbEleccionItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleccionItem.FormattingEnabled = true;
            this.cbEleccionItem.Location = new System.Drawing.Point(270, 233);
            this.cbEleccionItem.Name = "cbEleccionItem";
            this.cbEleccionItem.Size = new System.Drawing.Size(219, 21);
            this.cbEleccionItem.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // textNombreModificado
            // 
            this.textNombreModificado.Location = new System.Drawing.Point(369, 302);
            this.textNombreModificado.Name = "textNombreModificado";
            this.textNombreModificado.Size = new System.Drawing.Size(100, 20);
            this.textNombreModificado.TabIndex = 6;
            // 
            // buttonModificarMC
            // 
            this.buttonModificarMC.Location = new System.Drawing.Point(334, 374);
            this.buttonModificarMC.Name = "buttonModificarMC";
            this.buttonModificarMC.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarMC.TabIndex = 7;
            this.buttonModificarMC.Text = "Modificar";
            this.buttonModificarMC.UseVisualStyleBackColor = true;
            this.buttonModificarMC.Click += new System.EventHandler(this.buttonModificarMC_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModificarMC);
            this.Controls.Add(this.textNombreModificado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEleccionItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEleccionAtributo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEleccionAtributo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEleccionItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNombreModificado;
        private System.Windows.Forms.Button buttonModificarMC;
    }
}