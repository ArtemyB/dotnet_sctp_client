﻿using Ostis.Sctp.Arguments;

namespace Ostis.Sctp.Responses
{
    /// <summary>
    /// Ответ на команду: Поиск SC-элемента по его системному идентификатору.
    /// </summary>
    public class FindElementResponse : Response
    {
        /// <summary>
        /// Найденный адрес.
        /// </summary>
        public ScAddress FoundAddress
        { get { return address; } }

               private readonly ScAddress address;

        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="bytes">массив байт</param>
        public FindElementResponse(byte[] bytes)
            : base(bytes)
        {
            if (Header.ReturnCode == ReturnCode.Successfull)
            {
                address = ScAddress.Parse(bytes, SctpProtocol.HeaderLength);
            }
        }
    }
}
