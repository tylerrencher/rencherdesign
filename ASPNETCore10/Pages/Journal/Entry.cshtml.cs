using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services;

public class EntryModel(JournalService journalService) : PageModel
{
    private const int DisplayedEntries = 3;

    public required JournalEntry Entry { get; set; }
    public required List<JournalEntry> RelatedEntries { get; set; }

    public IActionResult OnGet(string slug)
    {
        var entry = journalService.GetBySlug(slug);

        if (entry == null)
        {
            return NotFound();
        }

        Entry = entry;
        // We want 3 entries at the bottom of the page, but it is possible that we could
        // select the entry we are displaying right now as a related entry. So we get 4
        // entries, discard the current entry if it exists, then take 3 of the remainder.
        RelatedEntries = journalService.GetRandom(DisplayedEntries + 1);
        RelatedEntries = [.. RelatedEntries.Where(x => x.Slug != slug).Take(DisplayedEntries)];

        return Page();
    }
}
