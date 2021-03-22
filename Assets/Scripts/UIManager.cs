using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    // Start is called before the first frame update
    public GameObject textBackground;
    public GameObject text;

    public bool active = false;

    void Awake()
    {

        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(this.gameObject);

            //Rest of your Awake code

        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        textBackground.SetActive(false);
    }

    public void ShowNarrativeText(NarrativeItem item)
    {
        textBackground.SetActive(true);
        text.GetComponent<Text>().text = item.text;
        active = true;
    }

    public void HideNarrativeText()
    {
        textBackground.SetActive(false);
        text.GetComponent<Text>().text = "";
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
