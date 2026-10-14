# 🐾 Sistema Veterinaria

Sistema de gestión integral para clínicas veterinarias desarrollado como **proyecto académico** (5.º semestre). Permite administrar clientes, mascotas, citas y el historial clínico de los pacientes, con módulos separados para recepción y consulta médica.

> **Nota:** proyecto de escritorio con fines educativos; no está destinado a producción.

---

## ✨ Características

- **Gestión de clientes (dueños):** alta, modificación, eliminación y búsqueda con validación de cédula (10 dígitos).
- **Gestión de mascotas:** ficha completa (especie, raza, sexo, fecha de nacimiento) vinculada obligatoriamente a su dueño.
- **Gestión de citas:** agendamiento, cancelación y atención; filtros por estado (`PENDIENTE`, `ATENDIDA`, `CANCELADA`).
- **Historial clínico:** registro de peso, temperatura, diagnóstico, tratamiento y observaciones por consulta.
- **Impresión:** comprobantes de cita y reportes de historial médico con vista previa.
- **Control de acceso:** módulo veterinario protegido por PIN validado **contra la base de datos** (`EmpleadoDatos.ValidarPin`), con roles (`ADMIN` / `PERSONAL`).
- **Configuración externa:** la cadena de conexión vive en `appsettings.json`, no en el código, por lo que puede cambiarse sin recompilar.

---

## 🛠️ Tecnologías

| Categoría | Tecnología |
| --- | --- |
| Lenguaje | C# |
| Framework | .NET 10 |
| UI | Windows Forms |
| Base de datos | PostgreSQL 18 |
| Acceso a datos | ADO.NET (Npgsql) |
| IDE | JetBrains Rider |

---

## 🏗️ Arquitectura

Proyecto estructurado en **cuatro capas** con dependencias unidireccionales:

```
┌──────────────────┐
│  Veterinaria.UI  │  ← Formularios Windows Forms
└────────┬─────────┘
         ▼
┌─────────────────────┐
│ Veterinaria.Negocio │  ← Lógica de negocio y validaciones
└────────┬────────────┘
         ▼
┌───────────────────┐
│  Veterinaria.Datos│  ← Repositorios (SQL parametrizado con Npgsql)
└────────┬──────────┘
         ▼
┌────────────────────────┐
│ Veterinaria.Entidades  │  ← Modelos / POCOs del dominio
└────────────────────────┘
```

- **Patrón Repository:** cada entidad tiene su clase de acceso a datos (`ClienteDatos`, `MascotaDatos`, `CitaDatos`, `HistorialClinicoDatos`, `EmpleadoDatos`).
- **SQL parametrizado** en todas las operaciones para prevenir inyección SQL.
- **Integridad referencial** en base de datos: claves foráneas con `ON DELETE CASCADE` y restricciones `CHECK` para estados, roles y sexo.
- **Credenciales desacopladas:** `Program.CargarConfiguracion()` lee `Veterinaria.UI/appsettings.json` al iniciar y entrega la cadena de conexión a `ConexionBD.CadenaConexion`. La capa de datos no contiene credenciales.

---

## 📦 Estructura del proyecto

```
VeterinariaApp/
├── Scripts/
│   ├── schema.sql                  # Esquema de la base de datos
│   └── seed.sql                    # Datos iniciales (empleado por defecto)
├── Veterinaria.Entidades/          # Modelos del dominio
│   ├── Cliente.cs
│   ├── Mascota.cs
│   ├── Cita.cs
│   ├── Empleado.cs
│   └── HistorialClinico.cs
├── Veterinaria.Datos/              # Capa de acceso a datos
│   ├── ConexionBD.cs
│   ├── ClienteDatos.cs
│   ├── MascotaDatos.cs
│   ├── CitaDatos.cs
│   ├── EmpleadoDatos.cs
│   └── HistorialClinicoDatos.cs
├── Veterinaria.Negocio/            # Lógica de negocio
│   ├── ClienteNegocio.cs
│   ├── MascotaNegocio.cs
│   ├── CitaNegocio.cs
│   ├── EmpleadoNegocio.cs
│   └── HistorialClinicoNegocio.cs
└── Veterinaria.UI/                 # Interfaz gráfica (WinForms)
    ├── Program.cs
    ├── appsettings.json            # Cadena de conexión (local)
    ├── appsettings.example.json    # Plantilla de configuración
    ├── FormInicio.cs               # Menú principal
    ├── FormPin.cs                  # Acceso por PIN
    ├── FormRecepcion.cs            # Módulo de recepción
    └── FormVeterinario.cs          # Módulo de consulta médica
```

---

## 💾 Modelo de datos

| Tabla | Descripción | Campos principales |
| --- | --- | --- |
| `cliente` | Dueños de las mascotas | cédula (PK), nombres, apellidos, teléfono, dirección |
| `mascota` | Pacientes | id_mascota (PK), cedula_dueno (FK), nombre, especie, raza, sexo, fecha_nacimiento |
| `empleado` | Usuarios del sistema | id_empleado (PK), nombre, rol, clave_pin |
| `cita` | Citas agendadas | id_cita (PK), id_mascota (FK), id_empleado (FK), fecha_hora, motivo, estado |
| `historial_clinico` | Registros médicos | id_historial (PK), id_mascota (FK), id_empleado (FK), fecha, peso_actual, diagnostico, tratamiento |

---

## 📱 Módulos de la aplicación

### FormInicio
Menú principal con acceso a los dos módulos del sistema.

### FormRecepcion
Módulo de recepción con tres pestañas:
- **Clientes:** CRUD completo con búsqueda.
- **Mascotas:** CRUD con selección de dueño.
- **Citas:** agendamiento, cancelación, filtro por estado e impresión de comprobante.

### FormVeterinario (acceso con PIN)
Módulo de atención médica:
- Listado de pacientes en espera (citas pendientes).
- Formulario de consulta: peso, temperatura, diagnóstico, tratamiento y observaciones.
- Historial clínico previo del paciente.
- Impresión de reporte médico.

---

## 👤 Roles de acceso

| Rol | Descripción |
| --- | --- |
| `ADMIN` | Acceso completo al sistema |
| `PERSONAL` | Acceso a módulos operativos |

> El acceso al módulo veterinario se valida contra la tabla `empleado` (consulta parametrizada por `clave_pin`). Al ejecutar `Scripts/seed.sql` se crea un empleado `ADMIN` con PIN `1234`, de demostración académica.

---

## ⚙️ Puesta en marcha

1. **Crear la base de datos y el esquema:**
   ```bash
   createdb db_veterinaria
   psql -d db_veterinaria -f Scripts/schema.sql
   psql -d db_veterinaria -f Scripts/seed.sql   # empleado por defecto
   ```
2. **Configurar la conexión:** copiar `Veterinaria.UI/appsettings.example.json` como `Veterinaria.UI/appsettings.json` y ajustar host, puerto, base de datos, usuario y contraseña.
3. **Compilar y ejecutar:**
   ```bash
   dotnet run --project Veterinaria.UI
   ```

> `Scripts/seed.sql` es necesario porque las citas y el historial referencian un `id_empleado`; sin al menos un empleado registrado, las altas fallarían por clave foránea.

---

## 📋 Próximos pasos (mejoras previstas)

- [ ] Migración de base de datos con scripts versionados (hoy es un volcado de `pg_dump`).
- [ ] Separar temperatura y observaciones en columnas propias del historial.
- [ ] Inyectar dependencias en la capa de negocio para poder probarla.
- [ ] Agregar pruebas unitarias para la capa de negocio.
- [ ] Cifrar el almacenamiento de los PIN de empleados.
- [ ] Dashboard con reportes y estadísticas.

---

## 🎓 Contexto académico

Proyecto grupal desarrollado en el 5.º semestre como parte de la formación en desarrollo de software, aplicando:

- Arquitectura en capas
- Patrón Repository
- SQL relacional con integridad referencial
- Descripción de interfaces en Windows Forms

---

## 📄 Licencia

Este proyecto es de uso académico. Para más información, contacta al autor.
