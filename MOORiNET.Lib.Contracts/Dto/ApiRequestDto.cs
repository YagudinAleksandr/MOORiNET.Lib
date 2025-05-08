using System.Collections.Generic;
using System.Net.Http;

namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Запрос к API
    /// </summary>
    /// <typeparam name="TResponse">Тип ответа</typeparam>
    public abstract class ApiRequestDto<TResponse> : IApiRequestDto where TResponse : class
    {
        public abstract string Endpoint { get; }

        public virtual HttpMethod Method => HttpMethod.Get;
        public virtual Dictionary<string, string> Headers => new Dictionary<string, string>();
        
        /// <summary>
        /// Тело запроса опционально для POST/PUT
        /// </summary>
        public virtual object Body => null;
    }
}
