﻿//Generando un grafo aleatoriamente
using System;
using System.Collections.Generic;

namespace ArbolGrafoLista {
	class Program {
		public static void Main() {
			Random azar = new Random();

			//Usa una lista para guardar los nodos
			List<Nodo> listado = new List<Nodo>();

			//Genera los nodos dentro de un List
			int Total = azar.Next(20, 30);
			for (int cont = 1; cont <= Total; cont++) {
				listado.Add(new Nodo(cont));
			}

			//Ahora interconecta los nodos al azar
			Total = azar.Next(50, 200);
			for (int cont = 1; cont <= Total; cont++) {
				int nodoA = azar.Next(listado.Count);
				int nodoB;
				do {
					nodoB = azar.Next(listado.Count);
				} while (nodoA == nodoB);

                switch (azar.Next(4)) {
					case 0: listado[nodoA].Arriba = listado[nodoB]; break;
					case 1: listado[nodoA].Abajo = listado[nodoB]; break;
					case 2: listado[nodoA].Izquierda = listado[nodoB]; break;
					case 3: listado[nodoA].Derecha = listado[nodoB]; break;
				}
			}

			//Imprime el grafo para ser interpretado por viz.js
			Console.WriteLine("digraph testgraph{");
			for (int cont = 0; cont < listado.Count; cont++) {
				if (listado[cont].Arriba != null) Console.WriteLine(listado[cont].Numero + "->" + listado[cont].Arriba.Numero);
				if (listado[cont].Abajo != null) Console.WriteLine(listado[cont].Numero + "->" + listado[cont].Abajo.Numero);
				if (listado[cont].Izquierda != null) Console.WriteLine(listado[cont].Numero + "->" + listado[cont].Izquierda.Numero);
				if (listado[cont].Derecha != null) Console.WriteLine(listado[cont].Numero + "->" + listado[cont].Derecha.Numero);
			}
			Console.WriteLine("}");
			//Imprime
			Console.ReadKey();
		}
	}
}