using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2Week3.Pages.Models;

namespace Exercise2Week3.Pages.AccountHolderPages;

public class CreateModel : PageModel
{
    private readonly Exercise2Week3Context _context;

    public CreateModel(Exercise2Week3Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public AccountHolder AccountHolder { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.AccountHolder.Add(AccountHolder);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
