namespace Act.Aprendizaje.U._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnBorrarTodo = new Button();
            btnBorrarUltimo = new Button();
            btnVerValores = new Button();
            lblEspacios = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregarValor = new Button();
            btnCrearArreglo = new Button();
            txtNumero = new TextBox();
            txtTamaño = new TextBox();
            groupBox2 = new GroupBox();
            listBoxNodos = new ListBox();
            txtValor = new TextBox();
            btnAgg = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gray;
            groupBox1.Controls.Add(btnBorrarTodo);
            groupBox1.Controls.Add(btnBorrarUltimo);
            groupBox1.Controls.Add(btnVerValores);
            groupBox1.Controls.Add(lblEspacios);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregarValor);
            groupBox1.Controls.Add(btnCrearArreglo);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtTamaño);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estatica";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(246, 182);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(126, 29);
            btnBorrarTodo.TabIndex = 9;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrarUltimo
            // 
            btnBorrarUltimo.Location = new Point(114, 182);
            btnBorrarUltimo.Name = "btnBorrarUltimo";
            btnBorrarUltimo.Size = new Size(126, 29);
            btnBorrarUltimo.TabIndex = 8;
            btnBorrarUltimo.Text = "Borrar ultimo";
            btnBorrarUltimo.UseVisualStyleBackColor = true;
            btnBorrarUltimo.Click += btnBorrarUltimo_Click;
            // 
            // btnVerValores
            // 
            btnVerValores.Location = new Point(6, 182);
            btnVerValores.Name = "btnVerValores";
            btnVerValores.Size = new Size(102, 29);
            btnVerValores.TabIndex = 7;
            btnVerValores.Text = "Ver";
            btnVerValores.UseVisualStyleBackColor = true;
            btnVerValores.Click += btnVerValores_Click;
            // 
            // lblEspacios
            // 
            lblEspacios.AutoSize = true;
            lblEspacios.Font = new Font("Segoe UI", 12F);
            lblEspacios.Location = new Point(6, 151);
            lblEspacios.Name = "lblEspacios";
            lblEspacios.Size = new Size(173, 28);
            lblEspacios.TabIndex = 6;
            lblEspacios.Text = "Espacios restantes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 90);
            label2.Name = "label2";
            label2.Size = new Size(198, 28);
            label2.TabIndex = 5;
            label2.Text = "Numeros a ingresar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 4;
            label1.Text = "Tamaño de arreglo";
            // 
            // btnAgregarValor
            // 
            btnAgregarValor.Location = new Point(278, 121);
            btnAgregarValor.Name = "btnAgregarValor";
            btnAgregarValor.Size = new Size(94, 29);
            btnAgregarValor.TabIndex = 3;
            btnAgregarValor.Text = "Ingresar";
            btnAgregarValor.UseVisualStyleBackColor = true;
            btnAgregarValor.Click += btnAgregarValor_Click;
            // 
            // btnCrearArreglo
            // 
            btnCrearArreglo.Location = new Point(278, 53);
            btnCrearArreglo.Name = "btnCrearArreglo";
            btnCrearArreglo.Size = new Size(94, 29);
            btnCrearArreglo.TabIndex = 2;
            btnCrearArreglo.Text = "Tamaño";
            btnCrearArreglo.UseVisualStyleBackColor = true;
            btnCrearArreglo.Click += btnCrearArreglo_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(6, 121);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(254, 27);
            txtNumero.TabIndex = 1;
            // 
            // txtTamaño
            // 
            txtTamaño.Location = new Point(6, 54);
            txtTamaño.Name = "txtTamaño";
            txtTamaño.Size = new Size(254, 27);
            txtTamaño.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gray;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(listBoxNodos);
            groupBox2.Controls.Add(txtValor);
            groupBox2.Controls.Add(btnAgg);
            groupBox2.Location = new Point(409, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dinamica";
            // 
            // listBoxNodos
            // 
            listBoxNodos.FormattingEnabled = true;
            listBoxNodos.Location = new Point(23, 90);
            listBoxNodos.Name = "listBoxNodos";
            listBoxNodos.Size = new Size(225, 124);
            listBoxNodos.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(23, 53);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 11;
            // 
            // btnAgg
            // 
            btnAgg.Location = new Point(154, 52);
            btnAgg.Name = "btnAgg";
            btnAgg.Size = new Size(94, 29);
            btnAgg.TabIndex = 10;
            btnAgg.Text = "Ingresar";
            btnAgg.UseVisualStyleBackColor = true;
            btnAgg.Click += btnAgg_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 21);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 10;
            label3.Text = "Numeros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 254);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtTamaño;
        private Label label2;
        private Label label1;
        private Button btnAgregarValor;
        private Button btnCrearArreglo;
        private TextBox txtNumero;
        private Label lblEspacios;
        private Button btnVerValores;
        private Button btnBorrarUltimo;
        private Button btnBorrarTodo;
        private Button btnAgg;
        private ListBox listBoxNodos;
        private TextBox txtValor;
        private Label label3;
    }
}
