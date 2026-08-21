using BibliotecaMVC.Models.ViewModels;

namespace BibliotecaMVC.Services;

/// <summary>
/// Contenido institucional fijo. Vive en listas estáticas porque todavía no
/// hay base de datos; cuando la haya, solo cambia esta clase y ni las vistas
/// ni el controlador se enteran.
/// </summary>
public class ContenidoPortalService : IContenidoPortalService
{
    private static readonly List<TarjetaCifraViewModel> Cifras =
    [
        new() { Valor = "5.280", Etiqueta = "Libros en catálogo" },
        new() { Valor = "1.140", Etiqueta = "Autores registrados" },
        new() { Valor = "24", Etiqueta = "Categorías temáticas" },
        new() { Valor = "3.900", Etiqueta = "Socios activos" }
    ];

    private static readonly List<EtiquetaViewModel> Categorias =
    [
        new() { Texto = "Novela", Tono = "primario", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Poesía", Tono = "secundario", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Historia", Tono = "acento", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Ciencia", Tono = "exito", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Tecnología", Tono = "primario", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Infantil", Tono = "acento", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Arte", Tono = "secundario", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Biografía", Tono = "neutro", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Derecho", Tono = "exito", Controlador = "Home", Accion = "Categorias" },
        new() { Texto = "Salud", Tono = "secundario", Controlador = "Home", Accion = "Categorias" }
    ];

    private static readonly List<TarjetaInfoViewModel> Servicios =
    [
        new()
        {
            Titulo = "Préstamo a domicilio",
            Descripcion = "Llévate hasta 3 libros por 15 días, renovables una vez si nadie los ha reservado.",
            Icono = "libro",
            Etiqueta = new EtiquetaViewModel { Texto = "Con carné", Tono = "primario" },
            EnlaceTexto = "Ver catálogo",
            Controlador = "Libros",
            Accion = "Index"
        },
        new()
        {
            Titulo = "Sala de lectura y cabinas",
            Descripcion = "120 puestos individuales y 8 cabinas de estudio en grupo, reservables por bloques de dos horas.",
            Icono = "libro-abierto",
            Etiqueta = new EtiquetaViewModel { Texto = "Presencial", Tono = "neutro" }
        },
        new()
        {
            Titulo = "Biblioteca digital",
            Descripcion = "Más de 2.000 libros electrónicos y bases de datos académicas con acceso remoto.",
            Icono = "pantalla",
            Etiqueta = new EtiquetaViewModel { Texto = "En línea", Tono = "exito" }
        },
        new()
        {
            Titulo = "Reserva en línea",
            Descripcion = "Aparta un ejemplar prestado y recibe un aviso en cuanto vuelva a estar disponible.",
            Icono = "calendario",
            Etiqueta = new EtiquetaViewModel { Texto = "En línea", Tono = "exito" },
            EnlaceTexto = "Ir a préstamos",
            Controlador = "Home",
            Accion = "Prestamos"
        },
        new()
        {
            Titulo = "Formación de usuarios",
            Descripcion = "Talleres de búsqueda bibliográfica, gestión de referencias y normas de citación APA.",
            Icono = "birrete",
            Etiqueta = new EtiquetaViewModel { Texto = "Cada semestre", Tono = "acento" }
        },
        new()
        {
            Titulo = "Clubes de lectura",
            Descripcion = "Tertulias mensuales de narrativa, poesía y ensayo, abiertas a toda la comunidad.",
            Icono = "personas",
            Etiqueta = new EtiquetaViewModel { Texto = "Entrada libre", Tono = "acento" }
        }
    ];

    private static readonly List<TarjetaInfoViewModel> Principios =
    [
        new()
        {
            Titulo = "Misión",
            Descripcion = "Garantizar el acceso libre, ordenado y oportuno a la información que la comunidad universitaria necesita para estudiar, investigar y crear.",
            Icono = "diana"
        },
        new()
        {
            Titulo = "Visión",
            Descripcion = "Ser en 2030 la biblioteca universitaria de referencia del país en gestión de colecciones híbridas, físicas y digitales.",
            Icono = "brujula"
        },
        new()
        {
            Titulo = "Valores",
            Descripcion = "Acceso abierto, respeto por el lector, cuidado del patrimonio bibliográfico y acompañamiento a quien recién empieza a investigar.",
            Icono = "corazon"
        }
    ];

    private static readonly List<TarjetaPersonaViewModel> AutoresDestacados =
    [
        new()
        {
            Nombre = "Gabriel García Márquez",
            Iniciales = "GM",
            Rol = "Realismo mágico",
            Detalle = "Colombia · 1927",
            Etiqueta = new EtiquetaViewModel { Texto = "12 títulos", Tono = "primario" }
        },
        new()
        {
            Nombre = "Isabel Allende",
            Iniciales = "IA",
            Rol = "Narrativa contemporánea",
            Detalle = "Chile · 1942",
            Etiqueta = new EtiquetaViewModel { Texto = "9 títulos", Tono = "primario" }
        },
        new()
        {
            Nombre = "Mario Vargas Llosa",
            Iniciales = "MV",
            Rol = "Novela y ensayo",
            Detalle = "Perú · 1936",
            Etiqueta = new EtiquetaViewModel { Texto = "11 títulos", Tono = "primario" }
        }
    ];

    private static readonly List<TarjetaPersonaViewModel> Equipo =
    [
        new() { Nombre = "María Cedeño", Iniciales = "MC", Rol = "Directora de la biblioteca" },
        new() { Nombre = "Jorge Reyes", Iniciales = "JR", Rol = "Catalogación y proceso técnico" },
        new() { Nombre = "Ana Luna", Iniciales = "AL", Rol = "Circulación y préstamos" },
        new() { Nombre = "Daniel Vera", Iniciales = "DV", Rol = "Colección digital y sistemas" }
    ];

    public IReadOnlyList<TarjetaCifraViewModel> ListarCifras() => Cifras;

    public IReadOnlyList<EtiquetaViewModel> ListarCategorias() => Categorias;

    public IReadOnlyList<TarjetaInfoViewModel> ListarServicios() => Servicios;

    public IReadOnlyList<TarjetaInfoViewModel> ListarPrincipios() => Principios;

    public IReadOnlyList<TarjetaPersonaViewModel> ListarAutoresDestacados() => AutoresDestacados;

    public IReadOnlyList<TarjetaPersonaViewModel> ListarEquipo() => Equipo;
}
