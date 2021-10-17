using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace FastBlazor
{
    public class FastEditor<T> : FastComponent
    {
        private T _value;

        [Parameter]
        public T Value
        {
            get { return _value; }
            set
            {
                if (!EqualityComparer<T>.Default.Equals(_value, value))
                {
                    _value = value;
                }
            }
        }

        [Parameter]
        public EventCallback<T> ValueChanged { get; set; }
    }
}