using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//modification of code by https://sites.psu.edu/bdssblog/2017/04/06/basic-data-visualization-in-unity-scatterplot-creation/

public class Plotter2111 : MonoBehaviour {
 

 // get input file from Player Pref (set in "setInputData.cs")
 //vorher abfragen if (!PlayerPrefs.HasKey("Dataset"))..

 public GameObject CanvasError;
  
 // List for holding data from CSV reader
 private List<Dictionary<string, object>> pointList;
 
// Indices for columns to be assigned
 public int columnX = 0;
 public int columnY = 1;
 public int columnZ = 2;
 
 // Full column names
 public string xName;
 public string yName;
 public string zName;

 public float plotScale = 10;

//temp var for Barchart
private float position;
private float height;
private float scaleXZ;


// Scatterplot prefab for the data points to be instantiated
 public GameObject PointPrefab;
// Scatterplot prefab for the data points that will be instantiated
 public GameObject PointHolder;

// Barchart prefab for the data points to be instantiated
 public GameObject BoxPrefab;

//private string inputdata = "x";
 
public string inputdata; 


// plot Scatterplot
public void ShowScatterPlot () {
//void Start(){
//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
 

//  if (inputdata == "x"){
// 	Debug.Log("no Inputfile selected");
// 	CanvasError.SetActive(true);
//  }
//  else{
// 	CanvasError.SetActive(false);
//  }

// Set pointlist to results of function Reader with argument inputdata
 pointList = CSVReader.Read(inputdata);
 
 //Log to console
 Debug.Log(pointList);

// Declare list of strings, fill with keys (column names)
 List<string> columnList = new List<string>(pointList[1].Keys);
 
 // Print number of keys (using .count)
 Debug.Log("There are " + columnList.Count + " columns in CSV");

 if (columnList.Count <2)
	{
		CanvasError.SetActive(true);
	}
 
 foreach (string key in columnList)
 Debug.Log("Column name is " + key);

// Assign column name from columnList to Name variables
 xName = columnList[columnX];
 yName = columnList[columnY];


//Loop through Pointlist
 for (var i = 0; i < pointList.Count; i++)
 {
 // Get value in poinList at ith "row", in "column" Name
 float x = System.Convert.ToSingle(pointList[i][xName]);
 Debug.Log("x values:"+x);
 float y = System.Convert.ToSingle(pointList[i][yName]);
 Debug.Log("y values:" + y);
 // Maybe for Scatterplot three dimensions would be nice to have?
 // float z = System.Convert.ToSingle(pointList[i][zName]);


// Instantiate as gameobject variable so that it can be manipulated within loop
 GameObject dataPoint = Instantiate(
 PointPrefab, 
 new Vector2(x, y),  // wishing to have 3d? new Vector3(x,y,z)
 Quaternion.identity);
 
// Make dataPoint child of PointHolder object 
 dataPoint.transform.parent = PointHolder.transform;

// Assigns original values to dataPointName
 string dataPointName = 
 pointList[i][xName] + " "
 + pointList[i][yName];

// Assigns name to the prefab
 dataPoint.transform.name = dataPointName;
 

// color GameObjects randomly in red/blue/purple color range
dataPoint.GetComponent<Renderer>().material.color = new Color(
    UnityEngine.Random.Range(0f, 1f), 
    0f, 
    UnityEngine.Random.Range(0f, 1f));

// Assigns name to the prefab
 dataPoint.transform.name = dataPointName;
 }
 }


// plot BarChart
public void ShowBarchart () {
//void Start(){

//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
// Set pointlist to results of function Reader with argument inputdata
 pointList = CSVReader.Read(inputdata);
 
 //Log to console
 Debug.Log(pointList);

// Declare list of strings, fill with keys (column names)
 List<string> columnList = new List<string>(pointList[1].Keys);
 
 // Print number of keys (using .count)
 Debug.Log("There are " + columnList.Count + " columns in CSV");
 
 foreach (string key in columnList)
 Debug.Log("Column name is " + key);

// Assign column name from columnList to Name variables
 xName = columnList[columnX];

 for (var i = 0; i < pointList.Count; i++)
        {

	position = System.Convert.ToSingle(i*(plotScale/2)/columnList.Count); //x-position relative to plotScale and amount of cells
	height = System.Convert.ToSingle(pointList[i][xName]);
	scaleXZ = System.Convert.ToSingle((plotScale/columnList.Count)/2); 
	GameObject dataBar = Instantiate(BoxPrefab, new Vector3(position, (height/2)-10, 0), Quaternion.identity);

	dataBar.transform.localScale = new Vector3 (scaleXZ,height,scaleXZ);

	dataBar.transform.parent = PointHolder.transform;  //make dataBars children of DataHolder
	

    // color GameObjects randomly in red/blue/purple color range
	dataBar.GetComponent<Renderer>().material.color = new Color(
            UnityEngine.Random.Range(0f, 1f), 
            0f, 
            UnityEngine.Random.Range(0f, 1f));
	}    
}

// plot Inverted BarChart
public void ShowBarchartInverted () {
//void Start(){
//for debugging in unity editor: void Start(){

//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
//CanvasError.SetActive(true);

// Set pointlist to results of function Reader with argument inputdata
 pointList = CSVReader.Read(inputdata);
 
 //Log to console
 Debug.Log(pointList);

// Declare list of strings, fill with keys (column names)
 List<string> columnList = new List<string>(pointList[1].Keys);
 
 // Print number of keys (using .count)
 Debug.Log("There are " + columnList.Count + " columns in CSV");
 
 foreach (string key in columnList)
 Debug.Log("Column name is " + key);

// Assign column name from columnList to Name variables
 xName = columnList[columnX];


 for (var i = 0; i < pointList.Count; i++)
        {

	position = System.Convert.ToSingle(i*plotScale/columnList.Count); //x-position relative to plotScale and amount of cells
	height = System.Convert.ToSingle(pointList[i][xName]);
	scaleXZ = System.Convert.ToSingle((plotScale/columnList.Count)/2); 


	//GameObject dataBar = Instantiate(BoxPrefab, new Vector3((height/2),(position/2)-11, 0), Quaternion.identity);
    GameObject dataBar = Instantiate(BoxPrefab, new Vector3(height/2,i*scaleXZ-22, 0), Quaternion.identity);

	Debug.Log(i+" : "+System.Convert.ToSingle(pointList[i][xName]));
	dataBar.transform.localScale = new Vector3 (height,scaleXZ,scaleXZ);

	dataBar.transform.parent = PointHolder.transform;  //make dataBars children of DataHolder
	

    // color GameObjects randomly in red/blue/purple color range
	dataBar.GetComponent<Renderer>().material.color = new Color(
            UnityEngine.Random.Range(0f, 1f), 
            0f, 
            UnityEngine.Random.Range(0f, 1f));
	}    
}

}
