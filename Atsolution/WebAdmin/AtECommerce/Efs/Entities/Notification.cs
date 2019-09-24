using System;
using System.Collections.Generic;

namespace GenEf.Efs.Entities
{
    public partial class Notification
    {
        public string NotificationId { get; set; }
        public string RefId { get; set; }
        public string RefNo { get; set; }
        public int? RefType { get; set; }
        public string UserName { get; set; }
        public DateTime? RefDate { get; set; }
        public string Description { get; set; }
        public int? NotificationType { get; set; }
        public string BranchId { get; set; }
        public int? DisplayOnBook { get; set; }
        public string UserHasVisited { get; set; }
        public string NotificationIsmacId { get; set; }
        public string Title { get; set; }
        public string SubContent { get; set; }
        public string ThumbnailsImage { get; set; }
    }
}
