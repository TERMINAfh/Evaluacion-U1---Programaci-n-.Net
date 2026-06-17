namespace Evaluacion1
{
    partial class FrmMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimiento));
            this.CalacaChida = new System.Windows.Forms.PictureBox();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnReinicar = new System.Windows.Forms.Button();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.lblPaso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CalacaChida)).BeginInit();
            this.SuspendLayout();
            // 
            // CalacaChida
            // 
            this.CalacaChida.Image = ((System.Drawing.Image)(resources.GetObject("CalacaChida.Image")));
            this.CalacaChida.Location = new System.Drawing.Point(0, 0);
            this.CalacaChida.Name = "CalacaChida";
            this.CalacaChida.Size = new System.Drawing.Size(163, 147);
            this.CalacaChida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CalacaChida.TabIndex = 0;
            this.CalacaChida.TabStop = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(12, 415);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(107, 415);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 2;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnReinicar
            // 
            this.btnReinicar.Location = new System.Drawing.Point(201, 415);
            this.btnReinicar.Name = "btnReinicar";
            this.btnReinicar.Size = new System.Drawing.Size(75, 23);
            this.btnReinicar.TabIndex = 3;
            this.btnReinicar.Text = "Reinicar";
            this.btnReinicar.UseVisualStyleBackColor = true;
            this.btnReinicar.Click += new System.EventHandler(this.btnReinicar_Click);
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(348, 418);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(49, 20);
            this.txtPaso.TabIndex = 4;
            this.txtPaso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPaso
            // 
            this.lblPaso.AutoSize = true;
            this.lblPaso.Location = new System.Drawing.Point(307, 421);
            this.lblPaso.Name = "lblPaso";
            this.lblPaso.Size = new System.Drawing.Size(34, 13);
            this.lblPaso.TabIndex = 5;
            this.lblPaso.Text = "Paso:";
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPaso);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.btnReinicar);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.CalacaChida);
            this.Name = "FrmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMovimiento_FormClosed);
            this.Load += new System.EventHandler(this.FrmMovimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalacaChida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CalacaChida;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnReinicar;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Label lblPaso;
    }
}