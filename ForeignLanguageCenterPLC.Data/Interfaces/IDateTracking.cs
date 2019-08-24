using System;

namespace ForeignLanguageCenterPLC.Infrastructure.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}
