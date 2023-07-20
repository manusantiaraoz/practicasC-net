using System.Collections;

internal class Program
{
    static ArrayList milista = new ArrayList();
    static Stack mipila = new Stack();  //estrucutra LIFO( last in first out)
    static Queue cola = new Queue();   //estructura FIFO(first in first out)

    private static void Main(string[] args)
    {
        int menu;
        String dato;



        do
        {

            Console.WriteLine("ingresa que te gustaria hacer: \n 1-agregar dato \n 2-ver datos \n 3-eliminar dato \n 4-buescar dato  \n 0 para salir ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 0: break;

                case 1:
                    Console.WriteLine("ingresa el dato ");
                    dato = Console.ReadLine();
                    agrega(milista, dato);
                    Console.Clear();
                    Console.WriteLine("agregado a lista\n");
                    agregarPila(mipila, dato);
                    Console.WriteLine("agregado a pila\n");
                    agregarCola(cola, dato);
                    Console.WriteLine("agreado a cola \n");

                    break;

                case 2:
                    Console.WriteLine("mostrar datos: \n");
                    Console.WriteLine("LISTA");
                    mostrar(milista);
                    Console.WriteLine("PILA");
                    mostrarPila(mipila);
                    Console.WriteLine("COLA");
                    mostrarCola(cola);
                    break;

                case 3:
                    Console.WriteLine(" \n ingresa el dato a eliminar ");
                    dato = Console.ReadLine();
                    eliminar(milista, dato);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n eliminar dato de pila \n");
                    sacarPila(mipila);
                    Console.WriteLine("\n eliminar dato de cola \n");
                    sacarCola(cola);
                    break;
                case 4:
                    Console.WriteLine("ingrese dato a buscar ");
                    dato= Console.ReadLine();
                    buscarLista(milista, dato);
                    Console.WriteLine("\n");
                    buscarPila(mipila,dato);
                    Console.WriteLine("\n");
                    buscarCola(cola,dato);
                    Console.WriteLine("\n");
                    break;
                default: Console.WriteLine("opcion invalida");
                    break;
            }
        } while (menu != 0);

        Console.WriteLine("gracias por usar el programa");
    }



    //DATOS CON LISTA
    public static void agrega(ArrayList n, String dato)
    {
        n.Add(dato);
    }
    public static void mostrar(IEnumerable myList)
    {

        foreach (Object obj in myList)
            Console.Write("   {0} \n", obj);
        Console.WriteLine();
    }
    public static void eliminar(ArrayList n, String dato)
    {

        n.Remove(dato);

        Console.WriteLine(" \n quedan " + n.Count);
        Console.WriteLine("datos en lista: ");
        mostrar(n);
    }


    //DATOS CON PILAS

    public static void agregarPila(Stack x, string dato)
    {

        x.Push(dato);

    }
    public static void mostrarPila(IEnumerable x)
    {

        foreach (Object obj in x)
            Console.Write("   {0} \n", obj);
        Console.WriteLine();
    }

    public static void sacarPila(Stack x)
    {
        int cuenta;
        cuenta = x.Count;
        Console.WriteLine("\n antes de eliminar existen {0} elementos en pila", cuenta);
        x.Pop();
        cuenta = x.Count;
        Console.WriteLine("\n quedan: {0} en pila", cuenta);
        Console.WriteLine("datos en pilas: ");
        mostrar(x);

    }

    // DATOS CON COLA

    public static void agregarCola(Queue x, string dato)
    {
        x.Enqueue(dato);
    }

    public static void mostrarCola(IEnumerable x)
    {
        foreach (Object obj in x)
            Console.Write("   {0} \n", obj);
        Console.WriteLine();
    }
    public static void sacarCola(Queue x)
    {
        int cuenta;
        cuenta = x.Count;
        Console.WriteLine("\n antes de eliminar existen {0} elementos en cola", cuenta);
        x.Dequeue();
        cuenta = x.Count;
        Console.WriteLine("\n quedan: {0} en cola", cuenta);
        Console.WriteLine("datos actuales en colas: ");
        mostrar(x);

    }

    //busqueda de datos

    //lista

    public static void buscarLista(ArrayList x, string dato)
    {
        bool existe = x.Contains(dato);

        if (existe)
        { Console.WriteLine("el dato {0} si existe en lista", dato); }
        else { Console.WriteLine("el dato {0} no existe en lista", dato); }

    }

    //pila
    public static void buscarPila(Stack x, string dato)
    {
        bool existe = x.Contains(dato);
        if (existe)
        { Console.WriteLine("el dato {0} si existe en pila", dato); }
        else { Console.WriteLine("el dato {0} no existe en pila", dato); }
    }

    //cola 
    public static void buscarCola(Queue x, string dato)
    {
        bool existe = x.Contains(dato);
        if (existe)
        { Console.WriteLine("el dato {0} si existe en cola", dato); }
        else { Console.WriteLine("el dato {0} no existe en cola", dato); }
    }

}
