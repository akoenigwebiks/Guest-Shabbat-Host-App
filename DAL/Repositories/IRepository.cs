namespace Guest_Shabbat_Host_App.DAL.Repositories
{
    public interface IRepository<T>
    {
        List<T> FindAll();
        T FindById(int id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
