using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackupPlot : MonoBehaviour
{
   // Name of the input file, no extension
 public string inputfile;

 public GameObject CanvasError;
 
//  // Set userselection as Dataset Resource
//  public void Set1Selected(){
//      inputfile = "iris";
//  }
 
//   // Set userselection as Dataset Resource
//  public void Set2Selected(){
//      inputfile = "iris";
//  }
  
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


// plot Scatterplot
public void ShowScatterPlot () {
//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
 
 // Set pointlist to results of function Reader with argument inputfile
 pointList = CSVReader.Read(inputfile);
 
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
 yName = columnList[columnY];


//Loop through Pointlist
 for (var i = 0; i < pointList.Count; i++)
 {
 // Get value in poinList at ith "row", in "column" Name
 float x = System.Convert.ToSingle(pointList[i][xName]);
 float y = System.Convert.ToSingle(pointList[i][yName]);
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


// color GameObjects randomly in red/blue/purple color range
dataPoint.GetComponent<Renderer>().material.color = new Color(
    UnityEngine.Random.Range(0f, 1f), 
    0f, 
    UnityEngine.Random.Range(0f, 1f));

// Assigns name to the prefab
 dataPoint.transform.name = dataPointName;
 }
 }

// TESTEN!!!
// plot BarChart
//public void ShowBarchart () {
void Start(){
//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
// Set pointlist to results of function Reader with argument inputfile
 pointList = CSVReader.Read(inputfile);
 
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
 yName = columnList[columnY];

 for (var i = 0; i < pointList.Count; i++)
        {

	position = System.Convert.ToSingle(i*plotScale/columnList.Count); //x-position relative to plotScale and amount of cells
	height = System.Convert.ToSingle(pointList[i][yName]);
	scaleXZ = System.Convert.ToSingle(plotScale/columnList.Count); //DUMMY VALUE
	GameObject dataBar = Instantiate(BoxPrefab, new Vector3(position, height/2, 0), Quaternion.identity);

	Debug.Log(i+" : "+System.Convert.ToSingle(pointList[i][yName]));
	dataBar.transform.localScale = new Vector3 (scaleXZ,height,scaleXZ);

	dataBar.transform.parent = PointHolder.transform;  //make dataBars children of DataHolder
	
	string dataBarName = pointList[i][yName] + " ";
	dataBar.transform.name = dataBarName;

    // color GameObjects randomly in red/blue/purple color range
	dataBar.GetComponent<Renderer>().material.color = new Color(
            UnityEngine.Random.Range(0f, 1f), 
            0f, 
            UnityEngine.Random.Range(0f, 1f));
	}    
}

// plot BarChart
public void ShowBarchartInverted () {

//delete plotted elements if there are any
foreach (Transform child in PointHolder.transform){
	GameObject.Destroy(child.gameObject);
    }
//CanvasError.SetActive(true);

// Set pointlist to results of function Reader with argument inputfile
 pointList = CSVReader.Read(inputfile);
 
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
 yName = columnList[columnY];
 zName = columnList[columnZ];

 for (var i = 0; i < pointList.Count; i++)
        {

	position = System.Convert.ToSingle(i*plotScale/columnList.Count); //x-position relative to plotScale and amount of cells
	height = System.Convert.ToSingle(pointList[i][yName]);
	scaleXZ = System.Convert.ToSingle(plotScale/columnList.Count); 

	//TESTEN!!! ob so rotiert
	GameObject dataBar = Instantiate(BoxPrefab, new Vector3(position, height/2, 0), Quaternion.Euler(0f,90f,0));

	Debug.Log(i+" : "+System.Convert.ToSingle(pointList[i][yName]));
	dataBar.transform.localScale = new Vector3 (scaleXZ,height,scaleXZ);

	dataBar.transform.parent = PointHolder.transform;  //make dataBars children of DataHolder
	
	string dataBarName = pointList[i][yName] + " ";
	dataBar.transform.name = dataBarName;

    // color GameObjects randomly in red/blue/purple color range
	dataBar.GetComponent<Renderer>().material.color = new Color(
            UnityEngine.Random.Range(0f, 1f), 
            0f, 
            UnityEngine.Random.Range(0f, 1f));
	}    
}

}
