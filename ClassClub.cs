/*
 * Creado por SharpDevelop.
 * Usuario: nicog
 * Fecha: 10/10/2023
 * Hora: 08:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto_4
{
	/// <summary>
	/// Description of ClassClub.
	/// </summary>
	
	public class Club{
		//Atributos
		private string nombre;
		private ArrayList entrenadores;
		private ArrayList deportes;
		private ArrayList socios;
		
		//Constructor
		public Club (string nombre){
			this.nombre=nombre;
			entrenadores=new ArrayList();
			deportes=new ArrayList();
			socios=new ArrayList();
		}
		//Propiedades
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
		
		//Metodos
		
		public void DarAltaEntrenador(Entrenador e){
			entrenadores.Add(e);
		}
		public void DarDeBajaEntrenador(Entrenador e){
			entrenadores.Remove(e);
		}
		
		
		public void AgregarDeporte(Deporte d){
			deportes.Add(d);
		}
		
		public void EliminarDeporte(Deporte d){
			deportes.Remove(d);
		}
		
		public void AgregarSocio(Socio s){
			socios.Add(s);
		}
		public void EliminarSocio(Socio s){
			socios.Remove(s);
		}
		
		public int TotalDeporte(){
			return deportes.Count;
		}
		
		public int TotalSocio(){
			return socios.Count;
		}
		
		public int TotalEntrenador(){
			return entrenadores.Count;
		}
		
		public Entrenador BuscarEntrenadores(int indice){
			return (Entrenador) entrenadores[indice];		
		}
		
		public Deporte BuscarDeportes(int indice){
			return (Deporte) deportes[indice];		
		}
		
		public Socio BuscarSocios(int indice){
			return (Socio) socios[indice];
		}
		public ArrayList ListaSocios() {
			return socios;
		}
		public ArrayList ListaEntrenadores() {
			return entrenadores;
		}
		public ArrayList ListaDeportes() {
			return deportes;
		}
		public bool existeDeporte(string nomb){
			foreach(Deporte d in deportes){
				if(d.NombreDeporte==nomb){
					return true;
				}
			}
			return false;
				
			}
	/*	public void existeDeporte(string nombre) {
			foreach(Deporte d in deportes){
				if(d.NombreDeporte==nombre){
					Club.AsociarSocio(socio)
			}
			else:
				Console.WriteLine("el deporte no esta")
		}
		}*/
	
	}
}
