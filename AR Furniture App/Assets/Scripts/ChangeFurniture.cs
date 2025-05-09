using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeFurniture : MonoBehaviour
{
    public GameObject container;
    public GameObject buttonPrefab;
    public Transform buttonParent;

    private List<GameObject> _furniture = new List<GameObject>();

    void Start()
    {
        foreach (Transform child in container.transform)
        {
            _furniture.Add(child.gameObject);

            GameObject buttonObj = Instantiate(buttonPrefab, buttonParent);
            Button btn = buttonObj.GetComponent<Button>();
            TextMeshProUGUI btnText = buttonObj.GetComponentInChildren<TextMeshProUGUI>();

            btnText.text = child.name;

            string objName = child.name;

            btn.onClick.AddListener(() => OnButtonClick(objName));
        }
    }

    private void OnButtonClick(string objectName)
    {
        foreach (GameObject obj in _furniture)
        {
            obj.SetActive(obj.name == objectName);
        }
    }
}
