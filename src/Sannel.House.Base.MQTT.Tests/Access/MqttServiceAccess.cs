/* Copyright 2020-2020 Sannel Software, L.L.C.
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
      http://www.apache.org/licenses/LICENSE-2.0
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.*/

using Microsoft.Extensions.Logging;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using Sannel.House.Base.MQTT.Interfaces;
using System.Collections.Generic;

namespace Sannel.House.Base.MQTT.Tests.Access
{
	public class MqttServiceAccess : MqttService
	{
		public MqttServiceAccess(IMqttClient client, string defaultTopic, IMqttClientOptions options, IEnumerable<IMqttTopicSubscriber> subscribers, ILogger<MqttService> logger) : base(client, defaultTopic, options, subscribers, logger)
		{

		}
	}
}
