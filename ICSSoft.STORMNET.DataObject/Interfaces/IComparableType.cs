﻿namespace ICSSoft.STORMNET
{
    /// <summary>
    /// Интерфейс для пользовательских типов, которые должны иметь специальную логику сравнения (по умолчанию для кастом-типов вызывается ToString() и сравнение по строкам). Сравнение выполняется хотя бы для определения изменённых свойств.
    /// </summary>
    public interface IComparableType
    {
        /// <summary>
        /// Сравнить текущий объект с переданным параметром. Если 0, значит объекты равны.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        int Compare(object x);
    }
}
