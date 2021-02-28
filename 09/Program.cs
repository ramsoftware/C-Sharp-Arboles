﻿using System;

namespace ArbolGrafoLista {
	class Program {
		static void Main() {
			//Crea la lista
			Nodo lista = new Nodo("aaaa", 'A', 1, 0.1, null);
			lista = new Nodo("bbbb", 'B', 2, 0.2, lista);
			lista = new Nodo("cccc", 'C', 3, 0.3, lista);
			lista = new Nodo("dddd", 'D', 4, 0.4, lista);
			lista = new Nodo("eeee", 'E', 5, 0.5, lista);

			//Imprime la lista en ambos sentidos
			ImprimeIzquierdaDerecha(lista);
			ImprimeDerechaIzquierda(lista);
			Console.ReadKey();
		}

		//Imprime la lista de izquierda a derecha
		static public void ImprimeIzquierdaDerecha(Nodo pasear) {
			Console.WriteLine("\r\nDe izquierda a derecha");

			//Debe ponerse en el primer nodo de la izquierda
			while (pasear.NodoIzq != null) {
				pasear = pasear.NodoIzq;
			}

			//Una vez en el primer nodo de la izquierda, entonces va
			//de izquierda a derecha imprimiendo
			while (pasear != null) {
				pasear.Imprime();
				pasear = pasear.NodoDer;
			}
		}

		//Imprime la lista de derecha a izquierda
		static public void ImprimeDerechaIzquierda(Nodo pasear) {
			Console.WriteLine("\r\nDe derecha a izquierda");

			//Debe ponerse en el primer nodo de la derecha
			while (pasear.NodoDer != null) {
				pasear = pasear.NodoDer;
			}

			//Una vez en el primer nodo de la derecha, entonces va
			//de derecha a izquierda imprimiendo
			while (pasear != null) {
				pasear.Imprime();
				pasear = pasear.NodoIzq;
			}
		}
	}
}
