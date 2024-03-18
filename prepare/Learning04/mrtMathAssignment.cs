

public class mrtMathAssignment : mrtAssignment
{

 private string _textbookSection;
 private string _problems;
 public mrtMathAssignment(string p_textbookSection, string p_problems, string p_studentName, string p_topic) : base(p_studentName, p_topic)
 {
    _textbookSection = p_textbookSection;
    _problems = p_problems;
 }
 public string mrtGetHomeworkList()
 {
    string output = $"{mrtGetSummary()}\nSection: {_textbookSection}\nProblems: {_problems}";
    return output;
 }
}