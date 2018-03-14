namespace NominaGH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENERARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarNominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papelitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parteAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.gENERARToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(551, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Empleados";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosNominaToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // empleadosNominaToolStripMenuItem
            // 
            this.empleadosNominaToolStripMenuItem.Name = "empleadosNominaToolStripMenuItem";
            this.empleadosNominaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.empleadosNominaToolStripMenuItem.Text = "Empleados Nomina";
            this.empleadosNominaToolStripMenuItem.Click += new System.EventHandler(this.empleadosNominaToolStripMenuItem_Click);
            // 
            // gENERARToolStripMenuItem
            // 
            this.gENERARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarNominaToolStripMenuItem});
            this.gENERARToolStripMenuItem.Name = "gENERARToolStripMenuItem";
            this.gENERARToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gENERARToolStripMenuItem.Text = "GENERAR";
            // 
            // generarNominaToolStripMenuItem
            // 
            this.generarNominaToolStripMenuItem.Name = "generarNominaToolStripMenuItem";
            this.generarNominaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.generarNominaToolStripMenuItem.Text = "Generar Nomina";
            this.generarNominaToolStripMenuItem.Click += new System.EventHandler(this.generarNominaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominaCompletaToolStripMenuItem,
            this.papelitosToolStripMenuItem,
            this.parteAtrasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // nominaCompletaToolStripMenuItem
            // 
            this.nominaCompletaToolStripMenuItem.Name = "nominaCompletaToolStripMenuItem";
            this.nominaCompletaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nominaCompletaToolStripMenuItem.Text = "Nomina Completa";
            this.nominaCompletaToolStripMenuItem.Click += new System.EventHandler(this.nominaCompletaToolStripMenuItem_Click);
            // 
            // papelitosToolStripMenuItem
            // 
            this.papelitosToolStripMenuItem.Name = "papelitosToolStripMenuItem";
            this.papelitosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.papelitosToolStripMenuItem.Text = "Papelitos";
            this.papelitosToolStripMenuItem.Click += new System.EventHandler(this.papelitosToolStripMenuItem_Click);
            // 
            // parteAtrasToolStripMenuItem
            // 
            this.parteAtrasToolStripMenuItem.Name = "parteAtrasToolStripMenuItem";
            this.parteAtrasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.parteAtrasToolStripMenuItem.Text = "Parte Atras";
            this.parteAtrasToolStripMenuItem.Click += new System.EventHandler(this.parteAtrasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Sistema de Nomina GH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papelitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarNominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parteAtrasToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menu;
        public System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gENERARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
    }
}

