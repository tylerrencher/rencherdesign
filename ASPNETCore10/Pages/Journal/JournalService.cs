using System.Runtime.InteropServices;

public class JournalService
{
    private readonly string _contentPath;
    private Dictionary<string, JournalEntry> _entryCache;

    public JournalService(IWebHostEnvironment env)
    {
        _contentPath = env.WebRootPath + "/../Content/Entries";
        _entryCache = [];
        foreach (var entry in GetAll())
        {
            _entryCache.Add(entry.Slug, entry);
        }
    }

    public JournalEntry? GetBySlug(string slug)
    {
        _entryCache.TryGetValue(slug, out var entry);
        return entry;
    }

    public List<JournalEntry> GetRandom(int count)
    {
        var keys = _entryCache.Keys.ToList();
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(keys));
        return [.. keys.Take(count).Select(k => _entryCache[k])];
    }

    private List<JournalEntry> GetAll()
    {
        return
        [
            .. Directory
                .GetFiles(_contentPath, "*.md")
                .Select(p => new JournalEntry(p))
                .OrderByDescending(e => e.PublishedDate),
        ];
    }
}
