using System.ComponentModel.DataAnnotations;

namespace hospital.Domain.Entities
{
    public class Mural
    {
        [Key]
        public long Mural_Id { get; set; }
        public DateTime ?Mural_Data { get; set; } 
        public String ?Mural_Titulo { get; set; } =  "O morro dos ventos uivantes" ;   
        public String ?Mural_Aviso { get; set; }
        public String ?Mural_Autor { get; set; }
        public String ?Mural_Email { get; set; }              
         
    }
}
