﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.Sistema.Domain.Core.Events
{
    public abstract class Message : IRequest
    {
        public Guid AggregateId { get; protected set; }
        public string MessageType { get; protected set; }

        protected Message() => MessageType = GetType().Name;
    }
}
