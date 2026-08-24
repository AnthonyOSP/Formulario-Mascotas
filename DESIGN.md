---
name: Registro de Mascotas
description: Formulario y libro de registro de mascotas con la gravedad de una mesa de partes universitaria
colors:
  granate:
    value: "#7c1f2c"
  granate-fuerte:
    value: "#591620"
  granate-suave:
    value: "#f2e2df"
  granate-tinta:
    value: "#fff6ed"
  papel:
    value: "#f4efe3"
  hoja:
    value: "#fbf8f1"
  tinta:
    value: "#2a2118"
  tinta-suave:
    value: "#5a4c3c"
  raya:
    value: "#d9cbab"
  raya-fuerte:
    value: "#c3b291"
  error:
    value: "#96392a"
typography:
  rotulo:
    fontFamily: "Public Sans, Segoe UI, system-ui, sans-serif"
    fontWeight: 700
    letterSpacing: "0.03em"
  cuerpo:
    fontFamily: "Public Sans, Segoe UI, system-ui, sans-serif"
    fontWeight: 400
    lineHeight: 1.5
  folio:
    fontFamily: "Courier Prime, ui-monospace, SFMono-Regular, Menlo, monospace"
    fontWeight: 700
rounded:
  documento: "3px"
  campo: "2px"
  boton-sello: "999px"
spacing:
  campo: "1.1rem"
  panel: "1.5rem"
components:
  button-presentar:
    backgroundColor: "{colors.granate}"
    textColor: "{colors.granate-tinta}"
    rounded: "{rounded.campo}"
    padding: "0.65rem 1rem"
  button-presentar-hover:
    backgroundColor: "{colors.granate-fuerte}"
    textColor: "{colors.granate-tinta}"
  button-sello:
    backgroundColor: "{colors.granate}"
    textColor: "{colors.granate-tinta}"
    rounded: "{rounded.boton-sello}"
    padding: "0.75rem 1.6rem"
---

# Design System: Registro de Mascotas

## Overview

**Creative North Star: "La mesa de partes universitaria"**

El sistema trata cada registro como un trámite real: la ficha (formulario) se presenta en un mostrador institucional y cada envío válido gana una fila numerada y sellada en el libro de registro (la tabla). No es una card de Bootstrap con bordes redondeados — es un documento oficial junto a un libro rayado, con el granate institucional de USMP como el único acento que marca "esto es oficial". La app inherita este mundo completo: cabecera, portada, formulario, listado y páginas de contenido comparten el mismo papel, tinta y granate.

Rechazos confirmados: sin ilustraciones de mascotas ni iconos de patitas decorativos, sin degradados ni vidrio esmerilado, sin colores adicionales fuera del granate y el papel — la seriedad institucional es el punto, no un tema "mono" o "juguetón" para mascotas.

**Key Characteristics:**
- Papel crema con raya de libro de fondo; tinta casi negra, nunca negro puro.
- Un solo acento — granate institucional — que carga sellos, botones primarios y estados activos.
- Public Sans para toda la interfaz; Courier Prime reservado para folios y fechas (dato, no decoración).
- Radios casi rectos en documentos y campos; el único elemento circular/pill es el botón "sello".

## Colors

Paleta restringida (Restrained): neutros de papel y tinta cálida, más un solo granate que hace todo el trabajo de acento.

### Primary
- **Granate institucional** (#7c1f2c): botón "Presentar", cabecera del sitio, folios, bordes de foco, hover de fila en la tabla. Aproximación razonable a la identidad de USMP — reemplazar por el hex oficial en `wwwroot/css/site.css` (`--color-accent`) en cuanto se confirme.
- **Granate fuerte** (#591620): estados hover/active del granate y borde inferior de la cabecera.
- **Granate suave** (#f2e2df): fondo de cabecera de tabla y anillo de foco; nunca texto sobre sí mismo.

### Neutral
- **Papel** (#f4efe3): fondo general de la página, con la raya horizontal de libro superpuesta.
- **Hoja** (#fbf8f1): superficie de la ficha y el libro, un tono más clara que el papel para que "floten" como documentos.
- **Tinta** (#2a2118): texto principal, encabezados.
- **Tinta suave** (#5a4c3c): texto secundario, etiquetas de campo — probado ≥4.5:1 sobre papel y hoja.
- **Raya** (#d9cbab) / **Raya fuerte** (#c3b291): líneas de libro, bordes de documento y tabla.

### Named Rules
**La regla del acento único.** El granate es el único color con carga semántica en toda la app; no se introduce un verde de éxito ni un azul de enlace distinto — el "sello" (forma + granate) es la señal de éxito, no un nuevo matiz.

**La regla de la marca, no el color.** Los estados de error nunca dependen solo del granate ni de un rojo genérico: usan un rust distinto (`--color-error`, #96392a) *y* un borde punteado en vez de sólido, para no depender del color como única señal.

## Typography

**Rótulo / UI Font:** Public Sans (con Segoe UI, system-ui, sans-serif como respaldo)
**Cuerpo Font:** Public Sans (misma familia — una sola familia alcanza para un panel de tarea)
**Folio/Mono Font:** Courier Prime (con ui-monospace, SFMono-Regular, Menlo como respaldo)

**Character:** Public Sans lee como un sans de servicio público — sobrio, sin capricho, apto para formularios oficiales; Courier Prime aparece solo donde hay un dato mecanografiado (folio, fecha), nunca como voz de titular.

### Hierarchy
- **Título de portada** (700, `clamp(2rem, 4vw, 3rem)`): titular de Inicio.
- **Encabezado de panel** (700, 1.15rem): "Registrar nueva mascota", "Libro de registro".
- **Etiqueta de campo** (700, 0.78rem, mayúsculas, 0.03em): rótulos sobre cada input de la ficha.
- **Cuerpo** (400, 1rem, line-height 1.5, medida máx. 68ch): párrafos y texto de listado.
- **Folio/dato** (700, mono, 0.92rem): números de folio, fechas — la única voz monoespaciada del sistema.

### Named Rules
**La regla del dato mecanografiado.** Courier Prime aparece únicamente donde el contenido es un dato medible (folio, fecha, contador) — nunca como decoración "técnica" en titulares o botones.

## Layout

Grid de Bootstrap (`row`/`col-md-*`) para el par ficha/libro: 5/7 columnas en escritorio, apiladas en móvil (< 768px) sin composición adicional. El fondo de `body` lleva una raya horizontal repetida cada 2.15rem simulando el rayado de un libro; los paneles (`.ficha`, `.libro`) son las únicas superficies "elevadas" sobre ese papel. Contenedor principal hereda el `container` de Bootstrap (ancho máx. estándar, sin composición propia).

## Elevation & Depth

Mayormente plano: los paneles de documento (`.ficha`) y el botón de portada (`.sello-btn`) llevan una sola sombra suave con offset y blur (`--shadow-sheet: 0 10px 24px -18px rgba(42,33,24,.45), 0 2px 6px -2px rgba(42,33,24,.18)`) para leerse como una hoja apoyada sobre el mostrador. El resto de la interfaz (tabla, cabecera, footer) es completamente plana y se apoya en líneas (`--color-rule`) en vez de sombra para separar zonas.

### Named Rules
**La regla de la hoja única.** Solo los elementos que representan un documento físico (la ficha, el CTA tipo sello) llevan sombra; la tabla, la cabecera y el footer nunca la usan.

## Shapes

Radios casi rectos en todo lo que es "documento" o "campo" (2–3px: `--radius-sheet`, inputs, botón "Presentar") — evocan una hoja impresa, no una app de consumo. La única excepción deliberada es el CTA de portada y el sello circular del logo, en forma de pill/círculo (999px / círculo completo), que citan literalmente un sello de goma. Bordes: hairline de 1px en `--color-rule-strong` en paneles y tabla; el único borde de 3px es el borde inferior granate de la cabecera.

## Components

### Buttons
- **Shape:** `.btn-presentar` (primario, dentro de la ficha) usa radio de 2px, ancho completo; `.sello-btn` (CTA de portada) usa pill de 999px.
- **Primary:** fondo granate (#7c1f2c), texto `--color-accent-ink` (#fff6ed), borde 1px granate fuerte.
- **Hover / Focus:** hover oscurece a granate fuerte (#591620); foco visible con `outline` de 2px en granate (o tinta, sobre fondo granate) vía `:focus-visible`, nunca solo `box-shadow` de Bootstrap.

### Cards / Containers
- **Ficha** (`.ficha`): esquina superior con pestaña granate rotulada ("Ficha de registro"), cuerpo en `--color-sheet`, sombra `--shadow-sheet`, radio 3px.
- **Libro** (`.libro`): mismo tratamiento de superficie sin pestaña; cabecera interna separada por una línea, no por sombra.

### Inputs / Fields
- **Style:** fondo `--color-ground`, borde 1px `--color-rule-strong`, radio 2px, etiqueta en mayúsculas encima (no floating label).
- **Focus:** borde granate + halo de 3px en `--color-accent-soft`.
- **Error:** borde discontinuo (`dashed`) en `--color-error` + marca "✕" delante del mensaje — nunca solo un cambio de color.

### Tabla / Libro de registro
- **Style:** cabecera en versalitas sobre `--color-accent-soft`, filas separadas por hairline `--color-rule`, columna de folio en Courier Prime + granate.
- **State:** hover de fila tiñe la fila completa de `--color-accent-soft`; estado vacío muestra una línea punteada y el texto "Aún no hay folios sellados".

### Navigation
- **Style:** barra granate de ancho completo, marca (sello SVG + "USMP · Programación 1" + "Registro de Mascotas") a la izquierda, enlaces a la derecha; enlace activo subrayado con una línea de 2px en `--color-accent-ink`.

## Do's and Don'ts

### Do:
- **Do** mantener el granate como único acento con carga semántica (botones primarios, folios, estados activos); todo lo demás vive en papel/tinta.
- **Do** usar Courier Prime solo para datos medibles (folio, fecha), nunca para titulares o cuerpo.
- **Do** marcar los estados de error con forma (borde punteado + "✕") además de color, no solo con `--color-error`.
- **Do** mantener las esquinas casi rectas (2–3px) en todo lo que representa un documento; reservar el pill/círculo para el sello y el CTA de portada.

### Don't:
- **Don't** introducir un segundo acento de color (verde de éxito, azul de enlace distinto) — rompe la regla del acento único.
- **Don't** usar Courier Prime como "voz técnica" decorativa fuera de folios/fechas.
- **Don't** agregar sombras a la tabla, la cabecera o el footer — la sombra es exclusiva de las superficies tipo "hoja" (ficha, CTA).
- **Don't** apilar cards genéricas de icono + título + texto para futuras secciones; cualquier panel nuevo hereda el lenguaje de "ficha" o "libro", no un card shell neutro.
