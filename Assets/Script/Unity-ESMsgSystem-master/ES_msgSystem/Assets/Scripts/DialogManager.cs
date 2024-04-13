using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RemptyTool.ES_MessageSystem;

public class DialogManager : MonoBehaviour
{
    public GameObject dialogPanel;
    public GameObject posterDialogPanel;
    public GameObject player;
    public GameObject poster;

    private ES_MessageSystem messageSystem;
    private bool dialogActive = false;

    void Start()
    {
        messageSystem = dialogPanel.GetComponent<ES_MessageSystem>();
        ShowDialogPanel();
    }

    void Update()
    {
        if (!dialogActive && Input.GetKeyDown(KeyCode.O) && Vector3.Distance(player.transform.position, poster.transform.position) < 2f)
        {
            ShowPosterDialogPanel();
        }
    }

    void ShowDialogPanel()
    {
        dialogPanel.SetActive(true);
        dialogActive = true;
    }

    void ShowPosterDialogPanel()
    {
        dialogPanel.SetActive(false);
        posterDialogPanel.SetActive(true);
        dialogActive = true;
    }

    void EndDialog()
    {
        Destroy(dialogPanel);
        Destroy(posterDialogPanel);
    }
}