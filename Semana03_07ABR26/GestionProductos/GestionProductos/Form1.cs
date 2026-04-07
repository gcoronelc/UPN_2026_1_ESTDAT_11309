namespace GestionProductos
{
	public partial class Form1 : Form
	{

		// Instancias de las dos listas enlazadas
		private ListaEnlazada lista1 = new ListaEnlazada();
		private ListaEnlazada lista2 = new ListaEnlazada();

		public Form1()
		{
			InitializeComponent();
			ConfigurarGrids();
		}


		// Configura las columnas de los DataGridView
		private void ConfigurarGrids()
		{
			string[] cols = { "Nombre", "Precio (S/)" };
			foreach (DataGridView dgv in
				new[] { dgvLista1, dgvLista2, dgvMezclada })
			{
				dgv.Columns.Clear();
				dgv.Columns.Add("colNombre", cols[0]);
				dgv.Columns.Add("colPrecio", cols[1]);
				dgv.Columns["colNombre"].Width = (dgv == dgvMezclada ? 600 : 200);
				dgv.Columns["colPrecio"].Width = 100;
				dgv.AllowUserToAddRows = false;
				// Identificar si es el dgvMezclada
				if (dgv == dgvMezclada)
				{
					dgv.BackgroundColor = Color.FromArgb(226, 239, 218); // verde claro
					dgv.ColumnHeadersDefaultCellStyle.BackColor 
						= Color.FromArgb(30, 113, 69);
					dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				}
				else
				{
					dgv.BackgroundColor = Color.FromArgb(214, 228, 240); // azul claro
					dgv.ColumnHeadersDefaultCellStyle.BackColor 
						= Color.FromArgb(46, 117, 182);
					dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				}
			}
		}

		// Actualiza un DataGridView a partir de una lista enlazada
		private void ActualizarGrid(ListaEnlazada lista, DataGridView dgv)
		{
			dgv.Rows.Clear();
			foreach (Producto p in lista.ObtenerTodos())
			{
				dgv.Rows.Add(p.Nombre, p.Precio.ToString("F2"));
			}
		}


		// EVENTOS
		private void btnAgregar1_Click(object sender, EventArgs e)
		{
			if (!ValidarEntrada(out string nombre, out double precio)) return;
			lista1.InsertarAlFinal(new Producto(nombre, precio));
			ActualizarGrid(lista1, dgvLista1);
			LimpiarEntrada();
		}

		private void btnAgregar2_Click(object sender, EventArgs e)
		{
			if (!ValidarEntrada(out string nombre, out double precio)) return;
			lista2.InsertarAlFinal(new Producto(nombre, precio));
			ActualizarGrid(lista2, dgvLista2);
			LimpiarEntrada();
		}

		// Aplicando Early Return o Guard Clause
		// Robert C.Martin lo recomienda explícitamente en Clean Code (2008)
		// como una forma de reducir la complejidad cognitiva del código.
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text.Trim();
			if (string.IsNullOrEmpty(nombre))
			{
				MessageBox.Show("Ingrese un nombre para buscar.",
					"Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Nodo encontrado = lista1.Buscar(nombre);
			if (encontrado != null)
			{
				lblResultado.Text = $"Encontrado en Lista 1: {encontrado.Dato}";
				return;
			}
			encontrado = lista2.Buscar(nombre);
			if (encontrado != null)
			{
				lblResultado.Text = $"Encontrado en Lista 2: {encontrado.Dato}";
				return;
			}
			lblResultado.Text = "Producto no encontrado en ninguna lista.";
		}

		private void btnOrdenar1_Click(object sender, EventArgs e)
		{
			lista1.OrdenarBurbuja();
			ActualizarGrid(lista1, dgvLista1);
		}

		private void btnOrdenar2_Click(object sender, EventArgs e)
		{
			lista2.OrdenarBurbuja();
			ActualizarGrid(lista2, dgvLista2);
		}

		private void btnMezclar_Click(object sender, EventArgs e)
		{
			// Precondicion: ambas listas deben estar ordenadas antes de mezclar
			lista1.OrdenarBurbuja();
			lista2.OrdenarBurbuja();
			ActualizarGrid(lista1, dgvLista1);
			ActualizarGrid(lista2, dgvLista2);
			// Mezcla ordenada: se asume que ambas listas ya estan ordenadas por Precio
			ListaEnlazada mezclada = lista1.Mezclar(lista2);
			ActualizarGrid(mezclada, dgvMezclada);
			lblResultado.Text = "Mezcla completada correctamente.";
		}

		private void btnDatosEjemplo_Click(object sender, EventArgs e)
		{
			// Limpiar listas existentes
			lista1 = new ListaEnlazada();
			lista2 = new ListaEnlazada();

			// Cargar datos en Lista 1
			lista1.InsertarAlFinal(new Producto("Teclado", 80.50));
			lista1.InsertarAlFinal(new Producto("Mouse", 45.00));
			lista1.InsertarAlFinal(new Producto("Monitor", 950.00));

			// Cargar datos en Lista 2
			lista2.InsertarAlFinal(new Producto("USB Hub", 35.00));
			lista2.InsertarAlFinal(new Producto("Webcam", 120.00));
			lista2.InsertarAlFinal(new Producto("Audifonos", 75.00));

			// Reflejar en los DataGridView
			ActualizarGrid(lista1, dgvLista1);
			ActualizarGrid(lista2, dgvLista2);

			// Limpiar la lista mezclada si hubiera un resultado previo
			dgvMezclada.Rows.Clear();

			lblResultado.Text = "Datos de ejemplo cargados correctamente.";
		}

		// AUXILIARES

		private bool ValidarEntrada(out string nombre, out double precio)
		{
			// Inicializa las variables de salida
			nombre = txtNombre.Text.Trim();
			precio = 0;
			// Valida que el nombre no este vacio.
			if (string.IsNullOrEmpty(nombre))
			{
				MessageBox.Show("El nombre no puede estar vacio.",
					"Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtNombre.Focus();
				return false;
			}
			// Valida que el precio sea un numero valido mayor a cero.
			string texto = txtPrecio.Text.Trim().Replace(",", ".");
			bool exito = double.TryParse(texto, out precio);
			if (!exito || precio <= 0)
			{
				MessageBox.Show("Ingrese un precio numerico mayor a cero.",
					"Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPrecio.Focus();
				return false;
			}
			return true;
		}

		private void LimpiarEntrada()
		{
			txtNombre.Clear();
			txtPrecio.Clear();
			txtNombre.Focus();
		}


	}
}
