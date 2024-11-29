namespace Act.Aprendizaje.U._1
{
    public partial class Form1 : Form
    {
        private int[]? arreglo;
        private int tamaño;
        private int indice;

        public Form1()
        {
            InitializeComponent();
            lista = new ListaEnlazada();
        }

        private void btnCrearArreglo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTamaño.Text, out int valor) && valor > 0 && valor <= 10)
            {
                tamaño = valor;
                arreglo = new int[tamaño];
                indice = 0;
                lblEspacios.Text = $"Espacios restantes: {tamaño}";
                MessageBox.Show("Arreglo creado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un tamaño válido (entre 1 y 10).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarValor_Click(object sender, EventArgs e)
        {
            if (arreglo == null)
            {
                MessageBox.Show("Primero debe crear el arreglo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el número ingresado sea válido
            if (int.TryParse(txtNumero.Text, out int numero))
            {
                if (indice < tamaño)
                {
                    arreglo[indice] = numero; // Guardar el valor en el arreglo
                    indice++;
                    lblEspacios.Text = $"Espacios restantes: {tamaño - indice}";

                    if (indice == tamaño)
                    {
                        MessageBox.Show("El arreglo está completo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El arreglo ya está lleno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNumero.Text = "";
        }
        private void btnVerValores_Click(object sender, EventArgs e)
        {
            if (arreglo == null || indice == 0)
            {
                MessageBox.Show("El arreglo está vacío o no ha sido creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            indice--; // Reducir el índice
            arreglo[indice] = 0; // Opcional: Restablecer el valor a 0
            lblEspacios.Text = $"Espacios restantes: {tamaño - indice}";

            MessageBox.Show("Último valor borrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tamaño = 0;
            indice = 0;

            lblEspacios.Text = "Espacios restantes: 0";

            MessageBox.Show("Todos los valores del arreglo han sido borrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Por favor, ingrese un número válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
