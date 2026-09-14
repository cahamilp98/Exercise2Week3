using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2Week3.Pages.Models;

namespace Exercise2Week3.Pages.AccountHolderPages;

public class IndexModel : PageModel
{
    private readonly Exercise2Week3Context _context;

    public IndexModel(Exercise2Week3Context context)
    {
        _context = context;
    }

    public IList<AccountHolder> AccountHolder { get; set; } = default!;

    public async Task OnGetAsync()
    {
        AccountHolder = await _context.AccountHolder.ToListAsync();
    }
}
