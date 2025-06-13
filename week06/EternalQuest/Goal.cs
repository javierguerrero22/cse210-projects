class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start() { /* Lógica de inicialización */ }
    public void DisplayPlayerInfo() { /* Mostrar información del jugador */ }
    public void ListGoalNames() { /* Mostrar nombres de los objetivos */ }
    public void ListGoalDetails() { /* Mostrar detalles de los objetivos */ }
    public void CreateGoal() { /* Crear un nuevo objetivo */ }
    public void RecordEvent(string goalName) { /* Registrar evento */ }
    public void SaveGoals() { /* Guardar objetivos en archivo */ }
    public void LoadGoals() { /* Cargar objetivos desde archivo */ }
}

abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString() => $"{_shortName}: {_description} ({_points} pts)";
    public virtual string GetStringRepresentation() => $"{_shortName}, {_description}, {_points}";
}

class SimpleGoal : Goal
{
    private bool _isComplete;

    public override void RecordEvent() => _isComplete = true;
    public override bool IsComplete() => _isComplete;
    public override string GetStringRepresentation() => $"{base.GetStringRepresentation()}, {_isComplete}";
}

class EternalGoal : Goal
{
    public override void RecordEvent() { /* Lógica para registrar evento */ }
    public override bool IsComplete() => false;
    public override string GetStringRepresentation() => $"{base.GetStringRepresentation()}, Never Complete";
}

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target) _points += _bonus;
    }

    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetDetailsString() => $"{base.GetDetailsString()} - { _amountCompleted}/{_target} completado";
    public override string GetStringRepresentation() => $"{base.GetStringRepresentation()}, {_amountCompleted}, {_target}, {_bonus}";
}