﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18010
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICSSoft.STORMNET.Business.Audit.Objects
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;


    // *** Start programmer edit section *** (Using statements)
    using System.Runtime.Serialization;
    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Режим записи данных аудита
    /// </summary>
    // *** Start programmer edit section *** (tWriteMode CustomAttributes)
    [DataContract]
    // *** End programmer edit section *** (tWriteMode CustomAttributes)
    public enum tWriteMode
    {

        /// <summary>
        /// Запись данных аудита синхронная
        /// </summary>
        // *** Start programmer edit section *** (tWriteMode.Synchronous CustomAttributes)
        [System.Runtime.Serialization.EnumMemberAttribute()]
        // *** End programmer edit section *** (tWriteMode.Synchronous CustomAttributes)
        [Caption("Синхронный")]
        Synchronous,

        /// <summary>
        /// Запись данных аудита асинхронная
        /// </summary>
        // *** Start programmer edit section *** (tWriteMode.Asynchronous CustomAttributes)
        [System.Runtime.Serialization.EnumMemberAttribute()]
        // *** End programmer edit section *** (tWriteMode.Asynchronous CustomAttributes)
        [Caption("Асинхронный")]
        Asynchronous,
    }
}
