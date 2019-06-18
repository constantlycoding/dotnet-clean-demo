using System;

namespace CleanDemoProject.Core.Entities
{
    public class Interest
    {
        public string CustomerEmailAddress { get; set; }
        public long CustomerPhoneNumber { get; set; }
        public DateTime CreationDate { get; set; }
    }
}