using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Parauan_Andreea_Raluca_Proiect_MPD.Models
{
    public class Proiect_MPD
    {
        public int ID { get; set; }

        [Display(Name = "Apeluri")]
        public string Titlu { get; set; }
        public string Cod_apel { get; set; }
        public string Tip_apel { get; set; }
        public string Regiunea_de_dezvoltare { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_publicarii_ghidului { get; set; }

        public int? Fondul_StructuralID { get; set; }
        public Fondul_Structural? Fondul_Structural {get; set;}
      
        public int? Tip_ajutorID { get; set; }
        public Tip_ajutor? Tip_ajutor { get; set; }
        public int? Proiect_depusID { get; set; }
        public Proiect_depus? Proiect_depus { get; set; }
     


    } // navigation property
}
