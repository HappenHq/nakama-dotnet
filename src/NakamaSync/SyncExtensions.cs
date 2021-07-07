/**
* Copyright 2021 The Nakama Authors
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

using System.Threading.Tasks;
using Nakama;

namespace NakamaSync
{
    public static class SyncExtensions
    {
        // todo don't require session as a parameter here since we pass it to socket.

        // todo put reflection version here?
        public static async Task<IMatch> CreateSyncMatch(this ISocket socket, ISession session, SyncOpcodes opcodes, SyncVarRegistry registry)
        {
            var presenceTracker = new PresenceTracker(session.UserId);
            socket.ReceivedMatchPresence += presenceTracker.HandlePresenceEvent;
            IMatch match = await socket.CreateMatchAsync();
            var syncSocket = new SyncSocket(socket, match, opcodes, presenceTracker);
            var syncMatch = new SyncMatch(session, syncSocket, registry, presenceTracker);
            presenceTracker.ReceiveMatch(match);
            return match;
        }

        public static async Task<IMatch> JoinSyncMatch(this ISocket socket, ISession session, SyncOpcodes opcodes, string matchId, SyncVarRegistry registry)
        {
            var presenceTracker = new PresenceTracker(session.UserId);
            socket.ReceivedMatchPresence += presenceTracker.HandlePresenceEvent;
            IMatch match = await socket.JoinMatchAsync(matchId);
            var syncSocket = new SyncSocket(socket, match, opcodes, presenceTracker);
            var syncMatch = new SyncMatch(session, syncSocket, registry, presenceTracker);
            presenceTracker.ReceiveMatch(match);
            return match;
        }
    }
}