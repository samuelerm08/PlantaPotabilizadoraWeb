using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aplicacion_Desintoxicacion.Model;

namespace Aplicacion_Desintoxicacion.Pages
{
    public class DetalleModel : PageModel
    {
        private ListaAlternativas _lista;
        public Alternativa? alternativa;

        public DetalleModel(ListaAlternativas lista)
        {
            _lista = lista;
        }

        public void OnGet()
        {
            alternativa = _lista.ShowOne(Request.Query["encargado"]);
        }
    }
}
