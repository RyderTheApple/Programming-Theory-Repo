using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private string shapeName;

    public string GetShapeName()
    {
        return shapeName;
    }

    public abstract void Spin();
}
