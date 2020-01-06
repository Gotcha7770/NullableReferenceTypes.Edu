using NullableReferenceTypes.Edu.Models;
using System.Collections.Generic;
using System.Linq;

namespace NullableReferenceTypes.Edu
{
    public class SurveyRun
    {
        private List<SurveyQuestion> _surveyQuestions = new List<SurveyQuestion>();
        private List<SurveyResponse>? respondents;

        public void AddQuestion(QuestionType type, string text)
        {
            AddQuestion(new SurveyQuestion(type, text));
        }

        public void AddQuestion(SurveyQuestion question)
        {
            _surveyQuestions.Add(question);
        }
        
        public void PerformSurvey(int numberOfRespondents)
        {
            int repondentsConsenting = 0;
            respondents = new List<SurveyResponse>();

            while (repondentsConsenting < numberOfRespondents)
            {
                var respondent = SurveyResponse.GetRandomId();
                if (respondent.AnswerSurvey(_surveyQuestions))
                    repondentsConsenting++;

                respondents.Add(respondent);
            }
        }

        public IEnumerable<SurveyResponse> AllParticipants => respondents ?? Enumerable.Empty<SurveyResponse>();

        public ICollection<SurveyQuestion> Questions => _surveyQuestions;

        public SurveyQuestion GetQuestion(int index) => _surveyQuestions[index];
    }
}