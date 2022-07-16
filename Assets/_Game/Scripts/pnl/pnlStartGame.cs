using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pnlStartGame : MonoBehaviour
{
    [SerializeField] private Button _btnStart;

    private void Start()
    {
        _btnStart.onClick.AddListener(() => gameObject.SetActive(false));
    }
}
