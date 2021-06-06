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
    public partial class Index : IDisposable
    {
        [Inject] 
        HttpClient _client { get; set; }

        [Inject]
        IJSRuntime _js { get; set; }

        [Inject]
        HttpInterceptorService _interceptor { get; set; }

        private List<Colour> Colours;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            Colours = await _client.GetFromJsonAsync<List<Colour>>($"{Endpoints.ColoursEndpoint}");
        }

        async Task Delete(int id)
        {
            _interceptor.MonitorEvent();
            var colour = Colours.First(q => q.Id == id);
            var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ColoursEndpoint}{id}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
