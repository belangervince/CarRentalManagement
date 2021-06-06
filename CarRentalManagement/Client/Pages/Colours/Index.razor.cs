using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colours
{
    public partial class Index
    {
        [Inject]
        IHttpRepository<Colour> _client { get; set; }

        [Inject]
        IJSRuntime _js { get; set; }

        private IList<Colour> Colours;

        protected async override Task OnInitializedAsync()
        {
            Colours = await _client.GetAll($"{Endpoints.ColoursEndpoint}");
        }

        async Task Delete(int id)
        {
            var colour = Colours.First(q => q.Id == id);
            var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?");
            if (confirm)
            {
                await _client.Delete($"{Endpoints.ColoursEndpoint}{id}", id);
                await OnInitializedAsync();
            }
        }
    }
}
