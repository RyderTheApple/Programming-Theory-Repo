using UnityEngine;

public class PyramidShape : Shape
{
    public override void Spin()
    {
        transform.Rotate(Vector3.forward * 30f * Time.deltaTime);
    }
    private void Update()
    {
        Spin();
    }
}
