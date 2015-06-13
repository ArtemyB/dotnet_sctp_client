﻿using System;

namespace Ostis.Sctp.Arguments
{
    /// <summary>
    /// Аргумент типа события.
    /// </summary>
    public class EventsTypeArgument : IArgument
    {
        private EventsType eventsType;

        /// <summary>
		/// Тип события.
		/// </summary>
		public EventsType EventsType
		{
			get { return eventsType; }
			set { eventsType = value; }
		}

		/// <summary>
		/// ctor.
		/// </summary>
        /// <param name="eventsType">тип события</param>
        public EventsTypeArgument(EventsType eventsType)
		{
            this.eventsType = eventsType;
		}

        #region Реализация интерфеса IArgument

        /// <summary>
        /// Получить массив байт для передачи.
        /// </summary>
        public byte[] GetBytes()
        {
            var bytes = new byte[1];
            Array.Copy(BitConverter.GetBytes((byte) eventsType), bytes, 1);
            return bytes;
        }

        #endregion
    }
}