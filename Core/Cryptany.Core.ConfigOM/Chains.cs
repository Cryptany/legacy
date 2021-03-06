﻿/*
   Copyright 2006-2017 Cryptany, Inc.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Text;
using Cryptany.Core.DPO;
using Cryptany.Core.DPO.MetaObjects.Attributes;
namespace Cryptany.Core.ConfigOM
{
    [Serializable]
    [DbSchema("services")]
    [Table("chainsTariffs")]
    public class Chains : EntityBase
    {
     
        public string Text1
        {
            get
            {
                return GetValue<string>("Text1");
            }
            set
            {
                SetValue("Text1", value);
            }
        }

        public Guid TariffId1
        {
            get
            {
                return GetValue<Guid>("TariffId1");
            }
            set
            {
                SetValue("TariffId1", value);
            }

        }

        public int OrderInChain
        {
            get
            {
                return GetValue<int>("OrderInChain");
            }
            set
            {
                SetValue("OrderInChain", value);
            }

        }
    }
}
