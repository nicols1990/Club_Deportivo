/*
 * Creado por SharpDevelop.
 * Usuario: nicog
 * Fecha: 10/10/2023
 * Hora: 08:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto_4
{
	/// <summary>
	/// Description of ClassCategoria.
	/// </summary>

	public class Categoria{ 
		//Atributos
		
		private ArrayList entrenadores;
		private ArrayList socios;
		private string nombre;
		private int cupo,cantidadIncriptos,cuota, mes, dia,año;
		
		
		//Constructor
		
		public Categoria(string nombre,int cupo,int cantidadInscriptos, int dia, int año, int mes){
		this.nombre=nombre;
		this.cupo=cupo;
		this.cantidadIncriptos=cantidadInscriptos;
		cuota=0;
		this.dia=dia;
		this.año=año;
		this.mes=mes;
		}
		
		//Propiedades
		
		public int Cuota{
			get{return cuota;}
			set{cuota=value;}
		}
		
		public int Cupo{
			get{return cupo;}
			set{cupo=value;}
		}
		
			public int CantidadInscriptos{
			get{return cantidadIncriptos;}
			set{cantidadIncriptos=value;}
		}
		
		public int Dia{
			get{return dia;}
			set{dia=value;}
		}
		public int Año{
			get{return año;}
			set{año=value;}
			
		}
		public int Mes{
			get{return mes;}
			set{mes=value;}
			
		}
		//Metodos
		
		public ArrayList ListCategorias() {
			return socios;
		}
		public Socio BuscarSocio(int indice){
			return (Socio) socios[indice];
		}	
		public int TotalSocio(){
			return socios.Count;
		}
		public void AgregarSocio(Socio s){
			socios.Add(s);
		}
		public void EliminarSocio(Socio s){
			socios.Remove(s);
		}
		
		public ArrayList ListaEntrenadores() {
			return entrenadores;
		}
		public Entrenador BuscarEntrenadores(int indice){
			return (Entrenador) entrenadores[indice];
		}	
		public int TotalEntrenadores(){
			return entrenadores.Count;
		}
		public void AgregarEntrenador(Entrenador e){
			entrenadores.Add(e);
		}
		public void EliminarEntrenaodor(Entrenador e){
			entrenadores.Remove(e);
		}
		
		
			
			
		
		}
}

