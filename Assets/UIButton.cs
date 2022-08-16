using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class UIButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            Debug.Log("按钮被点击");
        });
    }


    // Update is called once per frame
    void Update()
    {
    }
}