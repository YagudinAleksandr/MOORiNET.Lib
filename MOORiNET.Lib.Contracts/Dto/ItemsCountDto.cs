namespace MOORiNET.Lib.Contracts.Dto
{
    /// <summary>
    /// Модель с количеством объектов
    /// </summary>
    /// <typeparam name="T">Тип данных</typeparam>
    public class ItemsCountDto<T>
    {
        /// <summary>
        /// Количество данных
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Массив данных
        /// </summary>
        public T[] Data { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="count">Количество данных</param>
        /// <param name="data">Массив данных</param>
        public ItemsCountDto(int count, T[] data) 
        {
            Count = count;
            Data = data;
        }
    }
}
