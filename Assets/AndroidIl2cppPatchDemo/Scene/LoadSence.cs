using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("LoadScene");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(5);//运行到这，暂停t秒


        SceneManager.LoadSceneAsync ("0");
        //不允许加载完毕自动切换场景，因为有时候加载太快了就看不到加载进度条UI效果了
        yield return null;
    }
}