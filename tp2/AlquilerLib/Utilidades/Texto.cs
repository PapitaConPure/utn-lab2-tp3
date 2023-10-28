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
		/// Deja en mayúscula la primer letra de cada palabra en el texto indicado y en minúsculas el resto
		/// </summary>
		/// <param name="texto">El texto a capitalizar</param>
		/// <returns>Texto indicado con la primer letra de cada palabra en mayúscula y el resto en minúscula</returns>
		/// <exception cref="NullReferenceException"></exception>
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
