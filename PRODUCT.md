# Product

<!-- impeccable:product-schema 1 -->

## Platform

web

## Users

Primary user is the student (Anthony) building and submitting this project, and the professor who reviews/grades it, for the Programación 1 course (USMP, ciclo 2026-2). There is no external end user yet; any resemblance to a real pet owner or clinic staff workflow is incidental to the academic exercise, not a target audience.

## Product Purpose

A course assignment ("Formulario Mascotas") that practices ASP.NET Core MVC fundamentals: a model with data-annotation validation, a controller action that registers records, and a Razor view that both submits a form and lists the resulting data. Success means a working, well-validated register-and-list flow that satisfies the assignment rubric.

## Operating Context

- Runs locally via `dotnet run`; reviewed by opening the app in a browser (Home → Mascotas).
- ASP.NET Core MVC (.NET, target framework net10.0), Razor views, Bootstrap for layout/components, jQuery included by the default template.
- Storage is a static in-memory `List<Mascota>` in `MascotasController` — data lives only while the process runs and resets on restart. No database is wired up.
- Single form posts to `Mascotas/Registrar`; the same page (`Mascotas/Index`) re-renders the running list below the form.

## Capabilities and Constraints

- Scope is fixed by the assignment rubric: register a mascota and list all registered mascotas. Do not add editing, deletion, search/filter, or database persistence unless the user explicitly asks — those are out of rubric scope for now.
- Model fields (`Models/Mascota.cs`): Nombre (required), Tipo (required, one of a fixed dropdown: Perro/Gato/Ave/Pez/Conejo/Hámster/Otro), Raza (required), Edad in años (0–100), Peso in kg (0–500), Color (optional), Sexo (optional: Macho/Hembra).
- Server-side validation via data annotations (`[Required]`, `[Range]`) with Spanish error messages; anti-forgery token on the POST.
- In-memory storage is a deliberate, temporary constraint of this assignment stage, not a bug to silently "fix" with a database.

## Brand Commitments

Must reflect USMP (Universidad de San Martín de Porres) identity — this is a binding constraint the user confirmed, but the specific execution (colors, logo, exact placement) is undecided and belongs to the design phase, not here.

## Evidence on Hand

No real content, sample data, testimonials, or brand assets (logo file, exact institutional color values) are on hand yet. Future work must not fabricate USMP brand assets or real pet records — use clearly placeholder data until the user supplies real assets.

## Product Principles

1. Respect the rubric's fixed scope: register + list only, in-memory, no unrequested features.
2. Keep validation and error messages in Spanish, matching the existing model and audience (a Peruvian university course).
3. Treat USMP identity as a real constraint to honor once assets/colors are supplied, not decoration to invent freely.
4. Favor a clean, gradeable, easy-to-demo MVC implementation over cleverness — this is a learning exercise, not a production product.
