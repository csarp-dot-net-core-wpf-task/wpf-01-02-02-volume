﻿using System;
using System.Runtime.Serialization;

namespace oop.Model
{
    [Serializable]
    public class ExceptionSphereRadiusNegativOrZero : Exception
    {
        public ExceptionSphereRadiusNegativOrZero()
        {
        }

        public ExceptionSphereRadiusNegativOrZero(string message) : base(message)
        {
        }

        public ExceptionSphereRadiusNegativOrZero(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionSphereRadiusNegativOrZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
