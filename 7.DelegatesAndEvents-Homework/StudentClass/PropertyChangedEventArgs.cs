using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentClass
{
    public class PropertyChangedEventArgs : EventArgs
    {
        public PropertyChangedEventArgs(string propName, object oldValue, object newValue)
        {
            this.PropertyName = propName;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName { get; set; }

        public object OldValue { get; set; }

        public object NewValue { get; set; }
    }
}
