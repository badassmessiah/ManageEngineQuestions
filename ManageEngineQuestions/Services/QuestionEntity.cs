using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ManageEngineQuestions.Services
{
    public class QuestionEntity
    {
        public string Question { get; set; }
        public string Explanation { get; set; }
        public QuestionType Type { get; set; }
        public string TextAnswer { get; set; }
        public List<string> DropdownOptions { get; set; } = new();
        public List<string> CheckboxAnswers { get; set; } = new();

        // Add this property to map answers to child questions
        public Dictionary<string, List<QuestionEntity>> ChildQuestionsByAnswer { get; set; } = new();

        // Constructor
        public QuestionEntity()
        {
            CheckboxAnswers = new List<string>();
            DropdownOptions = new List<string>();
            ChildQuestionsByAnswer = new Dictionary<string, List<QuestionEntity>>();
        }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QuestionType
    {
        Text,
        Dropdown
    }
}