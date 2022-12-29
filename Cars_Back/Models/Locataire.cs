using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars_Back.Models
{
    public class Locataire
    {
        //Id
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Nom { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Prenom { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Telephone { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Adresse { get; set; }
    }
}
