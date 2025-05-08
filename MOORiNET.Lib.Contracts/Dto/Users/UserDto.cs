using System;
using MOORiNET.Lib.Enums;

#nullable enable
namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Модель пользователя
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// ФИО
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// E-mail
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public UserStatusEnum Staus { get; set; }
    }
}
