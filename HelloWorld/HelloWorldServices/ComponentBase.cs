using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldServices
{
    public class ComponentBase: BlazorComponent
    {
        public string Text { get; set; } = "Route Text";

        [Inject]
        protected IDataAccess Repository { get; set; }
    }
}
