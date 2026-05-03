namespace ResumeBuilder;

class Job(string company)
{
    public string Company = company;
    public List<Position> Positions = [];
    public bool Include, ShowDetails;
}

class Position(string title, (int, int) startMonth, (int, int) endMonth)
{
    public string Title = title;
    public (int, int) StartMonth = startMonth, EndMonth = endMonth;
    public List<string> Accomplishments = [];
}
