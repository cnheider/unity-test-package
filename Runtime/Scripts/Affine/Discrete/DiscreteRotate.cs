using UnityEngine;

namespace Runtime.Scripts.Affine.Discrete {
  /// <inheritdoc />
  ///  <summary>
  ///  </summary>
  class DiscreteRotate : MonoBehaviour {
    [SerializeField] float angularVelocity = 1;
    [SerializeField] float stepSize = 90;
    [SerializeField] Vector3 axis = Vector3.up;

    void Update() {
      var rot = Quaternion.AngleAxis(angle : this.angularVelocity * this.stepSize, axis : this.axis);
      this.transform.localRotation *= rot;
    }
  }
}
