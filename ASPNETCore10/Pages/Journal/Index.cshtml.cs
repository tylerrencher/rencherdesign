using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel(JournalService journalService) : PageModel
{
    private const int DisplayedEntries = 9;
    private const string FeaturedEntrySlug = "air-sealing";

    public required JournalEntry FeaturedEntry { get; set; }
    public required List<JournalEntry> RelatedEntries { get; set; }

    public IActionResult OnGet()
    {
        var featuredEntry = journalService.GetBySlug(FeaturedEntrySlug);

        if (featuredEntry == null)
        {
            return NotFound();
        }

        FeaturedEntry = featuredEntry;

        // We want 9 entries at the bottom of the page, but it is possible that we could
        // select the featured entry a related entry. So we get 10 entries, discard the
        // air-sealing entry if it exists, then take 9 of the remainder.
        RelatedEntries = journalService.GetRandom(DisplayedEntries + 1);
        RelatedEntries =
        [
            .. RelatedEntries.Where(x => x.Slug != FeaturedEntrySlug).Take(DisplayedEntries),
        ];

        return Page();
    }
}
