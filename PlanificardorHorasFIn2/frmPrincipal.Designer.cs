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
            this.grbDias = new System.Windows.Forms.GroupBox();
            this.chkLunesViernes = new System.Windows.Forms.CheckBox();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grbDias.SuspendLayout();
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
            this.grbDias.Location = new System.Drawing.Point(483, 68);
            this.grbDias.Name = "grbDias";
            this.grbDias.Size = new System.Drawing.Size(319, 177);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(50, 258);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // frmPlanificador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 474);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbDias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlanificador";
            this.Text = "Planificador de módulos";
            this.grbDias.ResumeLayout(false);
            this.grbDias.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

