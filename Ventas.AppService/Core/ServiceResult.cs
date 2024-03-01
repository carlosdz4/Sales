using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.AppService.Core
{
    internal class ServiceResult
    {
        public string? Message { get; set; }
        public bool Success { get; set; }
        public dynamic? Data { get; set; }
    }
}
