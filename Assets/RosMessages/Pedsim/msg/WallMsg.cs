//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Pedsim
{
    [Serializable]
    public class WallMsg : Message
    {
        public const string k_RosMessageName = "pedsim_msgs/Wall";
        public override string RosMessageName => k_RosMessageName;

        //  A line obstacle in the simulator.
        public Geometry.PointMsg start;
        public Geometry.PointMsg end;
        public byte layer;

        public WallMsg()
        {
            this.start = new Geometry.PointMsg();
            this.end = new Geometry.PointMsg();
            this.layer = 0;
        }

        public WallMsg(Geometry.PointMsg start, Geometry.PointMsg end, byte layer)
        {
            this.start = start;
            this.end = end;
            this.layer = layer;
        }

        public static WallMsg Deserialize(MessageDeserializer deserializer) => new WallMsg(deserializer);

        private WallMsg(MessageDeserializer deserializer)
        {
            this.start = Geometry.PointMsg.Deserialize(deserializer);
            this.end = Geometry.PointMsg.Deserialize(deserializer);
            deserializer.Read(out this.layer);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.start);
            serializer.Write(this.end);
            serializer.Write(this.layer);
        }

        public override string ToString()
        {
            return "WallMsg: " +
            "\nstart: " + start.ToString() +
            "\nend: " + end.ToString() +
            "\nlayer: " + layer.ToString();
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