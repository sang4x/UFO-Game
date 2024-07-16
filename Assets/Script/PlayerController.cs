using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text CountText;
    public float speed;
    private Rigidbody2D rd;
    private int count;

    void Start()
    {
        rd = GetComponent<Rigidbody2D> ();
        count = 0;
       setcont();

    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal,moveVertical);
        rd.AddForce (movement * speed);
    }
 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            setcont();
        } 
    }
  void setcont()
    {
        CountText.text = "count:" + count.ToString();
    }
}
