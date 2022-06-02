﻿using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
namespace PizzaPlace_2022.Pages
{
    public partial class ItemList<ITem>
    {
        [Parameter]
        public RenderFragment? Header { get; set; }
        [Parameter]
        public RenderFragment<TItem> RowTemplate { get; set; } = default!;
        [Parameter]
        public RenderFragment? Footer { get; set; }
        [Parameter]
        public IEnumerable<TItem> Items { get; set; } = default!;

    }
}
