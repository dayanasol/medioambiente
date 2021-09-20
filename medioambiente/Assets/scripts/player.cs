using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float vel;
    bool isLeft = false;
    bool isRight = false;
    bool isUp = false;
    bool isDown = false;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*
        float x = Input.GetAxis("Horizontal");
        transform.Translate(translation: (Vector3)new Vector2(x: x * Time.deltaTime * vel, y: 0));
        */
    if(isLeft)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: -vel, y: 0) * Time.deltaTime));
        }

        if (isRight)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: vel, y: 0) * Time.deltaTime));
        }
        if (isUp)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: 0, y: vel) * Time.deltaTime));
        }
        if (isDown)
        {
            rb.transform.Translate(translation: (Vector3)(new Vector2(x: 0, y: -vel) * Time.deltaTime));
        }

    }
    public void clickLeft()
    {
    isLeft = true;
}
public void releaseLeft()
    {
        isLeft = false;
    }

    public void clickRight()
    {
        isLeft = true;
    }
    public void releaseRight()
    {
        isLeft = false;
    }
    public void clickUp()
    {
        isLeft = true;
    }
    public void releaseUp()
    {
        isLeft = false;
    }

    public void clickDown()
    {
        isLeft = true;
    }
    public void releaseDown()
    {
        isLeft = false;
    }

}
