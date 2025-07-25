using System.Net.Http.Json;

namespace CSCore.Ex
{
    public class SCS_ConsumingLogService : ICS_ConsumingLog
    {
        private static readonly HttpClient client = new()
        {
            BaseAddress = new Uri("http://docker.csicorpnet.com.br:7515/")
        };

        public async void CreateLogAsync(Dto_CreateLog dto, int tenant)
        {

            using var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/v1")
            {
                Content = JsonContent.Create(dto)
            };

            requestMessage.Headers.Add("Tenant_ID", tenant.ToString());

            await client.SendAsync(requestMessage);
        }
    }
}
