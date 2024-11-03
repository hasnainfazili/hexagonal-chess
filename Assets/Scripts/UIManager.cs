// UIManager.cs
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject rulePanel;
    public Text ruleText;

    private void Start()
    {
        ruleText.text = "Hex Chess Rules:\n\n" +
                        "1. Each piece moves according to chess-like rules on a hexagonal grid.\n" +
                        "2. Objective: Capture the opponent's King.\n" +
                        "3. Kings can move one tile in any direction.\n" +
                        "4. Pawns move forward only.\n";
    }

    public void ToggleRules()
    {
        rulePanel.SetActive(!rulePanel.activeSelf);
    }
}