//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Pedsim
{
    [Serializable]
    public class AgentFeedbackMsg : Message
    {
        public const string k_RosMessageName = "pedsim_msgs/AgentFeedback";
        public override string RosMessageName => k_RosMessageName;

        public string id;
        public Geometry.Vector3Msg force;
        public bool unforce;

        public AgentFeedbackMsg()
        {
            this.id = "";
            this.force = new Geometry.Vector3Msg();
            this.unforce = false;
        }

        public AgentFeedbackMsg(string id, Geometry.Vector3Msg force, bool unforce)
        {
            this.id = id;
            this.force = force;
            this.unforce = unforce;
        }

        public static AgentFeedbackMsg Deserialize(MessageDeserializer deserializer) => new AgentFeedbackMsg(deserializer);

        private AgentFeedbackMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.id);
            this.force = Geometry.Vector3Msg.Deserialize(deserializer);
            deserializer.Read(out this.unforce);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.id);
            serializer.Write(this.force);
            serializer.Write(this.unforce);
        }

        public override string ToString()
        {
            return "AgentFeedbackMsg: " +
            "\nid: " + id.ToString() +
            "\nforce: " + force.ToString() +
            "\nunforce: " + unforce.ToString();
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