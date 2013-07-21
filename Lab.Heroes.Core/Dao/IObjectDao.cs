namespace Lab.Heroes.Core.Dao
{
    public interface IObjectDao<TObject>
    {
        TObject LoadBy(string id);
    }
}