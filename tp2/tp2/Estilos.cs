using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace tp2 {
	//Perdón, parpadeé y cuando me di cuenta le había puesto estilo a todo el programa y mínimo 4 clases nuevas
	//Quién diría que Lato no es una fuente por defecto. Voy a matar a los de Microsoft
	static class Estilos {
		private static PrivateFontCollection latoBlack;
		private static FontFamily segoeUI;
		private static FontFamily segoeUISemibold;
		private static FontFamily segoeUIBlack;

		/// <summary>
		/// Fuente Sans-Serif humanista de apariencia limpia y moderna. Negra
		/// </summary>
		public static FontFamily LatoBlack { get { return latoBlack.Families[0]; } }
		/// <summary>
		/// Fuente Sans-Serif humanista de apariencia altamente legible y relativamente moderna
		/// </summary>
		public static FontFamily SegoeUI { get { return segoeUI; } }
		/// <summary>
		/// Fuente Sans-Serif humanista de apariencia altamente legible y relativamente moderna. Seminegrita
		/// </summary>
		public static FontFamily SegoeUISemibold { get { return segoeUISemibold; } }
		/// <summary>
		/// Fuente Sans-Serif humanista de apariencia altamente legible y relativamente moderna. Negra
		/// </summary>
		public static FontFamily SegoeUIBlack { get { return segoeUIBlack; } }

		/// <summary>
		/// Gris pálido, usado para texto
		/// </summary>
		public static readonly Color TextColor = Color.FromArgb(216, 216, 216);
		/// <summary>
		/// Gris súper oscuro, usado para texto
		/// </summary>
		public static readonly Color TextColorDarkest = Color.FromArgb(22, 22, 22);
		/// <summary>
		/// Azul negro, usado para fondos
		/// </summary>
		public static readonly Color BackgroundColorDark2 = Color.FromArgb(9, 9, 11);
		/// <summary>
		/// Azul súper oscuro, usado para fondos
		/// </summary>
		public static readonly Color BackgroundColorDark1 = Color.FromArgb(17, 17, 21);
		/// <summary>
		/// Azul oscuro, usado para fondos
		/// </summary>
		public static readonly Color BackgroundColor = Color.FromArgb(22, 22, 29);
		/// <summary>
		/// Color representante de la marca, se apunta a usarlo en aproximadamente 60% del contenido.
		/// Generalmente usado en los principales llamados-a-acción y secciones fundamentales
		/// </summary>
		/// <remarks>Color: naranja fuerte</remarks>
		public static readonly Color PrimaryColor = Color.FromArgb(13, 235, 94);
		/// <summary>
		/// Color secundario, se apunta a usarlo en aproximadamente 30% del contenido.
		/// Generalmente usado para acciones y secciones secundarias
		/// </summary>
		/// <remarks>Color: arcilla oscura</remarks>
		public static readonly Color SecondaryColor = Color.FromArgb(35, 35, 72);
		public static readonly Color SecondaryColorLight1 = Color.FromArgb(92, 92, 102);
		public static readonly Color SecondaryColorLight2 = Color.FromArgb(146, 146, 168);
		public static readonly Color SecondaryColorLight3 = Color.FromArgb(197, 197, 211);
		/// <summary>
		/// Color de acento, se apunta a usarlo en aproximadamente 10% del contenido.
		/// Generalmente usado para imágenes, enlaces, íconos, cajas, tarjetas, etc
		/// </summary>
		/// <remarks>Color: turquesa claro</remarks>
		public static readonly Color AccentColor = Color.FromArgb(245, 43, 101);
		/// <summary>
		/// Color semántico para indicar "información"
		/// </summary>
		public static readonly Color InformationSemanticColor = Color.FromArgb(29, 190, 245);
		/// <summary>
		/// Color semántico para indicar "éxito"
		/// </summary>
		public static readonly Color SuccessSemanticColor = Color.FromArgb(40, 185, 86);
		/// <summary>
		/// Color semántico para indicar "cuidado"
		/// </summary>
		public static readonly Color WarningSemanticColor = Color.FromArgb(240, 208, 0);
		/// <summary>
		/// Color semántico para indicar "peligro"
		/// </summary>
		public static readonly Color DangerSemanticColor = Color.FromArgb(217, 55, 60);

		static Estilos() {
			latoBlack = new PrivateFontCollection();
			latoBlack.AddFontFile(Path.Combine(Application.StartupPath, "Resources", "Lato-Black.ttf"));
			segoeUI = new FontFamily("Segoe UI");
			segoeUISemibold = new FontFamily("Segoe UI Semibold");
			segoeUIBlack = new FontFamily("Segoe UI Black");
		}
	}
}
