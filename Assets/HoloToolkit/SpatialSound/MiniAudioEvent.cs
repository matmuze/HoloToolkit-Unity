﻿using System;
using UnityEngine;

namespace HoloToolkit.Unity
{
    /// <summary>
    /// The MiniAudioEvent class is the main component of UAudioMiniManager and contains settings and a container for playing audio clips.
    /// </summary>
    [Serializable]
    public class MiniAudioEvent : AudioEvent
    {
        [Tooltip("The primary AudioSource.")]
        public AudioSource primarySource = null;

        [Tooltip("The secondary AudioSource for continuous containers.")]
        public AudioSource secondarySource = null;
    }
}