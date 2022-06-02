using Microsoft.AspNetCore.Components;
using PizzaPlace_2022.Shared;
namespace PizzaPlace_2022.Pages
{
    partial class CustomerEntry {

        private void FieldChanged(string fieldName)
        {
            CustomerChanged.InvokeAsync(Customer);
            isInvalid = !inputWatcher.Validate();
        }
        private InputWatcher inputWatcher = default!;
        bool isInvalid = true;

        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string Customer { get; set; } = default!;
        [Parameter]
        public EventCallback ValidSubmit { get; set; } = default!;
        [Parameter]
        public EventCallback<Customer> CustomerChanged { get; set; }
    }
   
}
