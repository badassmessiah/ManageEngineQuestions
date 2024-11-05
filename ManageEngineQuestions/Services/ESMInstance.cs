using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEngineQuestions.Services
{
    public class ESMInstance
    {
        public string Name { get; set; }
        public List<QuestionEntity> Questions { get; set; } = new();
    }
}