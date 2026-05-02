namespace ResumeBuilder;

class Job
{
    public string Company = "";
    public List<Position> Positions = [];
    public bool Include, ShowDetails;
}

class Position
{
    public string Title = "";
    public (int, int) StartMonth, EndMonth;
    public List<string> Accomplishments = [];
}
