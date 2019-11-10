using System.Collections.Generic;

namespace NullableReferenceTypes.Edu
{
    public class SurveyRun
    {
        private List<SurveyQuestion> _surveyQuestions = new List<SurveyQuestion>();

        public void AddQuestion(QuestionType type, string text)
        {
            AddQuestion(new SurveyQuestion(type, text));
        }

        public void AddQuestion(SurveyQuestion question)
        {
            _surveyQuestions.Add(question);
        }
    }
}