using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PastaShop.Models
{
    public class Persoon
    {
        public DateTime Vandaag = DateTime.Now;
        
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string Voornaam { get; set; }
        [Required(ErrorMessage = "Emailadres is verplicht")]
        public string Emailadres { get; set; }
        [Required(ErrorMessage = "Telefoon is verplicht")]
        public string Telefoon { get; set; }
        [Required(ErrorMessage = "Geboortedatum is verplicht")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        [Verleden(ErrorMessage ="Geboortedatum moet in het verleden liggen")]
        public DateTime Geboortedatum { get; set; }
    }
}
