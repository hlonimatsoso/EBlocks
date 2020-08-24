using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Pages.POC
{
    public class PocBase:ComponentBase
    {
       protected bool Opened = true;

        protected void ButtonClicked()
        {
            Opened = !Opened;
        }
    }
}
