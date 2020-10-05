using System.ComponentModel.DataAnnotations;

namespace Jean_P1_AP1.Entities
{
    public class Ciudad
    {
        [Key]
        public int CiudadID { get; set; }
        public string Nombre { get; set; }
        
    }
}