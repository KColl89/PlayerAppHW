﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHW
{
    public class Player : IPLayer
    {
        private readonly Guid _id = Guid.NewGuid();
        private string _name = "";

        public Guid ID { get { return _id; } }

        public Guid Id => throw new NotImplementedException();

        public string Name { get { return _name; } set { _name = value; } }

        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}