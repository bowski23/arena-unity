//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Ford
{
    [Serializable]
    public class GetSafeActionsResponse : Message
    {
        public const string k_RosMessageName = "ford_msgs/GetSafeActions";
        public override string RosMessageName => k_RosMessageName;


        public GetSafeActionsResponse()
        {
        }
        public static GetSafeActionsResponse Deserialize(MessageDeserializer deserializer) => new GetSafeActionsResponse(deserializer);

        private GetSafeActionsResponse(MessageDeserializer deserializer)
        {
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
        }

        public override string ToString()
        {
            return "GetSafeActionsResponse: ";
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize, MessageSubtopic.Response);
        }
    }
}