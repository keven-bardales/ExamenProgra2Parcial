using ProyectoExamen.Modelos;
/*Agregamos un objeto clase Academia*/


 Academia academiaEuropea = new Academia();



//Creamos una lista de clases para el maestro m1

List <Materia> listMaterias = new List<Materia>();

//Creamos lista de alumnos para asignar a la materia

List <Alumno> listaAlumno= new List<Alumno>();

AlumnoFinde a1= new AlumnoFinde()
{
    nombreAlumno = "Martin Velasquez",
};
a1.Notas = new double[] { 7.1, 7.3, 7.5, 8.9 };
a1.calcPromedio();
listaAlumno.Add(a1);

a1 = new AlumnoFinde()
{
    nombreAlumno = "Carla Maria"
};
a1.Notas = new double[] { 6.5, 7.0, 8.0, 7.2 };
a1.calcPromedio();
listaAlumno.Add(a1);

a1 = new AlumnoFinde()
{
    nombreAlumno = "Susan Maria"
};
a1.Notas = new double[] { 7.8, 6.9, 7.5, 8.1 };
a1.calcPromedio();
listaAlumno.Add(a1);

a1 = new AlumnoFinde()
{
    nombreAlumno = "Juan Perez"
};
a1.Notas = new double[] { 8.0, 8.0, 7.5, 7.5 };
a1.calcPromedio();
listaAlumno.Add(a1);




ClaseFindeSemana materia1 = new ClaseFindeSemana() { 
    listaAlumnos = listaAlumno,
    faseClase = 4,
    semanaClase = 7,

};

//Usamos la interfaz para calcular la cantidad de horas de Clase
materia1.calcHorasClase();

listMaterias.Add(materia1);

//Creamos una nueva lista de alumnos para la Materia 2

listaAlumno = new List<Alumno>();

AlumnoDiasDeSemana a2 = new AlumnoDiasDeSemana()
{
    nombreAlumno = "Ana Gomez"
};

a2.SetNotas(new double[,] {{ 7.0, 8.0, 6.0, 5.0 },
                               { 9.0, 7.0, 8.0, 6.0 },
                               { 8.0, 9.0, 7.0, 8.0 },
                               { 6.0, 8.0, 9.0, 7.0 },
                               { 7.0, 6.0, 8.0, 9.0 }});

// 

a2.calcPromedio();
listaAlumno.Add(a2);

a2 = new AlumnoDiasDeSemana()
{
    nombreAlumno = "Juan Carlos"
};
a2.SetNotas(new double[,] {{ 7.0, 8.0, 6.0, 5.0 },
                           { 9.0, 7.0, 8.0, 6.0 },
                           { 8.0, 9.0, 7.0, 8.0 },
                           { 6.0, 8.0, 9.0, 7.0 },
                           { 7.0, 6.0, 8.0, 9.0 }});
a2.calcPromedio();
listaAlumno.Add(a2);

a2 = new AlumnoDiasDeSemana()
{
    nombreAlumno = "Maria Fernandez"
};
a2.SetNotas(new double[,] {{ 8.0, 7.0, 6.0, 5.0 },
                           { 7.0, 6.0, 5.0, 4.0 },
                           { 6.0, 5.0, 4.0, 3.0 },
                           { 5.0, 4.0, 3.0, 2.0 },
                           { 4.0, 3.0, 2.0, 1.0 }});
a2.calcPromedio();
listaAlumno.Add(a2);


listaAlumno.Add(a2);

a2 = new AlumnoDiasDeSemana()
{
    nombreAlumno = "Carlos Sanchez"
};

a2.SetNotas(new double[,] {{ 6.0, 7.0, 8.0, 9.0 },
                           { 5.0, 6.0, 7.0, 8.0 },
                           { 4.0, 5.0, 6.0, 7.0 },
                           { 3.0, 4.0, 5.0, 6.0 },
                           { 2.0, 3.0, 4.0, 5.0 }});
a2.calcPromedio();
listaAlumno.Add(a2);

//Se crea la clase de dia de semana

ClaseDiaSemana materia2 = new ClaseDiaSemana()
{
    listaAlumnos = listaAlumno,
    faseClase = 2,
    semanaClase = 5,
};

materia2.calcHorasClase();


listMaterias.Add(materia2);



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



m1.listaClases.ElementAt(0).maestroasignado = m1;
m1.listaClases.ElementAt(1).maestroasignado = m1;




academiaEuropea.agregarMaestro(m1);

//Iniciamos sesion retornamos la posicion del maeastro actual

int poscionMaestroActual = academiaEuropea.loginGetMaestroActual("usuario1", "123");

verifyLogin2();

//Imprimimos en pantalla la informacion del maestroActual

Console.WriteLine(academiaEuropea.maestroList.ElementAt(poscionMaestroActual).ToString());

//Mostrar alumnos Maestro Actual

Materia materiaAmostrar = new Materia();

materiaAmostrar = academiaEuropea.maestroList.ElementAt(poscionMaestroActual).listaClases.ElementAt(0);


Console.WriteLine(academiaEuropea.maestroList.ElementAt(poscionMaestroActual).listarAlumnosClase(materiaAmostrar));




materiaAmostrar = new Materia();

materiaAmostrar = academiaEuropea.maestroList.ElementAt(poscionMaestroActual).listaClases.ElementAt(1);

Console.WriteLine(academiaEuropea.maestroList.ElementAt(poscionMaestroActual).listarAlumnosClase(materiaAmostrar));






//Funcion para verificar el login

void verifyLogin2()
{
    if (poscionMaestroActual != -1)
    {
        Console.WriteLine("Bienvenido " + academiaEuropea.maestroList.ElementAt(poscionMaestroActual).nombreMaestro);
    }
    else
    {
        Console.WriteLine("Usuario Incorrecto intente de nuevo");
    };
}




























