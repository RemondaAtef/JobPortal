namespace WebAPI.BL.Interface
{
    public interface IUnitOfWork
    {
        IJobRep JobRep {  get; }
        IJobDetailsRep DetailsRep { get; }
        IApplicationRep ApplicationRep { get; }
        Task<bool> SaveAsync();
    }
}
