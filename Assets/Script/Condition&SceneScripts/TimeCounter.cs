using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public Text timeText;

    public GameObject gameObj;

    private string time; //waktu tersisa dalam dormat 00:00
    private int Minute; //hasil konversi detik ke menit
    private int Second; //sisa konversi detik ke menit
    int gameOverScene = 53; //scene yang akan diaktifkan ketika waktu telah berakhir

    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        gameObj.GetComponent<StartButton>().delta_time -= Time.deltaTime;


     /**
     * Function untuk mengubah format jam yang akan ditampilkan
     * Minute merupakan jumlah menit pada jam
     * Second merupakan jumlah detik pada jam
     */
        Minute = (int)(gameObj.GetComponent<StartButton>().delta_time / 60);
        Second = (int)(gameObj.GetComponent<StartButton>().delta_time % 60);

        if (Minute >= 10)
        {
            if (Second >= 10)
            {
                time = Minute + ":" + Second;
            }
            else
            {
                time = Minute + ":0" + Second;
            }
        }
        else
        {
            if (Second >= 10)
            {
                time = "0" + Minute + ":" + Second;
            }
            else
            {
                time = "0" + Minute + ":0" + Second;

            }

        }

        //jika waktu habis, maka akan ditampilkan "times out"
        if (gameObj.GetComponent<StartButton>().delta_time <= 0)
        {
            timeText.text = "00:00";

            SceneManager.LoadScene(gameOverScene);
        }
        else
        {
            timeText.text = time;
        }
    }

}
