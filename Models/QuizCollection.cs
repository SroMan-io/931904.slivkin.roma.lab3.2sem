namespace WebApplication1.Models
{
    public class QuizCollection
    {
       public List<Quiz> quiz = new List<Quiz>();
       public List<int> answers = new List<int>();
       public int questionsCount = 0;
       public int rightAnswersCount = 0;
       public void CountRightAnswers()
       {
            for (int i = 0; i < questionsCount; i++)
                if (quiz[i].res == answers[i]) rightAnswersCount++;
        }
        public void Clear()
        {
            questionsCount = 0; 
            rightAnswersCount = 0;
            quiz.Clear();
            answers.Clear();    
        }
    }
}
