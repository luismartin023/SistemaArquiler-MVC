# Archivos Adicionales a Editar para Funcionalidad Completa

## Para que los Forms funcionen correctamente, se deben editar los siguientes archivos:

### 1. Program.cs
- **Ubicación:** `SISTEMA/Program.cs` (o raíz del proyecto)
- **Cambios necesarios:**
  - Configurar el contenedor de dependencias (DependencyInjection)
  - Establecer la cadena de conexión a la base de datos
  - Inicializar la base de datos con DbInitializer
  - Configurar el Form de inicio (LoginForm o MainForm según el flujo)

```csharp
// Ejemplo de configuración necesaria en Program.cs
using Microsoft.Extensions.DependencyInjection;
using SistemaGestionResidencial.Data;
using SistemaGestionResidencial.Forms;
using SistemaGestionResidencial.Services;

var services = new ServiceCollection();
var connectionString = "Data Source=residencial.db";

DependencyInjection.ConfigureServices(services, connectionString);

var serviceProvider = services.BuildServiceProvider();
var context = serviceProvider.GetRequiredService<ResidencialDbContext>();
DbInitializer.Initialize(context);

Application.Run(new LoginForm());
```

### 2. SistemaArquiler-MVC.csproj
- **Ubicación:** `SISTEMA/SistemaArquiler-MVC.csproj`
- **Verificar que tenga las referencias a:**
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Tools
  - Microsoft.Extensions.DependencyInjection
  - Microsoft.Extensions.Configuration
  - Microsoft.Extensions.Configuration.Json

### 3. Controllers (para conectar Forms con lógica de negocio)
- **Ubicación:** `SISTEMA/Controllers/`
- **Archivos existentes:**
  - `ApartamentoController.cs` - para ApartamentoForm
  - `InquilinoController.cs` - para InquilinoForm
  - `ContratoController.cs` - para ContratoForm
  - `PagoController.cs` - para PagoForm
  - `AuthController.cs` - para LoginForm
  - `DashboardController.cs` - para DashboardForms

- **Cambios necesarios:**
  - Implementar métodos CRUD en cada controller
  - Conectar los eventos de los botones de los Forms con los controllers
  - Manejar validaciones y errores

### 4. Interfaces y Repositories
- **Ubicación:** `SISTEMA/Interfaces/` y `SISTEMA/Repositories/`
- **Verificar que existan:**
  - `IApartamentoRepository` y `ApartamentoRepository`
  - `IInquilinoRepository` y `InquilinoRepository`
  - `IContratoRepository` y `ContratoRepository`
  - `IPagoRepository` y `PagoRepository`
  - `IUsuarioRepository` y `UsuarioRepository` (para autenticación)

### 5. Models
- **Ubicación:** `SISTEMA/Models/`
- **Verificar que existan:**
  - `Apartamento.cs`
  - `Inquilino.cs`
  - `Contrato.cs`
  - `Pago.cs`
  - `Usuario.cs`
  - Enums: `EstadoApartamento.cs`, `MetodoPago.cs`, `Rol.cs`, `TipoDocumento.cs`

### 6. Data
- **Ubicación:** `SISTEMA/Data/`
- **Verificar que existan:**
  - `ResidencialDbContext.cs` - con todas las DbSets configurados
  - `DbInitializer.cs` - con datos de seed

## Pasos para integrar los Forms:

### Para RAILYN (Apartamentos, Inquilinos, Contratos):
1. Copiar los Forms creados a la carpeta `SISTEMA/Forms/`
2. En `ApartamentoForm.cs`, conectar los métodos con `ApartamentoController`
3. En `InquilinoForm.cs`, conectar los métodos con `InquilinoController`
4. En `ContratoForm.cs`, conectar los métodos con `ContratoController`
5. Actualizar `Program.cs` para inyectar las dependencias

### Para FRANCISCO (Login, Main, Dashboards):
1. Copiar los Forms creados a la carpeta `SISTEMA/Forms/`
2. En `LoginForm.cs`, conectar con `AuthController`
3. En `MainForm.cs`, configurar navegación entre Forms
4. En `DashboardForms`, conectar con `DashboardController`
5. Actualizar `Program.cs` para iniciar con LoginForm

## Estructura de carpetas final esperada:

```
SistemaArquiler-MVC/
├── SISTEMA/
│   ├── Forms/
│   │   ├── LoginForm.cs
│   │   ├── MainForm.cs
│   │   ├── ApartamentoForm.cs
│   │   ├── InquilinoForm.cs
│   │   ├── ContratoForm.cs
│   │   ├── PagoForm.cs
│   │   ├── DashboardAdminForm.cs
│   │   ├── DashboardRecepcionistaForm.cs
│   │   └── DashboardUsuarioForm.cs
│   ├── Models/
│   │   ├── Apartamento.cs
│   │   ├── Inquilino.cs
│   │   ├── Contrato.cs
│   │   ├── Pago.cs
│   │   ├── Usuario.cs
│   │   ├── EstadoApartamento.cs
│   │   ├── MetodoPago.cs
│   │   ├── Rol.cs
│   │   └── TipoDocumento.cs
│   ├── Data/
│   │   ├── ResidencialDbContext.cs
│   │   └── DbInitializer.cs
│   ├── Interfaces/
│   │   ├── IRepository.cs
│   │   ├── IApartamentoRepository.cs
│   │   ├── IInquilinoRepository.cs
│   │   ├── IContratoRepository.cs
│   │   ├── IPagoRepository.cs
│   │   └── IUsuarioRepository.cs
│   ├── Repositories/
│   │   ├── ApartamentoRepository.cs
│   │   ├── InquilinoRepository.cs
│   │   ├── ContratoRepository.cs
│   │   ├── PagoRepository.cs
│   │   └── UsuarioRepository.cs
│   ├── Controllers/
│   │   ├── ApartamentoController.cs
│   │   ├── InquilinoController.cs
│   │   ├── ContratoController.cs
│   │   ├── PagoController.cs
│   │   ├── AuthController.cs
│   │   └── DashboardController.cs
│   ├── Services/
│   │   └── DependencyInjection.cs
│   └── SistemaArquiler-MVC.csproj
├── Program.cs
└── SistemaArquiler-MVC.slnx
```

## Notas importantes:
- Todos los Forms usan el namespace `SistemaGestionResidencial.Forms`
- Los Forms están diseñados con código puro (sin diseñador visual)
- El diseño usa colores modernos (Flat UI) con fuente Segoe UI
- Los métodos CRUD están marcados como pendientes de implementación
- Se necesita configurar la inyección de dependencias en Program.cs
