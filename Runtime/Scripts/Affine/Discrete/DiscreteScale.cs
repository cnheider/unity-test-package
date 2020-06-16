using UnityEngine;

namespace Runtime.Scripts.Affine.Discrete {
  /// <summary>
  ///
  /// </summary>
  public class DiscreteScale : MonoBehaviour {
    /// <summary>
    ///
    /// </summary>
    [SerializeField]
   float Speed = 1.0f;
    [SerializeField] float stepSize = 0.01f;

    [SerializeField] Vector3 _scalar = Vector3.right;

    void Update() {
      this.transform.localScale += this.stepSize *this.Speed* this._scalar;
    }
  }
}
