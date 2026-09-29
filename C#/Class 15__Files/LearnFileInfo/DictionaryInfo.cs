internal class DirectoryInfo
{
    internal readonly bool Exists;

    public DirectoryInfo(string v)
    {
    }

    public string FullName { get; internal set; }

    internal void Create()
    {
        throw new NotImplementedException();
    }
}