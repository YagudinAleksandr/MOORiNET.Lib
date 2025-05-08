namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Ответ от API на переадресацию
    /// </summary>
    /// <typeparam name="TResponse">Тип ответа</typeparam>
    internal class ApiResponseRedirectDto<TResponse> where TResponse : class
    {
        /// <summary>
        /// Запрос
        /// </summary>
        public IApiRequestDto OriginRequest { get; set; }

        /// <summary>
        /// Ссылка перенаправления
        /// </summary>
        public string RedirectUrl { get; set; } = null!;
    }
}
