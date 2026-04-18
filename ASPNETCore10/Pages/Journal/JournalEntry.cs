using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax; 
using YamlDotNet.Serialization;

public class JournalEntry
{
    public string Title { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Slug { get; set; }
    public string Summary { get; set; } 
    public string Category { get; set; }
    public string Lede { get; set; }
    public List<string> InterestPoints { get; set; }
    public string HeroImagePath { get; set; }
    public string BodyHtml { get; set; }
    public string ReadTimeMinutes { get; set; }

    public JournalEntry(string contentPath)
    { 
        // Configure safe defaults
        Title = "";
        PublishedDate = new DateTime();
        Slug = "";
        Category = "";
        Lede = "";
        Summary = "";
        ReadTimeMinutes = "";
        HeroImagePath = "";
        InterestPoints = [];
        BodyHtml = "";

        if(string.IsNullOrWhiteSpace(contentPath))
        {
            return;
        }    

        string content;
        try {
            content = File.ReadAllText(contentPath);
        }
        catch
        {
            return;
        }

        var pipeline = new MarkdownPipelineBuilder()
            .UseYamlFrontMatter()
            .UseGenericAttributes()
            .UseCustomContainers()
            .Build(); 
        var document = Markdown.Parse(content, pipeline);
        var yamlBlock = document.Descendants<YamlFrontMatterBlock>().FirstOrDefault();
        if (yamlBlock != null)
        {
            var yamlContent = yamlBlock.Lines.ToString();
            var deserializer = new DeserializerBuilder().Build();
            var metadata = deserializer.Deserialize<Dictionary<string, object>>(yamlContent);

            Title = ObjectToString(RetrieveValue(metadata, "title"));
            PublishedDate = DateTime.Parse(ObjectToString(RetrieveValue(metadata, "date")));
            Slug = ObjectToString(RetrieveValue(metadata, "slug"));
            Category = ObjectToString(RetrieveValue(metadata, "category"));
            Lede = ObjectToString(RetrieveValue(metadata, "lede"));
            Summary = ObjectToString(RetrieveValue(metadata, "summary"));
            ReadTimeMinutes = ObjectToString(RetrieveValue(metadata, "readminutes"));
            HeroImagePath = $"images/entries/{Slug}-hero.jpg";
            var interestPoints = (RetrieveValue(metadata, "interestpoints") as List<object>)?.Select(ObjectToString).ToList();
            if(interestPoints == null)
            {
                InterestPoints = [];
            }
            else
            {
                InterestPoints = interestPoints;
            }
        }

        BodyHtml = document.ToHtml(pipeline);
    }

    private string ObjectToString(object value)
    {
        if(value == null)
        {
            return "";
        }
        return value.ToString();
    }

    private object RetrieveValue(Dictionary<string, object> data, string key)
    {
        try
        {
            return data[key];
        }
        catch
        {
            return null;
        }
    }
}