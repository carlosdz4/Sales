using System.Text;
using System.Text.Json;
using Ventas.AppService.Models.Result;
using VentaWeb.Models;

namespace VentaWeb.Services
{
    public class NegocioApiService : INegocioService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<NegocioApiService> logger;
        private readonly IHttpClientFactory clientFactory;
        private string baseUrl;
        public NegocioApiService(
            IConfiguration configuration,
            ILogger<NegocioApiService> logger,
            IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.clientFactory = clientFactory;
            this.baseUrl = this.configuration["ApiConfig:baseUrl"];
        }

        public async Task<GetNegocioResult<NegocioModel>> GetNegocioByName(NegocioSearch name)
        {
            GetNegocioResult<NegocioModel> result = new GetNegocioResult<NegocioModel>();


            try
            {
                using (var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}Negocio/GetNegocioByName";

                    StringContent content = new StringContent(JsonSerializer.Serialize(name.name), Encoding.UTF8, "application/json");

                    using (var response = await httpclient.PostAsync(url,content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<GetNegocioResult<NegocioModel>>(resp);
                        }
                        else
                        {
                            result.success = false;
                            result.message = "Error a conectar con la API";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = "error al mostrar el negocio";

                this.logger.LogError(result.message, ex.ToString());
                throw;
            }

            return result;

        }

        public async Task<GetNegocioResult<List<NegocioModel>>> GetNegocios()
        {
            GetNegocioResult<List<NegocioModel>> result = new GetNegocioResult<List<NegocioModel>>();


            try
            {
                using (var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}Negocio/GetNegocio";

                    using (var response = await httpclient.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<GetNegocioResult<List<NegocioModel>>>(resp);
                        }
                        else
                        {
                            result.success = false;
                            result.message = "Error a conectar con la API";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = "error al mostrar el negocio";

                this.logger.LogError(result.message, ex.ToString());
                throw;
            }

            return result;
        }

        public async Task<ServicioResult> SaveNegocio(NegocioModel Createnegocio)
        {
            ServicioResult result = new ServicioResult();

            try
            {
                using(var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}Negocio/AddNegocio";

                    StringContent content = new StringContent(JsonSerializer.Serialize(Createnegocio) , Encoding.UTF8 , "application/json");
                    string resp = string.Empty;
                    using (var response = await httpclient.PostAsync(url , content)) { 
                        if (response.IsSuccessStatusCode)
                        {
                            resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<ServicioResult>(resp);
                            result.success = true;
                        }
                        else
                        {
                            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                            {
                                resp = await response.Content.ReadAsStringAsync();
                                result = JsonSerializer.Deserialize<ServicioResult>(resp);
                                return result;
                            }
                            else
                            {
                                result.success = false;
                                result.message = "Error conectandose al end point de Save Negocio.";
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                result.success = false;
                result.message = "Error guardando el Negocio.";
                this.logger.LogError(result.message, ex.ToString()); ;
            }


            return result;
        }
    }
}
