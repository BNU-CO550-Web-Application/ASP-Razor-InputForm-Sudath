using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorInputForm.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public string FullName { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Sudath Nawagamuwage";
        }
        public void OnPost()
        {
            if(String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
                FullName = "Please Fill The Details";
            }
            else
            {
                //Register the user
                ViewData["Message"] = "Name is Registered!";
            }

        }
    }
}