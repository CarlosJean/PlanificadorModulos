namespace PlanificardorHorasFIn2
{
    partial class frmPlanificador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanificador));
            this.grbDias = new System.Windows.Forms.GroupBox();
            this.chkLunesViernes = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHoraFIn = new System.Windows.Forms.Label();
            this.lblCantidadHoras = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.grbResultado = new System.Windows.Forms.GroupBox();
            this.lsbxDiasFeriados = new System.Windows.Forms.ListBox();
            this.lblDiasFeriados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lstHorasSemana = new System.Windows.Forms.ListBox();
            this.lblHorasSemana = new System.Windows.Forms.Label();
            this.txtFechaFinalizaciion = new System.Windows.Forms.TextBox();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.lblHorasExtras = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtHorasExtras = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbDias.SuspendLayout();
            this.grbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDias
            // 
            this.grbDias.Controls.Add(this.chkLunesViernes);
            this.grbDias.Controls.Add(this.chkDomingo);
            this.grbDias.Controls.Add(this.chkSabado);
            this.grbDias.Controls.Add(this.chkViernes);
            this.grbDias.Controls.Add(this.chkJueves);
            this.grbDias.Controls.Add(this.chkMiercoles);
            this.grbDias.Controls.Add(this.chkMartes);
            this.grbDias.Controls.Add(this.chkLunes);
            this.grbDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbDias.Location = new System.Drawing.Point(566, 26);
            this.grbDias.Name = "grbDias";
            this.grbDias.Size = new System.Drawing.Size(349, 177);
            this.grbDias.TabIndex = 0;
            this.grbDias.TabStop = false;
            this.grbDias.Text = "Días ";
            // 
            // chkLunesViernes
            // 
            this.chkLunesViernes.AutoSize = true;
            this.chkLunesViernes.Location = new System.Drawing.Point(152, 88);
            this.chkLunesViernes.Name = "chkLunesViernes";
            this.chkLunesViernes.Size = new System.Drawing.Size(162, 29);
            this.chkLunesViernes.TabIndex = 7;
            this.chkLunesViernes.Text = "Lunes-Viernes";
            this.chkLunesViernes.UseVisualStyleBackColor = true;
            this.chkLunesViernes.CheckedChanged += new System.EventHandler(this.chkLunesViernes_CheckedChanged);
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(152, 61);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(112, 29);
            this.chkDomingo.TabIndex = 6;
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(152, 34);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(103, 29);
            this.chkSabado.TabIndex = 5;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(6, 142);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(101, 29);
            this.chkViernes.TabIndex = 4;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(6, 115);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(98, 29);
            this.chkJueves.TabIndex = 3;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(6, 88);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(118, 29);
            this.chkMiercoles.TabIndex = 2;
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(6, 61);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(94, 29);
            this.chkMartes.TabIndex = 1;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(6, 34);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(88, 29);
            this.chkLunes.TabIndex = 0;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(646, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 52);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(71, 106);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(200, 30);
            this.dtpHoraInicio.TabIndex = 3;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(322, 106);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(200, 30);
            this.dtpHoraFin.TabIndex = 4;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(63, 60);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(130, 25);
            this.lblHoraInicio.TabIndex = 8;
            this.lblHoraInicio.Text = "Hora de inicio";
            // 
            // lblHoraFIn
            // 
            this.lblHoraFIn.AutoSize = true;
            this.lblHoraFIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFIn.Location = new System.Drawing.Point(319, 60);
            this.lblHoraFIn.Name = "lblHoraFIn";
            this.lblHoraFIn.Size = new System.Drawing.Size(182, 25);
            this.lblHoraFIn.TabIndex = 9;
            this.lblHoraFIn.Text = "Hora de finalización";
            // 
            // lblCantidadHoras
            // 
            this.lblCantidadHoras.AutoSize = true;
            this.lblCantidadHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadHoras.Location = new System.Drawing.Point(63, 186);
            this.lblCantidadHoras.Name = "lblCantidadHoras";
            this.lblCantidadHoras.Size = new System.Drawing.Size(172, 25);
            this.lblCantidadHoras.TabIndex = 10;
            this.lblCantidadHoras.Text = "Cantidad de horas";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(319, 186);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(143, 25);
            this.lblFechaInicio.TabIndex = 11;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // grbResultado
            // 
            this.grbResultado.Controls.Add(this.lsbxDiasFeriados);
            this.grbResultado.Controls.Add(this.lblDiasFeriados);
            this.grbResultado.Controls.Add(this.label1);
            this.grbResultado.Controls.Add(this.linkLabel1);
            this.grbResultado.Controls.Add(this.btnCopiar);
            this.grbResultado.Controls.Add(this.lstHorasSemana);
            this.grbResultado.Controls.Add(this.lblHorasSemana);
            this.grbResultado.Controls.Add(this.txtFechaFinalizaciion);
            this.grbResultado.Controls.Add(this.lblFechaFinalizacion);
            this.grbResultado.Controls.Add(this.lblHorasExtras);
            this.grbResultado.Controls.Add(this.lblDuracion);
            this.grbResultado.Controls.Add(this.txtHorasExtras);
            this.grbResultado.Controls.Add(this.txtDias);
            this.grbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbResultado.Location = new System.Drawing.Point(12, 279);
            this.grbResultado.Name = "grbResultado";
            this.grbResultado.Size = new System.Drawing.Size(966, 250);
            this.grbResultado.TabIndex = 12;
            this.grbResultado.TabStop = false;
            this.grbResultado.Text = "Resultados";
            // 
            // lsbxDiasFeriados
            // 
            this.lsbxDiasFeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lsbxDiasFeriados.FormattingEnabled = true;
            this.lsbxDiasFeriados.ItemHeight = 25;
            this.lsbxDiasFeriados.Location = new System.Drawing.Point(760, 93);
            this.lsbxDiasFeriados.Name = "lsbxDiasFeriados";
            this.lsbxDiasFeriados.Size = new System.Drawing.Size(167, 104);
            this.lsbxDiasFeriados.TabIndex = 22;
            // 
            // lblDiasFeriados
            // 
            this.lblDiasFeriados.AutoSize = true;
            this.lblDiasFeriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasFeriados.Location = new System.Drawing.Point(755, 57);
            this.lblDiasFeriados.Name = "lblDiasFeriados";
            this.lblDiasFeriados.Size = new System.Drawing.Size(132, 25);
            this.lblDiasFeriados.TabIndex = 21;
            this.lblDiasFeriados.Text = "Dias Feriados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(504, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha copiada al portapepeles";
            this.label1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(3, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 25);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Configuración";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(334, 129);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(192, 35);
            this.btnCopiar.TabIndex = 18;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lstHorasSemana
            // 
            this.lstHorasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstHorasSemana.FormattingEnabled = true;
            this.lstHorasSemana.ItemHeight = 25;
            this.lstHorasSemana.Location = new System.Drawing.Point(552, 93);
            this.lstHorasSemana.Name = "lstHorasSemana";
            this.lstHorasSemana.Size = new System.Drawing.Size(167, 104);
            this.lstHorasSemana.TabIndex = 17;
            // 
            // lblHorasSemana
            // 
            this.lblHorasSemana.AutoSize = true;
            this.lblHorasSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasSemana.Location = new System.Drawing.Point(547, 57);
            this.lblHorasSemana.Name = "lblHorasSemana";
            this.lblHorasSemana.Size = new System.Drawing.Size(172, 25);
            this.lblHorasSemana.TabIndex = 16;
            this.lblHorasSemana.Text = "Horas por semana";
            // 
            // txtFechaFinalizaciion
            // 
            this.txtFechaFinalizaciion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtFechaFinalizaciion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinalizaciion.Location = new System.Drawing.Point(334, 93);
            this.txtFechaFinalizaciion.Name = "txtFechaFinalizaciion";
            this.txtFechaFinalizaciion.ReadOnly = true;
            this.txtFechaFinalizaciion.Size = new System.Drawing.Size(192, 30);
            this.txtFechaFinalizaciion.TabIndex = 15;
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.AutoSize = true;
            this.lblFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(331, 57);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(195, 25);
            this.lblFechaFinalizacion.TabIndex = 14;
            this.lblFechaFinalizacion.Text = "Fecha de finalización";
            // 
            // lblHorasExtras
            // 
            this.lblHorasExtras.AutoSize = true;
            this.lblHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasExtras.Location = new System.Drawing.Point(162, 57);
            this.lblHorasExtras.Name = "lblHorasExtras";
            this.lblHorasExtras.Size = new System.Drawing.Size(122, 25);
            this.lblHorasExtras.TabIndex = 13;
            this.lblHorasExtras.Text = "Horas extras";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.Location = new System.Drawing.Point(1, 57);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(145, 25);
            this.lblDuracion.TabIndex = 12;
            this.lblDuracion.Text = "Duración (dias)";
            // 
            // txtHorasExtras
            // 
            this.txtHorasExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtHorasExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHorasExtras.Location = new System.Drawing.Point(165, 93);
            this.txtHorasExtras.Name = "txtHorasExtras";
            this.txtHorasExtras.ReadOnly = true;
            this.txtHorasExtras.Size = new System.Drawing.Size(144, 30);
            this.txtHorasExtras.TabIndex = 9;
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDias.Location = new System.Drawing.Point(0, 93);
            this.txtDias.Name = "txtDias";
            this.txtDias.ReadOnly = true;
            this.txtDias.Size = new System.Drawing.Size(100, 30);
            this.txtDias.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(753, 224);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 52);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudHoras
            // 
            this.nudHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHoras.Location = new System.Drawing.Point(69, 224);
            this.nudHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(120, 30);
            this.nudHoras.TabIndex = 14;
            this.nudHoras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPlanificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 550);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbResultado);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblCantidadHoras);
            this.Controls.Add(this.lblHoraFIn);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPlanificador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planificador de módulos";
            this.grbDias.ResumeLayout(false);
            this.grbDias.PerformLayout();
            this.grbResultado.ResumeLayout(false);
            this.grbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDias;
        private System.Windows.Forms.CheckBox chkLunesViernes;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHoraFIn;
        private System.Windows.Forms.Label lblCantidadHoras;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.GroupBox grbResultado;
        public System.Windows.Forms.TextBox txtFechaFinalizaciion;
        private System.Windows.Forms.Label lblFechaFinalizacion;
        private System.Windows.Forms.Label lblHorasExtras;
        private System.Windows.Forms.Label lblDuracion;
        public System.Windows.Forms.TextBox txtHorasExtras;
        public System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblHorasSemana;
        public System.Windows.Forms.ListBox lstHorasSemana;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ListBox lsbxDiasFeriados;
        private System.Windows.Forms.Label lblDiasFeriados;
    }
}

