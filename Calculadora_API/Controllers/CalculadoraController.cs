using System.Collections.Generic;
using System.Web.Http;
using Calculadora_API.Models;

namespace Calculadora_API.Controllers
{
    public class CalculadoraController : ApiController
    {
        public Operacion op = new Operacion("", 0, 0);

        // GET: api/Calculadora
        public List<string> Get()
        {
            var operationList = new List<string>();
            operationList.Add("Suma");
            operationList.Add("Resta");
            operationList.Add("Multiplicacion");
            operationList.Add("Division");
            return operationList;
        }

        // POST: api/Calculadora/
        public Operacion Post([FromBody] Operacion newOperador)
        {
            newOperador = newOperador.procesar(newOperador);
            op = newOperador;
            return op;
        }

        // PUT: api/Calculadora/5
        public Operacion Put([FromBody] Operacion newOperador)
        {
            newOperador = newOperador.procesar(newOperador);
            op = newOperador;
            return op;
        }
    }
}