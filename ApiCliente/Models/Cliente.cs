using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCliente.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column]
        public int Id { get; set; }

        [Column]
        public string Nome { get; set; }
    }
}
