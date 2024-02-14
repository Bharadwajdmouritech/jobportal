using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JobPortalAPI.Models;

namespace JobPortalBlazor.Services
{
    public class AdminService
    {
        private HttpClient _httpClient;
        public AdminService(HttpClient httpClient){
            _httpClient = httpClient;
            // _httpClient.BaseAddress = new Uri("http://localhost:5242");
        }

        public async Task<List<Admin>> GetAdminData(){
            
            var response = await _httpClient.GetFromJsonAsync<List<Admin>>("http://localhost:5242/api/Admin/GetAllAdmin");
            return response;
        }
    }
}