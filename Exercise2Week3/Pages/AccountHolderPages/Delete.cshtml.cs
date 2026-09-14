using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Exercise2Week3.Pages.Models;

namespace Exercise2Week3.Pages.AccountHolderPages;

public class DeleteModel : PageModel
{
    private readonly Exercise2Week3Context _context;

    public DeleteModel(Exercise2Week3Context context)
    {
        _context = context;
    }

    [BindProperty]
    public AccountHolder AccountHolder { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? accountholderid)
    {
        if (accountholderid is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FirstOrDefaultAsync(m => m.AccountHolderId == accountholderid);
        if (accountholder is null)
        {
            return NotFound();
        }
        else
        {
            AccountHolder = accountholder;
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? accountholderid)
    {
        if (accountholderid is null)
        {
            return NotFound();
        }

        var accountholder = await _context.AccountHolder.FindAsync(accountholderid);
        if (accountholder != null)
        {
            AccountHolder = accountholder;
            _context.AccountHolder.Remove(AccountHolder);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
