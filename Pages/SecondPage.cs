using Microsoft.AspNetCore.Mvc.RazorPages;

public class SecondPageModel : PageModel
{
    public string Title { get; set; } = "This is the Title Property";

    public string Welcome(string name)
    {
        return $"Welcome {name}";
    }
}