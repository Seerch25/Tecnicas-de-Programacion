namespace TemperaturaGrafica
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escribirValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_puertos = new System.Windows.Forms.ComboBox();
            this.cht_graficar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_tiempo_temperatura = new System.Windows.Forms.DataGridView();
            this.tiempo_segundos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo_adquisicion = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_graficar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiempo_temperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.conexiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.abrirToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            this.abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            this.abrirToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.abrirToolStripMenuItem1.Text = "A&brir";
            this.abrirToolStripMenuItem1.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escribirValoresToolStripMenuItem,
            this.graficarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // escribirValoresToolStripMenuItem
            // 
            this.escribirValoresToolStripMenuItem.Name = "escribirValoresToolStripMenuItem";
            this.escribirValoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.escribirValoresToolStripMenuItem.Text = "Escribir Valores";
            // 
            // graficarToolStripMenuItem
            // 
            this.graficarToolStripMenuItem.Name = "graficarToolStripMenuItem";
            this.graficarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.graficarToolStripMenuItem.Text = "Graficar";
            this.graficarToolStripMenuItem.Click += new System.EventHandler(this.graficarToolStripMenuItem_Click);
            // 
            // conexiónToolStripMenuItem
            // 
            this.conexiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem,
            this.pruebaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.iniciarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.conexiónToolStripMenuItem.Name = "conexiónToolStripMenuItem";
            this.conexiónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.conexiónToolStripMenuItem.Text = "Conexión";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurarToolStripMenuItem.Text = "&Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pruebaToolStripMenuItem.Text = "Prueba";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            this.iniciarToolStripMenuItem.Click += new System.EventHandler(this.iniciarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // cmb_puertos
            // 
            this.cmb_puertos.FormattingEnabled = true;
            this.cmb_puertos.Location = new System.Drawing.Point(186, 27);
            this.cmb_puertos.Name = "cmb_puertos";
            this.cmb_puertos.Size = new System.Drawing.Size(96, 21);
            this.cmb_puertos.TabIndex = 1;
            // 
            // cht_graficar
            // 
            chartArea2.Name = "ChartArea1";
            this.cht_graficar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cht_graficar.Legends.Add(legend2);
            this.cht_graficar.Location = new System.Drawing.Point(356, 64);
            this.cht_graficar.Name = "cht_graficar";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "Tiempo vs Temperatura";
            series2.Name = "tiempo_temperatura";
            this.cht_graficar.Series.Add(series2);
            this.cht_graficar.Size = new System.Drawing.Size(465, 218);
            this.cht_graficar.TabIndex = 2;
            this.cht_graficar.Text = "chart1";
            // 
            // dgv_tiempo_temperatura
            // 
            this.dgv_tiempo_temperatura.AllowUserToAddRows = false;
            this.dgv_tiempo_temperatura.AllowUserToDeleteRows = false;
            this.dgv_tiempo_temperatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tiempo_temperatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tiempo_segundos,
            this.temperatura});
            this.dgv_tiempo_temperatura.Location = new System.Drawing.Point(42, 93);
            this.dgv_tiempo_temperatura.Name = "dgv_tiempo_temperatura";
            this.dgv_tiempo_temperatura.ReadOnly = true;
            this.dgv_tiempo_temperatura.Size = new System.Drawing.Size(240, 218);
            this.dgv_tiempo_temperatura.TabIndex = 3;
            // 
            // tiempo_segundos
            // 
            this.tiempo_segundos.HeaderText = "Tiempo";
            this.tiempo_segundos.Name = "tiempo_segundos";
            this.tiempo_segundos.ReadOnly = true;
            // 
            // temperatura
            // 
            this.temperatura.HeaderText = "Temperatura";
            this.temperatura.Name = "temperatura";
            this.temperatura.ReadOnly = true;
            // 
            // tiempo_adquisicion
            // 
            this.tiempo_adquisicion.Interval = 1000;
            this.tiempo_adquisicion.Tick += new System.EventHandler(this.tiempo_adquisicion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 439);
            this.Controls.Add(this.dgv_tiempo_temperatura);
            this.Controls.Add(this.cht_graficar);
            this.Controls.Add(this.cmb_puertos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht_graficar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tiempo_temperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escribirValoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_puertos;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_graficar;
        private System.Windows.Forms.DataGridView dgv_tiempo_temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo_segundos;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatura;
        private System.Windows.Forms.Timer tiempo_adquisicion;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
    }
}

