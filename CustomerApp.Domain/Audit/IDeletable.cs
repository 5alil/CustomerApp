using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp.Domain.Audit
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
    }
}
