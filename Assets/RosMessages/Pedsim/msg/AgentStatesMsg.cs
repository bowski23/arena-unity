//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.Pedsim
{
    [Serializable]
    public class AgentStatesMsg : Message
    {
        public const string k_RosMessageName = "pedsim_msgs/AgentStates";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        public AgentStateMsg[] agent_states;

        public AgentStatesMsg()
        {
            this.header = new HeaderMsg();
            this.agent_states = new AgentStateMsg[0];
        }

        public AgentStatesMsg(HeaderMsg header, AgentStateMsg[] agent_states)
        {
            this.header = header;
            this.agent_states = agent_states;
        }

        public static AgentStatesMsg Deserialize(MessageDeserializer deserializer) => new AgentStatesMsg(deserializer);

        private AgentStatesMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.agent_states, AgentStateMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.agent_states);
            serializer.Write(this.agent_states);
        }

        public override string ToString()
        {
            return "AgentStatesMsg: " +
            "\nheader: " + header.ToString() +
            "\nagent_states: " + System.String.Join(", ", agent_states.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
