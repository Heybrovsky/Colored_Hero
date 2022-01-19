using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotZ;
    public float RotationSpeed;
    public bool clockwiseRotation;
    void Update()
    {
        if(clockwiseRotation == false)
        {
            rotZ += Time.deltaTime * RotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * RotationSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

    }
}
