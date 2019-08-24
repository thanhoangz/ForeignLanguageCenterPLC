using ForeignLanguageCenterPLC.Infrastructure.Enums;

namespace ForeignLanguageCenterPLC.Infrastructure.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}
