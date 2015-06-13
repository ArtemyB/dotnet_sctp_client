﻿using Ostis.Sctp.Arguments;

namespace Ostis.Sctp.Commands
{
    /// <summary>
    /// Команда: Создание нового SC-узла указанного типа.
    /// </summary>
    public class CreateNodeCommand : Command
    {
        #region Параметры команды

        /// <summary>
        /// Тип создаваемого SC-узла.
        /// </summary>
        public ElementType NodeType
        { get { return nodeType; } }

        private readonly ElementType nodeType;

        #endregion
        
        /// <summary>
        /// ctor.
        /// </summary>
        /// <param name="nodeType">тип создаваемого SC-узла</param>
        public CreateNodeCommand(ElementType nodeType)
            : base(CommandCode.CreateNode)
        {
            Arguments.Add(new ElementTypeArgument(this.nodeType = nodeType));
        }
    }
}
