//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Gazebo
{
    [Serializable]
    public class ODEJointPropertiesMsg : Message
    {
        public const string k_RosMessageName = "gazebo_msgs/ODEJointProperties";
        public override string RosMessageName => k_RosMessageName;

        //  access to low level joint properties, change these at your own risk
        public double[] damping;
        //  joint damping
        public double[] hiStop;
        //  joint limit
        public double[] loStop;
        //  joint limit
        public double[] erp;
        //  set joint erp
        public double[] cfm;
        //  set joint cfm
        public double[] stop_erp;
        //  set joint erp for joint limit "contact" joint
        public double[] stop_cfm;
        //  set joint cfm for joint limit "contact" joint
        public double[] fudge_factor;
        //  joint fudge_factor applied at limits, see ODE manual for info.
        public double[] fmax;
        //  ode joint param fmax
        public double[] vel;
        //  ode joint param vel

        public ODEJointPropertiesMsg()
        {
            this.damping = new double[0];
            this.hiStop = new double[0];
            this.loStop = new double[0];
            this.erp = new double[0];
            this.cfm = new double[0];
            this.stop_erp = new double[0];
            this.stop_cfm = new double[0];
            this.fudge_factor = new double[0];
            this.fmax = new double[0];
            this.vel = new double[0];
        }

        public ODEJointPropertiesMsg(double[] damping, double[] hiStop, double[] loStop, double[] erp, double[] cfm, double[] stop_erp, double[] stop_cfm, double[] fudge_factor, double[] fmax, double[] vel)
        {
            this.damping = damping;
            this.hiStop = hiStop;
            this.loStop = loStop;
            this.erp = erp;
            this.cfm = cfm;
            this.stop_erp = stop_erp;
            this.stop_cfm = stop_cfm;
            this.fudge_factor = fudge_factor;
            this.fmax = fmax;
            this.vel = vel;
        }

        public static ODEJointPropertiesMsg Deserialize(MessageDeserializer deserializer) => new ODEJointPropertiesMsg(deserializer);

        private ODEJointPropertiesMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.damping, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.hiStop, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.loStop, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.erp, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.cfm, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.stop_erp, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.stop_cfm, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.fudge_factor, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.fmax, sizeof(double), deserializer.ReadLength());
            deserializer.Read(out this.vel, sizeof(double), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.damping);
            serializer.Write(this.damping);
            serializer.WriteLength(this.hiStop);
            serializer.Write(this.hiStop);
            serializer.WriteLength(this.loStop);
            serializer.Write(this.loStop);
            serializer.WriteLength(this.erp);
            serializer.Write(this.erp);
            serializer.WriteLength(this.cfm);
            serializer.Write(this.cfm);
            serializer.WriteLength(this.stop_erp);
            serializer.Write(this.stop_erp);
            serializer.WriteLength(this.stop_cfm);
            serializer.Write(this.stop_cfm);
            serializer.WriteLength(this.fudge_factor);
            serializer.Write(this.fudge_factor);
            serializer.WriteLength(this.fmax);
            serializer.Write(this.fmax);
            serializer.WriteLength(this.vel);
            serializer.Write(this.vel);
        }

        public override string ToString()
        {
            return "ODEJointPropertiesMsg: " +
            "\ndamping: " + System.String.Join(", ", damping.ToList()) +
            "\nhiStop: " + System.String.Join(", ", hiStop.ToList()) +
            "\nloStop: " + System.String.Join(", ", loStop.ToList()) +
            "\nerp: " + System.String.Join(", ", erp.ToList()) +
            "\ncfm: " + System.String.Join(", ", cfm.ToList()) +
            "\nstop_erp: " + System.String.Join(", ", stop_erp.ToList()) +
            "\nstop_cfm: " + System.String.Join(", ", stop_cfm.ToList()) +
            "\nfudge_factor: " + System.String.Join(", ", fudge_factor.ToList()) +
            "\nfmax: " + System.String.Join(", ", fmax.ToList()) +
            "\nvel: " + System.String.Join(", ", vel.ToList());
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