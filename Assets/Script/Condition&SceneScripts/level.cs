using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level : MonoBehaviour
{

    public GameObject gameObj;

    int currentLevel; //posisi level sekarang/terakhir

    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Text berisi jumlah level pada saat ini
        currentLevel = gameObj.GetComponent<StartButton>().sceneLoaded.Count ;

        Debug.Log("Level:" );
        Debug.Log(currentLevel);

        levelText.text = currentLevel.ToString("0");
    }
}
