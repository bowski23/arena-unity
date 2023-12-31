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
    public class WaypointsMsg : Message
    {
        public const string k_RosMessageName = "pedsim_msgs/Waypoints";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        public WaypointMsg[] waypoints;

        public WaypointsMsg()
        {
            this.header = new HeaderMsg();
            this.waypoints = new WaypointMsg[0];
        }

        public WaypointsMsg(HeaderMsg header, WaypointMsg[] waypoints)
        {
            this.header = header;
            this.waypoints = waypoints;
        }

        public static WaypointsMsg Deserialize(MessageDeserializer deserializer) => new WaypointsMsg(deserializer);

        private WaypointsMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.waypoints, WaypointMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.waypoints);
            serializer.Write(this.waypoints);
        }

        public override string ToString()
        {
            return "WaypointsMsg: " +
            "\nheader: " + header.ToString() +
            "\nwaypoints: " + System.String.Join(", ", waypoints.ToList());
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
