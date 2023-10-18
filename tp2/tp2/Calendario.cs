using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2 {
	class Calendario {
		private DataGridView dataGridView;
		private int[,] días;
		private const int FILAS = 6;
		private const int COLUMNAS = 7;
		private int año;
		private int mes;

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

		public void MostrarMes(int mes, int año) {
			this.días = new int[40, 2];
			this.dataGridView.ClearSelection();
			this.mes = mes;
			this.año = año;

			DateTime fecha = new DateTime(año, mes, 1);

			int primerDíaSemana = (int)fecha.DayOfWeek;
			if(primerDíaSemana == (int)DayOfWeek.Sunday)
				primerDíaSemana = 6;
			else
				primerDíaSemana--;

			int díasTotales = DateTime.DaysInMonth(año, mes);

			for(int d = 0; d < díasTotales; d++)
				this.días[primerDíaSemana + d, 0] = d + 1;

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
					if(d < primerDíaSemana)
						celda.Value = d + 1 + DateTime.DaysInMonth(año, mes - 1) - primerDíaSemana;
					else
						celda.Value = d + 1 - díasTotales - primerDíaSemana;

					celda.Style.BackColor = Color.FromArgb(211, 197, 197);
					celda.Style.ForeColor = Color.FromArgb(112, 103, 103);
				}
			}
		}

		public bool HayDíaSeleccionado {
			get {
				if(this.dataGridView.SelectedCells.Count == 0)
					return false;

				DataGridViewCell celda = this.dataGridView.SelectedCells[0];
				int índice = celda.ColumnIndex + celda.RowIndex * COLUMNAS;
				return índice < this.días.GetLength(0) && this.días[índice, 0] != 0;
			}
		}

		public DateTime DíaSeleccionado {
			get {
				DataGridViewCell celda = this.dataGridView.SelectedCells[0];
				int índice = celda.ColumnIndex + celda.RowIndex * COLUMNAS;
				return new DateTime(this.año, this.mes, this.días[índice, 0]);
			}
		}
	}
}
