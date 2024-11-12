using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ManageEngineQuestions.Services
{
    public class QuestionEntity
    {
        public string Question { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public QuestionType Type { get; set; }
        public string TextAnswer { get; set; } = string.Empty;
        public List<string> DropdownOptions { get; set; } = new();
        public List<string> CheckboxAnswers { get; set; } = new();
        public Dictionary<string, List<QuestionEntity>> ChildQuestionsByAnswer { get; set; } = new();
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QuestionType
    {
        Text,
        Dropdown
    }
}