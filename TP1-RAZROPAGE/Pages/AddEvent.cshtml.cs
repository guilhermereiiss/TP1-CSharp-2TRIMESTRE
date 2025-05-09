using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ProductCatalog.Pages
{
    public class AddEventModel : PageModel
    {
        public class Event
        {
            public string Titulo { get; set; }
            public DateTime Data { get; set; }
            public string Local { get; set; }
        }

        [BindProperty]
        public Event NovoEvento { get; set; }

        public bool EventoCriado { get; set; }

        public static Action<Event> OnEventCreated = e =>
        {
            Console.WriteLine($"Evento criado: {e.Titulo}, em {e.Data.ToShortDateString()} no local {e.Local}");
        };

        public void OnGet()
        {
        }

        public void OnPost()
        {
            EventoCriado = true;
            OnEventCreated?.Invoke(NovoEvento);
        }
    }
}
