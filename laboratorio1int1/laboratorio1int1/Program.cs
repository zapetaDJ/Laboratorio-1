using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace laboratorio1int1
{
    class Program
    {
        static StreamReader leer;
        static StreamWriter escribir;
        private static string ruta;


        public static object Public { get; private set; }

        static void Main(string[] args)
        {
            int U;
            Console.WriteLine("¿Que puesto ejerces? \n1.Administrador \n2.Trabajador");
            U = int.Parse(Console.ReadLine());

            if (U == 1)
            {
                Console.WriteLine("Ingrese su usuario:");
                string Usuario = Console.ReadLine();
                Console.WriteLine("contraseña de Administrador:");
                string clave = Console.ReadLine();
                string RutaArchivo = "C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\laboratorio1int1\\bin\\Debug\\admins\\" + Usuario + ".txt";
                // StringReader Archivo = new StringReader(RutaArchivo);
                string UsuarioAR = "";
                string ClaveAR = "";
                string TipoUser = "";
                Boolean usuarioValido = false;
                if (File.Exists(RutaArchivo))
                {
                    ClaveAR = File.ReadAllText(RutaArchivo);
                    if (ClaveAR == clave)
                    {
                        Console.WriteLine("Ingreso Exitoso");
                        MenuAD();
                    }
                    else
                    {
                        Console.WriteLine("Usuario NO existe");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario NO existe");
                }





                int MenuAD()
                {
                    int ap = 0;
                    do
                    {
                            Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\tADMINISTRADOR");
                            Console.WriteLine("1.VER INVENTARIO\n2. LISTADO DE USUARIOS\n3. REGISTRO DE FACTURAS\n4. CREAR NUEVO USUARIO\n5. Salir");
                            Console.Write("ELija opción: ");
                            ap = int.Parse(Console.ReadLine());
                        if (ap == 1)
                        {
                            Console.Clear();
                            string Linea = File.ReadAllText("C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\laboratorio1int1\\bin\\Debug\\Inventario.txt");
                            Console.WriteLine(Linea);
                            Console.ReadKey();
                        }
                        if (ap == 2)
                        {
                            DirectoryInfo di = new DirectoryInfo(@"C:\Users\FamZapeta\Documents\diego joel\5to baco\Laboratorio\laboratorio1int1\laboratorio1int1\bin\Debug\admins");
                            DirectoryInfo di1 = new DirectoryInfo(@"C:\Users\FamZapeta\Documents\diego joel\5to baco\Laboratorio\laboratorio1int1\trabajadores");
                            //Console.WriteLine("No search pattern returns:");
                            Console.WriteLine("Usuarios Administradores");

                            foreach (var fi in di.GetFiles("*.txt"))
                            {
                                Console.WriteLine(fi.Name);
                            }
                            Console.WriteLine("Usuarios Trabajadores");
                            foreach (var fi in di1.GetFiles("*.txt"))
                            {
                                Console.WriteLine(fi.Name);
                            }
                            Console.ReadKey();
                        }
                        if (ap == 3)
                        {
                            Console.Clear();
                            string Linea = File.ReadAllText("C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\laboratorio1int1\\bin\\Debug\\Factura.txt");
                            Console.WriteLine(Linea);
                            Console.ReadKey();


                        }
                        if (ap == 4)
                        {
                            int O;
                            Console.WriteLine("¿Que tipo se usuario desea crear? \n1.Administrador \n2.Trabajador");
                            O = int.Parse(Console.ReadLine());
                            if ( O == 1)
                            {
                                Console.WriteLine("Ingrese Nombre del Nuevo usuario:");
                                string USUARIO = Console.ReadLine();
                                Console.WriteLine("Ingrese contraseña de usuario:");
                                string CLAVE = Console.ReadLine();
                                string RUTAAchivo = "C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\laboratorio1int1\\bin\\Debug\\" + USUARIO + ".txt";
                                // StringReader Archivo = new StringReader(RutaArchivo);
                                string UsuarioARC = "";
                                string ClaveARC = "";
                                string TipoUserNew = "";
                                Boolean UsuarioValido = false;
                                if (File.Exists(RUTAAchivo))
                                {
                                    Console.WriteLine("Usuario ya existe");
                                }
                                else
                                {

                                    CREARNUEVOUSUARIO(RUTAAchivo, CLAVE);
                                    Console.WriteLine("Usuario Agregado existosamente");

                                }
                            }

                            if (O == 2)
                            {
                                Console.WriteLine("Ingrese Nombre del Nuevo usuario:");
                                string USUARIO = Console.ReadLine();
                                Console.WriteLine("Ingrese contraseña de usuario:");
                                string CLAVE = Console.ReadLine();
                                string RUTAARCHIVO = "C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\trabajadores\\" + USUARIO + ".txt";
                                // StringReader Archivo = new StringReader(RutaArchivo);
                                string UsuarioARC = "";
                                string ClaveARC = "";
                                string TipoUserNew = "";
                                Boolean UsuarioValido = false;
                                if (File.Exists(RUTAARCHIVO))
                                {
                                    Console.WriteLine("Usuario ya existe");
                                }
                                else
                                {

                                    CREARNUEVOUSUARIO(RUTAARCHIVO, CLAVE);
                                    Console.WriteLine("Usuario Agregado existosamente");

                                }
                            }

                        }
                        Console.Clear();
                    } while (ap != 5);

                    return ap;
                }

                void CREARNUEVOUSUARIO(string usuario, string Contraseña)
                {
                    File.WriteAllText(usuario, Contraseña);
                    
                }



            }

            if (U == 2)
            {
                Console.WriteLine("Ingrese su usuario:");
                string Usuario = Console.ReadLine();
                Console.WriteLine("contraseña de Trabajador:");
                string clave = Console.ReadLine();
                string RutaArchivoTRA = "C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\trabajadores\\" + Usuario + ".txt";
                // StringReader Archivo = new StringReader(RutaArchivo);
                string UsuarioTRA = "";
                string ClaveTRA = "";
                string TipoUser2 = "";
                Boolean usuarioValido2 = false;
                if (File.Exists(RutaArchivoTRA))
                {
                    ClaveTRA = File.ReadAllText(RutaArchivoTRA);
                    if (ClaveTRA == clave)
                    {
                        Console.WriteLine("Ingreso Exitoso");
                        MenuTRA();
                    }
                    else
                    {
                        Console.WriteLine("Usuario NO existe");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario NO existe");
                }

                int MenuTRA()
                {
                    int op = 0;
                    do
                    {
                            Console.Clear();
                            Console.WriteLine("\t\tTRABAJADOR");
                            Console.WriteLine("1.CARGAR PRODUCTO\n2. FACTURAR PRODUCTO\n3. Salir");
                            Console.Write("ELija opción: ");
                            op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            CARGARPRODUCTO();

                        }
                        if (op == 2)
                        {
                            FACTURARPRODUCTO();
                        }
                        Console.Clear();
                    } while (op != 3);

                    return op;
                }

                void CARGARPRODUCTO()
                {
                    string nombre;
                    string   Cantidad;
                    string   Precio;

                    Console.WriteLine("Ingrese nombre del producto: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad: ");
                    Cantidad = Console.ReadLine();
                    Console.WriteLine("Ingrese precio del producto: ");
                    Precio = Console.ReadLine();

                    escribir = File.AppendText("C:\\Users\\FamZapeta\\Documents\\diego joel\\5to baco\\Laboratorio\\laboratorio1int1\\laboratorio1int1\\bin\\Debug\\Inventario.txt");
                    escribir.WriteLine("Producto: " + nombre);
                    escribir.WriteLine("unidades: " + Cantidad);
                    escribir.WriteLine("Costo: " + Precio);
                    escribir.Close();
                    Console.WriteLine("Producto guardado...");
                    Console.ReadKey();


                }

                void FACTURARPRODUCTO()
                {
                    string rutaArhivo = @"C:\Users\FamZapeta\Documents\diego joel\5to baco\Laboratorio\laboratorio1int1\laboratorio1int1\bin\Debug\";
                    Console.WriteLine("Ingrese Nit: ");
                    string NIT = Console.ReadLine();
                    Console.WriteLine("Ingrese Nombre:");
                    string NOMBRE = Console.ReadLine();
                    string rutaArhivo1 = rutaArhivo + "Correlativo.txt";
                    string Correlativo = File.ReadAllText(rutaArhivo1);
                    



                    DateTime Fecha = DateTime.Today;

                    int IDcorrelativ = int.Parse(Correlativo);
                    int valor;
                    valor = 1;
                    do
                    {
                        Console.WriteLine("Ingrese el producto a comprar: ");
                        string NOMPRODUC = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad a comprar: ");
                        int CANTIDAD = int.Parse(Console.ReadLine());

                        if (valor == 1)
                        {
                            rutaArhivo1 = rutaArhivo + "Inventario.txt";
                            string rutaArchivo2 = rutaArhivo + "InventarioTemp.txt";
                            StreamWriter Inven2 = new StreamWriter(rutaArchivo2);
                            StreamReader Inven = new StreamReader(rutaArhivo1 );
                            string linea = "";
                            linea = Inven.ReadLine();
                            while (linea != null)
                            {
                                Inven2.WriteLine(linea);
                                if (linea.Contains(NOMPRODUC))
                                {
                                    linea = Inven.ReadLine();
                                    string UndsInv = linea.Substring(10);
                                    //Console.WriteLine(UndsInv);
                                    int UndsNueva = int.Parse(UndsInv);
                                    UndsNueva = UndsNueva - CANTIDAD;
                                    Inven2.WriteLine("unidades :" + UndsNueva);

                                    linea = Inven.ReadLine();
                                    Inven2.WriteLine(linea);
                                    string PrecioInv = linea.Substring(7);
                                  //  Console.WriteLine(PrecioInv);
                                    int PrecioNueva = int.Parse(PrecioInv);

                                    linea = null;
      
                                }
                                linea = Inven.ReadLine();
                            }
                            Inven.Close();
                            Inven2.Close();
                            File.Delete(rutaArhivo1);
                            File.Copy(rutaArchivo2, rutaArhivo1);
                           
                        }
                        Console.WriteLine("1.Facturar otro producto\n2. Finalizar Facturación");
                        Console.Write("ELija opción: ");
                        valor = int.Parse(Console.ReadLine());


                    }
                    while (valor !=2);
                    rutaArhivo1 = rutaArhivo + "Factura.txt";
                    escribir = File.AppendText(rutaArhivo1 );
                    escribir.WriteLine("Factura :"+Correlativo);
                    escribir.WriteLine("Nit: "+NIT );
                    escribir.WriteLine("Nombre: "+NOMBRE);
                    //escribir.WriteLine("Nombre del producto comprado: "+ NOMPRODUC);
                    //escribir.WriteLine("Cantidad de producto:"+ CANTIDAD);
                    escribir.WriteLine("*************************************************************************");
                    escribir.Close();
                }

                Console.ReadKey();
            }
        }

        private static void FACTURARPRODUCTO()
        {
            throw new NotImplementedException();
        }

        private static void CARGARPRODUCTO()
        {
            throw new NotImplementedException();
        }
    }
}
