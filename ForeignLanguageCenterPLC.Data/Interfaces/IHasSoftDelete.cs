namespace ForeignLanguageCenterPLC.Infrastructure.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
