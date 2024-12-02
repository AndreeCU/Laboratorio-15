using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speedX;
    public float speedY;
    private float horizontal;
    private float vertical;
    public GameObject bulletPrefab;
    private Rigidbody2D _componentRigidbody2D;

    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(speedX * horizontal, speedY * vertical);
    }
}
