using System.Collections.Generic;
using System.Net.Http;

namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Базовая модель запроса
    /// </summary>
    public interface IApiRequestDto
    {
        /// <summary>
        /// Точка входа в API
        /// </summary>
        string Endpoint { get; }

        /// <summary>
        /// Тип запроса
        /// </summary>
        HttpMethod Method { get; }

        /// <summary>
        /// Заголовки
        /// </summary>
        Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Тело запроса
        /// </summary>
        object Body { get; }

        /// <summary>
        /// Максимальное количество перенаправлений
        /// </summary>
        int MaxRedirects { get; }
    }
}
