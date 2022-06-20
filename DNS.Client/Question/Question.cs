namespace DNS.Client;

public class Question
{
    public string Domain { get; set; }
    public QuestionType Type { get; set; }
    public QuestionClass Class { get; set; }
}