using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Crapper : MonoBehaviour
{
    public float crapPower = 3;
    private Rigidbody2D _rb;
    private bool _isDead;
    public GameObject Missile;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.simulated = false;
        Input.simulateMouseWithTouches = true;
    }

    void Update()
    {
        if(_isDead) return;
        
        if (Input.GetMouseButtonDown(0))
        {
            Missile.SetActive(true);
            
            if (_rb.simulated)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, crapPower);
            }
            else
            {
                _rb.simulated = true;
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(Co_OnDeath());
    }

    IEnumerator Co_OnDeath()
    {
        _isDead = true;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}