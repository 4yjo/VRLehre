using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarchartPlotter : MonoBehaviour
{
    public string inputfile;
    public float plotScale = 10;
    public int columnY = 1;
    public string yName;
    public GameObject CanvasError;
    public GameObject PointHolder;
    public GameObject BoxPrefab;

    //temp var for Barchart
    private float position;
    private float height;
    private float scaleXZ;


     // List for holding data from CSV reader
    private List<Dictionary<string, object>> pointList;

    // Start is called before the first frame update
    void Start()
    {
        CanvasError.SetActive(true);
        pointList = CSVReader.Read(inputfile);

        List<string> columnList = new List<string>(pointList[1].Keys);
        yName = columnList[columnY];

        for (var i = 0; i < pointList.Count; i++)
        {

        position = System.Convert.ToSingle(i*plotScale/columnList.Count); //set position relative to plotScale and Amount of Cells
        height = System.Convert.ToSingle(pointList[i][yName]);
        scaleXZ = System.Convert.ToSingle(plotScale/columnList.Count); //DUMMY VALUE
        
        GameObject dataBar = Instantiate(BoxPrefab, new Vector3(position, height/2, 0), Quaternion.identity);

        dataBar.transform.localScale = new Vector3 (scaleXZ,height,scaleXZ);

        dataBar.transform.parent = PointHolder.transform;  //make dataBars children of DataHolder
        

        dataBar.GetComponent<Renderer>().material.color = new Color(
                UnityEngine.Random.Range(0f, 1f), 
                UnityEngine.Random.Range(0f, 1f), 
                UnityEngine.Random.Range(0f, 1f));
        }    
        
    }
}
