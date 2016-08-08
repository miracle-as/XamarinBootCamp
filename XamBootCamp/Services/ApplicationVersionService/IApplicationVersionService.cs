namespace XamBootCamp
{
    public interface IApplicationVersionService
    {
        string ApplicationVersion { get; }
        string ApplicationBuildNumber { get; }
    }
}
