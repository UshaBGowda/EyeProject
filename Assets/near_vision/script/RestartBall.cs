using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class RestartBall : MonoBehaviour {
    public bool flag = false;
    public GameObject timer;
    public GameObject bg2;
    public GameObject ball;
    public GameObject pencil;

    // Use this for initialization
    void Start () {
          var button = this.gameObject.GetComponent<Button>();
          if (button != null)
          {
              button.onClick.RemoveAllListeners();
              button.onClick.AddListener(TestClick);
          }
        timer = GameObject.Find("Timer");
        bg2 = GameObject.Find("backGround2");
        ball = GameObject.Find("ball");
        pencil= GameObject.Find("pencil");

    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void TestClick()
    {
        if (flag)
        {
            AudioSource audio= GameObject.Find("RightAudio").GetComponent<AudioSource>();
            audio.Play();
            timer.SetActive(true);
            bg2.SetActive(true);
            ball.SetActive(true);
            pencil.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            AudioSource audio = GameObject.Find("WrongAudio").GetComponent<AudioSource>();
            audio.Play();
            ball.GetComponent<TimerAndColor>().wrongTime++;
        }
        
    }
}
