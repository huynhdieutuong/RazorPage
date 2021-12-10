using Microsoft.AspNetCore.Mvc.RazorPages;

public class ThirdPageModel : PageModel
{
    // OnGet Handler is similar ComponentDidMount
    // OnGetAbc, OnGetXyz,...
    // OnPut, OnPost, OnDelete - call api which methods: PUT, POST, DELETE
    public void OnGet()
    {
        System.Console.WriteLine("On Get Run Firstly");
        ViewData["mydata"] = "This is My Data";
    }

    // GET https://localhost:5001/third-page?handler=Abc
    public void OnGetAbc()
    {
        System.Console.WriteLine("On Get ABC Run");
        ViewData["mydata"] = "This is My Data ABC";
    }
}