namespace CRM.Core;

public interface ITimeProvider
{
    DateTimeOffset Get();
}
