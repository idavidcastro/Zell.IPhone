
namespace Esteban
{
    partial class FrmRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtIMEI2 = new System.Windows.Forms.TextBox();
            this.txtIMEI1 = new System.Windows.Forms.TextBox();
            this.cmbGB = new System.Windows.Forms.ComboBox();
            this.cmbTelefono = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbTelefonoConsulta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataConsultaEnRegistro = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarEnRegistro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaEnRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(162)))), ((int)(((byte)(62)))));
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1326, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(230, 61);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.panel1.Controls.Add(this.cmbColor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtObservacion);
            this.panel1.Controls.Add(this.txtSalida);
            this.panel1.Controls.Add(this.txtEntrada);
            this.panel1.Controls.Add(this.txtIMEI2);
            this.panel1.Controls.Add(this.txtIMEI1);
            this.panel1.Controls.Add(this.cmbGB);
            this.panel1.Controls.Add(this.cmbTelefono);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(127, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 492);
            this.panel1.TabIndex = 5;
            // 
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.White;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Negro",
            "Blanco",
            "Plateado",
            "Rojo",
            "Rosado"});
            this.cmbColor.Location = new System.Drawing.Point(259, 169);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(212, 28);
            this.cmbColor.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(603, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "(Opcional) IMEI 2:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(259, 366);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(760, 95);
            this.txtObservacion.TabIndex = 19;
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.Color.White;
            this.txtSalida.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(807, 300);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(212, 30);
            this.txtSalida.TabIndex = 18;
            this.txtSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalida_KeyPress);
            // 
            // txtEntrada
            // 
            this.txtEntrada.BackColor = System.Drawing.Color.White;
            this.txtEntrada.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(259, 300);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(212, 30);
            this.txtEntrada.TabIndex = 17;
            this.txtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntrada_KeyPress);
            // 
            // txtIMEI2
            // 
            this.txtIMEI2.BackColor = System.Drawing.Color.White;
            this.txtIMEI2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEI2.Location = new System.Drawing.Point(807, 235);
            this.txtIMEI2.Multiline = true;
            this.txtIMEI2.Name = "txtIMEI2";
            this.txtIMEI2.Size = new System.Drawing.Size(212, 30);
            this.txtIMEI2.TabIndex = 16;
            this.txtIMEI2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMEI2_KeyPress);
            // 
            // txtIMEI1
            // 
            this.txtIMEI1.BackColor = System.Drawing.Color.White;
            this.txtIMEI1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEI1.Location = new System.Drawing.Point(807, 170);
            this.txtIMEI1.Multiline = true;
            this.txtIMEI1.Name = "txtIMEI1";
            this.txtIMEI1.Size = new System.Drawing.Size(212, 30);
            this.txtIMEI1.TabIndex = 15;
            this.txtIMEI1.TextChanged += new System.EventHandler(this.txtIMEI1_TextChanged);
            this.txtIMEI1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIMEI1_KeyPress);
            // 
            // cmbGB
            // 
            this.cmbGB.BackColor = System.Drawing.Color.White;
            this.cmbGB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGB.FormattingEnabled = true;
            this.cmbGB.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256"});
            this.cmbGB.Location = new System.Drawing.Point(807, 107);
            this.cmbGB.Name = "cmbGB";
            this.cmbGB.Size = new System.Drawing.Size(212, 28);
            this.cmbGB.TabIndex = 12;
            // 
            // cmbTelefono
            // 
            this.cmbTelefono.BackColor = System.Drawing.Color.White;
            this.cmbTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTelefono.FormattingEnabled = true;
            this.cmbTelefono.IntegralHeight = false;
            this.cmbTelefono.Items.AddRange(new object[] {
            "IPhone 6",
            "IPhone 6s",
            "IPhone 6s Plus",
            "IPhone 7",
            "IPhone 7 Plus",
            "IPhone 8",
            "IPhone 8 Plus",
            "IPhone X",
            "IPhone XS",
            "IPhone XS Max",
            "IPhone XR",
            "IPhone 11",
            "IPhone 11 Pro",
            "IPhone 11 Pro Max",
            "IPhone 12",
            "IPhone 12 Pro",
            "IPhone 12 Pro Max",
            "IPhone 13",
            "IPhone 13 Pro",
            "IPhone 13 Pro Max",
            "IPhone SE 2020"});
            this.cmbTelefono.Location = new System.Drawing.Point(259, 107);
            this.cmbTelefono.Name = "cmbTelefono";
            this.cmbTelefono.Size = new System.Drawing.Size(212, 28);
            this.cmbTelefono.TabIndex = 11;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.White;
            this.txtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(807, 42);
            this.txtNombreCliente.Multiline = true;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(212, 30);
            this.txtNombreCliente.TabIndex = 10;
            this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCliente_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 26);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 9, 13, 54, 55, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(89, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Observación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(676, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salida ($):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(105, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Entrada ($):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(707, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "IMEI 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(161, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(732, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "GB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(132, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(603, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre (cliente):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Ingreso:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(170)))));
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(1326, 304);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(230, 61);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbTelefonoConsulta
            // 
            this.cmbTelefonoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelefonoConsulta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTelefonoConsulta.FormattingEnabled = true;
            this.cmbTelefonoConsulta.IntegralHeight = false;
            this.cmbTelefonoConsulta.Items.AddRange(new object[] {
            "IPhone 6",
            "Iphone 7",
            "Iphone 8",
            "Iphone X",
            "Iphone XR",
            "Iphone XS"});
            this.cmbTelefonoConsulta.Location = new System.Drawing.Point(1326, 622);
            this.cmbTelefonoConsulta.Name = "cmbTelefonoConsulta";
            this.cmbTelefonoConsulta.Size = new System.Drawing.Size(149, 28);
            this.cmbTelefonoConsulta.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1329, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Teléfono:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.dataConsultaEnRegistro);
            this.panel2.Location = new System.Drawing.Point(127, 585);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 297);
            this.panel2.TabIndex = 24;
            // 
            // dataConsultaEnRegistro
            // 
            this.dataConsultaEnRegistro.BackgroundColor = System.Drawing.Color.White;
            this.dataConsultaEnRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataConsultaEnRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataConsultaEnRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataConsultaEnRegistro.ColumnHeadersHeight = 30;
            this.dataConsultaEnRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataConsultaEnRegistro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataConsultaEnRegistro.EnableHeadersVisualStyles = false;
            this.dataConsultaEnRegistro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.dataConsultaEnRegistro.Location = new System.Drawing.Point(51, 21);
            this.dataConsultaEnRegistro.Name = "dataConsultaEnRegistro";
            this.dataConsultaEnRegistro.RowHeadersVisible = false;
            this.dataConsultaEnRegistro.RowHeadersWidth = 51;
            this.dataConsultaEnRegistro.RowTemplate.Height = 24;
            this.dataConsultaEnRegistro.Size = new System.Drawing.Size(1040, 254);
            this.dataConsultaEnRegistro.TabIndex = 0;
            this.dataConsultaEnRegistro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConsultaEnRegistro_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(130, 560);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Lista de Registros";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(21)))), ((int)(((byte)(14)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1326, 799);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 61);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarEnRegistro
            // 
            this.btnBuscarEnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.btnBuscarEnRegistro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEnRegistro.Location = new System.Drawing.Point(1481, 621);
            this.btnBuscarEnRegistro.Name = "btnBuscarEnRegistro";
            this.btnBuscarEnRegistro.Size = new System.Drawing.Size(75, 31);
            this.btnBuscarEnRegistro.TabIndex = 27;
            this.btnBuscarEnRegistro.Text = "Buscar";
            this.btnBuscarEnRegistro.UseVisualStyleBackColor = false;
            this.btnBuscarEnRegistro.Click += new System.EventHandler(this.btnBuscarEnRegistro_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1326, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 31);
            this.button1.TabIndex = 28;
            this.button1.Text = "Refrescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1599, 953);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarEnRegistro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbTelefonoConsulta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataConsultaEnRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtIMEI2;
        private System.Windows.Forms.TextBox txtIMEI1;
        private System.Windows.Forms.ComboBox cmbGB;
        private System.Windows.Forms.ComboBox cmbTelefono;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbTelefonoConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataConsultaEnRegistro;
        private System.Windows.Forms.Button btnBuscarEnRegistro;
        private System.Windows.Forms.Button button1;
    }
}