using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion_Desintoxicacion.Model;

namespace Aplicacion_Desintoxicacion.Pages
{
    public class IndexModel : PageModel
    {
        private ListaAlternativas _lista;
        public Alternativa? alternativa;

        public IndexModel(ListaAlternativas lista)
        {
            _lista = lista;
        }       
              
        public ListaAlternativas Lista { get => _lista; set => _lista = value; }

        public void OnGet()
        {

        }
    }
}