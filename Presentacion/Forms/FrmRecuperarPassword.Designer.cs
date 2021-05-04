
namespace Presentacion.Forms
{
    partial class FrmRecuperarPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtUsuarioMail = new System.Windows.Forms.TextBox();
            this.lblUsuarioMail = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.ipbCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblResultado);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.txtUsuarioMail);
            this.panel1.Controls.Add(this.lblUsuarioMail);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(17, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 252);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recuperar Contraseña";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.White;
            this.lblResultado.Location = new System.Drawing.Point(11, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(342, 75);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(215, 98);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(138, 34);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtUsuarioMail
            // 
            this.txtUsuarioMail.Location = new System.Drawing.Point(14, 72);
            this.txtUsuarioMail.Name = "txtUsuarioMail";
            this.txtUsuarioMail.Size = new System.Drawing.Size(339, 20);
            this.txtUsuarioMail.TabIndex = 5;
            // 
            // lblUsuarioMail
            // 
            this.lblUsuarioMail.AutoSize = true;
            this.lblUsuarioMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioMail.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioMail.Location = new System.Drawing.Point(11, 53);
            this.lblUsuarioMail.Name = "lblUsuarioMail";
            this.lblUsuarioMail.Size = new System.Drawing.Size(259, 16);
            this.lblUsuarioMail.TabIndex = 4;
            this.lblUsuarioMail.Text = "Ingrese su Nombre de Usuario o su Email:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(364, 248);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 11;
            this.lineShape1.X2 = 352;
            this.lineShape1.Y1 = 150;
            this.lineShape1.Y2 = 150;
            // 
            // ipbCerrar
            // 
            this.ipbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.ipbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ipbCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ipbCerrar.IconColor = System.Drawing.Color.White;
            this.ipbCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbCerrar.IconSize = 16;
            this.ipbCerrar.Location = new System.Drawing.Point(384, 6);
            this.ipbCerrar.Name = "ipbCerrar";
            this.ipbCerrar.Size = new System.Drawing.Size(16, 16);
            this.ipbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ipbCerrar.TabIndex = 13;
            this.ipbCerrar.TabStop = false;
            this.ipbCerrar.Click += new System.EventHandler(this.ipbCerrar_Click);
            // 
            // FrmRecuperarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(407, 307);
            this.Controls.Add(this.ipbCerrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecuperarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRecuperarPassword";
            this.Load += new System.EventHandler(this.FrmRecuperarPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtUsuarioMail;
        private System.Windows.Forms.Label lblUsuarioMail;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private FontAwesome.Sharp.IconPictureBox ipbCerrar;
    }
}