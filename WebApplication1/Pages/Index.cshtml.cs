using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Modal;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        //VAR FOR SERVICE 
        JsonFileBookServices BookService;
        // var for book records
        public IEnumerable<Book> Books;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileBookServices services)
        {
            _logger = logger;
            BookService = services;
        }

        public void OnGet()
        {
            Books = BookService.getBookRecord();
        }
    }
}