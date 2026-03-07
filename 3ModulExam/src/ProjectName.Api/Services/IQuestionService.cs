using ProjectName.Api.Entities;

namespace ProjectName.Api.Services;

public interface IQuestionService
{


    public bool isCorrect(bool IsCorrect , string CorrectAnswer);

    public bool SolveQuestion(Question question);

    public int CountOfQuestio(Question question);


}
