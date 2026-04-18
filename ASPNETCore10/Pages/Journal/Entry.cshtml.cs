using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EntryModel(JournalService journalService) : PageModel
{
    private readonly JournalService _journalService = journalService;
    private const int _displayedEntries = 3;

    public required JournalEntry Entry { get; set; }
    public required List<JournalEntry> RelatedEntries { get; set; }

    public IActionResult OnGet(string slug)
    {
        Entry = _journalService.GetBySlug(slug);

        if (Entry == null) {
            return NotFound();
        }
        // We want 3 entries at the bottom of the page, but it is possible that we could
        // select the entry we are displaying right now as a related entry. So we get 4
        // entries, discard the current entry if it exists, then take 3 of the remainder.
        RelatedEntries = _journalService.GetRandom(_displayedEntries + 1);
        RelatedEntries = [.. RelatedEntries.Where(x => x.Slug != slug).Take(_displayedEntries)];

        return Page();
    }
}