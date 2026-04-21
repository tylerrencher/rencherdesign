using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;
using YamlDotNet.Serialization;

namespace RencherDesign.Domain
{
    public class JournalEntry
    {
        public string Title { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; } = new DateTime();
        public string Slug { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Lede { get; set; } = string.Empty;
        public List<string> InterestPoints { get; set; } = [];
        public string HeroImagePath { get; set; } = string.Empty;
        public string BodyHtml { get; set; } = string.Empty;
        public string ReadTimeMinutes { get; set; } = string.Empty;

        public JournalEntry(string contentPath)
        {
            if (string.IsNullOrWhiteSpace(contentPath))
            {
                return;
            }

            string content;
            try
            {
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
                ReadTimeMinutes = ObjectToString(RetrieveValue(metadata, "read-minutes"));
                HeroImagePath = $"images/entries/{Slug}-hero.jpg";
                var interestPoints = (RetrieveValue(metadata, "interest-points") as List<object>)
                    ?.Select(ObjectToString)
                    .ToList();
                if (interestPoints != null)
                {
                    InterestPoints = interestPoints;
                }
            }

            BodyHtml = document.ToHtml(pipeline);
        }

        private string ObjectToString(object? value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            else
            {
                return value.ToString() ?? string.Empty;
            }
        }

        private object? RetrieveValue(Dictionary<string, object> data, string key)
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
}
