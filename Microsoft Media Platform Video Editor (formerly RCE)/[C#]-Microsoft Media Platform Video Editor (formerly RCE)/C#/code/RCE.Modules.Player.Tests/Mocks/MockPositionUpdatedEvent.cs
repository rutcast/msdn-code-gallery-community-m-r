// <copyright file="MockPositionUpdatedEvent.cs" company="Microsoft Corporation">
// ===============================================================================
//
//
// Project: Microsoft Silverlight Rough Cut Editor
// FILES: MockPositionUpdatedEvent.cs                     
//
// ===============================================================================
// Copyright 2010 Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
// ===============================================================================
// </copyright>

namespace RCE.Modules.Player.Tests.Mocks
{
    using System;
    using Infrastructure.Events;

    public class MockPositionUpdatedEvent : PositionUpdatedEvent
    {
        public bool PublishCalled { get; set; }

        public PositionPayloadEventArgs PublishArgumentPayload { get; set; }

        public EventHandler PublishCalledEvent { get; set; }

        public override void Publish(PositionPayloadEventArgs payload)
        {
            this.PublishCalled = true;
            this.PublishArgumentPayload = payload;
        }
    }
}