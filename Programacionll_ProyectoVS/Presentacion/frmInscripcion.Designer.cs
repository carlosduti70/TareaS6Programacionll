﻿namespace Programacionll_ProyectoVS.Presentacion
{
    partial class Inscripcion
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
            groupBox3 = new GroupBox();
            dgvCursos = new DataGridView();
            groupBox2 = new GroupBox();
            button2btnCancelar = new Button();
            btnAceptar = new Button();
            groupBox1 = new GroupBox();
            cmbCliente = new ComboBox();
            cmbCurso = new ComboBox();
            label1 = new Label();
            chkEstado = new CheckBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCursos);
            groupBox3.Location = new Point(66, 196);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(669, 241);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new Point(10, 20);
            dgvCursos.Margin = new Padding(3, 2, 3, 2);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(653, 217);
            dgvCursos.TabIndex = 16;
            dgvCursos.CellContentClick += dgvCursos_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2btnCancelar);
            groupBox2.Controls.Add(btnAceptar);
            groupBox2.Location = new Point(539, 136);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(196, 56);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // button2btnCancelar
            // 
            button2btnCancelar.Location = new Point(108, 20);
            button2btnCancelar.Margin = new Padding(3, 2, 3, 2);
            button2btnCancelar.Name = "button2btnCancelar";
            button2btnCancelar.Size = new Size(82, 22);
            button2btnCancelar.TabIndex = 13;
            button2btnCancelar.Text = "Cancelar";
            button2btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(6, 20);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(cmbCurso);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(66, 13);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(226, 124);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(81, 82);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 25;
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(81, 46);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(121, 23);
            cmbCurso.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 90);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 13;
            label1.Text = "Cliente";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(79, 16);
            chkEstado.Margin = new Padding(3, 2, 3, 2);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 11;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 20);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 49);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Curso";
            // 
            // Inscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Inscripcion";
            Text = "frmInscripcion";
            Load += Inscripcion_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView dgvCursos;
        private GroupBox groupBox2;
        private Button button2btnCancelar;
        private Button btnAceptar;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox chkEstado;
        private Label label6;
        private Label label4;
        private Label label2;
        private ComboBox cmbCliente;
        private ComboBox cmbCurso;
    }
}