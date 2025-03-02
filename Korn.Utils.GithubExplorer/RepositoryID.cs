namespace Korn.Utils.GithubExplorer
{
    public class RepositoryID
    {
        public RepositoryID(string owner, string name)
            => (Owner, Name) = (owner, name);

        public string Owner;
        public string Name;
    }
}