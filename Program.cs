/*
 * Creado por SharpDevelop.
 * Usuario: nicog
 * Fecha: 10/10/2023
 * Hora: 08:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;


namespace Proyecto_4
{
	class Program
	{
		public static void Main(string [] args)
		{
			
			Club clb=new Club("Olimpico");
			
			string opcion;
			do{
				menu();
				
				Console.WriteLine("Eliga un opcion del Menu");
				opcion=(Console.ReadLine());
				
				
				
				
				switch(opcion){
					case "a":
						Console.WriteLine("¿Quiere agregar un Entrenador?");
						Console.WriteLine("si ingresa no, vuelve al menu");
						string op= Console.ReadLine();
						while(op.ToLower()=="si"){
							Console.WriteLine("Ingrese nombre: ");
							string nombre= Console.ReadLine();
							Console.WriteLine("Ingrese edad: ");
							int edad=int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese dni: ");
							int dni=int.Parse(Console.ReadLine());
							Entrenador e= new Entrenador(nombre,dni,edad);
							
							clb.DarAltaEntrenador(e);
							Console.WriteLine("Quiere agregar otro Entrenador? si o no, si es no, se cierra el programa");
							op=Console.ReadLine();
						}
						Console.Clear();
						break;
								
					case "b":
						Console.WriteLine("Quiere eliminar un entrenaodor, si o no, si ingresa no, vuelve al menu");
						string opp=Console.ReadLine();
						while (opp!="no"){
							Console.WriteLine("Ingrese dni del entrenador que quiere elimnar");
							int dniAEliminar=int.Parse(Console.ReadLine());
							
							bool entrenadorEncontrado=false;
							foreach(Entrenador e in clb.ListaEntrenadores()){
								
								if(dniAEliminar==e.Dni){
									entrenadorEncontrado=true;
									clb.DarDeBajaEntrenador(e);
									Console.WriteLine("El entrenador se elimino correctamente");
									break;
									
									
								}
							}
							
							if (!entrenadorEncontrado) {
								Console.WriteLine("No existe entrenador con ese dni");
								
								
								
							}
							
							Console.WriteLine("Quiere eliminar un socio, SI o NO, si ingresa no, se cierra");
							opp=Console.ReadLine();
							
						}
						
						Console.Clear();
						break;
						
								case "c":
						Console.WriteLine("¿Quiere agregar un nuevo socio?");
						Console.WriteLine("si ingresa no, vuelve al menu");
						string opci= Console.ReadLine();
						while(opci.ToLower()=="si"){
							
							Console.WriteLine("Ingrese nombre: ");
							string nombre= Console.ReadLine();
							Console.WriteLine("Ingrese DNI: ");
							int dni=int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese edad: ");
							int edad=int.Parse(Console.ReadLine());
							Socio s= new Socio(nombre,dni,edad);
							clb.AgregarSocio(s);
							
					
							Console.WriteLine("a que deporte lo quiere asociar?");
							string nomb=Console.ReadLine();
							bool existe=clb.existeDeporte(nomb);
							if(existe!=true){
								Console.WriteLine("el deporte no existe, cree el deporte asi se asocia");
								string nombr=Console.ReadLine();
								Deporte d= new Deporte(nombr);
								clb.AgregarDeporte(d);
								Console.WriteLine("El socio fue anotado al deporte "+nombr+" con el dni: "+dni);
							}
							else{
								Console.WriteLine("El socio fue anotado al deporte "+nomb+" con el dni: "+dni); 
								
							
							
						}
						Console.WriteLine("¿Quiere agregar un nuevo socio?");
						Console.WriteLine("si ingresa no, vuelve al menu");
						opci= Console.ReadLine();
						}
						Console.Clear();
						break;
						
					case "g":
						
						Console.WriteLine("Quiere agreegar un nuevo deporte, si o no, si ingresa no, se vuelve al menu");
						string opc=Console.ReadLine();
						while (opc!="no"){
							Console.WriteLine("Ingrese nombre del deporte nuevo");
							string nombre=Console.ReadLine();
							Deporte d=new Deporte(nombre);
							
							clb.AgregarDeporte(d);
							
							Console.WriteLine("Quiere ingresar un deporte nuevo si,si es no, se cierra el programa");
							opc=Console.ReadLine();
							
							
						}
						Console.Clear();
						break;
						
					case "h":
						Console.WriteLine("Quiere eliminar un deporte, si o no, si ingresa no, vuelve al menu");
						string opcio=Console.ReadLine();
						while (opcio!="no"){
							Console.WriteLine("Ingrese el deporte que quiere elimnar");
							string deporteAEliminar=Console.ReadLine();
							
							bool deporteExiste=false;
							foreach(Deporte d in clb.ListaDeportes()){
								
								if(deporteAEliminar==d.NombreDeporte){
									clb.EliminarDeporte(d);
									Console.WriteLine("El deporte se elimino correctamente");
									deporteExiste=true;
									break;
								}
							}
							if(!deporteExiste){
								Console.WriteLine("No existe el deporte con ese nombre");
								
								
							}
							Console.WriteLine("Quiere eliminar un depotre, si o no, si ingresa no, vuelve al menu");
							opcio=Console.ReadLine();
							
						}
						Console.Clear();
						break;
						
					case "f":
						int sigue;
						do{
							Console.WriteLine("      Elija una opcion ");
							Console.WriteLine("      1.Listado por inscripcion");
							Console.WriteLine("      2.Listado por deporte");
							Console.WriteLine("      3.Listado por deporte y categoria");
							Console.WriteLine("      4.Inscriptos con cuota al dia");
							Console.WriteLine("      5.Volver al menu Principal");
							
							Console.WriteLine("Ingrese Opcion deseada");
							sigue=int.Parse(Console.ReadLine());
							
							
							switch(sigue){
									
								case 1:
									foreach(Socio s in clb.ListaSocios()){
										Console.WriteLine("La lista de socios es: ");
										Console.WriteLine("Nombre: "+ s.Nombre+"," + " dni: " + s.Dni);
									}
									
									break;
								case 2:
									foreach(Deporte d in clb.ListaDeportes()){
										Console.WriteLine("La lista de Deportes es: ");
										Console.WriteLine("Nombre es : "+ d.NombreDeporte);
									}
									break;
								case 3:
									foreach(Deporte d in clb.ListaDeportes()){
										Console.WriteLine("La lista de Deportes es: ");
										Console.WriteLine("Nombre es : "+ d.NombreDeporte);
									}
									break;
								case 5:
									break;
							}
						}while (sigue!=5);
						
						menu();
						Console.Clear();
						break;
				}
				
			}while(opcion!="i");
			
		}
	
	static void menu(){
		Console.WriteLine("");
		Console.WriteLine("Bienvenido al Club Olimpico");
		Console.WriteLine("____________________________");
		Console.WriteLine("  Menu");
		Console.WriteLine("  a.Dar de alta a un entrenador");
		Console.WriteLine("  b.Eliminar entrenador");
		Console.WriteLine("  c.Dar de alta a un niño en un deporte");
		Console.WriteLine("  d.Dar de baja a un niño de un deporte");
		Console.WriteLine("  e.Simular el pago de una cuota");
		Console.WriteLine("  f.Submenu de Inscriptos");
		Console.WriteLine("  g.Agregar un deporte");
		Console.WriteLine("  h.Eliminar un deporte");
		Console.WriteLine("  i.Salir");
	}
	}
}









/*	#Console.WriteLine("Ingrese el último mes de pago (en formato dd/MM/yyyy): ");
            				string fecha = Console.ReadLine();
            				//ultimoMesPago = DateTime.Parse(Console.ReadLine());
            			#	try
            			#	{
            			#		ultimoMesPago= DateTime.Parse(Console.ReadLine());
            			#		Console.WriteLine("Fecha ingresada correctamente: " + ultimoMesPago.ToString("dd/MM/yyyy"));
            			#	}
            			#	catch (FormatException)
            			#	{
            			#		Console.WriteLine("Fecha inválida. Ingrese la fecha en un formato reconocible.");
            			#		ultimoMesPago= DateTime.Parse(Console.ReadLine());// Puedes manejar este caso como desees, por ejemplo, solicitando nuevamente la fecha
            			#	}
            				
						 */
						
						
						
						//	clb.AgregarSocio(s);
						//	clb.AgregarSocio(s);
						
						
						
						//op=Console.ReadLine();*/

						
						
						
						/*Console.WriteLine("A que deporte quiere asociarlo?");
							string deporte=Console.ReadLine();
							foreach(Socio s in Socio){*/





