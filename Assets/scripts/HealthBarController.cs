using UnityEngine;
using System.Collections;

public class HealthBarController : MonoBehaviour
{

    private Camera mainCamera;
    private float width;
    private float oneHealthBar = 0.0f;
    private RectTransform healthBarRect;
    private int damageDealt = 0;
    private Color colorBar;
    private float swapColorRed = 0;
    private float swapColorGreen = 0;

    // Use this for initialization
    void Start()
    {
        mainCamera = Camera.main;
        width =  GetComponent<RectTransform>().rect.width;
        swapColorGreen = GetComponent<UnityEngine.UI.Image>().color.g;
    }

    // Update is called once per frame
    void Update()
    {
        //healthBarRect = GetComponent<RectTransform>();
        GetComponent<Transform>().LookAt(mainCamera.GetComponent<Transform>().position, Vector3.forward);
        colorBar = GetComponent<UnityEngine.UI.Image>().color;
        // GetComponent<Transform>().rotation = new Quaternion(0, 0, 0, 0);
        colorBar = GetComponent<UnityEngine.UI.Image>().color;
    }

    public void Damage(int health, int damageAmount)
    {
        swapColorRed += 255 / health;
        swapColorGreen -= 255 / health;
        oneHealthBar = (float)1 / health;
        damageDealt += damageAmount;
        GetComponent<RectTransform>().localScale = new Vector3((float)(1 - damageDealt * oneHealthBar), 1, 1);
        GetComponent<UnityEngine.UI.Image>().color = new Color32((byte)swapColorRed, (byte)swapColorGreen, (byte)colorBar.b, 255);
        
    }
}
