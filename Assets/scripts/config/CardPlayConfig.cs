using System;
using UnityEngine;

namespace config {
    [Serializable]
    public class CardPlayConfig {
        [SerializeField]
        public RectTransform playArea;
        
        [SerializeField]
        public bool destroyOnPlay;

    }
}
