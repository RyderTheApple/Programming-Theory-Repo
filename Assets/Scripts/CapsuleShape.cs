using UnityEngine;

public class CapsuleShape : Shape
{
    public override void Spin()
    {
        transform.Rotate(Vector3.right * 30f * Time.deltaTime);
    }
    private void Update()
    {
        Spin();
    }
}
