//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// ServiceJob Service class
    /// </summary>
    public partial class ServiceJobService : Service<ServiceJob>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceJobService"/> class
        /// </summary>
        public ServiceJobService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceJobService"/> class
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ServiceJobService(IRepository<ServiceJob> repository) : base(repository)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceJobService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public ServiceJobService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( ServiceJob item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class ServiceJobExtensionMethods
    {
        /// <summary>
        /// Clones this ServiceJob object to a new ServiceJob object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static ServiceJob Clone( this ServiceJob source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as ServiceJob;
            }
            else
            {
                var target = new ServiceJob();
                target.IsSystem = source.IsSystem;
                target.IsActive = source.IsActive;
                target.Name = source.Name;
                target.Description = source.Description;
                target.Assembly = source.Assembly;
                target.Class = source.Class;
                target.CronExpression = source.CronExpression;
                target.LastSuccessfulRunDateTime = source.LastSuccessfulRunDateTime;
                target.LastRunDateTime = source.LastRunDateTime;
                target.LastRunDurationSeconds = source.LastRunDurationSeconds;
                target.LastStatus = source.LastStatus;
                target.LastStatusMessage = source.LastStatusMessage;
                target.LastRunSchedulerName = source.LastRunSchedulerName;
                target.NotificationEmails = source.NotificationEmails;
                target.NotificationStatus = source.NotificationStatus;
                target.Id = source.Id;
                target.Guid = source.Guid;

            
                return target;
            }
        }
    }
}
