using System.Collections.Generic;

#nullable enable
namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Базовый ответ API
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponseDto<T>
    {
        /// <summary>
        /// Код ответа
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Данные
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Коллекция ошибок
        /// </summary>
        public Dictionary<string, string> Errors { get; set; } = new Dictionary<string, string>();
    }
}
