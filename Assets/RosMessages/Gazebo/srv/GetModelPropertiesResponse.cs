//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gazebo
{
    [Serializable]
    public class GetModelPropertiesResponse : Message
    {
        public const string k_RosMessageName = "gazebo_msgs/GetModelProperties";
        public override string RosMessageName => k_RosMessageName;

        public string parent_model_name;
        //  parent model
        public string canonical_body_name;
        //  name of canonical body, body names are prefixed by model name, e.g. pr2::base_link
        public string[] body_names;
        //  list of bodies, body names are prefixed by model name, e.g. pr2::base_link
        public string[] geom_names;
        //  list of geoms
        public string[] joint_names;
        //  list of joints attached to the model
        public string[] child_model_names;
        //  list of child models
        public bool is_static;
        //  returns true if model is static
        public bool success;
        //  return true if get successful
        public string status_message;
        //  comments if available

        public GetModelPropertiesResponse()
        {
            this.parent_model_name = "";
            this.canonical_body_name = "";
            this.body_names = new string[0];
            this.geom_names = new string[0];
            this.joint_names = new string[0];
            this.child_model_names = new string[0];
            this.is_static = false;
            this.success = false;
            this.status_message = "";
        }

        public GetModelPropertiesResponse(string parent_model_name, string canonical_body_name, string[] body_names, string[] geom_names, string[] joint_names, string[] child_model_names, bool is_static, bool success, string status_message)
        {
            this.parent_model_name = parent_model_name;
            this.canonical_body_name = canonical_body_name;
            this.body_names = body_names;
            this.geom_names = geom_names;
            this.joint_names = joint_names;
            this.child_model_names = child_model_names;
            this.is_static = is_static;
            this.success = success;
            this.status_message = status_message;
        }

        public static GetModelPropertiesResponse Deserialize(MessageDeserializer deserializer) => new GetModelPropertiesResponse(deserializer);

        private GetModelPropertiesResponse(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.parent_model_name);
            deserializer.Read(out this.canonical_body_name);
            deserializer.Read(out this.body_names, deserializer.ReadLength());
            deserializer.Read(out this.geom_names, deserializer.ReadLength());
            deserializer.Read(out this.joint_names, deserializer.ReadLength());
            deserializer.Read(out this.child_model_names, deserializer.ReadLength());
            deserializer.Read(out this.is_static);
            deserializer.Read(out this.success);
            deserializer.Read(out this.status_message);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.parent_model_name);
            serializer.Write(this.canonical_body_name);
            serializer.WriteLength(this.body_names);
            serializer.Write(this.body_names);
            serializer.WriteLength(this.geom_names);
            serializer.Write(this.geom_names);
            serializer.WriteLength(this.joint_names);
            serializer.Write(this.joint_names);
            serializer.WriteLength(this.child_model_names);
            serializer.Write(this.child_model_names);
            serializer.Write(this.is_static);
            serializer.Write(this.success);
            serializer.Write(this.status_message);
        }

        public override string ToString()
        {
            return "GetModelPropertiesResponse: " +
            "\nparent_model_name: " + parent_model_name.ToString() +
            "\ncanonical_body_name: " + canonical_body_name.ToString() +
            "\nbody_names: " + System.String.Join(", ", body_names.ToList()) +
            "\ngeom_names: " + System.String.Join(", ", geom_names.ToList()) +
            "\njoint_names: " + System.String.Join(", ", joint_names.ToList()) +
            "\nchild_model_names: " + System.String.Join(", ", child_model_names.ToList()) +
            "\nis_static: " + is_static.ToString() +
            "\nsuccess: " + success.ToString() +
            "\nstatus_message: " + status_message.ToString();
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