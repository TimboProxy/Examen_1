
using Examen_1.Dados;
using Examen_1.Jugador;
using Examen_1.Historial;

namespace Examen_1.Menu
{
    class Menu
    {
        private List<NumeroMenos> _NumMenos;
        private List<NumeroMas> _NumMas;
        private List<Pares> _NumPares;
        private List<Extremos> _NumExtremos;
        private List<Impares> _NumImpares;
        private List<Medios> _NumMedios;

        public Menu()
        {
            _NumMenos = new List<NumeroMenos>();
            _NumMas = new List<NumeroMas>();
            _NumPares = new List<Pares>();
            _NumExtremos = new List<Extremos>();
            _NumMedios = new List<Medios>();
            _NumImpares = new List<Impares>();
        }

        int Pasta = 300;
        string PastaSobreLaMesa = "";
        


        public void MostrarMenu()
        {
            int eleccion = 0;
            do
            {
                Console.WriteLine("******Bienvenido al juego o una wea asi, las opciones disponibles son las siguientes******"+"\n");
                Console.WriteLine("---Dinero actual: " + Pasta + "---"+"\n");
                Console.WriteLine("1.- Apostar a un numero especifico");
                Console.WriteLine("2.- Apostar a que es un numero extremo");
                Console.WriteLine("3.- Apostar a que es un numero medio");
                Console.WriteLine("4.- Apostar si el numero es par");
                Console.WriteLine("5.- Apostar si el numero es impar");
                Console.WriteLine("6.- Huir como cobarde" + "\n");
                Console.WriteLine("7.- Historial" + "\n");
                Console.WriteLine("Escribe el numero que corresponda a tu decisión");
            } while (!validarMenu(7, ref eleccion));
            switch (eleccion)
            {
                case 1:
                    string numelegido;
                    //Entrando al submenu1
                    Console.WriteLine("Apostando a un numero en especifico" + "\n");
                    Console.WriteLine("Ingresa la cantidad de dinero que quieres apostar (recuerda: debe ser multiplo de 10)");

                    PastaSobreLaMesa = Console.ReadLine();
                    int PastaPulida = int.Parse(PastaSobreLaMesa);

                    if (PastaPulida % 10 != 0)
                    {
                        Console.WriteLine("¿Con que intentando engañar al sistema, eh? a ver si en el bote haces lo mismo.");
                        Console.ReadLine();
                        Console.Clear();
                        MostrarMenu();
                    }
                    do
                    {
                        Console.WriteLine("Elige un numero del 2 al 12");
                        numelegido = Console.ReadLine();
                        //Verificando entradas
                        if (numelegido == null || numelegido == "" || int.Parse(numelegido) < 2 || int.Parse(numelegido) > 12)
                        {
                            Console.Write("Entrada invalida. ");
                            //Hacer algo aqui para que se regrese
                        }
                    } while (numelegido == null || numelegido == "");

                    //Cuando las entradas son correctas
                    int numentero = int.Parse(numelegido);
                    Console.WriteLine("Tu eleccion fue: " + numelegido);
                    if (numentero == Random())
                    {
                        Console.WriteLine("Felicidades!!!!!");
                        Pasta = Pasta + (PastaPulida * 10);
                    }
                    else
                    {
                        Console.WriteLine("Perdiste...");
                        Pasta = Pasta - PastaPulida;
                        Console.WriteLine("Has perdido " + PastaPulida + " pavos");
                    }

                    //Añandiendo al historial
                    NumeroMas nuevaUnidad1 = new NumeroMas(numelegido);
                    _NumMas.Add(nuevaUnidad1);
                    Console.WriteLine("Ronda terminada, presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;


                case 2:
                    string numelegido2;
                    //Entrando al submenu2
                    Console.WriteLine("*****Apostando a un numero extremo*****" + "\n");
                    Console.WriteLine("Ingresa la cantidad de dinero que quieres apostar (recuerda: debe ser multiplo de 10)");
                    PastaSobreLaMesa = Console.ReadLine();
                    int PastaPulida2 = int.Parse(PastaSobreLaMesa);
                    string resultado2 = "";

                    if (PastaPulida2 % 10 != 0)
                    {
                        Console.WriteLine("¿Con que intentando engañar al sistema, eh? a ver si en el bote haces lo mismo.");
                        Console.ReadLine();
                        Console.Clear();
                        MostrarMenu();
                    }

                    Console.WriteLine("Los numeros ganadores son: 2,3,4,10,11 y 12");
                    //Verificando igualdad
                    var numero2 = Random();
                    if (numero2 == 2 || (numero2 == 3 || numero2 == 4 || numero2 == 10 || numero2 == 11 || numero2 == 12))
                    {
                        Console.WriteLine("Felicidades!!!!!");
                        Pasta = Pasta + (PastaPulida2 * 8);
                        resultado2 = "Ganada";
                    }
                    else
                    {
                        Console.WriteLine("Perdiste...");
                        Pasta = Pasta - PastaPulida2;
                        Console.WriteLine("Has perdido " + PastaPulida2 + " pavos");
                        resultado2 = "Perdida";
                    }
                    //Añandiendo al historial
                    Extremos nuevaUnidad2 = new Extremos(resultado2);
                    _NumExtremos.Add(nuevaUnidad2);

                    Console.WriteLine("Ronda terminada, presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;

                case 3:
                    string numelegido3;
                    //Entrando al submenu3
                    Console.WriteLine("*****Apostando a un numero medio*****" + "\n");
                    Console.WriteLine("Ingresa la cantidad de dinero que quieres apostar (recuerda: debe ser multiplo de 10)");
                    PastaSobreLaMesa = Console.ReadLine();
                    int PastaPulida3 = int.Parse(PastaSobreLaMesa);
                    string resultado3 = "";

                    if (PastaPulida3 % 10 != 0)
                    {
                        Console.WriteLine("¿Con que intentando engañar al sistema, eh? a ver si en el bote haces lo mismo.");
                        Console.ReadLine();
                        Console.Clear();
                        MostrarMenu();
                    }

                    Console.WriteLine("Los numeros ganadores son: 5,6,7,8 y 9");
                    //Verificando igualdad
                    var numero3 = Random();
                    if (numero3 == 5 || (numero3 == 6 || numero3 == 7 || numero3 == 8 || numero3 == 9))
                    {
                        Console.WriteLine("Felicidades!!!!!");
                        Pasta = Pasta + (PastaPulida3 * 4);
                        resultado3 = "Ganada";
                    }
                    else
                    {
                        Console.WriteLine("Perdiste...");
                        Pasta = Pasta - PastaPulida3;
                        Console.WriteLine("Has perdido " + PastaPulida3 + " pavos");
                        resultado3 = "Perdida";
                    }
                    //Añandiendo al historial
                    Medios nuevaUnidad3 = new Medios(resultado3);
                    _NumMedios.Add(nuevaUnidad3);

                    Console.WriteLine("Ronda terminada, presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;
                case 4:
                    //Entrando al submenu4
                    Console.WriteLine("*****Apostando a un numero par*****" + "\n");
                    Console.WriteLine("Ingresa la cantidad de dinero que quieres apostar (recuerda: debe ser multiplo de 10)");
                    PastaSobreLaMesa = Console.ReadLine();
                    int PastaPulida4 = int.Parse(PastaSobreLaMesa);
                    string resultado4 = "";

                    if (PastaPulida4 % 10 != 0)
                    {
                        Console.WriteLine("¿Con que intentando engañar al sistema, eh? a ver si en el bote haces lo mismo.");
                        Console.ReadLine();
                        Console.Clear();
                        MostrarMenu();
                    }

                    Console.WriteLine("Los numeros ganadores son: 2,4,6,8,10 y 12");
                    //Verificando igualdad
                    var numero4 = Random();
                    int resto1 = numero4 % 2;
                    if (resto1 == 0)
                    {
                        Console.WriteLine("Felicidades!!!!!");
                        Pasta = Pasta + (PastaPulida4 * 2);
                        resultado4 = "Ganada";
                    }
                    else
                    {
                        Console.WriteLine("Perdiste...");
                        Pasta = Pasta - PastaPulida4;
                        Console.WriteLine("Has perdido " + PastaPulida4 + " pavos");
                        resultado4 = "Perdida";
                    }
                    //Añandiendo al historial
                    Pares nuevaUnidad4 = new Pares(resultado4);
                    _NumPares.Add(nuevaUnidad4);

                    Console.WriteLine("Ronda terminada, presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;
                case 5:
                    //Entrando al submenu5
                    Console.WriteLine("*****Apostando a un numero impar*****" + "\n");
                    Console.WriteLine("Ingresa la cantidad de dinero que quieres apostar (recuerda: debe ser multiplo de 10)");
                    PastaSobreLaMesa = Console.ReadLine();
                    int PastaPulida5 = int.Parse(PastaSobreLaMesa);
                    string resultado5 = "";

                    if (PastaPulida5 % 10 != 0)
                    {
                        Console.WriteLine("¿Con que intentando engañar al sistema, eh? a ver si en el bote haces lo mismo.");
                        Console.ReadLine();
                        Console.Clear();
                        MostrarMenu();
                    }

                    Console.WriteLine("Los numeros ganadores son: 1,3,5,7,9 y 11");
                    //Verificando igualdad
                    var numero5 = Random();
                    int resto2 = numero5 % 2;
                    if (resto2 != 0)
                    {
                        Console.WriteLine("Felicidades!!!!!");
                        Pasta = Pasta + (PastaPulida5 * 2);
                        resultado5 = "ganaste";
                    }
                    else
                    {
                        Console.WriteLine("Perdiste...");
                        Pasta = Pasta - PastaPulida5;
                        Console.WriteLine("Has perdido " + PastaPulida5 + " pavos");
                        resultado5 = "perdiste";
                    }
                    //Añandiendo al historial
                    Impares nuevaUnidad5 = new Impares(resultado5);
                    _NumImpares.Add(nuevaUnidad5);

                    Console.WriteLine("Ronda terminada, presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;
                case 6:
                    if (Pasta > 300)
                    {
                        Console.WriteLine("Ganaste un total de: " + ( Pasta - 300 ));
                    }
                    if (Pasta < 300)
                    {
                        Console.WriteLine("Perdiste un total de: " + ( 300 - Pasta ));

                    }
                    else
                    {
                        Console.WriteLine("Ni jugaste master, que pues?. No perdiste nada.");
                    }
                    mostrarHistorial();
                    Console.WriteLine("-----Saquese pues-----");
                    break;
                case 7:
                    mostrarHistorial();
                    Console.WriteLine("Presiona Enter para regresar al menú...");
                    Console.ReadLine();
                    Console.Clear();
                    checador();
                    MostrarMenu();
                    break;
            }
           
        }

        private bool validarMenu(int opciones, ref int eleccion)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    eleccion = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("*****Opción Invalida*****");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("*****El valor ingresado no es válido, debes ingresar un numero*****");
                return false;
            }
        }

        public int Random()
        {
            int Dado1 = new Random().Next(1, 7);
            int Dado2 = new Random().Next(1, 7);
            int total = Dado1 + Dado2;
            Console.WriteLine("Puntos del Dado 1: " + Dado1);
            Console.WriteLine("Puntos del Dado 2: " + Dado2);
            Console.WriteLine("Puntos totales: " + total);
            return total;
        }

        public void checador()
        {
            if (Pasta == 0)
            {
                Console.WriteLine("¿Con que apostando sin dinero eh? a ver si en el bote haces lo mismo." + "\n");
                Console.WriteLine("Final Malo: Seguiste apostando sin dinero y la chota vino por ti");
                Environment.Exit(0);
            }
        }

        private void mostrarExtremos()
        {
            Console.WriteLine("******Resultados extremos:");
            foreach (Extremos item in _NumExtremos)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarMedios()
        {
            Console.WriteLine("*****Resultados medios:");
            foreach (Medios item in _NumMedios)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarPares()
        {
            Console.WriteLine("****Resultados Pares:");
            foreach (Pares item in _NumPares)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarImpares()
        {
            Console.WriteLine("***Resultados extremos:");
            foreach (Impares item in _NumImpares)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarNumeroMas()
        {
            Console.WriteLine("**Número que mas veces se ha tirado:");
            foreach (NumeroMas item in _NumMas)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarNumeroMenos()
        {
            Console.WriteLine("*Número que menos veces se ha tirado:");
            foreach (NumeroMenos item in _NumMenos)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void mostrarHistorial()
        {
            Console.WriteLine("Balance: " + (Pasta-300) );
            mostrarExtremos();
            mostrarMedios();
            mostrarPares();
            mostrarImpares();
            mostrarNumeroMenos();
        }
    }
}
