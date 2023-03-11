using System;
using UnityEngine;

namespace config {
    [Serializable]
    public class ZoomConfig {

        [SerializeField]
        public bool zoomOnHover;
    
        [Range(1f, 5f)]
        [SerializeField]
        public float multiplier = 1;
        
        [Tooltip("This is the Y position of the card when it is zoomed in. If this is -1, the card will not be moved on the Y axis.")]
        [SerializeField]
        public float overrideYPosition = -1;

        [Header("UI Layer")]
        [Tooltip("This is the sorting order of the first card when it is not zoomed in. Subsequent cards will have a higher sorting order.")]
        [SerializeField]
        public int defaultSortOrder;
        
        [SerializeField]
        public bool bringToFrontOnHover;
        
        [Tooltip("This is the sorting order of the card when it is zoomed in.")]
        [SerializeField]
        public int zoomedSortOrder;

        [SerializeField]
        public bool resetRotationOnZoom;
    }
}
