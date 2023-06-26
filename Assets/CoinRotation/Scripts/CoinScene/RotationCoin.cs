using UnityEngine;

public class RotationCoin : MonoBehaviour {
    public float minRotationSpeed = 1.0f;
    public float maxRotationSpeed = 5.0f;
    public float rotationTime = 1.0f;

    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private float elapsedTime = 0.0f;
    private float currentRotationSpeed;

    private void Start()
    {
        initialRotation = transform.localRotation;
        SetNewTargetRotation();
    }

    private void Update()
    {
        if (elapsedTime < rotationTime)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime / rotationTime);
            transform.localRotation = Quaternion.Lerp(initialRotation, targetRotation, t);
        }
        else
        {
            SetNewTargetRotation();
        }
    }

    private void SetNewTargetRotation()
    {
        initialRotation = transform.localRotation;
        targetRotation = GenerateRandomRotation();
        elapsedTime = 0.0f;
        currentRotationSpeed = Random.Range(minRotationSpeed, maxRotationSpeed);
    }

    private Quaternion GenerateRandomRotation()
    {
        float randomX = Random.Range(0, 360);
        float randomY = Random.Range(0, 360);
        float randomZ = Random.Range(0, 360);
        return Quaternion.Euler(randomX, randomY, randomZ);
    }
}