namespace REsl.Result;

public interface IError: IReason
{
    List<IError> Reasons { get; }
}