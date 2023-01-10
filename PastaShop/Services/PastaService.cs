using PastaShop.Models;

namespace PastaShop.Services
{
    public class PastaService
    {
        private List<Bestelling>? bestellingen = new List<Bestelling>();

        public List<Bestelling> FindAll()
        {
            return bestellingen;
        }

        public void Add(Bestelling b)
        {
            bestellingen.Add(b);
        }
    }
}
