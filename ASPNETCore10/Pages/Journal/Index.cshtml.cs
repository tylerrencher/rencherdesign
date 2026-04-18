using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel(JournalService journalService) : PageModel
{
    private readonly JournalService _journalService = journalService;
    private const int _displayedEntries = 9;
    private const string _featuredEntrySlug = "air-sealing";

    public required JournalEntry FeaturedEntry { get; set; }
    public required List<JournalEntry> RelatedEntries { get; set; }

    public IActionResult OnGet()
    {
        FeaturedEntry = _journalService.GetBySlug(_featuredEntrySlug);

        if (FeaturedEntry == null) {
            return NotFound();
        }

        // We want 9 entries at the bottom of the page, but it is possible that we could
        // select the featured entry a related entry. So we get 10 entries, discard the 
        // air-sealing entry if it exists, then take 9 of the remainder.
        RelatedEntries = _journalService.GetRandom(_displayedEntries + 1);
        RelatedEntries = [.. RelatedEntries.Where(x => x.Slug != _featuredEntrySlug).Take(_displayedEntries)];

        return Page();
    }
}