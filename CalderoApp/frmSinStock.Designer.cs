namespace CalderoApp
{
    partial class frmSinStock
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
            this.dgvSinStock = new System.Windows.Forms.DataGridView();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.btnCancelarSinStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos sin stock";
            // 
            // dgvSinStock
            // 
            this.dgvSinStock.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinStock.Location = new System.Drawing.Point(37, 83);
            this.dgvSinStock.Name = "dgvSinStock";
            this.dgvSinStock.Size = new System.Drawing.Size(443, 331);
            this.dgvSinStock.TabIndex = 1;
            this.dgvSinStock.SelectionChanged += new System.EventHandler(this.dgvSinStock_SelectionChanged);
            // 
            // btnDarAlta
            // 
            this.btnDarAlta.BackColor = System.Drawing.Color.Thistle;
            this.btnDarAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarAlta.Location = new System.Drawing.Point(116, 453);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(83, 31);
            this.btnDarAlta.TabIndex = 2;
            this.btnDarAlta.Text = "Dar Alta";
            this.btnDarAlta.UseVisualStyleBackColor = false;
            this.btnDarAlta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDarAlta_MouseClick);
            // 
            // btnCancelarSinStock
            // 
            this.btnCancelarSinStock.BackColor = System.Drawing.Color.Thistle;
            this.btnCancelarSinStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarSinStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarSinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarSinStock.Location = new System.Drawing.Point(295, 453);
            this.btnCancelarSinStock.Name = "btnCancelarSinStock";
            this.btnCancelarSinStock.Size = new System.Drawing.Size(83, 31);
            this.btnCancelarSinStock.TabIndex = 3;
            this.btnCancelarSinStock.Text = "Cancelar";
            this.btnCancelarSinStock.UseVisualStyleBackColor = false;
            this.btnCancelarSinStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCancelarSinStock_MouseClick);
            // 
            // frmSinStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(515, 518);
            this.Controls.Add(this.btnCancelarSinStock);
            this.Controls.Add(this.btnDarAlta);
            this.Controls.Add(this.dgvSinStock);
            this.Controls.Add(this.label1);
            this.Name = "frmSinStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinStock";
            this.Load += new System.EventHandler(this.frmSinStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSinStock;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button btnCancelarSinStock;
    }
}