/*
 * Creado por SharpDevelop.
 * Usuario: nicog
 * Fecha: 10/10/2023
 * Hora: 08:34 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;


namespace Proyecto_4{
	/// <summary>
	/// Description of ClassSocio.:
	/// </summary>

	//Clase socio con herencia aplicada
	public class Socio:Persona{
		
		//Atributos de Socio con herencia
	private DateTime ultimoMesPago;
	
		
		//Constructor con Herencia aplicada, se usa base para que ejecute primero lo que hereda*/
	public Socio( string nombre,int dni, int edad): base(nombre, dni, edad){
			
		/*ultimoMesPago=new DateTime(2000,10,12);*/
			
		
		}
		//Propiedades con Herencia aplicada
		
		
		/*public DateTime UltimoMesPago{
			get{return ultimoMesPago;}
			set{ultimoMesPago=value;}
			}*/
		
	//Metodos

}
}
