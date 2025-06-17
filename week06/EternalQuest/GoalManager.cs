class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options:");
            Console.WriteLine("   1. Create Goal");
            Console.WriteLine("   2. List Goal ");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are: ");
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            Console.WriteLine();
        }
        Console.WriteLine("See you next time!");
    }
    public void DisplayPlayerInfo() {Console.WriteLine($"You have {_score} points.\n");}
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1 - Simple goal");
        Console.WriteLine("   2 - Eternal goal");
        Console.WriteLine("   3 - Checklist goal");
        Console.WriteLine("   4 - Negative goal");
        Console.Write("Which type of Goal do you want to create?: ");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?: ");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?: ");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points, isComplete: false);
        }
        else if (choice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus, completed: 0);
        }
        else if (choice == 4)
        {
            newGoal = new NegativeGoal(name, description, points);
        }

        _goals.Add(newGoal);
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("Which goal did you accomplish?: ");

        int choice = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[choice - 1];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("This goal is already completed and cannot be recorded again.");
        }
        else
        {
            selectedGoal.RecordEvent();
            if (selectedGoal is NegativeGoal)
            {
                _score -= selectedGoal.GetPoints();
                Console.WriteLine($"You lost {selectedGoal.GetPoints()} points! Try to avoid this habit.");
            }
            else
            {
                _score += selectedGoal.GetPoints();
                Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetPoints()} points!");
            }
            Console.WriteLine($"You now have {_score} points");
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved");
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty or not found.");
        }
        else if (lines.Length != 0)
        {
            _score += int.Parse(lines[0]);
            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                string name = parts[1];
                string description = parts[2];
                string type = parts[0];
                int points = int.Parse(parts[3]);

                Goal newGoal = null;
                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    newGoal = new SimpleGoal(name, description, points, isComplete);
                }
                else if (type == "EternalGoal")
                {
                    newGoal = new EternalGoal(name, description, points);
                }
                else if (type == "ChecklistGoal")
                {
                    int target = int.Parse(parts[5]);
                    int completed = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[6]);
                    newGoal = new ChecklistGoal(name, description, points, target, bonus, completed);
                }
                else if (type == "NegativeGoal")
                {
                    newGoal = new NegativeGoal(name, description, points);
                }

                if (newGoal != null)
                {
                    _goals.Add(newGoal);
                }
            }
        }     
    }
}