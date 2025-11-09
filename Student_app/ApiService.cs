using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Student_app.Models;

namespace Student_app
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        private const string BaseApiUrl = "https://localhost:7264/";

        public ApiService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseApiUrl)
            };
        }
        public async Task<LoginResponse?> LoginAsync(string username, string password)
        {
            var request = new LoginRequest { TenDangNhap = username, MatKhau = password };

            var response = await _httpClient.PostAsJsonAsync("/Controller_main/login", request);

            if (response.IsSuccessStatusCode)
            {
                var loginResponse = await response.Content.ReadFromJsonAsync<LoginResponse>();
                return loginResponse;
            }

            return null;
        }
    }
}
