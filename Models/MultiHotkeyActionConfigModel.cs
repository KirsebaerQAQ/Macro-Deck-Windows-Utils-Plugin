﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SuchByte.WindowsUtils.Models
{
    internal class MultiHotkeyActionConfigModel : ISerializableConfiguration
    {
        public List<IMultiHotkeyAction> MultiHotkeyActions { get; set; } = new List<IMultiHotkeyAction>();

        public bool SyncButtonState { get; set; } = false;


        public string Serialize()
        {
            return JsonSerializer.Serialize(this);
        }
        public static MultiHotkeyActionConfigModel Deserialize(string config)
        {
            return ISerializableConfiguration.Deserialize<MultiHotkeyActionConfigModel>(config);
        }
    }


}
