using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour
{

    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject lengthTextObject;
    public GameObject volumeTextObject;
    public GameObject edgeTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI lengthText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }
    private TextMeshProUGUI edgeText { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        edgeText = edgeTextObject.GetComponent<TextMeshProUGUI>();

        myCube = new Cube();
        
        GetSliderValue();
    }

    // Update is called once per frame
    void Update()
    {
        heightText.text = "Height: " + myCube.getHeight().ToString();
        widthText.text = "Width: " + myCube.getWidth().ToString();
        lengthText.text = "Length: " + myCube.getLength().ToString();
        volumeText.text = "Volume: " + myCube.getVolume().ToString();
        edgeText.text = "Edge Length: " + myCube.getEdge().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetSliderValue();
    }

    private void GetSliderValue()
    {
        myCube.setHeight(heightSlider.value);
        myCube.setWidth(widthSlider.value);
        myCube.setLength(lengthSlider.value);
    }
}
