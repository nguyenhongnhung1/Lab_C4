using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        Vector3 dir = Vector3.zero;

        if (keyboard.wKey.isPressed) dir += Vector3.forward;
        if (keyboard.sKey.isPressed) dir += Vector3.back;
        if (keyboard.aKey.isPressed) dir += Vector3.left;
        if (keyboard.dKey.isPressed) dir += Vector3.right;

        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }
}