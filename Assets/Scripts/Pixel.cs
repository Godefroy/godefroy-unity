using System.Collections;
using UnityEngine;

public class Pixel : MonoBehaviour {
    public bool LookAtMouse = false;
    public float PopDuration = 0.2f;

    public Rigidbody Rigidbody { get; private set; }
    public SpringJoint SpringJoint { get; private set; }

    private Vector3 _target;
    private static Vector3 _mouseWorldPosition;
    private float _spring;

    public Vector3 Target {
        get { return _target; }
        set {
            _target = value;
            SpringJoint.autoConfigureConnectedAnchor = false;
            SpringJoint.anchor = _target;
            SpringJoint.connectedAnchor = _target;
        }
    }

    public bool JointEnabled {
        get { return SpringJoint.spring > 0; }
        set { SpringJoint.spring = value ? _spring : 0; }
    }

    public bool KinematicEnabled {
        get { return Rigidbody.isKinematic; }
        set { Rigidbody.isKinematic = value; }
    }

    public bool GravityEnabled {
        get { return Rigidbody.useGravity; }
        set { Rigidbody.useGravity = value; }
    }

    public IEnumerator AnimatePop() {
        var time = 0f;
        while (time < PopDuration) {
            time += Time.deltaTime;
            transform.localScale = Vector3.one * Mathfx.Berp(0, 1, time / PopDuration);
            yield return null;
        }
    }

    public void Fall() {
        KinematicEnabled = false;
        GravityEnabled = true;
        JointEnabled = false;
        LookAtMouse = false;
    }

    public void JointToPosition() {
        KinematicEnabled = false;
        GravityEnabled = false;
        JointEnabled = true;
        LookAtMouse = true;
    }

    private void Update() {
        if (LookAtMouse) {
            if (_mouseWorldPosition == default(Vector3)) {
                _mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                _mouseWorldPosition.z = -1f;
            }
            transform.LookAt(_mouseWorldPosition);
        }
    }

    private void LateUpdate() {
        _mouseWorldPosition = default(Vector3);
    }

    private void Awake() {
        Rigidbody = GetComponent<Rigidbody>();
        SpringJoint = GetComponent<SpringJoint>();
        _spring = SpringJoint.spring;

        KinematicEnabled = true;
        JointEnabled = false;
        GravityEnabled = false;

        // Freeze Z position
        Rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
    }
}