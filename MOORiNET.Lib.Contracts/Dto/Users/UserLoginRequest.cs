namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Модель авторизации пользователя
    /// </summary>
    public class UserLoginRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;
    }
}
