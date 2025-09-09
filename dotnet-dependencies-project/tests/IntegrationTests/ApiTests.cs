using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace dotnet_dependencies_project.tests.IntegrationTests
{
    public class ApiTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public ApiTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task GetUser_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/users/1");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task CreateUser_ReturnsCreatedStatusCode()
        {
            var content = new StringContent("{\"name\":\"Test User\",\"email\":\"test@example.com\"}", System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/api/users", content);
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetProduct_ReturnsSuccessStatusCode()
        {
            var response = await _client.GetAsync("/api/products/1");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task CreateProduct_ReturnsCreatedStatusCode()
        {
            var content = new StringContent("{\"name\":\"Test Product\",\"price\":9.99}", System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/api/products", content);
            response.EnsureSuccessStatusCode();
        }
    }
}