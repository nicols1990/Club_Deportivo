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
	/// Description of ClassPersona.
	/// </summary>

	//Clase Persona
	public class Persona{
		
		//Atributos de clase Persona, para que se pueda heredad siempre tiene que estar public o protected
		protected string nombre;
		protected int dni;
		protected int edad;
		
		//Constructor
		public Persona(string nombre, int dni, int edad){
			this.nombre=nombre;
			this.dni=dni;
			this.edad=edad;
		}
		
		
		
		//Propiedades
		public string Nombre{
			get{return nombre;}
			set{nombre=value;}
		}
	 	
		public int Dni{
			get{return dni;}
			set{dni=value;}
		}
		
		public int Edad{
			get{return edad;}
			set{edad=value;}
		}
	}
}
