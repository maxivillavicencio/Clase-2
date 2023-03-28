using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Clase2.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public Form Data {get; set;}

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Data = new Form();
        Data.Mail = "test@gmail.com";
        Data.Passwd = "1234";
    }

    public IActionResult OnPost(){
        if(!ModelState.IsValid){
            return Page();
        }
        //Guardar en la base de datos, procesar info
        var formValues = Data;
        return RediretToPage("Index")
    }
}

