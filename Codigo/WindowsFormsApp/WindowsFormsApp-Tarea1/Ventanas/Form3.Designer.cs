namespace WindowsFormsApp_Tarea1.Ventanas
{
    partial class frmBuscarProducto
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
            this.labelbuscar = new System.Windows.Forms.Label();
            this.buttonBuscarPDT = new System.Windows.Forms.Button();
            this.txtNombreBox = new System.Windows.Forms.TextBox();
            this.dataGProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelbuscar
            // 
            this.labelbuscar.AutoSize = true;
            this.labelbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbuscar.Location = new System.Drawing.Point(289, 60);
            this.labelbuscar.Name = "labelbuscar";
            this.labelbuscar.Size = new System.Drawing.Size(164, 24);
            this.labelbuscar.TabIndex = 0;
            this.labelbuscar.Text = "Buscar Producto";
            // 
            // buttonBuscarPDT
            // 
            this.buttonBuscarPDT.Location = new System.Drawing.Point(412, 122);
            this.buttonBuscarPDT.Name = "buttonBuscarPDT";
            this.buttonBuscarPDT.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPDT.TabIndex = 2;
            this.buttonBuscarPDT.Text = "Buscar";
            this.buttonBuscarPDT.UseVisualStyleBackColor = true;
            this.buttonBuscarPDT.Click += new System.EventHandler(this.buttonBuscarPDT_Click);
            // 
            // txtNombreBox
            // 
            this.txtNombreBox.Location = new System.Drawing.Point(223, 122);
            this.txtNombreBox.Name = "txtNombreBox";
            this.txtNombreBox.Size = new System.Drawing.Size(175, 20);
            this.txtNombreBox.TabIndex = 3;
            // 
            // dataGProductos
            // 
            this.dataGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGProductos.Location = new System.Drawing.Point(186, 179);
            this.dataGProductos.Name = "dataGProductos";
            this.dataGProductos.Size = new System.Drawing.Size(344, 128);
            this.dataGProductos.TabIndex = 4;
            this.dataGProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGProductos_CellClick);
            // 
            // frmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGProductos);
            this.Controls.Add(this.txtNombreBox);
            this.Controls.Add(this.buttonBuscarPDT);
            this.Controls.Add(this.labelbuscar);
            this.Name = "frmBuscarProducto";
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbuscar;
        private System.Windows.Forms.Button buttonBuscarPDT;
        private System.Windows.Forms.TextBox txtNombreBox;
        private System.Windows.Forms.DataGridView dataGProductos;
    }
}