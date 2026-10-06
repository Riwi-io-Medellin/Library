# Library – Práctica de la capa Application

Una biblioteca que presta libros a sus miembros. Es un proyecto para practicar **Clean Architecture** y **DDD** en .NET 10.

## Cómo empezar

Requisitos: [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet build
```

## Estructura

```
src/
├── Library.Domain/        → no depende de nada
└── Library.Application/   → referencia a Domain
```

Más adelante llegarán las capas de Infrastructure y API.

### Qué va en cada carpeta de Domain

| Carpeta | Qué contiene |
|---|---|
| `Abstractions/` | Clases base, como `Entity` (identidad y auditoría) |
| `Entities/` | Las entidades: `Book`, `Member` y `Loan` |
| `Enums/` | Enumeraciones, como `LoanStatus` |
| `Errors/` | Catálogos de errores del dominio |
| `Events/` | Eventos del dominio (cosas que ya pasaron) |
| `Exceptions/` | Excepciones del dominio |
| `ValueObjects/` | Objetos de valor, como `LoanPeriod` |

## Ejercicio

Las tareas a completar están en [EXERCISE.md](EXERCISE.md).

---

## Autor

**Javier Cómbita Téllez**

[![GitHub](https://img.shields.io/badge/GitHub-jcomte23-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/jcomte23)\
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Javier_C%C3%B3mbita-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/javier-c%C3%B3mbita-t%C3%A9llez-4b4aa3258)\
[![Web](https://img.shields.io/badge/Web-javiercombita.pro-512BD4?style=for-the-badge&logo=googlechrome&logoColor=white)](https://javiercombita.pro)
