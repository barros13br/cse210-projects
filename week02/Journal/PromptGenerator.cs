public class PromptGenerator
{
    public List<string> _prompt = new List<string>
        {
            "What are three things I’m grateful for today?",
            "What went well today, and why?",
            "What lessons did I learn this week?",
            "What am I currently struggling with, and how can I overcome it?",
            "How did I take care of myself today?",
            "What emotions did I feel most strongly today?",
            "What’s been making me feel overwhelmed recently?",
            "How do I want to feel tomorrow, and how can I make that happen?",
            "Who am I most thankful for today, and why?",
            "What’s one way I can show kindness to someone tomorrow?",
            "If money wasn’t an issue, how would I spend my time today?"
        };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string random_p = _prompt[random.Next(_prompt.Count)];
        return random_p;
    }
}