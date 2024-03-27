using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using Ventas.AppService.Models.Result;
using VentaWeb.Models;
using VentaWeb.Models.Result;

namespace VentaWeb.Services
{
    public class VentaApiService : IVentaService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger logger;
        private readonly IHttpClientFactory clientFactory;
        private string BaseUrl;

        public VentaApiService(IConfiguration configuration , ILogger<VentaApiService> logger , IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.clientFactory = clientFactory;
            this.BaseUrl = this.configuration["ApiConfig:baseUrl"];
        }
        public async Task<GetResult<List<VentaModel>>> GetVentas()
        {
           GetResult<List<VentaModel>> result = new GetResult<List<VentaModel>>();

            try
            {
                using (var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.BaseUrl}Venta/GetVentas";

                    using (var response = await httpclient.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<GetResult<List<VentaModel>>>(resp);
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
                result.message = "error a mostra Venta";
                this.logger.LogError(result.message, ex.ToString());
                throw;
            }

            return result;

            
        }

        public async Task<GetResult<VentaModel>> VentaById(VentaSearch search)
        {

            GetResult<VentaModel> result = new GetResult<VentaModel>();


            try
            {
                using (var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.BaseUrl}Venta/GetVentaById";

                    StringContent content = new StringContent(JsonSerializer.Serialize(search.search), Encoding.UTF8, "application/json");

                    using (var response = await httpclient.PostAsync(url, content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<GetResult<VentaModel>>(resp);
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

        public async Task<ServicioResult> VentaAdd(VentaCreateModel CreateVenta)
        {
            ServicioResult result = new ServicioResult();

            try
            {
                using (var httpclient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.BaseUrl}Venta/AddVenta";

                    StringContent content = new StringContent(JsonSerializer.Serialize(CreateVenta), Encoding.UTF8, "application/json");
                    string resp = string.Empty;
                    using (var response = await httpclient.PostAsync(url, content))
                    {
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
                                result.message = "Error conectandose al end point de Save Venta.";
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                result.success = false;
                result.message = "Error guardando el Venta.";
                this.logger.LogError(result.message, ex.ToString()); ;
            }


            return result;
        }
    }
}
