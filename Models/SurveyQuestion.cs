namespace NullableReferenceTypes.Edu
{
    public enum QuestionType
    {
        YesNo,
        Number,
        Text
    }

    public class SurveyQuestion
    {
        public string QuestionText { get; }
        public QuestionType TypeOfQuestion { get; }

        public SurveyQuestion(QuestionType type, string text)
        {
            QuestionText = text;
            TypeOfQuestion = type;            
        }
    }
}