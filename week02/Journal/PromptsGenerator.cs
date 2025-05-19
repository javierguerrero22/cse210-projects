using System;

public class PromptsGenerator
{
        // public string _prompts;
        public List<string> questions = new List<string>{ 

            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What moment made me feel most grateful today?",
            "What was the most important lesson I learned today?",
            "Did I overcome any challenges today?",
            "How did I positively impact someone today?",
            "What decision did I make today that made me feel proud?",
            "When did I feel peace and calm today?",
            "How did I stay true to my values or beliefs today?",
            "What was the most interesting or profound thought I had today?",
            "If I could keep one memory from today, what would it be?",
            "In what aspect of my life did I grow or improve today?"
        };
        public string GetRandomPrompt(){
            Random randomGenerator = new Random();
            return questions[randomGenerator.Next(questions.Count)]; 
            
        }
        
}