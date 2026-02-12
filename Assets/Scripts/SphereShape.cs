using UnityEngine;

public class SphereShape : Shape
{
    private float floatSpeed = 2f;
    private float floatHeight = 0.5f;

    private Vector3 startPosition;
    private void Start()
    {
        startPosition = transform.position;
    }
    public override void Spin()
    // POLYMORPHISM
    {
        float newY = startPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
    private void Update()
    {
        Spin();
    }
}
