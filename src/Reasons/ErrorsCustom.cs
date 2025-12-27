namespace REsl.Result;

public class StartDateIsAfterEndDateError : Error
{
    public StartDateIsAfterEndDateError (DateTime startDate, DateTime endDate)
        : base ($"The start date {startDate} is after the end date {endDate}")
    {
        Metadata.Add ("ErrorCode", "12");
    }
}
