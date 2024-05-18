using System.Reflection;

public class PromptGen

{
    public List<string> _promp = [
        "What is the most interesting thing that happened to you today?",
        "What inspired you today?",
        "What did you create today?",
        "Who did you talk to today?",
        "How do you feel right now?",
        "Did you find anything you were looking for today?",
        "What the dog do?",
        "What were you reminded of today?",
        "What do you think tomorrow has in store for you?",
        "Have any of your thoughts changed today?",
        "Did you ever have a dreams?",
        "Tell me about your favorite thing that you experienced today."
    ];
    public Random _rng = new();
    
    public string GetPrompt()
    {
        int randPromp = _rng.Next(_promp.Count);
        return _promp[randPromp];
    }

    public List<string> _motivate = [
        "Starting and keeping a journal can be hard. A lot of people are held off by the idea of having to go back in time and write about previous events.\nWhen you're 25 and you can barely remember what happened to you at the age of 8, this seems tedious and daunting.\nHere is the real truth: you should just focus on today.\nThings will happen in your life that you will want to record, and you don't have to worry about going into the past right now.\nLet's start with today and go from there!",
        "Alma 37: 8: And now, it has hitherto been wisdom in God that these things should be preserved; for behold, they have enlarged the memory of this people...",
        "Take all of that noise in your mind, and press it into the page.",
        "This journal offers you a place to be whoever you want to be.",
        "With every word you write here, you are starting a voyage into yourself.",
        "This is a form of meditation. Pause, and listen to yourself.",
        "Did you think to pray?",
        "In 100 years, your journal becomes a celebration of who you are.",
        "Journaling is like whispering to yourself. Make sure to listen.",
        "Sometimes we don't know how we truly feel until we write it down.",
        "Don't worry. Just write.",
        "As you keep this journal, you will start to realize that every day has its own significance.",
        "Writing is something that is sustaining to the human soul.",
        "Journaling gives us a chance to experience life twice. One in the moment, and once in our retrospection."
    ];

    public string GetMotivation()
    {
        int randMotivate = _rng.Next(_motivate.Count);
        return _motivate[randMotivate];
    }
}