using UnityEngine;

namespace Common.Runtime.Scripts {
  /// <summary>
  ///
  /// </summary>
  class SimpleRotation : MonoBehaviour {
    [SerializeField] float angularVelocity = 10;
    [SerializeField] Vector3 axis = Vector3.up;

    void Update() {
      var rot = Quaternion.AngleAxis(this.angularVelocity * Time.deltaTime, axis);
      this.transform.localRotation *= rot;
    }
  }
}
