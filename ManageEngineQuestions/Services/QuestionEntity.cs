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
        public List<string> CheckboxAnswers { get; set; }
        public List<string> DropdownOptions { get; set; }

        public QuestionEntity()
        {
            CheckboxAnswers = new List<string>();
            DropdownOptions = new List<string>();
        }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum QuestionType
    {
        Text,
        Checkbox,
        Dropdown
    }
}