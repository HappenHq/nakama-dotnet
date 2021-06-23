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

using System.Runtime.Serialization;
using Nakama;

namespace NakamaSync
{
    /// <summary>
    /// A data-transfer object corresponding to the outgoing value for a sync var.
    /// </summary>
    internal class SyncVarValue<T>
    {
        [DataMember(Name="key_validation_status"), Preserve]
        public KeyValidationStatus KeyValidationStatus { get; }

        [DataMember(Name="key"), Preserve]
        public VarKey Key { get; }

        [DataMember(Name="lock_version"), Preserve]
        public int LockVersion { get; }

        [DataMember(Name="value"), Preserve]
        public T Value { get; }

        public SyncVarValue(VarKey key, T value, int lockVersion, KeyValidationStatus keyValidationStatus, IUserPresence sender)
        {
            Key = key;
            Value = value;
            LockVersion = lockVersion;
            KeyValidationStatus = keyValidationStatus;
        }
    }
}