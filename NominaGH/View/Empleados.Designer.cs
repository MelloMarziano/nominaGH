namespace NominaGH
{
    partial class Empleados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltblistado = new System.Windows.Forms.ListBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.mkcedula = new System.Windows.Forms.MaskedTextBox();
            this.mktelefono = new System.Windows.Forms.MaskedTextBox();
            this.cbosucursal = new System.Windows.Forms.ComboBox();
            this.txtocupacion = new System.Windows.Forms.TextBox();
            this.txtsueldobruto = new System.Windows.Forms.TextBox();
            this.txtextras = new System.Windows.Forms.TextBox();
            this.txtseguro = new System.Windows.Forms.TextBox();
            this.chkcomida = new System.Windows.Forms.CheckBox();
            this.dpentrada = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mkSalida = new System.Windows.Forms.MaskedTextBox();
            this.cboatras = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFechaS = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnSeguro = new System.Windows.Forms.Button();
            this.btnSueldoB = new System.Windows.Forms.Button();
            this.btnHE = new System.Windows.Forms.Button();
            this.btnOcupacion = new System.Windows.Forms.Button();
            this.btnCedula = new System.Windows.Forms.Button();
            this.btnDireccion = new System.Windows.Forms.Button();
            this.btnnombre = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.ltblistado);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 630);
            this.panel1.TabIndex = 0;
            // 
            // ltblistado
            // 
            this.ltblistado.FormattingEnabled = true;
            this.ltblistado.Location = new System.Drawing.Point(14, 84);
            this.ltblistado.Name = "ltblistado";
            this.ltblistado.Size = new System.Drawing.Size(201, 524);
            this.ltblistado.TabIndex = 3;
            this.ltblistado.SelectedIndexChanged += new System.EventHandler(this.ltblistado_SelectedIndexChanged);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(13, 36);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(202, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(403, 142);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(598, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(403, 196);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(598, 20);
            this.txtdireccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cedula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(762, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sucursal de Contrato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(590, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Horas Extras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(272, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ocupacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(272, 422);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sueldo Bruto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(762, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Comida";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Seguro Privado";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(590, 551);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "Fecha Salida";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(272, 555);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 16);
            this.label15.TabIndex = 16;
            this.label15.Text = "Fecha Entrada";
            // 
            // dpnacimiento
            // 
            this.dpnacimiento.Enabled = false;
            this.dpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpnacimiento.Location = new System.Drawing.Point(905, 253);
            this.dpnacimiento.Name = "dpnacimiento";
            this.dpnacimiento.Size = new System.Drawing.Size(96, 20);
            this.dpnacimiento.TabIndex = 5;
            // 
            // mkcedula
            // 
            this.mkcedula.Enabled = false;
            this.mkcedula.Location = new System.Drawing.Point(403, 253);
            this.mkcedula.Mask = "###-#######-#";
            this.mkcedula.Name = "mkcedula";
            this.mkcedula.Size = new System.Drawing.Size(100, 20);
            this.mkcedula.TabIndex = 3;
            this.mkcedula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkcedula_MaskInputRejected);
            this.mkcedula.Leave += new System.EventHandler(this.mkcedula_Leave);
            // 
            // mktelefono
            // 
            this.mktelefono.Enabled = false;
            this.mktelefono.Location = new System.Drawing.Point(603, 252);
            this.mktelefono.Mask = "(###)-###-####";
            this.mktelefono.Name = "mktelefono";
            this.mktelefono.Size = new System.Drawing.Size(100, 20);
            this.mktelefono.TabIndex = 4;
            // 
            // cbosucursal
            // 
            this.cbosucursal.Enabled = false;
            this.cbosucursal.FormattingEnabled = true;
            this.cbosucursal.Items.AddRange(new object[] {
            "Central Hierro",
            "Don Hierro Alma Rosa",
            "Don Hierro Los Mina",
            "Gigante Hierro San Cristobal",
            "Gigante Hierro Bani",
            "Todo Hierro Aluminio",
            "Todo Hierro Boca Chica",
            "Max Hierro Villa Mella",
            "Max Hierro Sabana ",
            "Quinto Hierro Alcarrizo",
            "Quinto Hierro Villa Altagracia",
            "Canal Hierro Herrera",
            "Canal Hierro Manoguayabo",
            "TGH Todo Import",
            "Trasporte Nohely",
            "Linkart"});
            this.cbosucursal.Location = new System.Drawing.Point(436, 309);
            this.cbosucursal.Name = "cbosucursal";
            this.cbosucursal.Size = new System.Drawing.Size(152, 21);
            this.cbosucursal.TabIndex = 6;
            this.cbosucursal.Text = "--ESCOGE UNA--";
            // 
            // txtocupacion
            // 
            this.txtocupacion.Enabled = false;
            this.txtocupacion.Location = new System.Drawing.Point(403, 368);
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.Size = new System.Drawing.Size(247, 20);
            this.txtocupacion.TabIndex = 8;
            // 
            // txtsueldobruto
            // 
            this.txtsueldobruto.Enabled = false;
            this.txtsueldobruto.Location = new System.Drawing.Point(403, 420);
            this.txtsueldobruto.Name = "txtsueldobruto";
            this.txtsueldobruto.Size = new System.Drawing.Size(137, 20);
            this.txtsueldobruto.TabIndex = 10;
            // 
            // txtextras
            // 
            this.txtextras.Enabled = false;
            this.txtextras.Location = new System.Drawing.Point(696, 418);
            this.txtextras.Name = "txtextras";
            this.txtextras.Size = new System.Drawing.Size(137, 20);
            this.txtextras.TabIndex = 11;
            // 
            // txtseguro
            // 
            this.txtseguro.Enabled = false;
            this.txtseguro.Location = new System.Drawing.Point(403, 488);
            this.txtseguro.Name = "txtseguro";
            this.txtseguro.Size = new System.Drawing.Size(137, 20);
            this.txtseguro.TabIndex = 12;
            // 
            // chkcomida
            // 
            this.chkcomida.AutoSize = true;
            this.chkcomida.Enabled = false;
            this.chkcomida.Location = new System.Drawing.Point(833, 371);
            this.chkcomida.Name = "chkcomida";
            this.chkcomida.Size = new System.Drawing.Size(15, 14);
            this.chkcomida.TabIndex = 9;
            this.chkcomida.UseVisualStyleBackColor = true;
            // 
            // dpentrada
            // 
            this.dpentrada.Enabled = false;
            this.dpentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpentrada.Location = new System.Drawing.Point(403, 551);
            this.dpentrada.Name = "dpentrada";
            this.dpentrada.Size = new System.Drawing.Size(96, 20);
            this.dpentrada.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(272, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 45;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(403, 83);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 22);
            this.txtId.TabIndex = 46;
            this.txtId.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mkSalida
            // 
            this.mkSalida.Location = new System.Drawing.Point(698, 550);
            this.mkSalida.Mask = "##-##-####";
            this.mkSalida.Name = "mkSalida";
            this.mkSalida.Size = new System.Drawing.Size(100, 20);
            this.mkSalida.TabIndex = 14;
            // 
            // cboatras
            // 
            this.cboatras.Enabled = false;
            this.cboatras.FormattingEnabled = true;
            this.cboatras.Items.AddRange(new object[] {
            "Central Hierro",
            "Don Hierro Alma Rosa",
            "Don Hierro Los Mina",
            "Gigante Hierro San Cristobal",
            "Gigante Hierro Bani",
            "Todo Hierro Aluminio",
            "Todo Hierro Boca Chica",
            "Max Hierro Villa Mella",
            "Max Hierro Sabana ",
            "Quinto Hierro Alcarrizo",
            "Quinto Hierro Villa Altagracia",
            "Canal Hierro Herrera",
            "Canal Hierro Manoguayabo",
            "TGH Todo Import",
            "Trasporte Nohely",
            "Linkart"});
            this.cboatras.Location = new System.Drawing.Point(766, 310);
            this.cboatras.Name = "cboatras";
            this.cboatras.Size = new System.Drawing.Size(152, 21);
            this.cboatras.TabIndex = 7;
            this.cboatras.Text = "--ESCOGE UNA--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(649, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 16);
            this.label16.TabIndex = 51;
            this.label16.Text = "Parte Atras";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Firebrick;
            this.btnAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtras.BackgroundImage")));
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Location = new System.Drawing.Point(924, 311);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(22, 20);
            this.btnAtras.TabIndex = 53;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.LightPink;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Image = global::NominaGH.Properties.Resources._003_user_1;
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCambios.Location = new System.Drawing.Point(894, 534);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(117, 49);
            this.btnGuardarCambios.TabIndex = 15;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Visible = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(600, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFechaS
            // 
            this.btnFechaS.BackColor = System.Drawing.Color.Firebrick;
            this.btnFechaS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechaS.BackgroundImage")));
            this.btnFechaS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechaS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechaS.Location = new System.Drawing.Point(810, 550);
            this.btnFechaS.Name = "btnFechaS";
            this.btnFechaS.Size = new System.Drawing.Size(22, 20);
            this.btnFechaS.TabIndex = 44;
            this.btnFechaS.UseVisualStyleBackColor = false;
            this.btnFechaS.Visible = false;
            this.btnFechaS.Click += new System.EventHandler(this.btnFechaS_Click);
            // 
            // btnComida
            // 
            this.btnComida.BackColor = System.Drawing.Color.Firebrick;
            this.btnComida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComida.BackgroundImage")));
            this.btnComida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComida.Location = new System.Drawing.Point(854, 367);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(22, 20);
            this.btnComida.TabIndex = 42;
            this.btnComida.UseVisualStyleBackColor = false;
            this.btnComida.Visible = false;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // btnSeguro
            // 
            this.btnSeguro.BackColor = System.Drawing.Color.Firebrick;
            this.btnSeguro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeguro.BackgroundImage")));
            this.btnSeguro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeguro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeguro.Location = new System.Drawing.Point(548, 487);
            this.btnSeguro.Name = "btnSeguro";
            this.btnSeguro.Size = new System.Drawing.Size(22, 20);
            this.btnSeguro.TabIndex = 40;
            this.btnSeguro.UseVisualStyleBackColor = false;
            this.btnSeguro.Visible = false;
            this.btnSeguro.Click += new System.EventHandler(this.btnSeguro_Click);
            // 
            // btnSueldoB
            // 
            this.btnSueldoB.BackColor = System.Drawing.Color.Firebrick;
            this.btnSueldoB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSueldoB.BackgroundImage")));
            this.btnSueldoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSueldoB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSueldoB.Location = new System.Drawing.Point(548, 421);
            this.btnSueldoB.Name = "btnSueldoB";
            this.btnSueldoB.Size = new System.Drawing.Size(22, 20);
            this.btnSueldoB.TabIndex = 39;
            this.btnSueldoB.UseVisualStyleBackColor = false;
            this.btnSueldoB.Visible = false;
            this.btnSueldoB.Click += new System.EventHandler(this.btnSueldoB_Click);
            // 
            // btnHE
            // 
            this.btnHE.BackColor = System.Drawing.Color.Firebrick;
            this.btnHE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHE.BackgroundImage")));
            this.btnHE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHE.Location = new System.Drawing.Point(857, 417);
            this.btnHE.Name = "btnHE";
            this.btnHE.Size = new System.Drawing.Size(22, 20);
            this.btnHE.TabIndex = 38;
            this.btnHE.UseVisualStyleBackColor = false;
            this.btnHE.Visible = false;
            this.btnHE.Click += new System.EventHandler(this.btnHE_Click);
            // 
            // btnOcupacion
            // 
            this.btnOcupacion.BackColor = System.Drawing.Color.Firebrick;
            this.btnOcupacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOcupacion.BackgroundImage")));
            this.btnOcupacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOcupacion.Location = new System.Drawing.Point(666, 366);
            this.btnOcupacion.Name = "btnOcupacion";
            this.btnOcupacion.Size = new System.Drawing.Size(22, 20);
            this.btnOcupacion.TabIndex = 37;
            this.btnOcupacion.UseVisualStyleBackColor = false;
            this.btnOcupacion.Visible = false;
            this.btnOcupacion.Click += new System.EventHandler(this.btnOcupacion_Click);
            // 
            // btnCedula
            // 
            this.btnCedula.BackColor = System.Drawing.Color.Firebrick;
            this.btnCedula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCedula.BackgroundImage")));
            this.btnCedula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCedula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCedula.Location = new System.Drawing.Point(709, 251);
            this.btnCedula.Name = "btnCedula";
            this.btnCedula.Size = new System.Drawing.Size(22, 20);
            this.btnCedula.TabIndex = 36;
            this.btnCedula.UseVisualStyleBackColor = false;
            this.btnCedula.Visible = false;
            this.btnCedula.Click += new System.EventHandler(this.btnCedula_Click);
            // 
            // btnDireccion
            // 
            this.btnDireccion.BackColor = System.Drawing.Color.Firebrick;
            this.btnDireccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDireccion.BackgroundImage")));
            this.btnDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDireccion.Location = new System.Drawing.Point(1016, 196);
            this.btnDireccion.Name = "btnDireccion";
            this.btnDireccion.Size = new System.Drawing.Size(22, 20);
            this.btnDireccion.TabIndex = 35;
            this.btnDireccion.UseVisualStyleBackColor = false;
            this.btnDireccion.Visible = false;
            this.btnDireccion.Click += new System.EventHandler(this.btnDireccion_Click);
            // 
            // btnnombre
            // 
            this.btnnombre.BackColor = System.Drawing.Color.Firebrick;
            this.btnnombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnombre.BackgroundImage")));
            this.btnnombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnombre.Location = new System.Drawing.Point(1016, 142);
            this.btnnombre.Name = "btnnombre";
            this.btnnombre.Size = new System.Drawing.Size(22, 20);
            this.btnnombre.TabIndex = 34;
            this.btnnombre.UseVisualStyleBackColor = false;
            this.btnnombre.Visible = false;
            this.btnnombre.Click += new System.EventHandler(this.btnnombre_Click);
            // 
            // btndeshacer
            // 
            this.btndeshacer.BackColor = System.Drawing.Color.LightPink;
            this.btndeshacer.Enabled = false;
            this.btndeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeshacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeshacer.Image = global::NominaGH.Properties.Resources._004_arrows;
            this.btndeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndeshacer.Location = new System.Drawing.Point(935, 0);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(119, 49);
            this.btndeshacer.TabIndex = 33;
            this.btndeshacer.Text = "Deshacer";
            this.btndeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndeshacer.UseVisualStyleBackColor = false;
            this.btndeshacer.Click += new System.EventHandler(this.btndeshacer_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.LightPink;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = global::NominaGH.Properties.Resources._001_new_file;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(766, 0);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(119, 49);
            this.btnnuevo.TabIndex = 32;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.LightPink;
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Image = global::NominaGH.Properties.Resources._005_user;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(599, 0);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(119, 49);
            this.btneliminar.TabIndex = 31;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.LightPink;
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Image = global::NominaGH.Properties.Resources._002_user_2;
            this.btneditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneditar.Location = new System.Drawing.Point(429, 0);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(119, 49);
            this.btneditar.TabIndex = 30;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightPink;
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = global::NominaGH.Properties.Resources._003_user_1;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(257, 0);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(119, 49);
            this.btnguardar.TabIndex = 29;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1074, 630);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cboatras);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mkSalida);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnFechaS);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btnSeguro);
            this.Controls.Add(this.btnSueldoB);
            this.Controls.Add(this.btnHE);
            this.Controls.Add(this.btnOcupacion);
            this.Controls.Add(this.btnCedula);
            this.Controls.Add(this.btnDireccion);
            this.Controls.Add(this.btnnombre);
            this.Controls.Add(this.btndeshacer);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dpentrada);
            this.Controls.Add(this.chkcomida);
            this.Controls.Add(this.txtseguro);
            this.Controls.Add(this.txtextras);
            this.Controls.Add(this.txtsueldobruto);
            this.Controls.Add(this.txtocupacion);
            this.Controls.Add(this.cbosucursal);
            this.Controls.Add(this.mktelefono);
            this.Controls.Add(this.mkcedula);
            this.Controls.Add(this.dpnacimiento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1090, 669);
            this.MinimumSize = new System.Drawing.Size(1090, 669);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ltblistado;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dpnacimiento;
        private System.Windows.Forms.MaskedTextBox mkcedula;
        private System.Windows.Forms.MaskedTextBox mktelefono;
        private System.Windows.Forms.ComboBox cbosucursal;
        private System.Windows.Forms.TextBox txtocupacion;
        private System.Windows.Forms.TextBox txtsueldobruto;
        private System.Windows.Forms.TextBox txtextras;
        private System.Windows.Forms.TextBox txtseguro;
        private System.Windows.Forms.CheckBox chkcomida;
        private System.Windows.Forms.DateTimePicker dpentrada;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btndeshacer;
        private System.Windows.Forms.Button btnnombre;
        private System.Windows.Forms.Button btnDireccion;
        private System.Windows.Forms.Button btnCedula;
        private System.Windows.Forms.Button btnOcupacion;
        private System.Windows.Forms.Button btnHE;
        private System.Windows.Forms.Button btnSueldoB;
        private System.Windows.Forms.Button btnSeguro;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnFechaS;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mkSalida;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cboatras;
        private System.Windows.Forms.Label label16;
    }
}