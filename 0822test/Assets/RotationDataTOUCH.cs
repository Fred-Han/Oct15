using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class RotationDataTOUCH {
    // target name
    public string Name;
    // rotation this frame
	public Vector2 qRotation;
    // frame time duration
    public float deltaTime;
}
