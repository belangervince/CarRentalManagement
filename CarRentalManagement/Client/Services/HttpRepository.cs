using CarRentalManagement.Client.Contracts;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Services
{
    public class HttpRepository<T> : IDisposable, IHttpRepository<T> where T : class
    {
        public HttpClient HttpClient { get; }
        public HttpInterceptorService Service { get; }

        public HttpRepository(HttpClient httpClient, HttpInterceptorService service)
        {
            HttpClient = httpClient;
            Service = service;
        }

        public async Task Create(string url, T obj)
        {
            Service.MonitorEvent();
            await HttpClient.PostAsJsonAsync(url, obj);
        }

        public async Task Delete(string url, int id)
        {
            Service.MonitorEvent();
            await HttpClient.DeleteAsync($"{url}{id}");
        }

        public async Task<T> Get(string url, int id)
        {
            Service.MonitorEvent();
            return await HttpClient.GetFromJsonAsync<T>($"{url}{id}");
        }

        public async Task<IList<T>> GetAll(string url)
        {
            Service.MonitorEvent();
            return await HttpClient.GetFromJsonAsync<IList<T>>(url);
        }

        public async Task Update(string url, T obj, int id)
        {
            Service.MonitorEvent();
            await HttpClient.PutAsJsonAsync($"{url}{id}", obj);
        }

        public void Dispose()
        {
            Service.DisposeEvent();
        }
    }
}
