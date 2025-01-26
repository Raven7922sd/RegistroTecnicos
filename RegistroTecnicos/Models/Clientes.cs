using System.ComponentModel.DataAnnotations;

namespace RegistroTecnicos.Models
{
    public class Clientes : Tecnicos
    {
        [Key]

        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido.")]
        public string ClienteNombre { get; set; } = null!;

        [Required(ErrorMessage ="Este campo es requerido.")]
        [DataType(DataType.Date, ErrorMessage ="Formato de fecha no válido.")]
        public DateTime? FechaIngreso { get; set; }

        [Required(ErrorMessage ="Este campo es requerido.")]
        public string Direccion { get; set;} = null!;
        
        [Required(ErrorMessage ="Este campo es requerido.")]
        public int Rnc { get; set;}
        
        [Required(ErrorMessage ="Este campo es requerido.")]
        [Range(0.1, double.MaxValue, ErrorMessage ="El crédito debe ser mayor a 0." )]
        
        public int LimiteCredito { get; set;}

        public new int TecnicoId { get; set; }







    }
}
