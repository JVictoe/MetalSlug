using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayMenu1 : MonoBehaviour
{

    [SerializeField] private Button btn = default;

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(PlayG);
    }

    void PlayG()
    {
        SceneManager.LoadScene(1);
    }
}
