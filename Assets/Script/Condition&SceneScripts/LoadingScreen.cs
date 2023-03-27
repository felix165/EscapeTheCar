using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public GameObject gameObj;

    private int nextSceneIndex;
    //scene game urutan 3 hingga 53 (terdapat 50 level yang disedikan)

    int batasBawah = 3; 
    int batasAtas = 52; 

    private float loadingTime; //waktu animasi loading
    // Start is called before the first frame update
    void Start()
    {
        loadingTime = 5.5f; //waktu animasi loading
    }

    // Update is called once per frame
    void Update()
    {
        loadingTime -= Time.deltaTime;
        //Ketika waktu delay loading telah habis, scene akan dialihkan ke scene berisi puzzle yang harus diselesaikan
        if(loadingTime <= 0){
            //random scene pertama
            nextSceneIndex = (int)Random.Range(batasBawah, batasAtas);

            gameObj.GetComponent<StartButton>().sceneLoaded.Add(nextSceneIndex);
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
