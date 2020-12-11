/**
 * Copyright 2020 The Nakama Authors
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

using System.Runtime.Serialization;

namespace Nakama.SocketInternal
{
    /// <summary>
    /// An envelope for messages received or sent on a <c>WebSocket</c>.
    /// </summary>
    public class WebSocketMessageEnvelope
    {
        [DataMember(Name="cid"), Preserve]
        public string Cid { get; set; }

        [DataMember(Name="channel"), Preserve]
        public Channel Channel { get; set; }

        [DataMember(Name="channel_join"), Preserve]
        public ChannelJoinMessage ChannelJoin { get; set; }

        [DataMember(Name="channel_leave"), Preserve]
        public ChannelLeaveMessage ChannelLeave { get; set; }

        [DataMember(Name="channel_message"), Preserve]
        public ApiChannelMessage ChannelMessage { get; set; }

        [DataMember(Name="channel_message_ack"), Preserve]
        public ChannelMessageAck ChannelMessageAck { get; set; }

        [DataMember(Name="channel_message_remove"), Preserve]
        public ChannelRemoveMessage ChannelMessageRemove { get; set; }

        [DataMember(Name="channel_message_send"), Preserve]
        public ChannelSendMessage ChannelMessageSend { get; set; }

        [DataMember(Name="channel_message_update"), Preserve]
        public ChannelUpdateMessage ChannelMessageUpdate { get; set; }

        [DataMember(Name="channel_presence_event"), Preserve]
        public ChannelPresenceEvent ChannelPresenceEvent { get; set; }

        [DataMember(Name="error"), Preserve]
        public WebSocketErrorMessage Error { get; set; }

        [DataMember(Name="matchmaker_add"), Preserve]
        public MatchmakerAddMessage MatchmakerAdd { get; set; }

        [DataMember(Name="matchmaker_matched"), Preserve]
        public MatchmakerMatched MatchmakerMatched { get; set; }

        [DataMember(Name="matchmaker_remove"), Preserve]
        public MatchmakerRemoveMessage MatchmakerRemove { get; set; }

        [DataMember(Name="matchmaker_ticket"), Preserve]
        public MatchmakerTicket MatchmakerTicket { get; set; }

        [DataMember(Name="match"), Preserve]
        public Match Match { get; set; }

        [DataMember(Name="match_create"), Preserve]
        public MatchCreateMessage MatchCreate { get; set; }

        [DataMember(Name="match_join"), Preserve]
        public MatchJoinMessage MatchJoin { get; set; }

        [DataMember(Name="match_leave"), Preserve]
        public MatchLeaveMessage MatchLeave { get; set; }

        [DataMember(Name="match_presence_event"), Preserve]
        public MatchPresenceEvent MatchPresenceEvent { get; set; }

        [DataMember(Name="match_data"), Preserve]
        public MatchState MatchState { get; set; }

        [DataMember(Name="match_data_send"), Preserve]
        public MatchSendMessage MatchStateSend { get; set; }

        [DataMember(Name="notifications"), Preserve]
        public ApiNotificationList NotificationList { get; set; }

        [DataMember(Name="rpc"), Preserve]
        public ApiRpc Rpc { get; set; }

        [DataMember(Name="status"), Preserve]
        public Status Status { get; set; }

        [DataMember(Name="status_follow"), Preserve]
        public StatusFollowMessage StatusFollow { get; set; }

        [DataMember(Name="status_presence_event"), Preserve]
        public StatusPresenceEvent StatusPresenceEvent { get; set; }

        [DataMember(Name="status_unfollow"), Preserve]
        public StatusUnfollowMessage StatusUnfollow { get; set; }

        [DataMember(Name="status_update"), Preserve]
        public StatusUpdateMessage StatusUpdate { get; set; }

        [DataMember(Name="stream_presence_event"), Preserve]
        public StreamPresenceEvent StreamPresenceEvent { get; set; }

        [DataMember(Name="stream_data"), Preserve]
        public StreamState StreamState { get; set; }

        public override string ToString()
        {
            return "WebSocketMessageEnvelope";
        }
    }
}
