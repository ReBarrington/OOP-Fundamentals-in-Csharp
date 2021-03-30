using System;
using System.Collections.Generic;
using System.Text;

namespace ACM
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; set; }
        public bool IsValid => Validate();

        public abstract bool Validate();
        // will be overridden by class' polymorphic Validate()
        // abstract methods have no default implementation, 
        // no body needed, just ;


    }
}
