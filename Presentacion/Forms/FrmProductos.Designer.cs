
namespace Presentacion.Forms
{
    partial class FrmProductos
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
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.ipbCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTOS";
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(254, 446);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 40);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Guardar";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // ipbCerrar
            // 
            this.ipbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbCerrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ipbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbCerrar.ForeColor = System.Drawing.Color.Black;
            this.ipbCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ipbCerrar.IconColor = System.Drawing.Color.Black;
            this.ipbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbCerrar.IconSize = 16;
            this.ipbCerrar.Location = new System.Drawing.Point(706, 6);
            this.ipbCerrar.Name = "ipbCerrar";
            this.ipbCerrar.Size = new System.Drawing.Size(16, 16);
            this.ipbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ipbCerrar.TabIndex = 7;
            this.ipbCerrar.TabStop = false;
            this.ipbCerrar.Click += new System.EventHandler(this.ipbCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 261);
            this.dataGridView1.TabIndex = 8;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ipbCerrar);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox ipbCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}