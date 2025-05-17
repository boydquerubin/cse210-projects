using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who did you talk to today and what did you talk about?",
        "What is something you're grateful for today?",
        "What was a challenge you faced today?",
        "Describe a moment that made you smile today.",
        "What is one goal you want to achieve this week?",
        "How did you see the hand of the Lord in your life today?",
        "Did you see anything interesting today?",
        "Did you eat or drink anything delicious today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
