
namespace Esteban
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelOpcionesLateral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCerrarPrincipal = new System.Windows.Forms.Button();
            this.panelBlancoPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelOpcionesLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelBlancoPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 265);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(307, 161);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelOpcionesLateral
            // 
            this.panelOpcionesLateral.AutoScroll = true;
            this.panelOpcionesLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.panelOpcionesLateral.Controls.Add(this.pictureBox1);
            this.panelOpcionesLateral.Controls.Add(this.flowLayoutPanel1);
            this.panelOpcionesLateral.Controls.Add(this.flowLayoutPanel2);
            this.panelOpcionesLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpcionesLateral.Location = new System.Drawing.Point(0, 0);
            this.panelOpcionesLateral.Name = "panelOpcionesLateral";
            this.panelOpcionesLateral.Size = new System.Drawing.Size(325, 953);
            this.panelOpcionesLateral.TabIndex = 0;
            this.panelOpcionesLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpcionesLateral_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.btnCerrarPrincipal);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 825);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(307, 77);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.btnCerrarPrincipal.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(3, 3);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(295, 58);
            this.btnCerrarPrincipal.TabIndex = 0;
            this.btnCerrarPrincipal.Text = "Cerrar";
            this.btnCerrarPrincipal.UseVisualStyleBackColor = false;
            this.btnCerrarPrincipal.Click += new System.EventHandler(this.btnCerrarPrincipal_Click);
            // 
            // panelBlancoPrincipal
            // 
            this.panelBlancoPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.panelBlancoPrincipal.Controls.Add(this.pictureBox2);
            this.panelBlancoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBlancoPrincipal.Location = new System.Drawing.Point(325, 0);
            this.panelBlancoPrincipal.Name = "panelBlancoPrincipal";
            this.panelBlancoPrincipal.Size = new System.Drawing.Size(1599, 953);
            this.panelBlancoPrincipal.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(735, 412);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.panelBlancoPrincipal);
            this.Controls.Add(this.panelOpcionesLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelOpcionesLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelBlancoPrincipal.ResumeLayout(false);
            this.panelBlancoPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelOpcionesLateral;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBlancoPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCerrarPrincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

