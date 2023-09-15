namespace CalderoApp
{
    partial class frmCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.lblCat = new System.Windows.Forms.Label();
            this.pboxCat = new System.Windows.Forms.PictureBox();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(50, 83);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(190, 303);
            this.dgvCategorias.TabIndex = 0;
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvCategorias_SelectionChanged);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(46, 32);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(184, 24);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Lista de categorias";
            // 
            // pboxCat
            // 
            this.pboxCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxCat.Location = new System.Drawing.Point(277, 83);
            this.pboxCat.Name = "pboxCat";
            this.pboxCat.Size = new System.Drawing.Size(183, 177);
            this.pboxCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCat.TabIndex = 2;
            this.pboxCat.TabStop = false;
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.BackColor = System.Drawing.Color.Thistle;
            this.btnAgregarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCat.Location = new System.Drawing.Point(50, 430);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(83, 31);
            this.btnAgregarCat.TabIndex = 3;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = false;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.BackColor = System.Drawing.Color.Thistle;
            this.btnEliminarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCat.Location = new System.Drawing.Point(157, 430);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(83, 31);
            this.btnEliminarCat.TabIndex = 4;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = false;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(494, 501);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.pboxCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.dgvCategorias);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.PictureBox pboxCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Button btnEliminarCat;
    }
}