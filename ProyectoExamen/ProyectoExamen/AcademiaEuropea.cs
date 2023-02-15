using ProyectoExamen.Modelos;
/*Agregamos un objeto clase Academia*/
 Academia academiaEuropea = new Academia();



//Creamos una lista de clases para el maestro m1

List <Materia> listMaterias = new List<Materia>();

//Creamos lista de alumnos para asignar a la materia

List <Alumno> listaAlumno= new List<Alumno>();

Alumno a1= new Alumno()
{
    nombreAlumno = "Martin Velasquez"
};
listaAlumno.Add(a1);

a1 = new Alumno()
{
    nombreAlumno = "Carla Maria"
};

listaAlumno.Add(a1);

a1 = new Alumno()
{
    nombreAlumno = "Carla Maria"
};

listaAlumno.Add(a1);

a1 = new Alumno()
{
    nombreAlumno = "Juan Perez"
};

listaAlumno.Add(a1);




ClaseFindeSemana materia1 = new ClaseFindeSemana() { 
    listaAlumnos = listaAlumno,
    faseClase = 4,
    semanaClase = 7,

};

listMaterias.Add(materia1);


//Creamos un objeto cuenta para asignar a maestros

Cuenta c1 = new Cuenta()
{
    nombreUsuario = "usuario1",
    contraUsuario = "123"
};


//Creamos un primer maestro 

Maestro m1 = new Maestro()
{
    nombreMaestro = "Maria Perez",
    totalHorasTrabajadas= 120,
    cuentaMaestro= c1,
    listaClases = listMaterias

};

m1.calcSalario();



academiaEuropea.agregarMaestro(m1);

Maestro maestroActual = new Maestro();

maestroActual = academiaEuropea.inciarSesionMaestro("kevenbardales", "12345");

verificarLogin();

maestroActual = academiaEuropea.inciarSesionMaestro("usuario1", "123");

verificarLogin();





void verificarLogin()
{
    if (maestroActual != null)
    {
        Console.WriteLine("Bienvenido" + maestroActual.nombreMaestro);
    }
    else
    {
        Console.WriteLine("Usuario Incorrecto intente de nuevo");
    };
}


























