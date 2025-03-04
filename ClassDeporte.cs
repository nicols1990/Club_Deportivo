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
	/// Description of ClassDeporte.
	/// </summary>
	/// 
	
	//Clase Deporte
	public class Deporte{
		
		//Atributos 
		private string nombreDeporte;
		private ArrayList categorias;
		
		//Constructor
		public Deporte(string nombreDeporte){
			this.nombreDeporte=nombreDeporte;
			categorias=new ArrayList();
		}
		
		//Propiedades
		public string NombreDeporte{
			get{return nombreDeporte;}
			set{nombreDeporte=value;}
		}
		
		
		
		public void AgregarCategoria (Categoria a){
			categorias.Add(a);
		}
		
		public void EliminarCategoria (Categoria a){
			categorias.Remove(a);
		}
		
		public int TotalCategorias(){
			return categorias.Count;
		}
		
		public Categoria ListadoCategogrias(int indice){
			return (Categoria) categorias[indice];
		}
		
			
		
		}
		
		
		


		}
	

/*public void AsociarSocioADeporte(Socio socio, string nombreDeporte) 
	foreach(Deporte in deportes)
	deporte.AsociarSocio(socio)
{ // Primero, buscar el deporte por su nombre en la lista de deportes Deporte deporte = buscarDeportePorNombre(nombreDeporte); if (deporte != null) { // Asociar el socio al deporte (esto dependerá de cómo tengas estructurada tu lógica) // Por ejemplo, puedes tener una lista de asociaciones en la clase Deporte, // o alguna otra estructura para manejar estas relaciones. // Aquí asumo que tienes un método en Deporte para asociar al socio deporte.AsociarSocio(socio); Console.WriteLine($"El socio {socio.Nombre} ha sido asociado al deporte {nombreDeporte}."); }
	else { Console.WriteLine($"No se encontró el deporte {nombreDeporte} en el club.");*/