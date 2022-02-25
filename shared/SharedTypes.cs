namespace shared;
public record Location(int row, int column);
public record EnlistRequest(string host, int port);
public class Cell
{
    public Location location {get; set;}
    public bool isPillAvailable {get; set;}
    public OccupiedBy occupiedBy {get; set;}
}
public class OccupiedBy
{
    public int id {get; set;}
    public string name {get; set;}
    public int score {get; set;}
}

public class Worker
{
    public string workerName { get; set;}
    public int workerID {get; set;}
    public Location workerLocation { get; set;}
}

public class State
{
    public string gameState {get; set;}
}
public class Status
{
    public State currentState {get; set;}
    public Location Destination {get; set;}
}

