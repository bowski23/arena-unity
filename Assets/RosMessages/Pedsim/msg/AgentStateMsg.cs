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
    public class AgentStateMsg : Message
    {
        public const string k_RosMessageName = "pedsim_msgs/AgentState";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        public string id;
        public string type;
        public string social_state;
        public Geometry.PoseMsg pose;
        public Geometry.TwistMsg twist;
        public AgentForceMsg forces;
        public string talking_to_id;
        public string listening_to_id;
        public Geometry.Vector3Msg acceleration;
        public Geometry.Vector3Msg destination;
        public double direction;

        public AgentStateMsg()
        {
            this.header = new HeaderMsg();
            this.id = "";
            this.type = "";
            this.social_state = "";
            this.pose = new Geometry.PoseMsg();
            this.twist = new Geometry.TwistMsg();
            this.forces = new AgentForceMsg();
            this.talking_to_id = "";
            this.listening_to_id = "";
            this.acceleration = new Geometry.Vector3Msg();
            this.destination = new Geometry.Vector3Msg();
            this.direction = 0.0;
        }

        public AgentStateMsg(HeaderMsg header, string id, string type, string social_state, Geometry.PoseMsg pose, Geometry.TwistMsg twist, AgentForceMsg forces, string talking_to_id, string listening_to_id, Geometry.Vector3Msg acceleration, Geometry.Vector3Msg destination, double direction)
        {
            this.header = header;
            this.id = id;
            this.type = type;
            this.social_state = social_state;
            this.pose = pose;
            this.twist = twist;
            this.forces = forces;
            this.talking_to_id = talking_to_id;
            this.listening_to_id = listening_to_id;
            this.acceleration = acceleration;
            this.destination = destination;
            this.direction = direction;
        }

        public static AgentStateMsg Deserialize(MessageDeserializer deserializer) => new AgentStateMsg(deserializer);

        private AgentStateMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.id);
            deserializer.Read(out this.type);
            deserializer.Read(out this.social_state);
            this.pose = Geometry.PoseMsg.Deserialize(deserializer);
            this.twist = Geometry.TwistMsg.Deserialize(deserializer);
            this.forces = AgentForceMsg.Deserialize(deserializer);
            deserializer.Read(out this.talking_to_id);
            deserializer.Read(out this.listening_to_id);
            this.acceleration = Geometry.Vector3Msg.Deserialize(deserializer);
            this.destination = Geometry.Vector3Msg.Deserialize(deserializer);
            deserializer.Read(out this.direction);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.id);
            serializer.Write(this.type);
            serializer.Write(this.social_state);
            serializer.Write(this.pose);
            serializer.Write(this.twist);
            serializer.Write(this.forces);
            serializer.Write(this.talking_to_id);
            serializer.Write(this.listening_to_id);
            serializer.Write(this.acceleration);
            serializer.Write(this.destination);
            serializer.Write(this.direction);
        }

        public override string ToString()
        {
            return "AgentStateMsg: " +
            "\nheader: " + header.ToString() +
            "\nid: " + id.ToString() +
            "\ntype: " + type.ToString() +
            "\nsocial_state: " + social_state.ToString() +
            "\npose: " + pose.ToString() +
            "\ntwist: " + twist.ToString() +
            "\nforces: " + forces.ToString() +
            "\ntalking_to_id: " + talking_to_id.ToString() +
            "\nlistening_to_id: " + listening_to_id.ToString() +
            "\nacceleration: " + acceleration.ToString() +
            "\ndestination: " + destination.ToString() +
            "\ndirection: " + direction.ToString();
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
