namespace Act.Aprendizaje.U._1
{
    public partial class Form1 : Form
    {
        private int[]? arreglo;
        private int tama�o;
        private int indice;

        public Form1()
        {
            InitializeComponent();
            lista = new ListaEnlazada();
        }

        private void btnCrearArreglo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTama�o.Text, out int valor) && valor > 0 && valor <= 10)
            {
                tama�o = valor;
                arreglo = new int[tama�o];
                indice = 0;
                lblEspacios.Text = $"Espacios restantes: {tama�o}";
                MessageBox.Show("Arreglo creado con �xito.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un tama�o v�lido (entre 1 y 10).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarValor_Click(object sender, EventArgs e)
        {
            if (arreglo == null)
            {
                MessageBox.Show("Primero debe crear el arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el n�mero ingresado sea v�lido
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (indice < tama�o)
                {
                    arreglo[indice] = numero; // Guardar el valor en el arreglo
                    indice++;
                    lblEspacios.Text = $"Espacios restantes: {tama�o - indice}";

                    if (indice == tama�o)
                    {
                        MessageBox.Show("El arreglo est� completo.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El arreglo ya est� lleno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un n�mero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNumero.Text = "";
        }
        private void btnVerValores_Click(object sender, EventArgs e)
        {
            if (arreglo == null || indice == 0)
            {
                MessageBox.Show("El arreglo est� vac�o o no ha sido creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Concatenar los valores guardados en el arreglo
            string valores = string.Join(", ", arreglo.Take(indice));
            MessageBox.Show($"Valores guardados: {valores}", "Valores del Arreglo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (arreglo == null || indice == 0)
            {
                MessageBox.Show("No hay valores para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            indice--; // Reducir el �ndice
            arreglo[indice] = 0; // Opcional: Restablecer el valor a 0
            lblEspacios.Text = $"Espacios restantes: {tama�o - indice}";

            MessageBox.Show("�ltimo valor borrado con �xito.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (arreglo == null || indice == 0)
            {
                MessageBox.Show("No hay valores para borrar o el arreglo no ha sido creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reiniciar el arreglo y los valores relacionados
            arreglo = null;
            tama�o = 0;
            indice = 0;

            lblEspacios.Text = "Espacios restantes: 0";

            MessageBox.Show("Todos los valores del arreglo han sido borrados.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        private ListaEnlazada lista;

        private void btnAgg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                lista.Agregar(valor);
                MostrarLista();
                txtValor.Clear();
                txtValor.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero v�lido.", "Entrada inv�lida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarLista()
        {
            listBoxNodos.Items.Clear();
            foreach (var dato in lista.ObtenerElementos())
            {
                listBoxNodos.Items.Add(dato);
            }
        }
    }
}
