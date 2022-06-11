
namespace DataBase_Curso
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkTemario = new System.Windows.Forms.LinkLabel();
            this.linkHorario = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TemCurso = new System.Windows.Forms.Label();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btneliminar = new System.Windows.Forms.Button();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.TxtnameCurso = new System.Windows.Forms.TextBox();
            this.NameCurso = new System.Windows.Forms.Label();
            this.BtnGuardarDataCurso = new System.Windows.Forms.Button();
            this.ID_Curso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId_Curso = new System.Windows.Forms.TextBox();
            this.TxtnombreInstructor = new System.Windows.Forms.TextBox();
            this.Instructor = new System.Windows.Forms.Label();
            this.TxtapellidosInstructor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkTemario);
            this.groupBox1.Controls.Add(this.linkHorario);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.TemCurso);
            this.groupBox1.Location = new System.Drawing.Point(358, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 239);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // linkTemario
            // 
            this.linkTemario.AutoSize = true;
            this.linkTemario.Location = new System.Drawing.Point(355, 10);
            this.linkTemario.Name = "linkTemario";
            this.linkTemario.Size = new System.Drawing.Size(56, 13);
            this.linkTemario.TabIndex = 25;
            this.linkTemario.TabStop = true;
            this.linkTemario.Text = "TEMARIO";
            // 
            // linkHorario
            // 
            this.linkHorario.AutoSize = true;
            this.linkHorario.Location = new System.Drawing.Point(278, 9);
            this.linkHorario.Name = "linkHorario";
            this.linkHorario.Size = new System.Drawing.Size(57, 13);
            this.linkHorario.TabIndex = 24;
            this.linkHorario.TabStop = true;
            this.linkHorario.Text = "HORARIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.Size = new System.Drawing.Size(427, 204);
            this.dataGridView1.TabIndex = 15;
            // 
            // TemCurso
            // 
            this.TemCurso.AutoSize = true;
            this.TemCurso.Location = new System.Drawing.Point(6, 9);
            this.TemCurso.Name = "TemCurso";
            this.TemCurso.Size = new System.Drawing.Size(180, 13);
            this.TemCurso.TabIndex = 23;
            this.TemCurso.Text = "DATOS GENERALES  DEL CURSO";
            // 
            // Btneditar
            // 
            this.Btneditar.Location = new System.Drawing.Point(178, 246);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(73, 23);
            this.Btneditar.TabIndex = 27;
            this.Btneditar.Text = "editar";
            this.Btneditar.UseVisualStyleBackColor = true;
            // 
            // Btneliminar
            // 
            this.Btneliminar.Location = new System.Drawing.Point(22, 246);
            this.Btneliminar.Name = "Btneliminar";
            this.Btneliminar.Size = new System.Drawing.Size(73, 23);
            this.Btneliminar.TabIndex = 26;
            this.Btneliminar.Text = "eliminar";
            this.Btneliminar.UseVisualStyleBackColor = true;
            this.Btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(101, 246);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(71, 23);
            this.Btnagregar.TabIndex = 25;
            this.Btnagregar.Text = "agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // TxtnameCurso
            // 
            this.TxtnameCurso.Location = new System.Drawing.Point(178, 85);
            this.TxtnameCurso.Name = "TxtnameCurso";
            this.TxtnameCurso.Size = new System.Drawing.Size(130, 20);
            this.TxtnameCurso.TabIndex = 22;
            // 
            // NameCurso
            // 
            this.NameCurso.AutoSize = true;
            this.NameCurso.Location = new System.Drawing.Point(31, 95);
            this.NameCurso.Name = "NameCurso";
            this.NameCurso.Size = new System.Drawing.Size(119, 13);
            this.NameCurso.TabIndex = 21;
            this.NameCurso.Text = "NOMBRE DEL CURSO";
            // 
            // BtnGuardarDataCurso
            // 
            this.BtnGuardarDataCurso.Location = new System.Drawing.Point(257, 246);
            this.BtnGuardarDataCurso.Name = "BtnGuardarDataCurso";
            this.BtnGuardarDataCurso.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardarDataCurso.TabIndex = 18;
            this.BtnGuardarDataCurso.Text = "insertar";
            this.BtnGuardarDataCurso.UseVisualStyleBackColor = true;
            this.BtnGuardarDataCurso.Click += new System.EventHandler(this.BtnGuardarDataCurso_Click);
            // 
            // ID_Curso
            // 
            this.ID_Curso.AutoSize = true;
            this.ID_Curso.Location = new System.Drawing.Point(31, 69);
            this.ID_Curso.Name = "ID_Curso";
            this.ID_Curso.Size = new System.Drawing.Size(62, 13);
            this.ID_Curso.TabIndex = 17;
            this.ID_Curso.Text = "ID_CURSO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "AGREGAR  CURSO";
            // 
            // TxtId_Curso
            // 
            this.TxtId_Curso.Location = new System.Drawing.Point(178, 59);
            this.TxtId_Curso.Name = "TxtId_Curso";
            this.TxtId_Curso.Size = new System.Drawing.Size(130, 20);
            this.TxtId_Curso.TabIndex = 15;
            // 
            // TxtnombreInstructor
            // 
            this.TxtnombreInstructor.Location = new System.Drawing.Point(178, 111);
            this.TxtnombreInstructor.Name = "TxtnombreInstructor";
            this.TxtnombreInstructor.Size = new System.Drawing.Size(130, 20);
            this.TxtnombreInstructor.TabIndex = 30;
            // 
            // Instructor
            // 
            this.Instructor.AutoSize = true;
            this.Instructor.Location = new System.Drawing.Point(31, 121);
            this.Instructor.Name = "Instructor";
            this.Instructor.Size = new System.Drawing.Size(128, 13);
            this.Instructor.TabIndex = 29;
            this.Instructor.Text = "NOMBRE INSTRUCTOR";
            // 
            // TxtapellidosInstructor
            // 
            this.TxtapellidosInstructor.Location = new System.Drawing.Point(178, 143);
            this.TxtapellidosInstructor.Name = "TxtapellidosInstructor";
            this.TxtapellidosInstructor.Size = new System.Drawing.Size(130, 20);
            this.TxtapellidosInstructor.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "APELLIDOS INSTRUCTOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 331);
            this.Controls.Add(this.TxtapellidosInstructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtnombreInstructor);
            this.Controls.Add(this.Instructor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btneliminar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.TxtnameCurso);
            this.Controls.Add(this.NameCurso);
            this.Controls.Add(this.BtnGuardarDataCurso);
            this.Controls.Add(this.ID_Curso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtId_Curso);
            this.Name = "Form1";
            this.Text = "DATOS DE CURSO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btneliminar;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Label TemCurso;
        private System.Windows.Forms.TextBox TxtnameCurso;
        private System.Windows.Forms.Label NameCurso;
        private System.Windows.Forms.Button BtnGuardarDataCurso;
        private System.Windows.Forms.Label ID_Curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId_Curso;
        private System.Windows.Forms.LinkLabel linkHorario;
        private System.Windows.Forms.LinkLabel linkTemario;
        private System.Windows.Forms.TextBox TxtnombreInstructor;
        private System.Windows.Forms.Label Instructor;
        private System.Windows.Forms.TextBox TxtapellidosInstructor;
        private System.Windows.Forms.Label label2;
    }
}

