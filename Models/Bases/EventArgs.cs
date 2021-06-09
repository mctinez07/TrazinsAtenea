using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Bases
{
    //Hasta aqui he añadido código.
    public class PropertyChangingCancelEventArgs : PropertyChangingEventArgs
    {
        public bool Cancel { get; set; }

        public PropertyChangingCancelEventArgs(string propertyName)
            : base(propertyName)
        {
        }
    }

    public class PropertyChangingCancelEventArgs<T> : PropertyChangingCancelEventArgs
    {
        public T OriginalValue { get; private set; }

        public T NewValue { get; private set; }

        public PropertyChangingCancelEventArgs(string propertyName, T originalValue, T newValue)
            : base(propertyName)
        {
            this.OriginalValue = originalValue;
            this.NewValue = newValue;
        }
    }

    public class PropertyChangedEventArgs<T> : PropertyChangedEventArgs
    {
        public T PreviousValue { get; private set; }

        public T CurrentValue { get; private set; }

        public PropertyChangedEventArgs(string propertyName, T previousValue, T currentValue)
            : base(propertyName)
        {
            this.PreviousValue = previousValue;
            this.CurrentValue = currentValue;
        }
    }

    public delegate void ModelEventHandler(object sender, ModelEventArgs e);

    public class ModelEventArgs : EventArgs
    {
        public ModelEventArgs(BaseModel model)
        {
            this.Model = model;
        }

        public BaseModel Model { get; protected set; }
    }
}
