using Microsoft.AspNetCore.Components;

namespace Web_Cite_Arrecife.Services;

public class NavigationService
{
    private readonly NavigationManager _nav;

    public NavigationService(NavigationManager nav)
    {
        _nav = nav;
    }

    public void GoToSection(string id)
    {
        _nav.NavigateTo($"/#{id}", forceLoad: true);
    }
}