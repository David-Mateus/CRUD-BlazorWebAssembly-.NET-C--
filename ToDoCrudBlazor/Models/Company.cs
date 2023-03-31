using System.ComponentModel.DataAnnotations;

namespace ToDoCrudBlazor.Models
{
    // propriedades
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = new DateTime(2023, 1, 1);

        [Required]
        [StringLength(100)]
        public string Prioridade { get; set; }
       
        [Required]
        public DateTime Vencimento { get; set; } = new DateTime(2023, 1, 1);
        [Required]
        public string Email { get; set; }

        
        // função para gerar um novo ID
        public void GenerateNewId()
        {
            Id = Guid.NewGuid();
        }
    }
}
