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

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaSync
{
    internal class HandshakeRequest
    {
        public List<SyncVarKey> AllKeys => _allKeys;

        [DataMember(Name="keys"), Preserve]
        private List<SyncVarKey> _allKeys;

        internal HandshakeRequest(List<SyncVarKey> allKeys)
        {
            _allKeys = allKeys;
        }
    }
}