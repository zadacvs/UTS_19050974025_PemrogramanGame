using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolaHijau : MonoBehaviour
{
    public float speed;
    public Text Menang;
    public Text Skor;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Menang.text="";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,speed);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0,0,-speed);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed,0,0);
        }
    }

    void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.tag=="targetBola")
        {
            Destroy(obj.gameObject);
            score += 10;
            Skor.text = "Skor : "+score.ToString();
        }
        if(score >= 40)
        {
            Menang.text = "Anda Menang";
        }
    }
}
