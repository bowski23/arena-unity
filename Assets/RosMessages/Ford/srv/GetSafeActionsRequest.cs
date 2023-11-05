//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Ford
{
    [Serializable]
    public class GetSafeActionsRequest : Message
    {
        public const string k_RosMessageName = "ford_msgs/GetSafeActions";
        public override string RosMessageName => k_RosMessageName;

        public Geometry.PoseStampedMsg start;
        public Geometry.PoseStampedMsg goal;

        public GetSafeActionsRequest()
        {
            this.start = new Geometry.PoseStampedMsg();
            this.goal = new Geometry.PoseStampedMsg();
        }

        public GetSafeActionsRequest(Geometry.PoseStampedMsg start, Geometry.PoseStampedMsg goal)
        {
            this.start = start;
            this.goal = goal;
        }

        public static GetSafeActionsRequest Deserialize(MessageDeserializer deserializer) => new GetSafeActionsRequest(deserializer);

        private GetSafeActionsRequest(MessageDeserializer deserializer)
        {
            this.start = Geometry.PoseStampedMsg.Deserialize(deserializer);
            this.goal = Geometry.PoseStampedMsg.Deserialize(deserializer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.start);
            serializer.Write(this.goal);
        }

        public override string ToString()
        {
            return "GetSafeActionsRequest: " +
            "\nstart: " + start.ToString() +
            "\ngoal: " + goal.ToString();
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