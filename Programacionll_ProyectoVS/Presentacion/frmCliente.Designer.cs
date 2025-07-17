namespace Programacionll_ProyectoVS.Presentacion
{
    partial class frmCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            textApellido = new TextBox();
            textDireccion = new TextBox();
            textEmail = new TextBox();
            chkEstado = new CheckBox();
            btnAceptar = new Button();
            button2btnCancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgvClientes = new DataGridView();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 46);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 104);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 74);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 132);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 22);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Estado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 7;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(81, 72);
            textApellido.Margin = new Padding(3, 2, 3, 2);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(232, 23);
            textApellido.TabIndex = 8;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(81, 101);
            textDireccion.Margin = new Padding(3, 2, 3, 2);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(232, 23);
            textDireccion.TabIndex = 9;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(81, 127);
            textEmail.Margin = new Padding(3, 2, 3, 2);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(232, 23);
            textEmail.TabIndex = 10;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(245, 20);
            chkEstado.Margin = new Padding(3, 2, 3, 2);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 11;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            chkEstado.CheckedChanged += checkBox1_CheckedChanged;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEstado);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(textDireccion);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(10, 13);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(328, 164);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parametros";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2btnCancelar);
            groupBox2.Controls.Add(btnAceptar);
            groupBox2.Location = new Point(483, 136);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(196, 56);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(10, 20);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(653, 217);
            dgvClientes.TabIndex = 16;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvClientes);
            groupBox3.Location = new Point(10, 196);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(669, 241);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 599);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCliente";
            Text = "Ingresar Cliente";
            Load += frmCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox textNombre;
        private TextBox textApellido;
        private TextBox textDireccion;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textEmail;
        private CheckBox chkEstado;
        private Button btnAceptar;
        private Button button2btnCancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvClientes;
        private GroupBox groupBox3;
    }
}