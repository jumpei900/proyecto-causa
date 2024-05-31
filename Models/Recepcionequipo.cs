using System;
using System.Collections.Generic;

namespace proyecto_causa.Models;

public partial class Recepcionequipo
{
    public int Id { get; set; }

    public int ServicioId { get; set; }

    public int ClienteId { get; set; }

    public DateTime? Fecha { get; set; }

    /// <summary>
    /// 0: Laptop; 1:Torre; 2: All-In-One
    /// </summary>
    public int? TipoPc { get; set; }

    public string? Accesorio { get; set; }

    public string? MarcaPc { get; set; }

    public string? ModeloPc { get; set; }

    public string? Nserie { get; set; }

    public int? CapacidadRam { get; set; }

    /// <summary>
    /// 0: HDD; 1: SSD; 2:Ambos
    /// </summary>
    public int? TipoAlmacenamiento { get; set; }

    public string? CapacidadAlmacenamiento { get; set; }

    /// <summary>
    /// 0:Tarjeta; 1:Chip
    /// </summary>
    public int? TipoGpu { get; set; }

    public string? Grafico { get; set; }

    public virtual Cliente Cliente { get; set; } = null!;

    public virtual Servicio Servicio { get; set; } = null!;
}
