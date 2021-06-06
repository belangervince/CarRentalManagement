using Microsoft.AspNetCore.Components;
using System;
using Toolbelt.Blazor;

namespace CarRentalManagement.Client.Services
{
    public class HttpInterceptorService
    {
        private readonly HttpClientInterceptor interceptor;
        private readonly NavigationManager navigationManager;

        public HttpInterceptorService(HttpClientInterceptor interceptor, NavigationManager navigationManager)
        {
            this.interceptor = interceptor;
            this.navigationManager = navigationManager;
        }

        public void MonitorEvent() => this.interceptor.AfterSend += InterceptResponse;

        public void DisposeEvent() => this.interceptor.AfterSend -= InterceptResponse;

        private void InterceptResponse(object sender, HttpClientInterceptorEventArgs e)
        {
            string message = string.Empty;
            if (!e.Response.IsSuccessStatusCode)
            {
                var responseCode = e.Response.StatusCode;
                switch (responseCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        navigationManager.NavigateTo("/404");
                        //message = "The requested resource was not found.";
                        break;
                    case System.Net.HttpStatusCode.Unauthorized:
                    case System.Net.HttpStatusCode.Forbidden:
                        navigationManager.NavigateTo("/Unauthorized");
                        //message = "The requested resource was not found.";
                        break;
                    default:
                        navigationManager.NavigateTo("/500");
                        //message = "Something went wrong, please contact Administrator.";
                        break;
                }
            }
        }
    }
}
