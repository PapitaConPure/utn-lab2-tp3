using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2 {
	/// <summary>
	/// Representa un calendario personalizado que edita un <see cref="DataGridView"/> relacionado para representarse
	/// </summary>
	class Calendario {
		private DataGridView dataGridView;
		private int[,] días;
		private const int FILAS = 6;
		private const int COLUMNAS = 7;
		private int año;
		private int mes;
		int díasTotales;
		int primerDíaSemana;

		/// <summary>
		/// Especifica un nombre de mes
		/// </summary>
		public enum NombreMes {
			Enero = 1,
			Febrero = 2,
			Marzo = 3,
			Abril = 4,
			Mayo = 5,
			Junio = 6,
			Julio = 7,
			Agosto = 8,
			Septiembre = 9,
			Octubre = 10,
			Noviembre = 11,
			Diciembre = 12,
		}

		/// <summary>
		/// Crea un nuevo calendario para modificar el <see cref="DataGridView"/> especificado, y carga inicialmente el mes actual
		/// </summary>
		/// <param name="dataGridView"><see cref="DataGridView"/> con el que operará este calendario</param>
		public Calendario(DataGridView dataGridView) {
			this.dataGridView = dataGridView;
			dataGridView.RowCount = FILAS;
			dataGridView.ColumnCount = COLUMNAS;

			int altoFilas = dataGridView.Height / (FILAS + 1);

			dataGridView.ColumnHeadersHeight = altoFilas;
			for(int i = 0; i < FILAS; i++)
				dataGridView.Rows[i].Height = altoFilas;

			DateTime fecha = DateTime.Now;
			this.MostrarMes(fecha.Month, fecha.Year);
		}

		/// <summary>
		/// Indica si hay algún día seleccionado actualmente en el calendario
		/// </summary>
		/// <remarks>Si no hay ningún calendario cargado, devuelve <see langword="false"/></remarks>
		public bool HayDíaSeleccionado {
			get {
				if(this.dataGridView.SelectedCells.Count == 0)
					return false;

				DataGridViewCell celda = this.dataGridView.SelectedCells[0];
				int índice = celda.ColumnIndex + celda.RowIndex * COLUMNAS;
				return índice < this.días.GetLength(0) && this.días[índice, 0] != 0;
			}
		}

		/// <summary>
		/// Devuelve el día seleccionado actualmente en el calendario
		/// </summary>
		/// 
		public DateTime DíaSeleccionado {
			get {
				DataGridViewCell celda = this.dataGridView.SelectedCells[0];
				int índice = celda.ColumnIndex + celda.RowIndex * COLUMNAS;
				return new DateTime(this.año, this.mes, this.días[índice, 0]);
			}
		}

		/// <summary>
		/// Muestra el mes especificado del año indicado en el calendario
		/// </summary>
		/// <param name="mes">El mes a mostrar</param>
		/// <param name="año">El año al que pertenece el mes a mostrar</param>
		public void MostrarMes(int mes, int año) {
			this.días = new int[40, 2];
			this.dataGridView.ClearSelection();
			this.mes = mes;
			this.año = año;

			DateTime fecha = new DateTime(año, mes, 1);

			this.primerDíaSemana = (int)fecha.DayOfWeek;
			if(this.primerDíaSemana == (int)DayOfWeek.Sunday)
				this.primerDíaSemana = 6;
			else
				this.primerDíaSemana--;

			this.díasTotales = DateTime.DaysInMonth(año, mes);

			for(int d = 0; d < this.díasTotales; d++)
				this.días[this.primerDíaSemana + d, 0] = d + 1;

			int columna, fila;
			DataGridViewCell celda;
			for(int d = 0; d < FILAS * COLUMNAS; d++) {
				columna = d % COLUMNAS;
				fila = d / COLUMNAS;
				celda = this.dataGridView[columna, fila];

				if(d < this.días.GetLength(0) && this.días[d, 0] > 0) {
					celda.Value = this.días[d, 0];

					if(this.días[d, 1] == 0)
						celda.Style.BackColor = Color.White;
					else
						celda.Style.BackColor = Color.FromArgb(219, 145, 88);
					celda.Style.ForeColor = Color.FromArgb(22, 22, 22);
				} else {
					if(d < this.primerDíaSemana)
						celda.Value = d + 1 + DateTime.DaysInMonth(año, mes - 1) - this.primerDíaSemana;
					else
						celda.Value = d + 1 - this.díasTotales - this.primerDíaSemana;

					celda.Style.BackColor = Color.FromArgb(211, 197, 197);
					celda.Style.ForeColor = Color.FromArgb(112, 103, 103);
				}
			}
		}

		/// <summary>
		/// Marca un día como alquilado u libre
		/// </summary>
		/// <remarks>Para ver los cambios, debe llamarse <see cref="MostrarMes(int, int)"/> nuevamente</remarks>
		/// <param name="día">El día a marcar, de 1 en adelante</param>
		/// <param name="alquilado"></param>
		public void Marcar(int día, bool alquilado = true) {
			if(día < 1)
				throw new ArgumentOutOfRangeException("El día a marcar no puede ser menor que 1");

			if(día >= this.díasTotales)
				return;

			int idx = this.primerDíaSemana + día - 1;
			int estado = 0;

			if(alquilado)
				estado = 1;

			this.días[idx, 1] = estado;
		}
	}
}
