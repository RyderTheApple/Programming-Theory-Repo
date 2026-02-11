using UnityEngine;

public class CubeShape : Shape
{
    public override void Spin()
    {
        transform.Rotate(Vector3.up * 30f * Time.deltaTime);
    }
    private void Update()
    {
        Spin();
    }
}
