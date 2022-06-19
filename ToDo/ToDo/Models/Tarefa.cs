using System.ComponentModel.DataAnnotations;

namespace ToDo.Models
{
    public class Tarefa
    {
        [Key]
       public int Id { get; set; }

        [Required]
        public string Name { get; set; }  
        
        public DateTime EndData { get; set; }

        public bool Status { get; set; }
   
    }
}
