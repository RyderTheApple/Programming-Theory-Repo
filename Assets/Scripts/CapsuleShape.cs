using UnityEngine;

public class CapsuleShape : Shape // ENCAPSULATION
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
