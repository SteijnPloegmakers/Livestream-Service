﻿using MediatR;

namespace Livestream.Application.Events
{
    public class LivestreamCreatedEvent : INotification
    {
        public Guid LivestreamId { get; set; }
        public string Name { get; set; } = null!;
        public decimal LivestreamNumber { get; set; }
    }

}
