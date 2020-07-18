
using UnityEngine;

public class Cmaera : MonoBehaviour
{
    public Transform Target;
    public float speed = 5;
    public Vector2 LimitY = new Vector2(0, 2);
    public Vector2 LimitX = new Vector2(-1, 34);

    private void Track()
    {
        Vector3 a = transform.position;
        Vector3 b = Target.position;
        b.z = -10;
        
       

        a = Vector3.Lerp(a, b, Time.deltaTime * speed);
        a.y = Mathf.Clamp(a.y, LimitY.x, LimitY.y);
        a.x = Mathf.Clamp(a.x, LimitX.x, LimitX.y);
        transform.position = a;
    }
    private void LateUpdate()
    {
        Track();
    }
}
