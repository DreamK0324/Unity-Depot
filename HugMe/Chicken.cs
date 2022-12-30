using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken : MonoBehaviour
{
    public float upSpeed = 8.0f;
    public float sideSpeed = 5.0f;
    private Rigidbody2D rb2d;
    private static int HP = 3;

    public GameOver gameOver;
    public GameObject gameO;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public Text timerText;
    private float startTime;

    public GameObject eggPrefab;
    public float height;
    public float maxSpawn = 1;
    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        HP = 3;
        gameO.SetActive(false);

        startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        timerText.text = minutes + " : " + seconds;

        if (Input.GetKey(KeyCode.W))
        {
            rb2d.velocity = Vector3.up * upSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = Vector3.left * sideSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = Vector3.right * sideSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            GameObject newEnter = Instantiate(eggPrefab);
            newEnter.transform.position = rb2d.position + new Vector2(0.0f, 3.0f);
            gameOver.over();
        }

        if (HP == 2)
        {
            Destroy(heart1);
        }
        else if (HP == 1)
        {
            Destroy(heart2);
        }
        else if (HP == 0)
        {
            Destroy(heart3);
            Destroy(this.gameObject);
            gameOver.over();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HP--;
    }

    
}
