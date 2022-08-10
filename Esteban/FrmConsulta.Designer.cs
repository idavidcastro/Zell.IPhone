
namespace Esteban
{
    partial class FrmConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbOpcionesdeConsulta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelBlanco = new System.Windows.Forms.Label();
            this.dataConsultaEnConsulta = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNombreClienteConsultar = new System.Windows.Forms.TextBox();
            this.cmbBlanco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaEnConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOpcionesdeConsulta
            // 
            this.cmbOpcionesdeConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesdeConsulta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOpcionesdeConsulta.FormattingEnabled = true;
            this.cmbOpcionesdeConsulta.IntegralHeight = false;
            this.cmbOpcionesdeConsulta.Items.AddRange(new object[] {
            "Teléfono",
            "Nombre",
            "IMEI",
            "Color",
            "GB"});
            this.cmbOpcionesdeConsulta.Location = new System.Drawing.Point(577, 56);
            this.cmbOpcionesdeConsulta.Name = "cmbOpcionesdeConsulta";
            this.cmbOpcionesdeConsulta.Size = new System.Drawing.Size(189, 28);
            this.cmbOpcionesdeConsulta.TabIndex = 29;
            this.cmbOpcionesdeConsulta.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(422, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "Consultar por:";
            // 
            // labelBlanco
            // 
            this.labelBlanco.AutoSize = true;
            this.labelBlanco.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlanco.ForeColor = System.Drawing.Color.White;
            this.labelBlanco.Location = new System.Drawing.Point(868, 58);
            this.labelBlanco.Name = "labelBlanco";
            this.labelBlanco.Size = new System.Drawing.Size(0, 22);
            this.labelBlanco.TabIndex = 31;
            // 
            // dataConsultaEnConsulta
            // 
            this.dataConsultaEnConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dataConsultaEnConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataConsultaEnConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataConsultaEnConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataConsultaEnConsulta.ColumnHeadersHeight = 30;
            this.dataConsultaEnConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataConsultaEnConsulta.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataConsultaEnConsulta.EnableHeadersVisualStyles = false;
            this.dataConsultaEnConsulta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.dataConsultaEnConsulta.Location = new System.Drawing.Point(143, 140);
            this.dataConsultaEnConsulta.Name = "dataConsultaEnConsulta";
            this.dataConsultaEnConsulta.RowHeadersVisible = false;
            this.dataConsultaEnConsulta.RowHeadersWidth = 51;
            this.dataConsultaEnConsulta.RowTemplate.Height = 24;
            this.dataConsultaEnConsulta.Size = new System.Drawing.Size(1313, 673);
            this.dataConsultaEnConsulta.TabIndex = 40;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(684, 839);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 43);
            this.button5.TabIndex = 41;
            this.button5.Text = "Refrescar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtNombreClienteConsultar
            // 
            this.txtNombreClienteConsultar.BackColor = System.Drawing.Color.White;
            this.txtNombreClienteConsultar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteConsultar.Location = new System.Drawing.Point(978, 54);
            this.txtNombreClienteConsultar.Multiline = true;
            this.txtNombreClienteConsultar.Name = "txtNombreClienteConsultar";
            this.txtNombreClienteConsultar.Size = new System.Drawing.Size(210, 30);
            this.txtNombreClienteConsultar.TabIndex = 42;
            this.txtNombreClienteConsultar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombreCliente_KeyUp);
            // 
            // cmbBlanco
            // 
            this.cmbBlanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlanco.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlanco.FormattingEnabled = true;
            this.cmbBlanco.IntegralHeight = false;
            this.cmbBlanco.Items.AddRange(new object[] {
            "Teléfono",
            "Nombre",
            "IMEI",
            "Color",
            "GB"});
            this.cmbBlanco.Location = new System.Drawing.Point(978, 56);
            this.cmbBlanco.Name = "cmbBlanco";
            this.cmbBlanco.Size = new System.Drawing.Size(210, 28);
            this.cmbBlanco.TabIndex = 43;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1599, 953);
            this.Controls.Add(this.cmbBlanco);
            this.Controls.Add(this.txtNombreClienteConsultar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataConsultaEnConsulta);
            this.Controls.Add(this.labelBlanco);
            this.Controls.Add(this.cmbOpcionesdeConsulta);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaEnConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOpcionesdeConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelBlanco;
        private System.Windows.Forms.DataGridView dataConsultaEnConsulta;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNombreClienteConsultar;
        private System.Windows.Forms.ComboBox cmbBlanco;
    }
}