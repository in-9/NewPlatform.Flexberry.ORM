﻿namespace ICSSoft.STORMNET.Windows.Forms.Binders
{
    using System;

    /// <summary>
    /// Атрибут, позволяющий указать ControlProvider для типа
    /// </summary>
    public class ControlProviderAttribute : Attribute
    {
        /// <summary>
        /// Тип ControlProvider'а
        /// </summary>
        public Type ControlProviderType;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="provType">Тип ControlProvider'а</param>
        public ControlProviderAttribute(Type provType)
        {
            ControlProviderType = provType;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="typeName">Тип ControlProvider'а строкой.</param>
        public ControlProviderAttribute(string typeName)
        {
            try
            {
                var type = Type.GetType(typeName, true);
                ControlProviderType = type;
            }
            catch (Exception exception)
            {
                throw new TypeLoadException("Ошибка загрузки типа провайдера элемента управления.", exception);
            }
        }
    }
}