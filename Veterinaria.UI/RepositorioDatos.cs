using Veterinaria.Entidades;

namespace Veterinaria.UI;

public static class RepositorioDatos
{
    public static List<Cliente> Clientes { get; set; } = [];
    public static List<Mascota> Mascotas { get; set; } = [];
    public static List<Cita> Citas { get; set; } = [];
    public static List<Consulta> Consultas { get; set; } = [];

    static RepositorioDatos()
    {
        InicializarDatosDemo();
    }

    private static void InicializarDatosDemo()
    {
        // Clientes iniciales
        Clientes.Add(new Cliente("0912345678", "Carlos", "Mendoza", "0991234567", "Av. Principal 123"));
        Clientes.Add(new Cliente("0987654321", "María", "Paredes", "0987654321", "Calle Central 456"));
        Clientes.Add(new Cliente("0955566778", "Andrés", "Gómez", "0955566778", "Urb. Las Acacias"));
        Clientes.Add(new Cliente("0944433221", "Laura", "Sánchez", "0944433221", "Cdla. Los Ceibos Mz 14"));
        Clientes.Add(new Cliente("0933322110", "Roberto", "Silva", "0933322110", "Calle 10 de Agosto 820"));
        Clientes.Add(new Cliente("0922211009", "Patricia", "Torres", "0922211009", "Av. Víctor Emilio Estrada 504"));

        // Mascotas iniciales
        Mascotas.Add(new Mascota(1, "Max", "Perro", "Golden Retriever", new DateTime(2021, 5, 12), "0912345678", "Macho"));
        Mascotas.Add(new Mascota(2, "Luna", "Gato", "Siamés", new DateTime(2022, 8, 20), "0912345678", "Hembra"));
        Mascotas.Add(new Mascota(3, "Rocky", "Perro", "Bulldog Francés", new DateTime(2023, 1, 15), "0987654321", "Macho"));
        Mascotas.Add(new Mascota(4, "Bella", "Gato", "Angora", new DateTime(2022, 3, 10), "0987654321", "Hembra"));
        Mascotas.Add(new Mascota(5, "Mimi", "Gato", "Persa", new DateTime(2020, 11, 5), "0955566778", "Hembra"));
        Mascotas.Add(new Mascota(6, "Thor", "Perro", "Pastor Alemán", new DateTime(2021, 9, 18), "0944433221", "Macho"));
        Mascotas.Add(new Mascota(7, "Coco", "Loro", "Amazonas", new DateTime(2019, 7, 25), "0933322110", "Macho"));
        Mascotas.Add(new Mascota(8, "Mia", "Gato", "Común Europeo", new DateTime(2023, 4, 1), "0922211009", "Hembra"));

        // Citas iniciales (Pendientes y Atendidas)
        Citas.Add(new Cita(1, DateTime.Now.AddHours(1), "Vacunación anual y chequeo general", "Pendiente", 1, 1));
        Citas.Add(new Cita(2, DateTime.Now.AddHours(2), "Control dermatológico y limpieza", "Pendiente", 2, 1));
        Citas.Add(new Cita(3, DateTime.Now.AddHours(3), "Revisión dental y limpieza de oídos", "Pendiente", 3, 1));
        Citas.Add(new Cita(4, DateTime.Now.AddHours(4), "Chequeo general post-adopción", "Pendiente", 6, 1));
        Citas.Add(new Cita(5, DateTime.Now.AddDays(-2), "Desparasitación interna y externa", "Atendida", 5, 1));

        // Consultas iniciales
        Consultas.Add(new Consulta(1, DateTime.Now.AddMonths(-3), 28.5m, "Faringitis leve", "Amoxicilina 500mg cada 12h por 7 días", "Paciente responde bien al tratamiento", 1, 1, 38.6m));
        Consultas.Add(new Consulta(2, DateTime.Now.AddMonths(-1), 4.2m, "Gastritis aguda", "Omeprazol 10mg y dieta blanda", "Completar tratamiento en 5 días", 2, 1, 38.9m));
        Consultas.Add(new Consulta(3, DateTime.Now.AddDays(-2), 11.5m, "Desparasitación de rutina", "Praziquantel 1 tableta dosis única", "Buen estado físico y peso óptimo", 5, 1, 38.2m));
    }
}
