using UnityEngine;

public class FPSCap : MonoBehaviour {
    private void Start() {
        Application.targetFrameRate = 60;
    }
}
