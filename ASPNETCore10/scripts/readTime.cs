var readWPM = 200;
var charInWord = 6;
var content = File.ReadAllText($"../ASPNETCore10/Content/Entries/{args[0]}.md");
var parts = content.Split("---");
var minutes = parts[2].Length / charInWord / readWPM;
System.Console.WriteLine($"{minutes} minutes");
