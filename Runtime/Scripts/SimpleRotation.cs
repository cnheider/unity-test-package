using UnityEngine;

namespace Common.Runtime.Scripts {
  /// <summary>
  ///
  /// </summary>
  class SimpleRotation : MonoBehaviour {
    [SerializeField] float angularVelocity = 10;

    void Update() {
      var rot = Quaternion.AngleAxis(this.angularVelocity * Time.deltaTime, Vector3.up);
      this.transform.localRotation *= rot;
    }
  }
}
