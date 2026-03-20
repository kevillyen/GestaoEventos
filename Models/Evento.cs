using System.ComponentModel.DataAnnotations;

namespace GestaoEventos.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do evento é obrigatório")]
        [StringLength(100)]

        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Data do Evento")]

        public DateTime Data { get; set; }

        //Relacionamento com categoria

        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }

        public int LocalId { get; set; }

        public Local? Local { get; set; }
    }
}
