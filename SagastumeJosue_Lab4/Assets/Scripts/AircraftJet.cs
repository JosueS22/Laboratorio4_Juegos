using UnityEngine;

public class AircraftJet : MonoBehaviour
{
    public Vector3 startPos = new Vector3();
    public float health = 10f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = startPos + new Vector3(20 * Mathf.Cos(Time.time), 0, 20 * Mathf.Sin(Time.time));
        transform.Rotate(0, -Time.deltaTime * 60, 0);
    }
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
