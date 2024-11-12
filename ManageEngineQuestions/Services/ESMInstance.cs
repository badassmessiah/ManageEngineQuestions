using System.Collections.Generic;

namespace ManageEngineQuestions.Services
{
    public class ESMInstance
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<QuestionEntity> Questions { get; set; } = new();
    }
}