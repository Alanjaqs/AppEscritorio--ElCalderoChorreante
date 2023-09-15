namespace CalderoApp
{
    partial class frmAgregar
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
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockProd = new System.Windows.Forms.TextBox();
            this.chbAlta = new System.Windows.Forms.CheckBox();
            this.cmbAgregarCat = new System.Windows.Forms.ComboBox();
            this.txtImagenProd = new System.Windows.Forms.TextBox();
            this.pboxAgregarProd = new System.Windows.Forms.PictureBox();
            this.btnAceptarProd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregarImagenLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Location = new System.Drawing.Point(152, 47);
            this.txtNombreProd.MaxLength = 20;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(186, 20);
            this.txtNombreProd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Location = new System.Drawing.Point(152, 93);
            this.txtDescripcionProd.MaxLength = 255;
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Size = new System.Drawing.Size(186, 20);
            this.txtDescripcionProd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imagen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio:";
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.Location = new System.Drawing.Point(152, 241);
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(186, 20);
            this.txtPrecioProd.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock:";
            // 
            // txtStockProd
            // 
            this.txtStockProd.Location = new System.Drawing.Point(152, 289);
            this.txtStockProd.Name = "txtStockProd";
            this.txtStockProd.Size = new System.Drawing.Size(186, 20);
            this.txtStockProd.TabIndex = 7;
            // 
            // chbAlta
            // 
            this.chbAlta.AutoSize = true;
            this.chbAlta.Checked = true;
            this.chbAlta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlta.Location = new System.Drawing.Point(406, 264);
            this.chbAlta.Name = "chbAlta";
            this.chbAlta.Size = new System.Drawing.Size(117, 24);
            this.chbAlta.TabIndex = 10;
            this.chbAlta.Text = "Dar de alta";
            this.chbAlta.UseVisualStyleBackColor = true;
            // 
            // cmbAgregarCat
            // 
            this.cmbAgregarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAgregarCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgregarCat.FormattingEnabled = true;
            this.cmbAgregarCat.Location = new System.Drawing.Point(152, 194);
            this.cmbAgregarCat.Name = "cmbAgregarCat";
            this.cmbAgregarCat.Size = new System.Drawing.Size(186, 21);
            this.cmbAgregarCat.TabIndex = 5;
            // 
            // txtImagenProd
            // 
            this.txtImagenProd.Location = new System.Drawing.Point(152, 145);
            this.txtImagenProd.Name = "txtImagenProd";
            this.txtImagenProd.Size = new System.Drawing.Size(186, 20);
            this.txtImagenProd.TabIndex = 3;
            this.txtImagenProd.Leave += new System.EventHandler(this.txtImagenProd_Leave);
            // 
            // pboxAgregarProd
            // 
            this.pboxAgregarProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxAgregarProd.Location = new System.Drawing.Point(397, 45);
            this.pboxAgregarProd.Name = "pboxAgregarProd";
            this.pboxAgregarProd.Size = new System.Drawing.Size(176, 175);
            this.pboxAgregarProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAgregarProd.TabIndex = 13;
            this.pboxAgregarProd.TabStop = false;
            // 
            // btnAceptarProd
            // 
            this.btnAceptarProd.BackColor = System.Drawing.Color.Thistle;
            this.btnAceptarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarProd.Location = new System.Drawing.Point(164, 345);
            this.btnAceptarProd.Name = "btnAceptarProd";
            this.btnAceptarProd.Size = new System.Drawing.Size(83, 31);
            this.btnAceptarProd.TabIndex = 8;
            this.btnAceptarProd.Text = "Aceptar";
            this.btnAceptarProd.UseVisualStyleBackColor = false;
            this.btnAceptarProd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAceptarProd_MouseClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Thistle;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(328, 345);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseClick);
            // 
            // btnAgregarImagenLocal
            // 
            this.btnAgregarImagenLocal.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregarImagenLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagenLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarImagenLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagenLocal.Location = new System.Drawing.Point(345, 143);
            this.btnAgregarImagenLocal.Name = "btnAgregarImagenLocal";
            this.btnAgregarImagenLocal.Size = new System.Drawing.Size(29, 23);
            this.btnAgregarImagenLocal.TabIndex = 4;
            this.btnAgregarImagenLocal.Text = "+";
            this.btnAgregarImagenLocal.UseVisualStyleBackColor = false;
            this.btnAgregarImagenLocal.Click += new System.EventHandler(this.btnAgregarImagenLocal_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(589, 420);
            this.Controls.Add(this.btnAgregarImagenLocal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarProd);
            this.Controls.Add(this.pboxAgregarProd);
            this.Controls.Add(this.txtImagenProd);
            this.Controls.Add(this.cmbAgregarCat);
            this.Controls.Add(this.chbAlta);
            this.Controls.Add(this.txtStockProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioProd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxAgregarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockProd;
        private System.Windows.Forms.CheckBox chbAlta;
        private System.Windows.Forms.ComboBox cmbAgregarCat;
        private System.Windows.Forms.TextBox txtImagenProd;
        private System.Windows.Forms.PictureBox pboxAgregarProd;
        private System.Windows.Forms.Button btnAceptarProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarImagenLocal;
    }
}