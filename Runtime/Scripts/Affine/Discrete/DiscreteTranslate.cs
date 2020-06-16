using UnityEngine;

namespace Runtime.Scripts.Affine.Discrete {
  /// <summary>
  ///
  /// </summary>
  public class DiscreteTranslate : MonoBehaviour {
    /// <summary>
    ///
    /// </summary>
    [SerializeField]
    float Speed = 1.0f;

    [SerializeField] float stepSize = 0.01f;

    [SerializeField] Vector3 _translation = Vector3.left;




    void Update() {
      this.transform.position += this.stepSize * this.Speed * this._translation;
    }
  }
}
