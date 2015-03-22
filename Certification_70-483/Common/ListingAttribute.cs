using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certification.Common
{
    /// <summary>
    /// An attribute for the listing classes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ListingAttribute : Attribute
    {
        public string Description { get; set; }

        public ListingAttribute(string description)
        {
            this.Description = description;
        }
    }
}
