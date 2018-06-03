﻿/**
 * Copyright 2018 The Nakama Authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Nakama
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Send a chat message to a channel on the server.
    /// </summary>
    public class ChannelSendMessage
    {
        [DataMember(Name="channel_id")]
        public string ChannelId { get; }

        [DataMember(Name="content")]
        public string Content { get; }

        public ChannelSendMessage(string channelId, string content)
        {
            ChannelId = channelId;
            Content = content;
        }

        public ChannelSendMessage(IChannel channel, string content) : this(channel.Id, content)
        {
        }

        public override string ToString()
        {
            return $"ChannelSendMessage[ChannelId={ChannelId}, Content={Content}]";
        }
    }
}
