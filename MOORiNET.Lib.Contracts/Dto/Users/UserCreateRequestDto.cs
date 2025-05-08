using MOORiNET.Lib.Enums;

#nullable enable
namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Модель создания пользователя
    /// </summary>
    public class UserCreateRequestDto
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; } = null!;

        /// <summary>
        /// E-mail
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Статус активности <see cref="UserStatusEnum"/>
        /// </summary>
        public UserStatusEnum Status { get; set; }
    }
}
