using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pnlManager : MonoBehaviour
{
    [SerializeField] private pnlStartGame _pnlStartGame;
    [SerializeField] private GameObject _pnlEndgame;
    [SerializeField] private GameObject _pnlGamePlay;

    private void Start()
    {
        Hide();
        _pnlStartGame.gameObject.SetActive(true);
    }

    private void Hide()
    {
        _pnlStartGame.gameObject.SetActive(false);
        _pnlEndgame.SetActive(false);
        _pnlGamePlay.SetActive(false);
    }


}
