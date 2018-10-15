using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Xml.Serialization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecordRotationTOUCH : MonoBehaviour
{

//Quaternion rotationLast; //The value of the rotation at the previous update
//    Quaternion CameraRotation;
 //   Vector3 rotationDelta; //The difference in rotation between now and the previous update

    public RotationContainerTOUCH RotationListTOUCH = new RotationContainerTOUCH();

    void Start()
    {

  //      InvokeRepeating("SaveDataTOUCH", 1f, 0.1f);   // 存 Data 文件夹 
       
        RotationListTOUCH.RotationLogTOUCH.Clear();

        //     Debug.Log("test:::"+ID1);   // 这里打印出来 
        //     RotationListTOUCH.Save(Path.Combine(Application.dataPath, "Data/RotationLogTOUCH_" +/* experimentData.GetExperimentIndex() + "_" + ParticipantID + "_" + experimentData.GetCurrentExperiment() +*/  "1.xml"));
    }
    void Update()
    {
        // update the rotation Log for this session


        //   RotationListTOUCH.RotationLogTOUCH[RotationListTOUCH.RotationLogTOUCH.Count - 1].Name = experimentData.GetCurrentExperiment() + "_" + TargetNumber;
        //    for (int i =1; ; i++)
        //  {
        //       RotationListTOUCH.RotationLogTOUCH[RotationListTOUCH.RotationLogTOUCH.Count - 1].deltaTime = Time.deltaTime ;
        // }


        //  Debug.Log(Time.deltaTime); 
        //  if 
        // InvokeRepeating("SaveData", 1f, 10f);
          // SaveData();
    }

    public void SaveDataTOUCH()
    {
        
  //      RotationListTOUCH.RotationLogTOUCH.Add(new RotationDataTOUCH());
	//	RotationListTOUCH.RotationLogTOUCH[RotationListTOUCH.RotationLogTOUCH.Count - 1].ScreenPosition = ovrcameraTOUCH.head.localPosition.x;
   //     RotationListTOUCH.RotationLogTOUCH[RotationListTOUCH.RotationLogTOUCH.Count - 1].headpositionyTOUCH = ovrcameraTOUCH.head.localPosition.y;
       
                                                                                                                             // centerEyeAnchor  记录下头的位置 
	}
}
