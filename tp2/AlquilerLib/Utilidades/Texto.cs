using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerLib.Utilidades {
	/// <summary>
	/// Provee utilidades para trabajar con texto
	/// </summary>
	internal static class Texto {
		/// <summary>
		/// Capitaliza la primer letra de cada palabra en el texto indicado y deja en minúsculas el resto de letras
		/// </summary>
		/// <param name="texto"></param>
		/// <returns></returns>
		public static string CapitalizarPalabras(string texto) {
			char[] caracteres = texto.ToCharArray();
			bool esPrimeraLetra = true;

			for(int i = 0; i < caracteres.Length; i++) {
				if(char.IsWhiteSpace(caracteres[i])) {
					esPrimeraLetra = true;
				} else if(esPrimeraLetra) {
					caracteres[i] = char.ToUpper(caracteres[i]);
					esPrimeraLetra = false;
				} else {
					caracteres[i] = char.ToLower(caracteres[i]);
				}
			}

			return new string(caracteres);
		}
	}
}
